namespace Railway_management_system
{
    partial class Cancellation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CancellationMGD = new Guna.UI2.WinForms.Guna2DataGridView();
            this.GBtnDel = new Guna.UI2.WinForms.Guna2Button();
            this.GBtnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.GCBTicketid = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CancellationMGD)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.CancellationMGD);
            this.guna2Panel1.Controls.Add(this.GBtnDel);
            this.guna2Panel1.Controls.Add(this.GBtnAdd);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.GCBTicketid);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Location = new System.Drawing.Point(5, 38);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(964, 545);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(346, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 49;
            this.label1.Text = "Cancelled TIckets";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CancellationMGD
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.CancellationMGD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CancellationMGD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.CancellationMGD.ColumnHeadersHeight = 4;
            this.CancellationMGD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CancellationMGD.DefaultCellStyle = dataGridViewCellStyle6;
            this.CancellationMGD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CancellationMGD.Location = new System.Drawing.Point(24, 361);
            this.CancellationMGD.Name = "CancellationMGD";
            this.CancellationMGD.RowHeadersVisible = false;
            this.CancellationMGD.RowHeadersWidth = 51;
            this.CancellationMGD.RowTemplate.Height = 24;
            this.CancellationMGD.Size = new System.Drawing.Size(886, 181);
            this.CancellationMGD.TabIndex = 48;
            this.CancellationMGD.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CancellationMGD.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CancellationMGD.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CancellationMGD.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CancellationMGD.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CancellationMGD.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CancellationMGD.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CancellationMGD.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CancellationMGD.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CancellationMGD.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancellationMGD.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CancellationMGD.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CancellationMGD.ThemeStyle.HeaderStyle.Height = 4;
            this.CancellationMGD.ThemeStyle.ReadOnly = false;
            this.CancellationMGD.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CancellationMGD.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CancellationMGD.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancellationMGD.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CancellationMGD.ThemeStyle.RowsStyle.Height = 24;
            this.CancellationMGD.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CancellationMGD.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // GBtnDel
            // 
            this.GBtnDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GBtnDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GBtnDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GBtnDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GBtnDel.FillColor = System.Drawing.Color.Green;
            this.GBtnDel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBtnDel.ForeColor = System.Drawing.Color.White;
            this.GBtnDel.Location = new System.Drawing.Point(553, 242);
            this.GBtnDel.Name = "GBtnDel";
            this.GBtnDel.Size = new System.Drawing.Size(122, 45);
            this.GBtnDel.TabIndex = 47;
            this.GBtnDel.Text = "Clear";
            // 
            // GBtnAdd
            // 
            this.GBtnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GBtnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GBtnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GBtnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GBtnAdd.FillColor = System.Drawing.Color.Green;
            this.GBtnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBtnAdd.ForeColor = System.Drawing.Color.White;
            this.GBtnAdd.Location = new System.Drawing.Point(242, 242);
            this.GBtnAdd.Name = "GBtnAdd";
            this.GBtnAdd.Size = new System.Drawing.Size(124, 45);
            this.GBtnAdd.TabIndex = 46;
            this.GBtnAdd.Text = "Cancel";
            this.GBtnAdd.Click += new System.EventHandler(this.GBtnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(307, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 32);
            this.label5.TabIndex = 45;
            this.label5.Text = "Cancellation Master";
            // 
            // GCBTicketid
            // 
            this.GCBTicketid.BackColor = System.Drawing.Color.Transparent;
            this.GCBTicketid.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GCBTicketid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GCBTicketid.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GCBTicketid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GCBTicketid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.GCBTicketid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.GCBTicketid.ItemHeight = 30;
            this.GCBTicketid.Items.AddRange(new object[] {
            "S001",
            "S002",
            "S003",
            "S004"});
            this.GCBTicketid.Location = new System.Drawing.Point(362, 176);
            this.GCBTicketid.Name = "GCBTicketid";
            this.GCBTicketid.Size = new System.Drawing.Size(168, 36);
            this.GCBTicketid.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(385, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 29);
            this.label2.TabIndex = 43;
            this.label2.Text = "Ticket ID";
            // 
            // Cancellation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(975, 632);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Cancellation";
            this.Text = "Cancellation";
            this.Load += new System.EventHandler(this.Cancellation_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CancellationMGD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox GCBTicketid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button GBtnDel;
        private Guna.UI2.WinForms.Guna2Button GBtnAdd;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView CancellationMGD;
    }
}