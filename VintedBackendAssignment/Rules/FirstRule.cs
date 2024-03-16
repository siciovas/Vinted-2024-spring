using VintedBackendAssignment.Enums;
using VintedBackendAssignment.Rules.Interface;
using static VintedBackendAssignment.PackageInformation;

namespace VintedBackendAssignment.Rules
{
    public class FirstRule : IRule
    {
        private readonly decimal _smallPackageLowestPrice = Packages.Where(packageInfo => packageInfo.Size == Size.S).Min(packageInfo => packageInfo.Price);

        public void ApplyDiscount(Shipment shipment, DiscountCalculation discountCalculation, decimal currentPrice)
        {
            if (shipment.Size == Size.S && currentPrice > _smallPackageLowestPrice)
            {
                var discount = discountCalculation.DiscountBalance(currentPrice - _smallPackageLowestPrice);

                shipment.DiscountPrice = currentPrice - discount;
                shipment.Discount = discount;
            }
        }
    }
}
