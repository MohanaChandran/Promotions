using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class ModelValidationException : BaseException
    {
        public ModelStateDictionary ModelState { get; set; }
        public ModelValidationException(ModelStateDictionary modelState) : base("Request validation failed")
        {
            ModelState = modelState;
        }
    }
}
