using System.Globalization;
using VintedBackendAssignment.Enums;
using Constant = VintedBackendAssignment.Constants.Constants;

namespace VintedBackendAssignment
{
    public static class Validators
    {
        public static bool ValidateAndBuildShipment(string[] input, out Shipment? shipment)
        {
            shipment = null;

            if (IsValidDate(input[0], out var date)
                && IsValidSize(input[1], out var size)
                && IsValidProvider(input[2], out var provider))
            {
                shipment = new Shipment(date, size, provider);

                return true;
            }

            return false;
        }

        private static bool IsValidDate(string input, out DateTime date)
        {
            return DateTime.TryParseExact(input, Constant.DateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out date);
        }

        private static bool IsValidSize(string input, out Size size)
        {
            return Enum.TryParse(input, out size);
        }

        private static bool IsValidProvider(string input, out Provider provider)
        {
            return Enum.TryParse(input, out provider);
        }
    }
}
