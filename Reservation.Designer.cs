namespace Railway_management_system
{
    partial class Reservation
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.GCBPassengerID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ReservationMGD = new Guna.UI2.WinForms.Guna2DataGridView();
            this.GCBTravelcode = new Guna.UI2.WinForms.Guna2ComboBox();
            this.GBtnClear = new Guna.UI2.WinForms.Guna2Button();
            this.GBtnDel = new Guna.UI2.WinForms.Guna2Button();
            this.GBtnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationMGD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.linkLabel1);
            this.guna2Panel1.Controls.Add(this.GCBPassengerID);
            this.guna2Panel1.Controls.Add(this.ReservationMGD);
            this.guna2Panel1.Controls.Add(this.GCBTravelcode);
            this.guna2Panel1.Controls.Add(this.GBtnClear);
            this.guna2Panel1.Controls.Add(this.GBtnDel);
            this.guna2Panel1.Controls.Add(this.GBtnAdd);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 26);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1008, 590);
            this.guna2Panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(887, 302);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(42, 16);
            this.linkLabel1.TabIndex = 43;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "BACK";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // GCBPassengerID
            // 
            this.GCBPassengerID.BackColor = System.Drawing.Color.Transparent;
            this.GCBPassengerID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GCBPassengerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GCBPassengerID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GCBPassengerID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GCBPassengerID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.GCBPassengerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.GCBPassengerID.ItemHeight = 30;
            this.GCBPassengerID.Items.AddRange(new object[] {
            "S001",
            "S002",
            "S003",
            "S004"});
            this.GCBPassengerID.Location = new System.Drawing.Point(207, 165);
            this.GCBPassengerID.Name = "GCBPassengerID";
            this.GCBPassengerID.Size = new System.Drawing.Size(168, 36);
            this.GCBPassengerID.TabIndex = 42;
            this.GCBPassengerID.SelectionChangeCommitted += new System.EventHandler(this.GCBPassengerID_SelectionChangeCommitted);
            // 
            // ReservationMGD
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ReservationMGD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReservationMGD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ReservationMGD.ColumnHeadersHeight = 4;
            this.ReservationMGD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReservationMGD.DefaultCellStyle = dataGridViewCellStyle3;
            this.ReservationMGD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReservationMGD.Location = new System.Drawing.Point(31, 343);
            this.ReservationMGD.Name = "ReservationMGD";
            this.ReservationMGD.RowHeadersVisible = false;
            this.ReservationMGD.RowHeadersWidth = 51;
            this.ReservationMGD.RowTemplate.Height = 24;
            this.ReservationMGD.Size = new System.Drawing.Size(952, 181);
            this.ReservationMGD.TabIndex = 41;
            this.ReservationMGD.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ReservationMGD.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ReservationMGD.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ReservationMGD.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ReservationMGD.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ReservationMGD.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ReservationMGD.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReservationMGD.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ReservationMGD.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ReservationMGD.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationMGD.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ReservationMGD.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ReservationMGD.ThemeStyle.HeaderStyle.Height = 4;
            this.ReservationMGD.ThemeStyle.ReadOnly = false;
            this.ReservationMGD.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ReservationMGD.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReservationMGD.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationMGD.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ReservationMGD.ThemeStyle.RowsStyle.Height = 24;
            this.ReservationMGD.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReservationMGD.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // GCBTravelcode
            // 
            this.GCBTravelcode.BackColor = System.Drawing.Color.Transparent;
            this.GCBTravelcode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GCBTravelcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GCBTravelcode.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GCBTravelcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GCBTravelcode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.GCBTravelcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.GCBTravelcode.ItemHeight = 30;
            this.GCBTravelcode.Location = new System.Drawing.Point(581, 165);
            this.GCBTravelcode.Name = "GCBTravelcode";
            this.GCBTravelcode.Size = new System.Drawing.Size(152, 36);
            this.GCBTravelcode.TabIndex = 40;
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
            this.GBtnClear.Location = new System.Drawing.Point(751, 244);
            this.GBtnClear.Name = "GBtnClear";
            this.GBtnClear.Size = new System.Drawing.Size(125, 45);
            this.GBtnClear.TabIndex = 38;
            this.GBtnClear.Text = "Clear";
            this.GBtnClear.Click += new System.EventHandler(this.GBtnClear_Click);
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
            this.GBtnDel.Location = new System.Drawing.Point(432, 244);
            this.GBtnDel.Name = "GBtnDel";
            this.GBtnDel.Size = new System.Drawing.Size(122, 45);
            this.GBtnDel.TabIndex = 37;
            this.GBtnDel.Text = "Delete";
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
            this.GBtnAdd.Location = new System.Drawing.Point(121, 244);
            this.GBtnAdd.Name = "GBtnAdd";
            this.GBtnAdd.Size = new System.Drawing.Size(124, 45);
            this.GBtnAdd.TabIndex = 35;
            this.GBtnAdd.Text = "Add";
            this.GBtnAdd.Click += new System.EventHandler(this.GBtnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(576, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "Travel Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(205, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "Passenger ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(367, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 32);
            this.label5.TabIndex = 30;
            this.label5.Text = "Reservation Master";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Railway_management_system.Properties.Resources.OIP63;
            this.pictureBox1.Location = new System.Drawing.Point(472, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 47);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1012, 625);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationMGD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox GCBTravelcode;
        private Guna.UI2.WinForms.Guna2Button GBtnClear;
        private Guna.UI2.WinForms.Guna2Button GBtnDel;
        private Guna.UI2.WinForms.Guna2Button GBtnAdd;
        private Guna.UI2.WinForms.Guna2DataGridView ReservationMGD;
        private Guna.UI2.WinForms.Guna2ComboBox GCBPassengerID;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}