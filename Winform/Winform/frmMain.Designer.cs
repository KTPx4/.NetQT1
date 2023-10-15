namespace Winform
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colItemID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDetails = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.itemBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(123, 68);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(566, 411);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemID,
            this.colItemName,
            this.colSize,
            this.colPrice,
            this.colOrderDetails});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(Winform.Item);
            // 
            // colItemID
            // 
            this.colItemID.FieldName = "ItemID";
            this.colItemID.Name = "colItemID";
            this.colItemID.Visible = true;
            this.colItemID.VisibleIndex = 0;
            // 
            // colItemName
            // 
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 1;
            // 
            // colSize
            // 
            this.colSize.FieldName = "Size";
            this.colSize.Name = "colSize";
            this.colSize.Visible = true;
            this.colSize.VisibleIndex = 2;
            // 
            // colPrice
            // 
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 3;
            // 
            // colOrderDetails
            // 
            this.colOrderDetails.FieldName = "OrderDetails";
            this.colOrderDetails.Name = "colOrderDetails";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 602);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colItemID;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colSize;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDetails;
    }
}

