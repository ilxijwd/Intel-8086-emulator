namespace Курсач.SuperComputer.Components
{
    public class FlagsRegister
    {
        // Флаг парного паритету
        public bool PF { get; set; } = false;
        // Флаг переповнення
        public bool OF { get; set; } = false;

        public void Reset()
        {
            this.PF = false;
            this.OF = false;
        }
    }
}