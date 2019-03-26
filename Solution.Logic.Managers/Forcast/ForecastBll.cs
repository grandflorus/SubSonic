using System;
using System.Collections.Generic;
using System.Text;
using DotNet.Utilities;
using Solution.DataAccess.DataModel;
using Solution.DataAccess.DbHelper;
using SubSonic.Query;
using System.Web.UI;
using AForge.Neuro;
using AForge.Neuro.Learning;
using System.IO;


/***********************************************************************
*   作    者：PengFei（彭飞）
*   邮    箱：xjvspf@163.com
*   QQ    号：124041108
*  
*   创建日期：2017-11-17
 *   文件名称：ForecastBll.cs
 *   描    述：预测分析逻辑类
 *             
 *   修 改 人：
 *   修改日期：
 *   修改原因：
 ***********************************************************************/
namespace Solution.Logic.Managers
{
    /// <summary>ForecastBll预测分析</summary>
   public  class Forecast
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        //[STAThread]

        public struct Year_Data
        {
            public string year;
            public string data;
        }

        public static int length_Rain;
        public static Year_Data[] iniYearData_Rain;
        public static double[][] trainInput_Rain;
        public static double[][] trainOutput_Rain;
        public static double[][] Output_Rain;
        public static double[] max_Rain;
        public static double[] min_Rain;
        public static ActivationNetwork network_Rain;
        public static BackPropagationLearning teacher_Rain;
        public static int trainNum_Rain;
        public static int testNum_Rain;
        public static double[][] testInput_Rain;
        public static double[] testOutput_Rain;

