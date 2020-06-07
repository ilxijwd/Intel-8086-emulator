using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач.SuperComputer
{
    class Operand
    {
        private byte data;
        public Operand(int data)
        {
            this.data = Convert.ToByte(data);
        }
        public Operand(char data)
        {
            this.data = Convert.ToByte(data);
        }
        public Operand(byte data)
        {
            this.data = data;
        }
        public byte getData() { return data; }
    }
}
