// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Server.Kestrel.Transport.NamedPipes;
using Microsoft.AspNetCore.Server.Kestrel.Transport.NamedPipes.Internal;

namespace Microsoft.Extensions.DependencyInjection;

/// <summary>
/// <see cref="IServiceCollection" /> extension methods to configure the Named Pipes transport to be used by Kestrel.
/// </summary>
public static class ServiceCollectionNamedPipeExtensions
{
    /// <summary>
    /// Specify Named Pipes as the transport to be used by Kestrel.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection" /> to add services to.</param>
    /// <returns>The service collection.</returns>
    public static IServiceCollection AddNamedPipes(this IServiceCollection services)
    {
        services.AddSingleton<IConnectionListenerFactory, NamedPipeTransportFactory>();
        return services;
    }

    /// <summary>
    /// Specify Named Pipes as the transport to be used by Kestrel.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection" /> to add services to.</param>
    /// <param name="configureOptions">A callback to configure transport options.</param>
    /// <returns>The service collection.</returns>
    public static IServiceCollection AddNamedPipes(this IServiceCollection services, Action<NamedPipeTransportOptions> configureOptions)
    {
        return services.AddNamedPipes().Configure(configureOptions);
    }
}
