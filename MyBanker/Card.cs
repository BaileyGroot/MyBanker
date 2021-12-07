using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Card : Bank
    {

        private string name;
        private int cardnumber;
        private int prefix;
        private string limit;
        private int accountnumber;
        private string type;

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                name = value;
            }
        }
        public int Cardnumber
        {
            get
            {
                return cardnumber;
            }
            private set
            {
                cardnumber = value;
            }
        }
        public int Prefix
        {
            get
            {
                return prefix;
            }
            private set
            {
                prefix = value;
            }
        }
        public string Limit
        {
            get
            {
                return limit;
            }
            private set
            {
                limit = value;
            }
        }
        public int Accountnumber
        {
            get
            {
                return accountnumber;
            }
            private set
            {
                accountnumber = value;
            }
        }
        public string Type
        {
            get
            {
                return type;
            }
            private set
            {
                type = value;
            }
        }

        public void Pay()
        {

        }

        public void Checkaccount()
        {

        }



    }
}
