using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Bank
    {
        private string bankname;
        private List<Card> card;

        public string Bankname
        {
            get
            {
                return bankname;
            }
            private set
            {
                bankname = value;
            }
        }

        public List<Card> Card
        {
            get
            {
                return card;
            }
            private set
            {
                card = value;
            }
        }


        public void Addcard()
        {

        }

    }
}
