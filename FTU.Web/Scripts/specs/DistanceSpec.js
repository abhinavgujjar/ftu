// describe("calculator tests", function(){
// 	it("Should give 0 tax for 0 income", function(){
// 		var tax = TaxCalculator.CalculateTax(44, true, 0);
// 		expect(tax).toEqual(0);
// 	})
describe("Distance Calculator Tests", function(){
	it("should return -5 when points are the same", function(){
		var distance = CalculateDistance(5,6, 5,6);

		expect(distance).toEqual(-5);
	});

	it("should return 1 with 2,3 and 5,6", function(){
		var distance = CalculateDistance(2,3, 5,6);

		expect(distance).toEqual(1);
	});

})

