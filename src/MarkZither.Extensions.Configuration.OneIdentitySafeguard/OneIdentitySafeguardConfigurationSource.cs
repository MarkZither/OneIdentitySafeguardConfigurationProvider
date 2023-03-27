using Microsoft.Extensions.Configuration;
namespace MarkZither.Extensions.Configuration.OneIdentitySafeguard;
public class OneIdentitySafeguardConfigurationSource : IConfigurationSource
{
    public IConfigurationProvider Build(IConfigurationBuilder builder)
    {
        return new OneIdentitySafeguardConfigurationProvider();
    }
}
