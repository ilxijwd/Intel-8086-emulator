using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсач.SuperComputer;
using Курсач.SuperComputer.InstructionMaker;
using Курсач.SuperComputer.InstructionMaker.enums;

namespace Курсач
{
    public partial class FormMain : Form
    {
        // Клас який зберігає логіку додатка
        private SuperPC pc;

        // Неініціалізовані об'экти класів Windows Forms
        private Debugger debugger;
        private CodePreview codePreview;
        public FormMain()
        {
            InitializeComponent();
            
            // Створення черги команд для виконання мЕОМ
            Queue<Instruction> instructions = new Queue<Instruction>();
            instructions.Enqueue(new Instruction(Mnemonic.PUSH, AddressType.IMMEDIATE, new Operand(1)));
            instructions.Enqueue(new Instruction(Mnemonic.PUSH, AddressType.IMMEDIATE, new Operand(2)));
            instructions.Enqueue(new Instruction(Mnemonic.PUSH, AddressType.IMMEDIATE, new Operand(3)));
            instructions.Enqueue(new Instruction(Mnemonic.IMUL, AddressType.NONE));

            // Ініціалізація класу SuperPC
            pc = new SuperPC(instructions);
        }

        // Callback на кнопку "Step"
        private void StepButton_Click(object sender, EventArgs e)
        {
            this.pc.Step(); // Виконання програмного кроку
            if (this.debugger != null) this.debugger.DrawResults(this.pc); // Відмальовка результатів виконання інструкцій у формі "Debugger"
        }

        // Callback на кнопку "Reset"
        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.pc.Reset();
        }

        // Callback на кнопку "Open debugger"
        private void OpenDebuggerButton_Click(object sender, EventArgs e)
        {
            this.debugger = new Debugger();
            this.debugger.Show();
            this.debugger.DrawStack(this.pc); // Ініціалізація форми "Debugger" та відмальовка поточного результату виконання інструкцій
        }

        // Callback на кнопку "Show programm"
        private void ShowProgrammButton_Click(object sender, EventArgs e)
        {
            this.codePreview = new CodePreview();
            this.codePreview.Show();
            this.codePreview.DrawInstructions(this.pc); // Ініціалізація форми "CodePreview" та відмальовка поточного результату виконання інструкцій
        }
    }
}
