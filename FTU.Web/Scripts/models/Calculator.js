"use strict";
var TaxCalculator = {
	
	CalculateTax : function (age, isFemale, income) {
		var rate = this.GetTaxRate(isFemale);

		var tax;
		if ( isFemale)
		{
			tax = income * rate / 100;
		}
		else
		{
			tax = income * rate / 100;
		}

		return tax;
	},
	GetTaxRate :  function(isFemale){
		return isFemale ? 30 : 24;
	}
};
