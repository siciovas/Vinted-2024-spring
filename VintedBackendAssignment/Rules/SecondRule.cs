﻿using VintedBackendAssignment.Enums;
using VintedBackendAssignment.Rules.Interface;
using Constant = VintedBackendAssignment.Constants.Constants;

namespace VintedBackendAssignment.Rules
{
    public class SecondRule : IRule
    {
        public void ApplyDiscount(Shipment shipment, DiscountCalculation discountCalculation, decimal currentPrice)
        {
            if (shipment.Size == Size.L && shipment.Provider == Provider.LP)
            {
                discountCalculation.LpShipmentTimes += 1;

                if (discountCalculation.LpShipmentTimes == Constant.FreeDelivery)
                {
                    shipment.DiscountPrice = 0;
                    shipment.Discount = discountCalculation.DiscountBalance(currentPrice);
                }
            }
        }
    }
}
