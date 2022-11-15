using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp02_02
{
    internal class KyungBookBank : KBBank
    {
        public KyungBookBank(string Name)
        {
            this.Name = Name;
        }
        public void Withdrawal(int money)
        {
            this.Balance -= money;
        }
        public void Saving(int money)
        {
            this.Balance += money;
        }
    }
}
