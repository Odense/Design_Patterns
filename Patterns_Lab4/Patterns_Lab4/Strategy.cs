using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Lab4
{
    public interface IShoppingStrategy
    {
        string ShopItem(string shoppingType);
    }

    public class OnlineShopping : IShoppingStrategy
    {
        public OnlineShopping() { }

        public string ShopItem(string shoppingType)
        {
            switch (shoppingType)
            {
                case "CashToCourier": return "You've bought item at internet shop with payment via cash to courier";
                case "CardAndPickup": return "You've bought item at internet shop with online payment via bank card and self pickup from our shop";
                default: return "Something went wrong";
            }
        }
    }

    public class RealShopping : IShoppingStrategy
    {
        public RealShopping() { }

        public string ShopItem(string shoppingType)
        {
            return "You've bought item in real shop whith delivering via our delivering service";
        }
    }

    public class PurchasedItem
    {
        private IShoppingStrategy _purchasedItem;
        private string _shoppingType;

        public PurchasedItem() { }

        public void SetShoppingType(IShoppingStrategy shoppingType)
        {
            _purchasedItem = shoppingType;
        }

        public string shoppingType
        {
            get { return _shoppingType; }
            set { _shoppingType = value; }
        }


        public string ItemShoppingType
        {
            get { return _purchasedItem.ShopItem(_shoppingType); }
        }
    } 
}
