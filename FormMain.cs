﻿using System;
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
            Instruction[] instructions = {
                new Instruction(Mnemonic.PUSH, AddressType.DIRECT, new Operand("cache")),
                new Instruction(Mnemonic.PUSH, AddressType.IMMEDIATE, new Operand(2)),
                new Instruction(Mnemonic.PUSH, AddressType.IMMEDIATE, new Operand(3)),
                new Instruction(Mnemonic.IMUL, AddressType.NONE),
                new Instruction(Mnemonic.RCL, AddressType.NONE),
                new Instruction(Mnemonic.STORE, AddressType.DIRECT, new Operand("cache")),
                new Instruction(Mnemonic.NOT, AddressType.NONE),
                new Instruction(Mnemonic.STORE, AddressType.DIRECT, new Operand("cache"))
            };

            // Ініціалізація класу SuperPC
            pc = new SuperPC(instructions);
        }

        // Callback на кнопку "Step"
        private void StepButton_Click(object sender, EventArgs e)
        {
            this.pc.Step(); // Виконання програмного кроку
            if (this.debugger != null) this.debugger.DrawResults(this.pc); // Відмальовка результатів виконання інструкцій у формі "Debugger"
            if (this.codePreview != null) this.codePreview.SelectInstruction(this.pc.GetInstructionManager().GetPC()); // Відмальовка поточної інструкції
        }

        // Callback на кнопку "Reset"
        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.pc.Reset();
            if (this.debugger != null) this.debugger.DrawResults(this.pc); // Відмальовка результатів виконання інструкцій у формі "Debugger"
            if (this.codePreview != null) this.codePreview.SelectInstruction(this.pc.GetInstructionManager().GetPC()); // Відмальовка поточної інструкції
        }

        // Callback на кнопку "Open debugger"
        private void OpenDebuggerButton_Click(object sender, EventArgs e)
        {
            this.debugger = new Debugger();
            this.debugger.Show();
            this.debugger.DrawResults(this.pc); // Ініціалізація форми "Debugger" та відмальовка поточного результату виконання інструкцій
        }

        // Callback на кнопку "Show programm"
        private void ShowProgrammButton_Click(object sender, EventArgs e)
        {
            this.codePreview = new CodePreview();
            this.codePreview.Show();
            this.codePreview.DrawInstructions(this.pc); // Ініціалізація форми "CodePreview" та відмальовка поточного результату виконання інструкцій
            this.codePreview.SelectInstruction(this.pc.GetInstructionManager().GetPC()); // Відмальовка поточної інструкції
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ilxijwd/");
        }
    }
}