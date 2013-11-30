define(['app/viewmodels/onlinepayment', 'app/common/dataaccess', 'app/common/navManager'], function (op, da, nav) {
    describe("Tests online payment", function () {

        it("should populate the list invoices", function () {
            spyOn(da, 'getInvoices').andReturn([{ id: 99, amount: 1000, invNumber: 'XXXXX' },
            { id: 99, amount: 1000, invNumber: 'YYY' }]);

            op.activate();
            expect(op.Invoices().length).toBe(2);
        });

        it("should navigate to the correct route", function () {
            spyOn(nav, 'navigate');

            op.SelectedPaymentOption = { name: 'dummy option', route: 'd' };
            op.doPayment();
            
            expect(nav.navigate).toHaveBeenCalled();
            expect(nav.navigate).toHaveBeenCalledWith('d');
            
        });

        it("should have the selected invoice with taxation added on invoking the select method", function () {

            op.Tax(400);
            op.selectInvoice( { id: 99, amount: 1000, invNumber: 'YYY' });

            expect(op.SelectedInvoice()).toEqual({ id: 99, amount: 1400, invNumber: 'YYY' });
        });

    });
});