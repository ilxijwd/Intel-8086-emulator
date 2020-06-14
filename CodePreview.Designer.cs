namespace Курсач
{
    partial class CodePreview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InstructionsDataGrid = new System.Windows.Forms.DataGridView();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instruction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructionsMemoryDump = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InstructionsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // InstructionsDataGrid
            // 
            this.InstructionsDataGrid.AllowUserToAddRows = false;
            this.InstructionsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InstructionsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Address,
            this.Instruction});
            this.InstructionsDataGrid.Location = new System.Drawing.Point(12, 12);
            this.InstructionsDataGrid.Name = "InstructionsDataGrid";
            this.InstructionsDataGrid.RowTemplate.Height = 24;
            this.InstructionsDataGrid.ShowEditingIcon = false;
            this.InstructionsDataGrid.Size = new System.Drawing.Size(300, 300);
            this.InstructionsDataGrid.TabIndex = 0;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 127;
            // 
            // Instruction
            // 
            this.Instruction.HeaderText = "Instruction";
            this.Instruction.Name = "Instruction";
            this.Instruction.ReadOnly = true;
            this.Instruction.Width = 130;
            // 
            // instructionsMemoryDump
            // 
            this.instructionsMemoryDump.Location = new System.Drawing.Point(318, 34);
            this.instructionsMemoryDump.Name = "instructionsMemoryDump";
            this.instructionsMemoryDump.Size = new System.Drawing.Size(302, 278);
            this.instructionsMemoryDump.TabIndex = 1;
            this.instructionsMemoryDump.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(390, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дамп пам\'яті інструкцій";
            // 
            // CodePreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 325);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.instructionsMemoryDump);
            this.Controls.Add(this.InstructionsDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CodePreview";
            this.Text = "CodePreview";
            ((System.ComponentModel.ISupportInitialize)(this.InstructionsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView InstructionsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instruction;
        private System.Windows.Forms.RichTextBox instructionsMemoryDump;
        private System.Windows.Forms.Label label1;
    }
}