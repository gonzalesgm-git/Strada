using FluentValidation;
using FluentValidation.AspNetCore;
using Newtonsoft.Json;

namespace Strada.API
{
    public static class MvcBuilder
    {
        public static IMvcBuilder BuildMvc(this IServiceCollection services)
        {
            var mvcBuilder = services.AddControllers(opts =>
            {
                opts.Filters.Add(typeof(ModelValidatorFilter));
            });

            return mvcBuilder;
        }
    }
}
