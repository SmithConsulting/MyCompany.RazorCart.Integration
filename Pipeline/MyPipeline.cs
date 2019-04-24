using System;
using RazorCart.Core.ActionPipeline;

namespace MyCompany.RazorCart.Integration
{
    public class MyPipeline : PipelineManager
    {
        /// <summary>
        /// Register the Pipeline Action List to be executed once an item(s) requested to be added to the cart
        /// </summary>
        /// <returns>A <see cref="RazorCart.Core.ActionPipeline.PipelineAction[]"/></returns>
        protected override PipelineAction[] ListCartPipelineActions()
        {
            return base.ListCartPipelineActions();
        }

        /// <summary>
        /// Register the Pipeline Action List to be executed on cart totals calculation request
        /// </summary>
        /// <returns>A <see cref="RazorCart.Core.ActionPipeline.PipelineAction[]"/></returns>
        protected override PipelineAction[] ListCalculatorPipelineActions()
        {
            return base.ListCalculatorPipelineActions();
        }

        /// <summary>
        /// Register the Pipeline Action List to be executed on cart checkout/place order
        /// </summary>
        /// <returns>A <see cref="RazorCart.Core.ActionPipeline.PipelineAction[]"/></returns>
        protected override PipelineAction[] ListCheckoutPipelineActions()
        {
            return base.ListCheckoutPipelineActions();
        }
    }
}
