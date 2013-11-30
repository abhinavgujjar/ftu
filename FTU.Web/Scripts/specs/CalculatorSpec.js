describe("calculator tests", function(){
	it("Should give 0 tax for 0 income", function(){
		var tax = TaxCalculator.CalculateTax(44, true, 0);
		expect(tax).toEqual(0);
	})

	it("Should give 1000 tax for 10000 income with a rate of 10%", function(){
		spyOn(TaxCalculator, "GetTaxRate").andReturn(10);//(function(){
		// 	return 10
		// })

		var tax = TaxCalculator.CalculateTax(44, true, 10000);
		expect(tax).toEqual(1000);
	})
})