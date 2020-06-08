using System.Collections.Generic;
using Курсач.SuperComputer.Components;
using Курсач.SuperComputer.InstructionMaker;
using Курсач.SuperComputer.InstructionMaker.enums;

namespace Курсач.SuperComputer
{
    public class SuperPC
    {
        private Queue<Instruction> instructions;
        private Stack<Operand> stack;
        private FlagsRegister flags;
        private ALU alu;

        public SuperPC(Queue<Instruction> i)
        {
            this.instructions = i;
            this.stack = new Stack<Operand>();
            this.flags = new FlagsRegister();
            this.alu = new ALU(this.flags);
        }

        public void Step()
        {
            Instruction currentInstruction = this.instructions.Dequeue();

            Mnemonic currentMnemonic = currentInstruction.GetMnemonic();
            AddressType currentAddressType = currentInstruction.GetAddressType();
            Operand currentOperand = currentInstruction.GetOperand();

            switch (currentMnemonic)
            {
                case Mnemonic.PUSH:
                    this.stack.Push(currentOperand);
                    break;

                case Mnemonic.STORE:
                    this.stack.Pop();
                    // TODO: Create RAM storage
                    break;

                case Mnemonic.IMUL:
                    {
                        Operand stackTop = this.stack.Pop();
                        Operand stackAfterTop = this.stack.Pop();

                        Operand result = this.alu.Perform(Mnemonic.IMUL, stackTop, stackAfterTop);
                        this.stack.Push(result);
                    }
                    break;

                case Mnemonic.CMP:
                    {
                        Operand stackTop = this.stack.Peek();

                        this.alu.Perform(Mnemonic.CMP, stackTop, currentOperand);
                    }
                    break;

                case Mnemonic.NOT:
                    {
                        Operand stackTop = this.stack.Pop();

                        Operand result = this.alu.Perform(Mnemonic.NOT, stackTop);
                        this.stack.Push(result);
                    }
                    break;

                case Mnemonic.TEST:
                    {
                        Operand stackTop = this.stack.Pop();

                        this.alu.Perform(Mnemonic.TEST, stackTop, currentOperand);
                    }
                    break;

                case Mnemonic.RCL:
                    {
                        Operand stackTop = this.stack.Pop();

                        Operand result = this.alu.Perform(Mnemonic.RCL, stackTop);
                        this.stack.Push(result);
                    }
                    break;

                case Mnemonic.ROR:
                    {
                        Operand stackTop = this.stack.Pop();

                        Operand result = this.alu.Perform(Mnemonic.ROR, stackTop);
                        this.stack.Push(result);
                    }
                    break;
                    /*case Mnemonic.JMP:
                    case Mnemonic.JNP:
                    case Mnemonic.INT:
                    case Mnemonic.IN:
                    case Mnemonic.OUT:*/
            }
        }

        public void Reset()
        {
        }

        public Queue<Instruction> GetInstructions()
        {
            return this.instructions;
        }

        public Stack<Operand> GetStack()
        {
            return this.stack;
        }

        public FlagsRegister GetFlags()
        {
            return this.flags;
        }
    }
}