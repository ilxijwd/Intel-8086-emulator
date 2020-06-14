
namespace Курсач.SuperComputer.InstructionMaker.enums
{
    // Типи адресації команд (Безадресна, Безпосередня, Пряма, Непряма)
    public enum AddressType
    {
        NONE = 0x00,
        IMMEDIATE = 0x01,
        DIRECT = 0x02,
        INDIRECT = 0x03
    }
}