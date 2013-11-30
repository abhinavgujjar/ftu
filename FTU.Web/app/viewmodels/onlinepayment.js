define(['knockout', 'jquery', 'app/common/dataaccess', 'app/common/navManager'],
    function (ko, $, da, nav) {
    var vm = {
        Invoices: ko.observableArray([]),
        selectInvoice: function (data) {
            data.amount = data.amount + $("#taxInput").value();
            vm.SelectedInvoice(data);
        },
        Tax :ko.observable(),
        SelectedInvoice: ko.observable(),
        PaymentOptions: [
            { name: 'credit card', route: 'x' },
            { name: 'debit card', route: 'y' },
            { name: 'paypal', route: 'p' }],
        SelectedPaymentOption: ko.observable(),
        TotalAmount: ko.observable(),
        doPayment: function () {
            nav.navigate(vm.SelectedPaymentOption.route)
        },
        activate: function () {
            var invoices = da.getInvoices();
            $.each(invoices, function (index, item) {
                vm.Invoices().push(item);
            });
        }
    }

    return vm;
});