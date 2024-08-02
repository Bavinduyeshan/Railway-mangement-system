namespace Railway_management_system
{
    partial class Train_master
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTrainName = new System.Windows.Forms.TextBox();
            this.txtTrainCapacity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GRbtBusy = new Guna.UI2.WinForms.Guna2RadioButton();
            this.GRbtAvai = new Guna.UI2.WinForms.Guna2RadioButton();
            this.GDTrainlist = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.GBtnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.GBtnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.GBtnDel = new Guna.UI2.WinForms.Guna2Button();
            this.GBtnClear = new Guna.UI2.WinForms.Guna2Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GDTrainlist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(406, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Train Master";
            // 
            // txtTrainName
            // 
            this.txtTrainName.Location = new System.Drawing.Point(30, 229);
            this.txtTrainName.Multiline = true;
            this.txtTrainName.Name = "txtTrainName";
            this.txtTrainName.Size = new System.Drawing.Size(211, 40);
            this.txtTrainName.TabIndex = 3;
            this.txtTrainName.Leave += new System.EventHandler(this.txtTrainName_Leave);
            // 
            // txtTrainCapacity
            // 
            this.txtTrainCapacity.Location = new System.Drawing.Point(324, 229);
            this.txtTrainCapacity.Multiline = true;
            this.txtTrainCapacity.Name = "txtTrainCapacity";
            this.txtTrainCapacity.Size = new System.Drawing.Size(202, 40);
            this.txtTrainCapacity.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(50, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "TrainName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(339, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "TrainCapacity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(637, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "TrainStatus";
            // 
            // GRbtBusy
            // 
            this.GRbtBusy.AutoSize = true;
            this.GRbtBusy.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GRbtBusy.CheckedState.BorderThickness = 0;
            this.GRbtBusy.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GRbtBusy.CheckedState.InnerColor = System.Drawing.Color.White;
            this.GRbtBusy.CheckedState.InnerOffset = -4;
            this.GRbtBusy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRbtBusy.ForeColor = System.Drawing.Color.Green;
            this.GRbtBusy.Location = new System.Drawing.Point(567, 229);
            this.GRbtBusy.Name = "GRbtBusy";
            this.GRbtBusy.Size = new System.Drawing.Size(81, 29);
            this.GRbtBusy.TabIndex = 8;
            this.GRbtBusy.Text = "Busy";
            this.GRbtBusy.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.GRbtBusy.UncheckedState.BorderThickness = 2;
            this.GRbtBusy.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.GRbtBusy.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // GRbtAvai
            // 
            this.GRbtAvai.AutoSize = true;
            this.GRbtAvai.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GRbtAvai.CheckedState.BorderThickness = 0;
            this.GRbtAvai.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GRbtAvai.CheckedState.InnerColor = System.Drawing.Color.White;
            this.GRbtAvai.CheckedState.InnerOffset = -4;
            this.GRbtAvai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRbtAvai.ForeColor = System.Drawing.Color.Green;
            this.GRbtAvai.Location = new System.Drawing.Point(734, 229);
            this.GRbtAvai.Name = "GRbtAvai";
            this.GRbtAvai.Size = new System.Drawing.Size(122, 29);
            this.GRbtAvai.TabIndex = 9;
            this.GRbtAvai.Text = "Available";
            this.GRbtAvai.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.GRbtAvai.UncheckedState.BorderThickness = 2;
            this.GRbtAvai.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.GRbtAvai.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // GDTrainlist
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.GDTrainlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GDTrainlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GDTrainlist.ColumnHeadersHeight = 4;
            this.GDTrainlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GDTrainlist.DefaultCellStyle = dataGridViewCellStyle3;
            this.GDTrainlist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GDTrainlist.Location = new System.Drawing.Point(42, 421);
            this.GDTrainlist.Name = "GDTrainlist";
            this.GDTrainlist.RowHeadersVisible = false;
            this.GDTrainlist.RowHeadersWidth = 51;
            this.GDTrainlist.RowTemplate.Height = 24;
            this.GDTrainlist.Size = new System.Drawing.Size(924, 171);
            this.GDTrainlist.TabIndex = 10;
            this.GDTrainlist.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GDTrainlist.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GDTrainlist.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GDTrainlist.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GDTrainlist.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GDTrainlist.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GDTrainlist.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GDTrainlist.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GDTrainlist.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GDTrainlist.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GDTrainlist.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GDTrainlist.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GDTrainlist.ThemeStyle.HeaderStyle.Height = 4;
            this.GDTrainlist.ThemeStyle.ReadOnly = false;
            this.GDTrainlist.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GDTrainlist.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GDTrainlist.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GDTrainlist.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GDTrainlist.ThemeStyle.RowsStyle.Height = 24;
            this.GDTrainlist.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GDTrainlist.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(463, 367);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Train List";
            // 
            // GBtnAdd
            // 
            this.GBtnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GBtnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GBtnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GBtnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GBtnAdd.FillColor = System.Drawing.Color.Green;
            this.GBtnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GBtnAdd.ForeColor = System.Drawing.Color.White;
            this.GBtnAdd.Location = new System.Drawing.Point(122, 301);
            this.GBtnAdd.Name = "GBtnAdd";
            this.GBtnAdd.Size = new System.Drawing.Size(124, 45);
            this.GBtnAdd.TabIndex = 12;
            this.GBtnAdd.Text = "Add";
            this.GBtnAdd.Click += new System.EventHandler(this.GBtnAdd_Click);
            // 
            // GBtnUpdate
            // 
            this.GBtnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GBtnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GBtnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GBtnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GBtnUpdate.FillColor = System.Drawing.Color.Green;
            this.GBtnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GBtnUpdate.ForeColor = System.Drawing.Color.White;
            this.GBtnUpdate.Location = new System.Drawing.Point(324, 301);
            this.GBtnUpdate.Name = "GBtnUpdate";
            this.GBtnUpdate.Size = new System.Drawing.Size(135, 45);
            this.GBtnUpdate.TabIndex = 13;
            this.GBtnUpdate.Text = "Update";
            this.GBtnUpdate.Click += new System.EventHandler(this.GBtnUpdate_Click);
            // 
            // GBtnDel
            // 
            this.GBtnDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GBtnDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GBtnDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GBtnDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GBtnDel.FillColor = System.Drawing.Color.Green;
            this.GBtnDel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GBtnDel.ForeColor = System.Drawing.Color.White;
            this.GBtnDel.Location = new System.Drawing.Point(548, 301);
            this.GBtnDel.Name = "GBtnDel";
            this.GBtnDel.Size = new System.Drawing.Size(122, 45);
            this.GBtnDel.TabIndex = 14;
            this.GBtnDel.Text = "Delete";
            this.GBtnDel.Click += new System.EventHandler(this.GBtnDel_Click);
            // 
            // GBtnClear
            // 
            this.GBtnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GBtnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GBtnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GBtnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GBtnClear.FillColor = System.Drawing.Color.Green;
            this.GBtnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GBtnClear.ForeColor = System.Drawing.Color.White;
            this.GBtnClear.Location = new System.Drawing.Point(756, 301);
            this.GBtnClear.Name = "GBtnClear";
            this.GBtnClear.Size = new System.Drawing.Size(125, 45);
            this.GBtnClear.TabIndex = 15;
            this.GBtnClear.Text = "Clear";
            this.GBtnClear.Click += new System.EventHandler(this.GBtnClear_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(806, 367);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(41, 16);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Train_master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 616);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.GBtnClear);
            this.Controls.Add(this.GBtnDel);
            this.Controls.Add(this.GBtnUpdate);
            this.Controls.Add(this.GBtnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GDTrainlist);
            this.Controls.Add(this.GRbtAvai);
            this.Controls.Add(this.GRbtBusy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTrainCapacity);
            this.Controls.Add(this.txtTrainName);
            this.Controls.Add(this.label1);
            this.Name = "Train_master";
            this.Text = "Train_master";
            this.Load += new System.EventHandler(this.Train_master_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GDTrainlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTrainName;
        private System.Windows.Forms.TextBox txtTrainCapacity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2RadioButton GRbtBusy;
        private Guna.UI2.WinForms.Guna2RadioButton GRbtAvai;
        private Guna.UI2.WinForms.Guna2DataGridView GDTrainlist;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button GBtnAdd;
        private Guna.UI2.WinForms.Guna2Button GBtnUpdate;
        private Guna.UI2.WinForms.Guna2Button GBtnDel;
        private Guna.UI2.WinForms.Guna2Button GBtnClear;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}