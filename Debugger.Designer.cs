namespace Курсач
{
    partial class Debugger
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
            this.StackDataGrid = new System.Windows.Forms.DataGridView();
            this.StackData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parityFlagTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CSRegister = new System.Windows.Forms.TextBox();
            this.DSRegister = new System.Windows.Forms.TextBox();
            this.IPRegister = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StackDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // StackDataGrid
            // 
            this.StackDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StackDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StackData});
            this.StackDataGrid.Location = new System.Drawing.Point(12, 9);
            this.StackDataGrid.Name = "StackDataGrid";
            this.StackDataGrid.RowHeadersVisible = false;
            this.StackDataGrid.RowHeadersWidth = 50;
            this.StackDataGrid.RowTemplate.Height = 24;
            this.StackDataGrid.Size = new System.Drawing.Size(160, 105);
            this.StackDataGrid.TabIndex = 5;
            // 
            // StackData
            // 
            this.StackData.HeaderText = "Stack Data";
            this.StackData.Name = "StackData";
            this.StackData.ReadOnly = true;
            // 
            // parityFlagTextBox
            // 
            this.parityFlagTextBox.Location = new System.Drawing.Point(93, 120);
            this.parityFlagTextBox.Name = "parityFlagTextBox";
            this.parityFlagTextBox.Size = new System.Drawing.Size(79, 25);
            this.parityFlagTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Parity Flag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "CS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "DS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "IP";
            // 
            // CSRegister
            // 
            this.CSRegister.Location = new System.Drawing.Point(93, 151);
            this.CSRegister.Name = "CSRegister";
            this.CSRegister.Size = new System.Drawing.Size(79, 25);
            this.CSRegister.TabIndex = 11;
            // 
            // DSRegister
            // 
            this.DSRegister.Location = new System.Drawing.Point(93, 182);
            this.DSRegister.Name = "DSRegister";
            this.DSRegister.Size = new System.Drawing.Size(79, 25);
            this.DSRegister.TabIndex = 12;
            // 
            // IPRegister
            // 
            this.IPRegister.Location = new System.Drawing.Point(93, 213);
            this.IPRegister.Name = "IPRegister";
            this.IPRegister.Size = new System.Drawing.Size(79, 25);
            this.IPRegister.TabIndex = 13;
            // 
            // Debugger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 248);
            this.Controls.Add(this.IPRegister);
            this.Controls.Add(this.DSRegister);
            this.Controls.Add(this.CSRegister);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parityFlagTextBox);
            this.Controls.Add(this.StackDataGrid);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Debugger";
            this.Text = "Debugger";
            ((System.ComponentModel.ISupportInitialize)(this.StackDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StackDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn StackData;
        private System.Windows.Forms.TextBox parityFlagTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CSRegister;
        private System.Windows.Forms.TextBox DSRegister;
        private System.Windows.Forms.TextBox IPRegister;
    }
}