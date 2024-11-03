namespace CommercialAutomationProject
{
    partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.products = new DevExpress.XtraBars.BarButtonItem();
			this.stocks = new DevExpress.XtraBars.BarButtonItem();
			this.customers = new DevExpress.XtraBars.BarButtonItem();
			this.companies = new DevExpress.XtraBars.BarButtonItem();
			this.home = new DevExpress.XtraBars.BarButtonItem();
			this.employees = new DevExpress.XtraBars.BarButtonItem();
			this.expenses = new DevExpress.XtraBars.BarButtonItem();
			this.till = new DevExpress.XtraBars.BarButtonItem();
			this.notes = new DevExpress.XtraBars.BarButtonItem();
			this.banks = new DevExpress.XtraBars.BarButtonItem();
			this.directory = new DevExpress.XtraBars.BarButtonItem();
			this.invoices = new DevExpress.XtraBars.BarButtonItem();
			this.settings = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonControl1
			// 
			this.ribbonControl1.ExpandCollapseItem.Id = 0;
			this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.products,
            this.stocks,
            this.customers,
            this.companies,
            this.home,
            this.employees,
            this.expenses,
            this.till,
            this.notes,
            this.banks,
            this.directory,
            this.invoices,
            this.settings});
			this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl1.MaxItemId = 14;
			this.ribbonControl1.Name = "ribbonControl1";
			this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
			this.ribbonControl1.Size = new System.Drawing.Size(1015, 150);
			// 
			// products
			// 
			this.products.Caption = "ÜRÜNLER";
			this.products.Id = 1;
			this.products.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("products.ImageOptions.LargeImage")));
			this.products.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.products.ItemAppearance.Normal.Options.UseFont = true;
			this.products.Name = "products";
			this.products.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.products_ItemClick);
			// 
			// stocks
			// 
			this.stocks.Caption = "STOKLAR";
			this.stocks.Id = 2;
			this.stocks.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("stocks.ImageOptions.LargeImage")));
			this.stocks.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.stocks.ItemAppearance.Normal.Options.UseFont = true;
			this.stocks.Name = "stocks";
			// 
			// customers
			// 
			this.customers.Caption = "MÜŞTERİLER";
			this.customers.Id = 3;
			this.customers.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("customers.ImageOptions.LargeImage")));
			this.customers.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.customers.ItemAppearance.Normal.Options.UseFont = true;
			this.customers.Name = "customers";
			// 
			// companies
			// 
			this.companies.Caption = "FİRMALAR";
			this.companies.Id = 4;
			this.companies.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("companies.ImageOptions.LargeImage")));
			this.companies.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.companies.ItemAppearance.Normal.Options.UseFont = true;
			this.companies.Name = "companies";
			// 
			// home
			// 
			this.home.Caption = "ANASAYFA";
			this.home.Id = 5;
			this.home.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("home.ImageOptions.LargeImage")));
			this.home.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.home.ItemAppearance.Normal.Options.UseFont = true;
			this.home.Name = "home";
			// 
			// employees
			// 
			this.employees.Caption = "PERSONELLER";
			this.employees.Id = 6;
			this.employees.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("employees.ImageOptions.LargeImage")));
			this.employees.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.employees.ItemAppearance.Normal.Options.UseFont = true;
			this.employees.Name = "employees";
			// 
			// expenses
			// 
			this.expenses.Caption = "GİDERLER";
			this.expenses.Id = 7;
			this.expenses.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("expenses.ImageOptions.LargeImage")));
			this.expenses.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.expenses.ItemAppearance.Normal.Options.UseFont = true;
			this.expenses.Name = "expenses";
			// 
			// till
			// 
			this.till.Caption = "KASA";
			this.till.Id = 8;
			this.till.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("till.ImageOptions.LargeImage")));
			this.till.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.till.ItemAppearance.Normal.Options.UseFont = true;
			this.till.Name = "till";
			// 
			// notes
			// 
			this.notes.Caption = "NOTLAR";
			this.notes.Id = 9;
			this.notes.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("notes.ImageOptions.LargeImage")));
			this.notes.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.notes.ItemAppearance.Normal.Options.UseFont = true;
			this.notes.Name = "notes";
			// 
			// banks
			// 
			this.banks.Caption = "BANKALAR";
			this.banks.Id = 10;
			this.banks.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("banks.ImageOptions.LargeImage")));
			this.banks.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.banks.ItemAppearance.Normal.Options.UseFont = true;
			this.banks.Name = "banks";
			// 
			// directory
			// 
			this.directory.Caption = "REHBER";
			this.directory.Id = 11;
			this.directory.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("directory.ImageOptions.LargeImage")));
			this.directory.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.directory.ItemAppearance.Normal.Options.UseFont = true;
			this.directory.Name = "directory";
			// 
			// invoices
			// 
			this.invoices.Caption = "FATURALAR";
			this.invoices.Id = 12;
			this.invoices.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("invoices.ImageOptions.LargeImage")));
			this.invoices.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.invoices.ItemAppearance.Normal.Options.UseFont = true;
			this.invoices.Name = "invoices";
			// 
			// settings
			// 
			this.settings.Caption = "AYARLAR";
			this.settings.Id = 13;
			this.settings.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("settings.ImageOptions.LargeImage")));
			this.settings.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.settings.ItemAppearance.Normal.Options.UseFont = true;
			this.settings.Name = "settings";
			// 
			// ribbonPage1
			// 
			this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
			this.ribbonPage1.Name = "ribbonPage1";
			this.ribbonPage1.Text = "TİCARİ OTOMASYON";
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.ItemLinks.Add(this.home);
			this.ribbonPageGroup1.ItemLinks.Add(this.products);
			this.ribbonPageGroup1.ItemLinks.Add(this.stocks);
			this.ribbonPageGroup1.ItemLinks.Add(this.customers);
			this.ribbonPageGroup1.ItemLinks.Add(this.companies);
			this.ribbonPageGroup1.ItemLinks.Add(this.employees);
			this.ribbonPageGroup1.ItemLinks.Add(this.expenses);
			this.ribbonPageGroup1.ItemLinks.Add(this.till);
			this.ribbonPageGroup1.ItemLinks.Add(this.notes);
			this.ribbonPageGroup1.ItemLinks.Add(this.banks);
			this.ribbonPageGroup1.ItemLinks.Add(this.directory);
			this.ribbonPageGroup1.ItemLinks.Add(this.invoices);
			this.ribbonPageGroup1.ItemLinks.Add(this.settings);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			// 
			// xtraTabbedMdiManager1
			// 
			this.xtraTabbedMdiManager1.MdiParent = this;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1015, 704);
			this.Controls.Add(this.ribbonControl1);
			this.IsMdiContainer = true;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ticari Otomasyon";
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
		private DevExpress.XtraBars.BarButtonItem products;
		private DevExpress.XtraBars.BarButtonItem stocks;
		private DevExpress.XtraBars.BarButtonItem customers;
		private DevExpress.XtraBars.BarButtonItem companies;
		private DevExpress.XtraBars.BarButtonItem home;
		private DevExpress.XtraBars.BarButtonItem employees;
		private DevExpress.XtraBars.BarButtonItem expenses;
		private DevExpress.XtraBars.BarButtonItem till;
		private DevExpress.XtraBars.BarButtonItem notes;
		private DevExpress.XtraBars.BarButtonItem banks;
		private DevExpress.XtraBars.BarButtonItem directory;
		private DevExpress.XtraBars.BarButtonItem invoices;
		private DevExpress.XtraBars.BarButtonItem settings;
		private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
	}
}

