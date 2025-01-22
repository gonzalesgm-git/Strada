using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Strada.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddItemApplicationMediatR(this IServiceCollection services)
        {
            var assembly = typeof(DependencyInjection).Assembly;
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));

            return services;
        }

        public static IServiceCollection AddValidators(this IServiceCollection services)
        {
            var validatorAssemblies = new List<Assembly>
            {
                typeof(DependencyInjection).Assembly
            };

            AssemblyScanner.FindValidatorsInAssemblies(validatorAssemblies)
                .ForEach(pair =>
                {
                    services.Add(ServiceDescriptor.Transient(pair.InterfaceType, pair.ValidatorType));
                });

            return services;
        }
    }
}
