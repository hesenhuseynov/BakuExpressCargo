using BakuExpressCargo.Application.Exceptions;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakuExpressCargo.Application.Behaviours
{
    public class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        public Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }




        //public Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        //{
        //    if (_validators.Any())
        //    {
        //        var context = new ValidationContext<TRequest>(request);
        //        var validationResults = _validators
        //            .Select(v => v.Validate(context))
        //            .Where(result => !result.IsValid)
        //            .ToList();


        //        if (validationResults.Any())
        //        {
        //            var failures = validationResults
        //                .SelectMany(result => result.Errors)
        //                .ToList();

        //            //throw new ValidationException(failures);                    //throw new ValidationException(failures);
        //        }

        //    }

        //    return Task.FromResult();

        //}
    }
}
