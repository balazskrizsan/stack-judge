using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using StackJudge.Builders;

namespace StackJudge.Filters
{
    public class ValidateModelStateAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                if (!context.ModelState.IsValid)
                {
                    var state = context.ModelState;
                    var errors = state.Keys
                        .Where(k => state[k].Errors.Count > 0)
                        .Select(
                            k => new
                            {
                                propertyName = k,
                                errorMessage = CollectMessages(state[k].Errors)
                            }
                        );

                    var responseEntityBuilder = new ResponseEntityBuilder<object>()
                    {
                        Data = errors,
                        ErrorCode = 1,
                        ResponseStatusCode = HttpStatusCode.BadRequest
                    };

                    context.Result = responseEntityBuilder.Build();
                }
            }
        }

        private List<string> CollectMessages(ModelErrorCollection modelErrorCollection)
        {
            List<string> errors = new List<string>();

            modelErrorCollection.ToList().ForEach(
                error => errors.Add(error.ErrorMessage)
            );

            return errors;
        }
    }
}
