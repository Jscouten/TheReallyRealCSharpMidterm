using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMidterm
{
    public class UserObject
    {
        public string Worked { get; set; }
        public int IDObject { get; set; }
        public string UsernameObject { get; set; }
        public int PINObject { get; set; }
        public decimal CheckingObject { get; set; }
        public decimal SavingObject { get; set; }

        public UserObject()
        {

        }

        public UserObject(int IDPlaceholder, string UsernamePlaceholder, int PINPlaceholder, decimal CheckingPlaceholder, decimal SavingPlaceholder)
        {
            IDObject = IDPlaceholder;
            UsernameObject = UsernamePlaceholder;
            PINObject = PINPlaceholder;
            CheckingObject = CheckingPlaceholder;
            SavingObject = SavingPlaceholder;
            Worked = string.Empty;
        }

        public virtual decimal GetMoney()
        {
            return 42069;
        }
    }
}
