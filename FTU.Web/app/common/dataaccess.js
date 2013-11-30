define(['jquery'], function ($) {

    return {
        getStudents: function (callback) {
            $.get('/api/Students', function (data) {
                callback(data);
            });
        },
        getInvoices: function () {
            return [{ id: 1, amount: 5000, invNumber: 'FF5667' },
        { id: 2, amount: 7344, invNumber: 'PPY89' },
        { id: 3, amount: 8000, invNumber: 'KA56T' },
        { id: 4, amount: 2100, invNumber: 'XXR5T' }];
        },

        getInfo: function () {
            return 'real';
        }
    };
});