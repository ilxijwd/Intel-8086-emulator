using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач.SuperComputer.Components
{
    public struct RAMCell
    {
        public ushort startAddress; // Максимальна довжина адреси 65535 біт.
        public byte data;
        public string name;
    }

    public class RAM
    {
        List<RAMCell> cells = new List<RAMCell>();
        byte cellDataSize = 8; // Розмір одного осередка: 8 біт.

        public RAM() { }

        public List<RAMCell> GetCells()
        {
            return this.cells;
        }

        public void Reset()
        {
            this.cells.Clear();
        }

        public byte Read(string name, int offset = 0)
        {
            RAMCell ramCell = this.cells.Find(c => c.name == name);

            if (ramCell.name == "") return 0;
            if (offset == 0) return ramCell.data;

            int perByteOffset = offset / this.cellDataSize; // Побайтовий зсув
            int bits = (byte)(offset - perByteOffset * this.cellDataSize); // Побітовий зсув (залишковий зсув)

            // Якщо offset кратний 8ми - можна вертати цілий осередок
            if (bits == 0) return this.cells.Find(c => c.startAddress == offset).data;

            // Осередок за offset'ом
            RAMCell cellByOffset = this.cells.Find(c => c.startAddress == ramCell.startAddress + perByteOffset);

            string offsetData; // Збочення, та кращий побітовий зсув без втрати нулів я не зроблю, і ніхто не зробить :)
            if (offset > 0) // Зсув вправо
                offsetData = Convert.ToString(cellByOffset.data, 2).PadLeft(8, '0').Substring(bits); // Ліва частина байту, який має скластися далі
            else // Зсув вліво
                offsetData = Convert.ToString(cellByOffset.data, 2).PadLeft(8, '0').Substring(0, this.cellDataSize - bits); // Права частина

            // Найближча частина до осередка вибранного за offset'ом
            RAMCell nearestCellByOffset = this.cells.Find(c => c.startAddress == ((offset > 0) ? cellByOffset.startAddress + 1 : cellByOffset.startAddress - 1));

            string nearestOffsetData;
            if (offset > 0)
                nearestOffsetData = Convert.ToString(nearestCellByOffset.data, 2).PadLeft(8, '0').Substring(0, this.cellDataSize - bits);
            else
                nearestOffsetData = Convert.ToString(nearestCellByOffset.data, 2).PadLeft(8, '0').Substring(bits);

            string data;
            if (offset > 0)
                data = offsetData + nearestOffsetData;
            else
                data = nearestOffsetData + offsetData;

            return Convert.ToByte(data, 2);
        }

        public void Write(string name, byte data, int offset = 0)
        {
            RAMCell ramCell = this.cells.Find(c => c.name == name);

            if (ramCell.name == "") return;
            if (offset == 0)
            {
                this.cells.Remove(ramCell);

                RAMCell newCell = new RAMCell();
                newCell.name = name;
                newCell.data = data;
                newCell.startAddress = ramCell.startAddress;

                this.cells.Add(newCell);
                return;
            }

            int perByteOffset = offset / this.cellDataSize; // Побайтовий зсув
            int bits = (byte)(offset - perByteOffset * this.cellDataSize); // Побітовий зсув (залишковий зсув)

            // Якщо offset кратний 8ми - можна переписати цілий осередок
            if (bits == 0)
            {
                this.cells.Remove(ramCell);

                RAMCell newCell = new RAMCell();
                newCell.name = name;
                newCell.data = data;
                newCell.startAddress = (ushort)(ramCell.startAddress + offset);

                this.cells.Add(newCell);
                return;
            }

            // Осередок за offset'ом
            RAMCell cellByOffset = this.cells.Find(c => c.startAddress == ramCell.startAddress + perByteOffset);

            if (offset > 0)
            {
                string leftSidedData = Convert.ToString(cellByOffset.data, 2).PadLeft(8, '0').Substring(0, bits);
                string rightSidedData = Convert.ToString(data, 2).PadLeft(8, '0').Substring(0, this.cellDataSize - bits);

                RAMCell newCell = new RAMCell();
                newCell.name = name;
                newCell.data = Convert.ToByte(leftSidedData + rightSidedData, 2);
                newCell.startAddress = cellByOffset.startAddress;

                this.cells.Remove(cellByOffset);
                this.cells.Add(newCell);
            }
            else
            {
                string leftSidedData = Convert.ToString(data, 2).PadLeft(8, '0').Substring(bits);
                string rightSidedData = Convert.ToString(cellByOffset.data, 2).PadLeft(8, '0').Substring(this.cellDataSize - bits);

                RAMCell newCell = new RAMCell();
                newCell.name = name;
                newCell.data = Convert.ToByte(leftSidedData + rightSidedData, 2);
                newCell.startAddress = cellByOffset.startAddress;

                this.cells.Remove(cellByOffset);
                this.cells.Add(newCell);
            }

            // Найближча частина до осередка вибранного за offset'ом
            RAMCell nearestCellByOffset = this.cells.Find(c => c.startAddress == ((offset > 0) ? cellByOffset.startAddress + 1 : cellByOffset.startAddress - 1));

            if (offset > 0)
            {
                string leftSidedData = Convert.ToString(data, 2).PadLeft(8, '0').Substring(0, bits);
                string rightSidedData = Convert.ToString(nearestCellByOffset.data, 2).PadLeft(8, '0').Substring(bits);

                RAMCell newCell = new RAMCell();
                newCell.name = name;
                newCell.data = Convert.ToByte(leftSidedData + rightSidedData, 2);
                newCell.startAddress = nearestCellByOffset.startAddress;

                this.cells.Remove(nearestCellByOffset);
                this.cells.Add(newCell);
            }
            else
            {
                string leftSidedData = Convert.ToString(nearestCellByOffset.data, 2).PadLeft(8, '0').Substring(0, bits);
                string rightSidedData = Convert.ToString(data, 2).PadLeft(8, '0').Substring(bits, this.cellDataSize - bits);

                RAMCell newCell = new RAMCell();
                newCell.name = name;
                newCell.data = Convert.ToByte(leftSidedData + rightSidedData, 2);
                newCell.startAddress = nearestCellByOffset.startAddress;

                this.cells.Remove(nearestCellByOffset);
                this.cells.Add(newCell);
            }
        }
    }
}
