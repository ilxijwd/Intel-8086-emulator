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
    public partial class Debugger : Form
    {
        public Debugger()
        {
            InitializeComponent();
        }

        public void DrawResults(SuperPC pc)
        {
            this.DrawStack(pc);
            this.DrawFlags(pc);
        }

        public void DrawStack(SuperPC pc)
        {
            StackDataGrid.Rows.Clear();

            Operand[] operands = new Operand[pc.GetStack().Count];
            pc.GetStack().CopyTo(operands, 0);

            foreach (Operand operand in operands)
                StackDataGrid.Rows.Add(operand.GetData().ToString());
        }
        public void DrawFlags(SuperPC pc)
        {
            parityFlagTextBox.Text = (pc.GetFlags().PF == true) ? "1" : "0";
        }

    }
}
