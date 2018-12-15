using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Assistant
{
    public class Player
    {
        private string name;
        private int money;

        public Player(string name, int money)
        {
            this.name = name;
            this.money = money;
        }

        public void addMoney(int amt)
        {
            this.money += amt;
        }

        public void subMoney(int amt)
        {
            this.money -= amt;
        }

        #region get methods

        public string getName()
        {
            return this.name;
        }

        public int getMoney()
        {
            return this.money;
        }

        #endregion
    }
}
