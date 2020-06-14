using System;
using System.Linq;
using Курсач.SuperComputer.InstructionMaker.enums;

namespace Курсач.SuperComputer.InstructionMaker
{
    public class InstructionRule
    {
        private Mnemonic m;
        private AddressType[] at;

        public InstructionRule(Mnemonic m, AddressType[] at)
        {
            this.m = m; this.at = at;
        }

        public bool Check(Instruction i)
        {
            AddressType at = i.GetAddressType();
            Operand o = i.GetOperand();
            if (!this.at.Contains(at))
                throw new Exception(String.Format("Инструкция {0} не может иметь тип адресации {1}", this.m.ToString(), at));
            return true;
        }

        public Mnemonic GetMnemonic()
        {
            return this.m;
        }
    }
}