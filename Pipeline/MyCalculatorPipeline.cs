using System;
using RazorCart.Core.ActionPipeline;

namespace MyCompany.RazorCart.Integration
{
    class MyCalculateTax : CalculateTax
    {
        public override PipelineAction Clone() { return (MyCalculateTax)MemberwiseClone(); }
        public override int ActionID() { return 1; }
        public override string ActionName() { return "Custom Tax Calculator"; }
        public override bool IsDisposable() { return false; }
        public override ActionEndResult Execute(VATContext context)
        {
            // Execute the RazorCart core tax calculation which will set context.CartTotals.TaxTotal based on store config
            var result = base.Execute(context);
            if (result.Success)
            {
                if (context.ShippingData.CountryCode.Equals("US", StringComparison.OrdinalIgnoreCase) && context.ShippingData.RegionCode.Equals("OH", StringComparison.OrdinalIgnoreCase))
                {
                    // Charge 6.75% for Ohio state only
                    context.CartTotals.TaxRate = 6.75M / 100;
                    context.CartTotals.TaxTotal = context.CartTotals.SubTotal * context.CartTotals.TaxRate;
                }
            }
            return new ActionEndResult() { Success = true, FailureMessage = string.Empty };
        }
    }
}
