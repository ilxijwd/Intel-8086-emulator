using System;
using Курсач.SuperComputer.InstructionMaker.enums;

namespace Курсач.SuperComputer.InstructionMaker
{
    public class Instruction
    {
        private Mnemonic m;
        private AddressType at;
        private Operand o;

        private static InstructionRule[] instructionRules = new[] {
            new InstructionRule(Mnemonic.PUSH, new [] { AddressType.DIRECT, AddressType.IMMEDIATE, AddressType.INDIRECT, AddressType.DIRECT_BASING, AddressType.DIRECT_INDEXING }, true),
            new InstructionRule(Mnemonic.STORE, new [] { AddressType.DIRECT, AddressType.IMMEDIATE, AddressType.INDIRECT, AddressType.DIRECT_BASING, AddressType.DIRECT_INDEXING }, true),
            new InstructionRule(Mnemonic.CMP, new [] { AddressType.DIRECT }, true),
            new InstructionRule(Mnemonic.CMP, new [] { AddressType.NONE }, false),
            new InstructionRule(Mnemonic.IMUL, new [] { AddressType.DIRECT }, true),
            new InstructionRule(Mnemonic.IMUL, new [] { AddressType.NONE }, false),
            new InstructionRule(Mnemonic.NOT, new [] { AddressType.NONE }, false),
            new InstructionRule(Mnemonic.TEST, new [] { AddressType.NONE }, false),
            new InstructionRule(Mnemonic.RCL, new [] { AddressType.NONE }, false),
            new InstructionRule(Mnemonic.ROR, new [] { AddressType.NONE }, false),
            new InstructionRule(Mnemonic.JMP, new [] { AddressType.IMMEDIATE }, true),
            new InstructionRule(Mnemonic.JNP, new [] { AddressType.IMMEDIATE }, true),
            new InstructionRule(Mnemonic.INT, new [] { AddressType.IMMEDIATE }, true),
            new InstructionRule(Mnemonic.IN, new [] { AddressType.IMMEDIATE }, true),
            new InstructionRule(Mnemonic.OUT, new [] { AddressType.IMMEDIATE }, true),
        };

        public Instruction(Mnemonic m, AddressType at = AddressType.NONE, Operand o = null)
        {
            this.m = m; this.at = at; this.o = o;
            Array.Find(instructionRules, rule => rule.GetMnemonic() == m && rule.GetHasOperand() == (o != null)).Check(this);
        }

        public Mnemonic GetMnemonic()
        {
            return m;
        }

        public AddressType GetAddressType()
        {
            return at;
        }

        public Operand GetOperand()
        {
            return o;
        }
    }
}