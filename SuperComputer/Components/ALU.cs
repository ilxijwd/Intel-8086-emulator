using System;
using Курсач.SuperComputer.InstructionMaker;
using Курсач.SuperComputer.InstructionMaker.enums;

namespace Курсач.SuperComputer.Components
{
    public class ALU
    {
        private FlagsRegister flags;

        public ALU(FlagsRegister flags)
        {
            this.flags = flags;
        }

        public Operand Perform(Mnemonic m, Operand first_operand, Operand second_operand = null)
        {
            Operand result = new Operand(0);
            try
            {
                switch (m)
                {
                    case Mnemonic.CMP:
                        // Команда CMP сравнивает 2 операнда вычитая второй из первого
                        // Источник: http://www.club155.ru/x86cmd/CMP
                        result = first_operand - second_operand;
                        break;

                    case Mnemonic.IMUL:
                        result = first_operand * second_operand;
                        break;

                    case Mnemonic.NOT:
                        result = ~first_operand;
                        break;

                    case Mnemonic.TEST:
                        result = first_operand & second_operand;
                        break;

                    case Mnemonic.RCL:
                        result = first_operand << 1;
                        break;

                    case Mnemonic.ROR:
                        result = first_operand >> 1;
                        break;
                }

                flags.OF = false;
            }
            catch (OverflowException)
            {
                flags.OF = true;
            }

            flags.PF = ((result.GetData() & 1) == 0) ? true : false;

            return result;
        }

        public void Reset()
        {
            this.flags.Reset();
        }

        public FlagsRegister GetFlags()
        {
            return this.flags;
        }
    }
}