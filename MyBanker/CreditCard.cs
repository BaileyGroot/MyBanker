using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class CreditCard
    {
        private string expirationdate;
        private int overdraw;

        public string Expirationdate
        {
            get
            {
                return expirationdate;
            }
            private set
            {
                expirationdate = value;
            }
        }

        public int Overdraw
        {
            get
            {
                return overdraw;
            }
            private set
            {
                overdraw = value;
            }
        }
    }
}
