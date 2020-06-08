using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсач.SuperComputer;
using Курсач.SuperComputer.InstructionMaker;

namespace Курсач
{
    public partial class CodePreview : Form
    {
        public CodePreview()
        {
            InitializeComponent();
        }

        public void DrawInstructions(SuperPC pc)
        {
            InstructionsDataGrid.Rows.Clear();

            Instruction[] instructions = new Instruction[pc.GetInstructions().Count];
            pc.GetInstructions().CopyTo(instructions, 0);

            foreach (Instruction instruction in instructions)
            {
                string address = instruction.GetAddressType().ToString();
                string command = instruction.GetMnemonic().ToString() + " " + (instruction.GetOperand() == null ? "" : instruction.GetOperand().GetData().ToString());
                InstructionsDataGrid.Rows.Add(address, 1, command);
            }
        }
    }
}
