using System;
using System.Linq;
using Курсач.SuperComputer.InstructionMaker.enums;

namespace Курсач.SuperComputer.InstructionMaker
{
    public class InstructionRule
    {
        private Mnemonic m;
        private AddressType[] at;
        private bool hasOperand;

        public InstructionRule(Mnemonic m, AddressType[] at, bool hasOperand)
        {
            this.m = m; this.at = at; this.hasOperand = hasOperand;
        }

        public bool Check(Instruction i)
        {
            AddressType at = i.GetAddressType();
            Operand o = i.GetOperand();
            if (!this.at.Contains(at))
                throw new Exception(String.Format("Инструкция {0} не может иметь тип адресации {1}", this.m.ToString(), at));
            if (o != null && this.hasOperand == false)
                throw new Exception(String.Format("Инструкция {0} не может иметь операнд", this.m.ToString()));
            if (o == null && this.hasOperand == true)
                throw new Exception(String.Format("Инструкция {0} должна иметь операнд", this.m.ToString()));
            return true;
        }

        public Mnemonic GetMnemonic()
        {
            return this.m;
        }

        public bool GetHasOperand()
        {
            return this.hasOperand;
        }
    }
}