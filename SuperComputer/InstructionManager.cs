using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсач.SuperComputer.InstructionMaker;
using Курсач.SuperComputer.InstructionMaker.enums;

namespace Курсач.SuperComputer
{
    public class InstructionManager
    {
        private Instruction[] instructions;
        private int PC;     // Лічильник індексу виконання поточної інструкції
        private Int16 CS;   // Виконавчий адрес поточної інструкції
        private Int16 IP;   // Виконавчий адрес наступної інструкції

        public InstructionManager(Instruction[] i)
        {
            this.instructions = i;
            this.Reset();
        }

        public void CheckInstructions()
        {
            // Ініціалізація правил створення інструкцій
            InstructionRule[] instructionRules = new[] {
                new InstructionRule(Mnemonic.PUSH, new [] { AddressType.IMMEDIATE, AddressType.DIRECT, AddressType.INDIRECT }),
                new InstructionRule(Mnemonic.STORE, new [] { AddressType.IMMEDIATE, AddressType.DIRECT, AddressType.INDIRECT }),
                new InstructionRule(Mnemonic.CMP, new [] { AddressType.NONE }),
                new InstructionRule(Mnemonic.IMUL, new [] { AddressType.NONE }),
                new InstructionRule(Mnemonic.NOT, new [] { AddressType.NONE }),
                new InstructionRule(Mnemonic.TEST, new [] { AddressType.NONE }),
                new InstructionRule(Mnemonic.RCL, new [] { AddressType.NONE }),
                new InstructionRule(Mnemonic.ROR, new [] { AddressType.NONE }),
                /*new InstructionRule(Mnemonic.JMP, new [] { AddressType.IMMEDIATE }),
                new InstructionRule(Mnemonic.JNP, new [] { AddressType.IMMEDIATE }),
                new InstructionRule(Mnemonic.LABEL, new [] { AddressType.IMMEDIATE }),*/
            };

            // Перевірка інструкцій за відповідним правилом
            foreach (Instruction i in this.instructions)
                Array.Find(instructionRules, rule => rule.GetMnemonic() == i.GetMnemonic()).Check(i);
        }

        /**
         * КОП - код операції - займає 4 біта
         * ПА - ознака адресності операнда - займає 2 біта
         * А - поле адреси операнда - займає 16 біт
         */
        public void MapAddressesToInstructions()
        {
            Int16 addressCounter = 0;
            foreach (Instruction i in this.instructions)
            {
                i.SetAddress(new Address(addressCounter));

                switch (i.GetMnemonic())
                {
                    // Розміри приведених інструкцій
                    case Mnemonic.PUSH:
                    case Mnemonic.STORE:
                    /*case Mnemonic.JMP:
                    case Mnemonic.JNP:*/
                        addressCounter += 23;
                        break;
                    case Mnemonic.CMP:
                    case Mnemonic.IMUL:
                    case Mnemonic.NOT:
                    case Mnemonic.TEST:
                    case Mnemonic.RCL:
                    case Mnemonic.ROR:
                        addressCounter += 5;
                        break;
                }
            }
        }

        public void Reset()
        {
            this.PC = -1;
            this.CS = 0;
            this.IP = 0;
        }

        // Робить 16річний дамп коду
        public string GetAddressMemoryDump()
        {
            return String.Join(" ", this.instructions.Select(i => {
                string opCode = Convert.ToString((int)i.GetMnemonic(), 16).ToUpper();
                string comAddressType = Convert.ToString((int)i.GetAddressType(), 16).ToUpper();
                string operand = i.GetOperand() != null ? Convert.ToString(i.GetOperand().GetData(), 16) : "";

                return opCode + comAddressType + operand;
            }).ToArray());
        }

        public Instruction[] GetInstructions()
        {
            return this.instructions;
        }

        // Повертає інструкцію яка виконується ЗАРАЗ
        // Важливо викликати цю функцію тільки один раз під час виконання кроку
        public Instruction GetCurrentInstruction()
        {
            this.PC += 1;

            Instruction currentInstruction = this.instructions[this.PC];
            Instruction nextInstruction = this.GetNextInstruction();

            this.CS = currentInstruction.GetAddress().GetAddress();
            this.IP = nextInstruction.GetAddress().GetAddress();

            return currentInstruction;
        }

        // Повертає інструкцію яка буде виконуватись ДАЛІ
        public Instruction GetNextInstruction()
        {
            Instruction instruction;
            try
            {
                instruction = this.instructions[this.PC + 1];
            } catch (IndexOutOfRangeException)
            {
                instruction = this.instructions[0];
            }

            return instruction;
        }

        public int GetPC()
        {
            return this.PC;
        }

        public string GetCS()
        {
            return Convert.ToString(this.CS, 16);
        }

        public string GetIP()
        {
            return Convert.ToString(this.IP, 16);
        }
    }
}
