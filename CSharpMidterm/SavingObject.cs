using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMidterm
{
    class SavingObject : UserObject
    {
        private static decimal Interest = 12;

        public SavingObject(int IDPlaceholder, string UsernamePlaceholder, int PINPlaceholder, decimal CheckingPlaceholder, decimal SavingPlaceholder) : base(IDPlaceholder, UsernamePlaceholder, PINPlaceholder, CheckingPlaceholder, SavingPlaceholder)
        {
            int ID = IDPlaceholder;
            string Username = UsernamePlaceholder;
            int PIN = PINPlaceholder;
            decimal Saving = SavingPlaceholder;
        }

        public override decimal GetMoney()
        {
            return SavingObject;
        }
    }
}
