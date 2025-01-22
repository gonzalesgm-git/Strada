using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Strada.Database.Repositories;
using Strada.Database.Repositories.Employments;
using Strada.Database.Repositories.Users;
using Strada.Domain.Models.Employments;
using Strada.Domain.Models.Users;

namespace Strada.Database
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            services.AddDbContext<StradaDbContext>(options => {
                options.UseInMemoryDatabase(databaseName: "StradaDb");
            });

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepository<User>, UserRepository>();
            services.AddScoped<IRepository<Employment>, EmploymentRepository>();
            return services;
        }

        public static void InitializeDatabase(this IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<StradaDbContext>();

                // Check if data already exists
                if (!context.Users.Any())
                {
                    context.Users.AddRange(
                        new User()
                        {
                            Id = 1,
                            Email = "gerald@test.com",
                            FirstName = "Gerald",
                            LastName = "Gonzales"
                        },
                        new User()
                        {
                            Id = 2,
                            Email = "gerald2@test.com",
                            FirstName = "Gerald2",
                            LastName = "Gonzales2"
                        }
                    );
                }

                // Save changes to the in-memory database
                context.SaveChanges();
            }
        }
    }
}
