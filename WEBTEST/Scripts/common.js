function Query(url, type, data, callback) {

    //把JSON类型的数组传入方法
    $.ajax({
        url: url,
        async: false,
        type: type,
        dataType: 'json',
        data: JSON.stringify(data),
        success: callback
    });
}