using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230614
{
    public class ItemInfo
    {
        public string itemName;

        public int itemCount { get; private set; }
        public int ItemPrice;

        public int ItemPrice_
        {
            get
            {
                return ItemPrice_;
            }
            private set
            {
                ItemPrice_ = value;
            }
        }

        public void InitItem( string name , int count , int price)
        {
            itemName = name;
            itemCount = count;
            ItemPrice = price;

        }


        // !아이템 name을 Return 해보겠음
        public string Get_ItemName()
        {
            return itemName;
        }     // Get_itemName()

        // !아이템 name을 외부에서 변경할 수 있게 해주겠음
        public void Set_ItemName(string changName)
        {
            itemName = changName;
        }     // Set_ItemName()
    }
}
