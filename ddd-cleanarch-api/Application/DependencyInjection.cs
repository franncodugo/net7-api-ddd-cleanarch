﻿
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Application;


public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(config =>
        {
            config.RegisterServicesFromAssemblyContaining<ApplicationAssemblyReference>();
        });

        // Fluent Validation registration.
        services.AddValidatorsFromAssemblyContaining<ApplicationAssemblyReference>();

        return services;
    }
}
   
