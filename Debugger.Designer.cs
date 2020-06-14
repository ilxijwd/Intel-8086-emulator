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
            this.label4 = new System.Windows.Forms.Label();
            this.CSRegister = new System.Windows.Forms.TextBox();
            this.IPRegister = new System.Windows.Forms.TextBox();
            this.MemoryGridView = new System.Windows.Forms.DataGridView();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overflowFlagTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StackDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoryGridView)).BeginInit();
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
            this.StackDataGrid.Size = new System.Drawing.Size(112, 100);
            this.StackDataGrid.TabIndex = 5;
            // 
            // StackData
            // 
            this.StackData.HeaderText = "Stack Data";
            this.StackData.Name = "StackData";
            this.StackData.ReadOnly = true;
            this.StackData.Width = 109;
            // 
            // parityFlagTextBox
            // 
            this.parityFlagTextBox.Location = new System.Drawing.Point(45, 120);
            this.parityFlagTextBox.Name = "parityFlagTextBox";
            this.parityFlagTextBox.Size = new System.Drawing.Size(79, 25);
            this.parityFlagTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "PF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "CS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "IP";
            // 
            // CSRegister
            // 
            this.CSRegister.Location = new System.Drawing.Point(45, 182);
            this.CSRegister.Name = "CSRegister";
            this.CSRegister.Size = new System.Drawing.Size(79, 25);
            this.CSRegister.TabIndex = 11;
            // 
            // IPRegister
            // 
            this.IPRegister.Location = new System.Drawing.Point(45, 211);
            this.IPRegister.Name = "IPRegister";
            this.IPRegister.Size = new System.Drawing.Size(79, 25);
            this.IPRegister.TabIndex = 13;
            // 
            // MemoryGridView
            // 
            this.MemoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemoryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Address,
            this.Data});
            this.MemoryGridView.Location = new System.Drawing.Point(130, 9);
            this.MemoryGridView.Name = "MemoryGridView";
            this.MemoryGridView.RowHeadersVisible = false;
            this.MemoryGridView.RowHeadersWidth = 50;
            this.MemoryGridView.RowTemplate.Height = 24;
            this.MemoryGridView.Size = new System.Drawing.Size(200, 227);
            this.MemoryGridView.TabIndex = 14;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.Width = 80;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 117;
            // 
            // overflowFlagTextBox
            // 
            this.overflowFlagTextBox.Location = new System.Drawing.Point(45, 151);
            this.overflowFlagTextBox.Name = "overflowFlagTextBox";
            this.overflowFlagTextBox.Size = new System.Drawing.Size(79, 25);
            this.overflowFlagTextBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "OF";
            // 
            // Debugger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 247);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.overflowFlagTextBox);
            this.Controls.Add(this.MemoryGridView);
            this.Controls.Add(this.IPRegister);
            this.Controls.Add(this.CSRegister);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parityFlagTextBox);
            this.Controls.Add(this.StackDataGrid);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Debugger";
            this.Text = "Debugger";
            ((System.ComponentModel.ISupportInitialize)(this.StackDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StackDataGrid;
        private System.Windows.Forms.TextBox parityFlagTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CSRegister;
        private System.Windows.Forms.TextBox IPRegister;
        private System.Windows.Forms.DataGridView MemoryGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn StackData;
        private System.Windows.Forms.TextBox overflowFlagTextBox;
        private System.Windows.Forms.Label label3;
    }
}