namespace Winform.Dialog
{
    partial class box_Items_Order
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbCount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbName = new System.Windows.Forms.ComboBox();
            this.cbbIID = new System.Windows.Forms.ComboBox();
            this.ptbDel = new System.Windows.Forms.PictureBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.txtQuan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDel)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(120, 16);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(36, 13);
            this.lbCount.TabIndex = 0;
            this.lbCount.Text = "Item 1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.cbbName);
            this.groupBox1.Controls.Add(this.cbbIID);
            this.groupBox1.Controls.Add(this.ptbDel);
            this.groupBox1.Controls.Add(this.txtSum);
            this.groupBox1.Controls.Add(this.txtQuan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbCount);
            this.groupBox1.Location = new System.Drawing.Point(0, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 176);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cbbName
            // 
            this.cbbName.Enabled = false;
            this.cbbName.FormattingEnabled = true;
            this.cbbName.Location = new System.Drawing.Point(104, 72);
            this.cbbName.Name = "cbbName";
            this.cbbName.Size = new System.Drawing.Size(137, 21);
            this.cbbName.TabIndex = 4;
            // 
            // cbbIID
            // 
            this.cbbIID.FormattingEnabled = true;
            this.cbbIID.Location = new System.Drawing.Point(104, 40);
            this.cbbIID.Name = "cbbIID";
            this.cbbIID.Size = new System.Drawing.Size(137, 21);
            this.cbbIID.TabIndex = 4;
            this.cbbIID.SelectedIndexChanged += new System.EventHandler(this.cbbIID_SelectedIndexChanged);
            // 
            // ptbDel
            // 
            this.ptbDel.Image = global::Winform.Properties.Resources.icons8_close_ios_16_filled_32;
            this.ptbDel.Location = new System.Drawing.Point(6, 16);
            this.ptbDel.Name = "ptbDel";
            this.ptbDel.Size = new System.Drawing.Size(23, 26);
            this.ptbDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbDel.TabIndex = 3;
            this.ptbDel.TabStop = false;
            this.ptbDel.Click += new System.EventHandler(this.ptbDel_Click);
            this.ptbDel.MouseLeave += new System.EventHandler(this.ptbDel_MouseLeave);
            this.ptbDel.MouseHover += new System.EventHandler(this.ptbDel_MouseHover);
            // 
            // txtSum
            // 
            this.txtSum.Enabled = false;
            this.txtSum.Location = new System.Drawing.Point(104, 134);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(97, 20);
            this.txtSum.TabIndex = 1;
            // 
            // txtQuan
            // 
            this.txtQuan.Location = new System.Drawing.Point(104, 102);
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.Size = new System.Drawing.Size(97, 20);
            this.txtQuan.TabIndex = 1;
            this.txtQuan.TextChanged += new System.EventHandler(this.txtQuan_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Item";
            // 
            // box_Items_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBox1);
            this.Name = "box_Items_Order";
            this.Size = new System.Drawing.Size(298, 186);
            this.Load += new System.EventHandler(this.box_Items_Order_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.TextBox txtQuan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbDel;
        private System.Windows.Forms.ComboBox cbbName;
        private System.Windows.Forms.ComboBox cbbIID;
    }
}
