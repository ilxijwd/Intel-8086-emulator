using System;

namespace Курсач.SuperComputer.InstructionMaker
{
    public class Operand
    {
        private byte data;
        private string name;

        public Operand(byte d)
        {
            this.data = d;
        }

        public Operand(string n)
        {
            this.name = n;
        }

        public static Operand operator -(Operand a, Operand b) => new Operand((byte)(a.GetData() - b.GetData()));

        public static Operand operator *(Operand a, Operand b) => new Operand((byte)(a.GetData() * b.GetData()));

        public static Operand operator ~(Operand a) => new Operand((byte)(~a.GetData()));

        public static Operand operator &(Operand a, Operand b) => new Operand((byte)(a.GetData() & b.GetData()));

        public static Operand operator <<(Operand a, int b) => new Operand((byte)(a.GetData() << b));

        public static Operand operator >>(Operand a, int b) => new Operand((byte)(a.GetData() >> b));

        public byte GetData()
        {
            return this.data;
        }

        public string GetName()
        {
            return this.name;
        }
    }
}