using System;
using System.Collections.Generic;
using Курсач.SuperComputer.Components;
using Курсач.SuperComputer.InstructionMaker;
using Курсач.SuperComputer.InstructionMaker.enums;

namespace Курсач.SuperComputer
{
    // Відповідає за збереження та виконання процедур
    public class SuperPC
    {
        private InstructionManager instructionManager;
        private Stack<Operand> stack;
        private RAM ram;

        private ALU alu;

        public SuperPC(Instruction[] i)
        {
            this.instructionManager = new InstructionManager(i);
            this.instructionManager.CheckInstructions();
            this.instructionManager.MapAddressesToInstructions();

            this.stack = new Stack<Operand>();
            this.alu = new ALU(new FlagsRegister());
            this.ram = new RAM();
            this.ram.Write("cache", 123);
        }

        public void Step()
        {
            Instruction currentInstruction;

            try
            {
                currentInstruction = this.instructionManager.GetCurrentInstruction();
            } catch (IndexOutOfRangeException)
            {
                this.Reset();
                return;
            }

            Mnemonic currentMnemonic = currentInstruction.GetMnemonic();
            AddressType currentAddressType = currentInstruction.GetAddressType();
            Operand currentOperand = currentInstruction.GetOperand();

            switch (currentMnemonic)
            {
                case Mnemonic.PUSH:
                    {
                        switch (currentAddressType)
                        {
                            case AddressType.IMMEDIATE:
                                this.stack.Push(currentOperand);
                                break;
                            case AddressType.DIRECT:
                                byte data = this.ram.Read(currentOperand.GetName());
                                this.stack.Push(new Operand(data));
                                break;
                        }
                    }
                    break;

                case Mnemonic.STORE:
                    {
                        Operand stackTop = this.stack.Pop();
                        this.ram.Write(currentOperand.GetName(), stackTop.GetData());
                    }
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
                    case Mnemonic.JNP:*/
            }
        }

        public void Reset()
        {
            this.instructionManager.Reset();
            this.stack.Clear();
            this.alu.Reset();
            this.ram.Reset();
            this.ram.Write("cache", 123);
        }

        public RAM GetRam()
        {
            return this.ram;
        }

        // Має викликатись виключно для відображення даних виконання інструкцій
        public InstructionManager GetInstructionManager()
        {
            return this.instructionManager;
        }

        public Stack<Operand> GetStack()
        {
            return this.stack;
        }

        public FlagsRegister GetFlags()
        {
            return this.alu.GetFlags();
        }
    }
}