﻿namespace Winform.Dialog
{
    partial class box_Item
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
            this.Item = new System.Windows.Forms.Panel();
            this.lbCountItem = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.Item.SuspendLayout();
            this.SuspendLayout();
            // 
            // Item
            // 
            this.Item.BackColor = System.Drawing.Color.Snow;
            this.Item.Controls.Add(this.btnClear);
            this.Item.Controls.Add(this.btnDel);
            this.Item.Controls.Add(this.label4);
            this.Item.Controls.Add(this.label2);
            this.Item.Controls.Add(this.label3);
            this.Item.Controls.Add(this.label1);
            this.Item.Controls.Add(this.txtPrice);
            this.Item.Controls.Add(this.txtSize);
            this.Item.Controls.Add(this.txtName);
            this.Item.Controls.Add(this.txtID);
            this.Item.Controls.Add(this.lbCountItem);
            this.Item.Location = new System.Drawing.Point(0, 0);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(321, 194);
            this.Item.TabIndex = 1;
            // 
            // lbCountItem
            // 
            this.lbCountItem.AutoSize = true;
            this.lbCountItem.BackColor = System.Drawing.Color.Transparent;
            this.lbCountItem.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbCountItem.Location = new System.Drawing.Point(2, 3);
            this.lbCountItem.Name = "lbCountItem";
            this.lbCountItem.Size = new System.Drawing.Size(36, 13);
            this.lbCountItem.TabIndex = 9;
            this.lbCountItem.Text = "Item 1";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.Azure;
            this.btnClear.Location = new System.Drawing.Point(192, 161);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(69, 28);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.Color.Azure;
            this.btnDel.Location = new System.Drawing.Point(100, 160);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(69, 28);
            this.btnDel.TabIndex = 30;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(90, 131);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 20);
            this.txtPrice.TabIndex = 21;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(90, 92);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(200, 20);
            this.txtSize.TabIndex = 22;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 23;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(90, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(200, 20);
            this.txtID.TabIndex = 24;
            // 
            // box_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Item);
            this.Name = "box_Item";
            this.Size = new System.Drawing.Size(322, 206);
            this.Load += new System.EventHandler(this.box_Item_Load);
            this.Item.ResumeLayout(false);
            this.Item.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Item;
        private System.Windows.Forms.Label lbCountItem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
    }
}
