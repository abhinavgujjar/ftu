define(['app/viewmodels/welcome', 'app/common/dataaccess'], function (wc, da) {
    describe("Player", function () {

        it("should be able to play a Song", function () {
            spyOn(da, 'getStudents').andCallFake(function (callback) {
                callback([{ FirstName: 'X' }, { FirstName: 'Y' }])
            });
            //demonstrates use of custom matcher

            wc.activate();
            expect(wc.displayName()).toBe('Fake');
        });
    });
});