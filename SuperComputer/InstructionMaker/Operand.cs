using System;

namespace Курсач.SuperComputer.InstructionMaker
{
    public class Operand
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

        public static Operand operator -(Operand a, Operand b) => new Operand(a.GetData() - b.GetData());

        public static Operand operator *(Operand a, Operand b) => new Operand(a.GetData() * b.GetData());

        public static Operand operator ~(Operand a) => new Operand(~a.GetData());

        public static Operand operator &(Operand a, Operand b) => new Operand(a.GetData() & b.GetData());

        public static Operand operator <<(Operand a, int b) => new Operand(a.GetData() << b);

        public static Operand operator >>(Operand a, int b) => new Operand(a.GetData() >> b);

        public byte GetData()
        {
            return data;
        }
    }
}