var config = {

    apiurl: "http://localhost:8010/",
    url: "http://localhost:8009/"
}

function Query(url, type, data, callback,beforesend='') {
    debugger    
    //把JSON类型的数组传入方法
    $.ajax({
        url: url,
        async: false,
        type: type,       
        dataType: 'json',
        data: data,
        beforeSend: beforesend,
        success: callback
    });
}
