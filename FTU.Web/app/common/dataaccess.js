define(['jquery'], function ($) {

    return {
        getStudents: function (callback) {
            $.get('/api/Students', function (data) {
                callback(data);
            });
        },
        getInfo: function () {
            return 'real';
        }
    };
});