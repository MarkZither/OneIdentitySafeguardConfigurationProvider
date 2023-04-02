using MarkZither.Extensions.Configuration.OneIdentitySafeguard;

using Microsoft.Extensions.Configuration;

using OneIdentity.SafeguardDotNet;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Configuration;
public static class ConfigurationBuilderExtensions {
    public static IConfigurationBuilder AddOneIdentitySafeguardConfiguration(
    this IConfigurationBuilder builder) {
        var tempConfig = builder.Build();

        return builder.Add(new OneIdentitySafeguardConfigurationSource());
    }

    public static IConfigurationBuilder AddOneIdentitySafeguardConfiguration(
    this IConfigurationBuilder builder, Uri OneIdentityServer) {
        var tempConfig = builder.Build();
        var connection = Safeguard.Connect(OneIdentityServer.ToString());

        return builder.Add(new OneIdentitySafeguardConfigurationSource());
    }
}