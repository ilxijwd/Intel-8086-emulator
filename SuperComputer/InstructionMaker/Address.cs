using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач.SuperComputer.InstructionMaker
{
    public class Address
    {
        private Int16 address;

        public Address(Int16 a)
        {
            this.address = a;
        }

        public Int16 GetAddress()
        {
            return this.address;
        }

        public string Get16BitAddress()
        {
            return Convert.ToString(this.address, 16);
        }
    }
}
