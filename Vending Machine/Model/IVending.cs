using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Model
{
    interface IVending
    {
        Product Purchase(int index);
        void ShowAll();
        void InsertMoney(int money);
        Dictionary<int, int> EndTransaction();
    }
}
