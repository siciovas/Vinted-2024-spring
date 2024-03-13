using VintedBackendAssignment.Enums;

namespace VintedBackendAssignment
{
    public class PackageInfo
    {
        private record Package(Provider Provider, Size Size, decimal Price);

        private readonly List<Package> _package =
        [
            new Package(Provider.LP, Size.S, 1.50m),
            new Package(Provider.LP, Size.M, 4.90m),
            new Package(Provider.LP, Size.L, 6.90m),
            new Package(Provider.MR, Size.S, 2),
            new Package(Provider.MR, Size.M, 3),
            new Package(Provider.MR, Size.L, 4),
        ];

        public decimal GetLowestShipmentPrice()
        {
            return _package.Where(packageInfo => packageInfo.Size == Size.S).Min(packageInfo => packageInfo.Price);
        }

        public decimal GetCurrentShipmentPrice(Shipment shipment)
        {
            return _package.Single(packageInfo => packageInfo.Provider == shipment.Provider && packageInfo.Size == shipment.Size).Price;
        }
    }
}
