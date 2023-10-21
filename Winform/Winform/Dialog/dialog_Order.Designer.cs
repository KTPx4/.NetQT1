namespace Winform.Dialog
{
    partial class dialog_Order
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtOD = new System.Windows.Forms.TextBox();
            this.dateO = new DevExpress.XtraEditors.DateEdit();
            this.cbbCustName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbCustID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.pnContent = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.txtSumPrice = new System.Windows.Forms.TextBox();
            this.txtSumItem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateO.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.checkBox1);
            this.groupControl1.Controls.Add(this.txtOD);
            this.groupControl1.Controls.Add(this.dateO);
            this.groupControl1.Controls.Add(this.cbbCustName);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.cbbCustID);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(21, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(306, 194);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Infor";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(221, 36);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Auto ID";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtOD
            // 
            this.txtOD.Location = new System.Drawing.Point(94, 33);
            this.txtOD.Name = "txtOD";
            this.txtOD.Size = new System.Drawing.Size(121, 20);
            this.txtOD.TabIndex = 3;
            // 
            // dateO
            // 
            this.dateO.EditValue = null;
            this.dateO.Location = new System.Drawing.Point(93, 139);
            this.dateO.Name = "dateO";
            this.dateO.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateO.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateO.Size = new System.Drawing.Size(190, 20);
            this.dateO.TabIndex = 2;
            // 
            // cbbCustName
            // 
            this.cbbCustName.Enabled = false;
            this.cbbCustName.FormattingEnabled = true;
            this.cbbCustName.Location = new System.Drawing.Point(93, 102);
            this.cbbCustName.Name = "cbbCustName";
            this.cbbCustName.Size = new System.Drawing.Size(190, 21);
            this.cbbCustName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name Customer";
            // 
            // cbbCustID
            // 
            this.cbbCustID.FormattingEnabled = true;
            this.cbbCustID.Location = new System.Drawing.Point(93, 68);
            this.cbbCustID.Name = "cbbCustID";
            this.cbbCustID.Size = new System.Drawing.Size(190, 21);
            this.cbbCustID.TabIndex = 1;
            this.cbbCustID.SelectedIndexChanged += new System.EventHandler(this.cbbCustID_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID Order";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Customer";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.pnContent);
            this.groupControl2.Location = new System.Drawing.Point(333, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(338, 582);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "List Items";
            // 
            // pnContent
            // 
            this.pnContent.AutoScroll = true;
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.Location = new System.Drawing.Point(2, 23);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(334, 557);
            this.pnContent.TabIndex = 0;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(22, 359);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(71, 45);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(115, 359);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 45);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.txtSumPrice);
            this.groupControl3.Controls.Add(this.txtSumItem);
            this.groupControl3.Controls.Add(this.label6);
            this.groupControl3.Controls.Add(this.label5);
            this.groupControl3.Enabled = false;
            this.groupControl3.Location = new System.Drawing.Point(23, 225);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(304, 106);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "Total";
            // 
            // txtSumPrice
            // 
            this.txtSumPrice.Location = new System.Drawing.Point(91, 73);
            this.txtSumPrice.Name = "txtSumPrice";
            this.txtSumPrice.Size = new System.Drawing.Size(122, 20);
            this.txtSumPrice.TabIndex = 1;
            // 
            // txtSumItem
            // 
            this.txtSumItem.Location = new System.Drawing.Point(91, 43);
            this.txtSumItem.Name = "txtSumItem";
            this.txtSumItem.Size = new System.Drawing.Size(122, 20);
            this.txtSumItem.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sum Item";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sum Price";
            // 
            // dialog_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 596);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dialog_Order";
            this.Text = "Order Item";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dialog_Order_FormClosing);
            this.Load += new System.EventHandler(this.dialog_Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateO.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.TextBox txtOD;
        private DevExpress.XtraEditors.DateEdit dateO;
        private System.Windows.Forms.ComboBox cbbCustName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbCustID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.FlowLayoutPanel pnContent;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.TextBox txtSumPrice;
        private System.Windows.Forms.TextBox txtSumItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}