using System;
using Курсач.SuperComputer.InstructionMaker.enums;

namespace Курсач.SuperComputer.InstructionMaker
{
    // Клас, для збереження інформації інструкцій
    public class Instruction
    {
        private Address address;
        private Mnemonic mnemonic;
        private AddressType addressType;
        private Operand operand;
        private ushort offset;

        public Instruction(Mnemonic m, AddressType at = AddressType.NONE, Operand o = null, ushort of = 0)
        {
            this.mnemonic = m; this.addressType = at; this.operand = o; this.offset = of;
        }

        public void SetAddress(Address address)
        {
            this.address = address;
        }

        public Address GetAddress()
        {
            return this.address;
        }

        public Mnemonic GetMnemonic()
        {
            return this.mnemonic;
        }

        public AddressType GetAddressType()
        {
            return this.addressType;
        }

        public Operand GetOperand()
        {
            return this.operand;
        }

        public ushort GetOffset()
        {
            return this.offset;
        }
    }
}