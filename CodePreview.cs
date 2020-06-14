using System.Windows.Forms;
using Курсач.SuperComputer;
using Курсач.SuperComputer.InstructionMaker;
using Курсач.SuperComputer.InstructionMaker.enums;

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

            instructionsMemoryDump.Text = pc.GetInstructionManager().GetAddressMemoryDump();

            Instruction[] instructions = pc.GetInstructionManager().GetInstructions();

            foreach (Instruction instruction in instructions)
            {
                string address = "0x" + instruction.GetAddress().Get16BitAddress();
                string mnemonic = instruction.GetMnemonic().ToString().ToLower();

                if (instruction.GetOperand() == null)
                    InstructionsDataGrid.Rows.Add(address, mnemonic);
                else
                {
                    Operand operand = instruction.GetOperand();
                    string operandData = instruction.GetOperand().GetData().ToString();

                    string renderedOperand = "";
                    if (operand.GetName() != null)
                    {
                        renderedOperand = '[' 
                            + operand.GetName()
                            + ((instruction.GetOffset() != 0) ? instruction.GetOffset().ToString() : "")
                            + ']';
                    }
                    else renderedOperand = operandData;

                    InstructionsDataGrid.Rows.Add(address, mnemonic + " " + renderedOperand);
                }
            }
        }

        public void SelectInstruction(int i)
        {
            for (int row = 0; row < InstructionsDataGrid.Rows.Count; row++)
                InstructionsDataGrid.Rows[row].Selected = (row == i) ? true : false;
        }
    }
}