        public static int length_Iron;
        public static Year_Data[] iniYearData_Iron;
        public static double[][] trainInput_Iron;
        public static double[][] trainOutput_Iron;
        public static double[][] Output_Iron;
        public static double max_Iron;
        public static double min_Iron;
        public static ActivationNetwork network_Iron;
        public static BackPropagationLearning teacher_Iron;
        public static int trainNum_Iron;
        public static int testNum_Iron;
        public static double[][] testInput_Iron;
        public static double[] testOutput_Iron;
        // 将num映射到[-1, 1]中
        public static double premnmx(double num, double min, double max)
        {
            if (num > max)
                num = max;
            if (num < min)
                num = min;

            return 2 * (num - min) / (max - min) - 1;
        }
        static void Main()
        {
            //length_Rain = File.ReadAllLines("小河站年降雨量.txt").Length;
            length_Rain = 50;
            trainNum_Rain = length_Rain - 4;
            testNum_Rain = length_Rain - 4;
            iniYearData_Rain = new Year_Data[length_Rain];
            trainInput_Rain = new double[trainNum_Rain][];
            trainOutput_Rain = new double[trainNum_Rain][];
            Output_Rain = new double[trainNum_Rain][];

            length_Iron = File.ReadAllLines(@"D:\铁矿石进口量.txt").Length;
            trainNum_Iron = length_Iron - 1;
            testNum_Iron = length_Iron - 1;
            iniYearData_Iron = new Year_Data[length_Iron];
            trainInput_Iron = new double[trainNum_Iron][];
            trainOutput_Iron = new double[trainNum_Iron][];
            Output_Iron = new double[trainNum_Iron][];

            max_Rain = new double[4];
            min_Rain = new double[4];
            for (int i = 0; i < 4; i++)
            {
                max_Rain[i] = double.MinValue;
                min_Rain[i] = double.MaxValue;
            }

            max_Iron = double.MinValue;
            min_Iron = double.MaxValue;

            // 获取小河站年降雨量初始数据
            StreamReader ini_Rain = new StreamReader(@"D:\小河站年降雨量.txt");
            for (int i = 0; i < length_Rain; i++)
            {
                string value = ini_Rain.ReadLine();
                string[] temp = value.Split('\t');

                iniYearData_Rain[i].year = temp[0];
                iniYearData_Rain[i].data = temp[1];
            }
            // 获取中国铁矿石年进口量初始数据
            //StreamReader ini_Iron = new StreamReader(@"D:\铁矿石进口量.txt");
            //for (int i = 0; i < length_Iron; i++)
            //{
            //    string value = ini_Iron.ReadLine();
            //    string[] temp = value.Split('\t');

            //    iniYearData_Iron[i].year = temp[0];
            //    iniYearData_Iron[i].data = temp[1];
            //}

            // 生成小河站测试数据文件
            StreamWriter test_Rain = new StreamWriter(@"D:\测试数据(小河站年降雨量).txt");
            for (int i = 0; i < testNum_Rain; i++)
            {
                string temp = null;
                for (int j = 0; j < 4; j++)
                    temp += iniYearData_Rain[i + j].data + '\t';
                test_Rain.WriteLine(temp);
            }
            test_Rain.Close();
            // 生成中国铁矿石年进口量测试文件
            //StreamWriter test_Iron = new StreamWriter(@"D:\测试数据(中国铁矿石年进口量).txt");
            //for (int i = 0; i < testNum_Iron; i++)
            //    test_Iron.WriteLine(iniYearData_Iron[i].data);
            //test_Iron.Close();

            // 读取小河站年降雨量测试数据
            testInput_Rain = new double[testNum_Rain][];
            testOutput_Rain = new double[testNum_Rain];
            StreamReader reader_testRain = new StreamReader(@"D:\测试数据(小河站年降雨量).txt");
            for (int i = 0; i < testNum_Rain; i++)
            {
                string value = reader_testRain.ReadLine();
                string[] temp = value.Split('\t');

                testInput_Rain[i] = new double[4];
                for (int j = 0; j < 4; j++)
                    testInput_Rain[i][j] = double.Parse(temp[j]);
            }
            //// 读取中国铁矿石年进口量测试数据
            //testInput_Iron  = new double[testNum_Iron][];
            //testOutput_Iron = new double[testNum_Iron];
            //StreamReader reader_testIron = new StreamReader(@"D:\测试数据(中国铁矿石年进口量).txt");
            //for (int i = 0; i < testNum_Iron; i++)
            //{
            //    string temp = reader_testIron.ReadLine();
            //    testInput_Iron[i]    = new double[1];
            //    testInput_Iron[i][0] = double.Parse(temp);
            //}

            // 生成小河站年降雨量训练数据
            StreamWriter train_Rain = new StreamWriter(@"D:\训练数据(小河站年降水量).txt");
            for (int i = 0; i < trainNum_Rain; i++)
            {
                string temp = null;
                for (int j = 0; j < 5; j++)
                    temp += iniYearData_Rain[i + j].data + '\t';
                train_Rain.WriteLine(temp);
            }
            train_Rain.Close();
            //// 生成中国铁矿石年进口量训练数据
            //StreamWriter train_Iron = new StreamWriter(@"D:\训练数据(中国铁矿石年进口量).txt");
            //for (int i = 0; i < trainNum_Iron; i++)
            //{
            //    string temp = null;
            //    for (int j = 0; j < 2; j++)
            //        temp += iniYearData_Iron[i + j].data + '\t';
            //    train_Iron.WriteLine(temp);
            //}
            //train_Iron.Close();

            // 读取小河站年降雨量训练数据
            StreamReader reader_trainRain = new StreamReader(@"D:\训练数据(小河站年降水量).txt");
            for (int i = 0; i < trainNum_Rain; i++)
            {
                string value = reader_trainRain.ReadLine();
                string[] temp = value.Split('\t');

                trainInput_Rain[i] = new double[4];
                trainOutput_Rain[i] = new double[1];
                Output_Rain[i] = new double[1];

                for (int j = 0; j < 4; j++)
                {
                    trainInput_Rain[i][j] = double.Parse(temp[j]);
                    if (trainInput_Rain[i][j] > max_Rain[j])
                        max_Rain[j] = trainInput_Rain[i][j];

                    if (trainInput_Rain[i][j] < min_Rain[j])
                        min_Rain[j] = trainInput_Rain[i][j];
                }

                trainOutput_Rain[i][0] = double.Parse(temp[4]);
                Output_Rain[i][0] = double.Parse(temp[4]);
            }
            // 归一化小河站年降雨量训练数据
            for (int i = 0; i < trainNum_Rain; i++)
            {
                for (int j = 0; j < 4; j++)
                    trainInput_Rain[i][j] = premnmx(trainInput_Rain[i][j], min_Rain[j], max_Rain[j]);

                trainOutput_Rain[i][0] = premnmx(trainOutput_Rain[i][0], min_Rain[0], max_Rain[0]);
                //}
                //// 读取中国铁矿石年进口量训练数据
                //StreamReader reader_trainIron = new StreamReader(@"D:\训练数据(中国铁矿石年进口量).txt");
                //for (int i = 0; i < trainNum_Iron; i++)
                //{
                //    string value        = reader_trainIron.ReadLine();
                //    string[] temp       = value.Split('\t');
                //    trainInput_Iron[i]  = new double[1];
                //    trainOutput_Iron[i] = new double[1];
                //    Output_Iron[i]      = new double[1];


                //    trainInput_Iron[i][0] = double.Parse(temp[0]);
                //    if (trainInput_Iron[i][0] > max_Iron)
                //        max_Iron = trainInput_Iron[i][0];

                //    if (trainInput_Iron[i][0] < min_Iron)
                //        min_Iron = trainInput_Iron[i][0];

                //    trainOutput_Iron[i][0] = double.Parse(temp[1]);
                //    Output_Iron[i][0]      = double.Parse(temp[1]);
                //}
                //// 归一化中国铁矿石年进口量训练数据
                //for (int i = 0; i < trainNum_Iron; i++)
                //{
                //    trainInput_Iron [i][0] = premnmx(trainInput_Iron[i][0], min_Iron, max_Iron);
                //    trainOutput_Iron[i][0] = premnmx(trainOutput_Iron[i][0], min_Iron, max_Iron);
                //}


                // 训练小河站年降雨量网络
                // 创建一个多层神经网络，采用S形激活函数，各层分别4，20，1个神经元
                // (其中4是输入个数，1是输出个数，20是隐层节点个数)
                network_Rain = new ActivationNetwork(new BipolarSigmoidFunction(3), 4, 20, 1);
                // 创建小河站BP神经网络进行训练
                teacher_Rain = new BackPropagationLearning(network_Rain);
                // 设置小河站学习率和冲量系数
                teacher_Rain.LearningRate = 0.01;
                teacher_Rain.Momentum = 0;
                // 训练中国铁矿石年进口量网络
                // 创建一个多层神经网络，采用S形激活函数，各层分别1，16，1个神经元
                // (其中1是输入个数，1是输出个数，16是隐层节点个数)
                network_Iron = new ActivationNetwork(new BipolarSigmoidFunction(3), 1, 16, 1);
                // 创建BP神经网络进行训练
                teacher_Iron = new BackPropagationLearning(network_Iron);
                // 设置学习率和冲量系数
                teacher_Iron.LearningRate = 0.05;
                teacher_Iron.Momentum = 0;


                //Application.enablevisualstyles();
                //Application.setcompatibletextrenderingdefault(false);
                //Application.Run(new Form1());
            }
        }
    }
}

        /***********************************************************************
         * 自定义函数                                                          *
         ***********************************************************************/
        #region 自定义函数

        #region 取得属性
        /// <summary>取得 Ext</summary>
        /// <param name="typeKey"></param>
        /// <returns></returns>



        #endregion 自定义函数

    



#endregion