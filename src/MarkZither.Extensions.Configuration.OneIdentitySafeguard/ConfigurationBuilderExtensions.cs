using MarkZither.Extensions.Configuration.OneIdentitySafeguard;

using Microsoft.Extensions.Configuration;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Configuration;
public static class ConfigurationBuilderExtensions {
    public static IConfigurationBuilder AddEntityConfiguration(
    this IConfigurationBuilder builder) {
        var tempConfig = builder.Build();

        return builder.Add(new OneIdentitySafeguardConfigurationSource());
    }
}