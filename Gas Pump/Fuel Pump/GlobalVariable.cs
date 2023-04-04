using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel_Pump
{
    internal class GlobalVariable
    {
        private static string v_Fuel = "";

        public static string variable_Fuel
        {
            get { return v_Fuel; }
            set { v_Fuel = value; }
        }
        private static string v_amount = "";

        public static string variable_amount
        {
            get { return v_amount; }
            set { v_amount = value; }
        }

        private static string v_change = "";
        public static string variable_change
        {
            get { return v_change; }
            set { v_change = value; }
        }

        private static string v_cash = "10000";
        public static string variable_cash
        {
            get { return v_cash; }
            set { v_cash = value; }
        }

        private static string v_liters = "";
        public static string variable_liters
        {
            get { return v_liters; }
            set { v_liters = value; }
        }

        private static string v_Dliters = "5000";
        public static string variable_Dliters
        {
            get { return v_Dliters; }
            set { v_Dliters = value; }
        }

        private static string v_Pliters = "5000";
        public static string variable_Pliters
        {
            get { return v_Pliters; }
            set { v_Pliters = value; }
        }

        private static string v_Uliters = "5000";
        public static string variable_Uliters
        {
            get { return v_Uliters; }
            set { v_Uliters = value; }
        }



    }
}
    

