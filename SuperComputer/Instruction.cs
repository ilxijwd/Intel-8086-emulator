using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач.SuperComputer
{
    class Instruction
    {
        private Mnemonic m;
        private AddressType at;
        private Operand o;
        public Instruction(Mnemonic m, AddressType at = AddressType.NONE, Operand o = null)
        {
            switch (m)
            {
                case Mnemonic.NOT:
                case Mnemonic.TEST:
                case Mnemonic.RCL:
                case Mnemonic.ROR:
                    if (at == AddressType.NONE)
                    {
                        if (o == null)
                        {
                            // Add rules
                        }
                    }
                    else
                    {
                        throw new Exception("Commands NOT, TEST, RCL and ROR cannot have an operand!");
                    }
                    break;
                case Mnemonic.NOT:
                    break;
                case Mnemonic.NOT:
                    break;
                case Mnemonic.NOT:
                    break;
                case Mnemonic.NOT:
                    break;
            }
            this.m = m; this.at = at; this.o = o;
        }
    }
}
