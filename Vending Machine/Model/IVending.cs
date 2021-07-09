using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Model
{
    interface IVending
    {
        string Purchase(int index);
        string ShowAll();
        void InsertMoney(int money);
        Dictionary<int, int> EndTransaction();
    }
}
