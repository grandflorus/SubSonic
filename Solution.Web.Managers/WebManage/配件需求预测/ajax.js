/******************************************************************************
* filename: ajax.js
*******************************************************************************/
$.ajaxSetup({
    async: false
}); 

var imgPath = "loading.gif"; //加载图片路径

var ajax = {};
//获取服务器路径
ajax.getPath = function (param) {
    return "ajax.ashx?action=" + param;
};

//显示正在加载的图标
ajax.loading = function (src, show) {
    show = show || false;
    //显示
    if (show) {
       // $(src).after("<img id=\"loading\" src='loading.gif' title='加载中...' alt='加载中...' />");
        //$(src).hide();
    } else {
        //隐藏
        // $(src).show();
      //  $("#loading").hide();
    
    }
};

ajax.Test = function () {
    ajax.loading(this, true);
    $.post("ajax.ashx?action=Show", {
        ID: "2"
    }, function (data) {
    //  ajax.loading(this, false);
        var json = Tool.getJSON(data);
        alert(json.ID);
    });
};

ajax.ChartString = "";

ajax.ShowChart = function () {
    ajax.loading(this, true);
    $.post("ajax.ashx?action=ShowChart", {
}, function (data) {
    //  ajax.loading(this, false);
    ajax.ChartString = data;
   
});
};

var Tool = {};
//获取JSON数据
Tool.getJSON = function (str) {
    if (str == null || str == "") {
        return [];
    }
    return eval("(" + str + ")");
};
