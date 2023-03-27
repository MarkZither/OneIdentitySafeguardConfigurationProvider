using Microsoft.Extensions.Configuration;

namespace MarkZither.Extensions.Configuration.OneIdentitySafeguard {
    public class OneIdentitySafeguardConfigurationProvider : ConfigurationProvider {
        public override void Load() {
            var settings = new Dictionary<string, string?>(
            StringComparer.OrdinalIgnoreCase) {
                ["WidgetOptions:EndpointId"] = "b3da3c4c-9c4e-4411-bc4d-609e2dcc5c67",
                ["WidgetOptions:DisplayLabel"] = "Widgets Incorporated, LLC.",
                ["WidgetOptions:WidgetRoute"] = "api/widgets"
            };

            Data = settings;
        }
    }
}