using Microsoft.Extensions.Configuration;

namespace MarkZither.Extensions.Configuration.OneIdentitySafeguard.Tests;

public class ConfigurationExtensionTest
{
    [Fact]
    public void AddUserSecrets_Does_Not_Fail_On_Non_Existing_File() {
        var builder = new ConfigurationBuilder().AddOneIdentitySafeguardConfiguration();

        var configuration = builder.Build();
        Assert.Null(configuration["Facebook:PLACEHOLDER"]);
    }
}