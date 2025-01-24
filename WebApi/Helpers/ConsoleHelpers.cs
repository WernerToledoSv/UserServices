using System.Globalization;

namespace WebApi.Helpers
{
    public class ConsoleHelpers
    {
        public static void ConfigurationDefaultCulture(ILogger logger, bool displayCulture = true) 
        { 
            CultureInfo cultureInfo = CultureInfo.GetCultureInfo("es-SV");
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

            if (displayCulture) 
            {
                ShowDefaultCultureInfo(logger);
            }
        }

        private static void ShowDefaultCultureInfo(ILogger logger) 
        {
            var timeZone = TimeZoneInfo.Local;
            var currentCulture = CultureInfo.CurrentCulture;
            var localDate = DateTime.Now;
            var utcDate = DateTime.UtcNow;

            logger.LogInformation("=============================================================");
            logger.LogInformation("TimeZone                     :{timeZone}", timeZone);
            logger.LogInformation("Local time                   :{localTime}", localDate);
            logger.LogInformation("UTC Date                     :{utcDate}", utcDate);
            logger.LogInformation("Culture Name                 :{displayName}", currentCulture.DisplayName);
            logger.LogInformation("Native Culture Name          :{nativeName}", currentCulture.NativeName);
            logger.LogInformation("Format Date                  :{longDatePattern}", currentCulture.DateTimeFormat.LongDatePattern);
            logger.LogInformation("Current Symbol               :{currencySymbol}", currentCulture.NumberFormat.CurrencySymbol);
            logger.LogInformation("Current Decimal Separator    :{currentDecimalSeparator}", currentCulture.NumberFormat.CurrencyDecimalSeparator);
            logger.LogInformation("Current Group Separator      :{currencyGroupSeparator}", currentCulture.NumberFormat.CurrencyGroupSeparator);
            logger.LogInformation("=============================================================");
        }
    }
}
