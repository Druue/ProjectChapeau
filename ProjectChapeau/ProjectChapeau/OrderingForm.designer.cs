﻿namespace ProjectChapeau
{
    partial class OrderingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderingForm));
            this.OrderingSystemPanel = new System.Windows.Forms.Panel();
            this.CancelOrderButton = new System.Windows.Forms.Button();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.PriceOverviewListView = new System.Windows.Forms.ListView();
            this.ItemNamePriceOverview = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dotsPriceOverview = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemPriceOverview = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MenuDisplayPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MenuTypeComboBox = new System.Windows.Forms.ComboBox();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.MenuListView = new System.Windows.Forms.ListView();
            this.OrdersCart = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommentButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ItemNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommentHidden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuListImageList = new System.Windows.Forms.ImageList(this.components);
            this.OrderingSystemPanel.SuspendLayout();
            this.MenuDisplayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersCart)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderingSystemPanel
            // 
            this.OrderingSystemPanel.Controls.Add(this.CancelOrderButton);
            this.OrderingSystemPanel.Controls.Add(this.AddOrderButton);
            this.OrderingSystemPanel.Controls.Add(this.PriceOverviewListView);
            this.OrderingSystemPanel.Controls.Add(this.MenuDisplayPanel);
            this.OrderingSystemPanel.Controls.Add(this.OrdersCart);
            resources.ApplyResources(this.OrderingSystemPanel, "OrderingSystemPanel");
            this.OrderingSystemPanel.Name = "OrderingSystemPanel";
            // 
            // CancelOrderButton
            // 
            resources.ApplyResources(this.CancelOrderButton, "CancelOrderButton");
            this.CancelOrderButton.Name = "CancelOrderButton";
            this.CancelOrderButton.UseVisualStyleBackColor = true;
            // 
            // AddOrderButton
            // 
            resources.ApplyResources(this.AddOrderButton, "AddOrderButton");
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // PriceOverviewListView
            // 
            this.PriceOverviewListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemNamePriceOverview,
            this.dotsPriceOverview,
            this.ItemPriceOverview});
            resources.ApplyResources(this.PriceOverviewListView, "PriceOverviewListView");
            this.PriceOverviewListView.MultiSelect = false;
            this.PriceOverviewListView.Name = "PriceOverviewListView";
            this.PriceOverviewListView.Scrollable = false;
            this.PriceOverviewListView.ShowGroups = false;
            this.PriceOverviewListView.UseCompatibleStateImageBehavior = false;
            this.PriceOverviewListView.View = System.Windows.Forms.View.Details;
            // 
            // ItemNamePriceOverview
            // 
            resources.ApplyResources(this.ItemNamePriceOverview, "ItemNamePriceOverview");
            // 
            // dotsPriceOverview
            // 
            resources.ApplyResources(this.dotsPriceOverview, "dotsPriceOverview");
            // 
            // ItemPriceOverview
            // 
            resources.ApplyResources(this.ItemPriceOverview, "ItemPriceOverview");
            // 
            // MenuDisplayPanel
            // 
            this.MenuDisplayPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MenuDisplayPanel.Controls.Add(this.textBox1);
            this.MenuDisplayPanel.Controls.Add(this.MenuTypeComboBox);
            this.MenuDisplayPanel.Controls.Add(this.AddToCartButton);
            this.MenuDisplayPanel.Controls.Add(this.MenuListView);
            resources.ApplyResources(this.MenuDisplayPanel, "MenuDisplayPanel");
            this.MenuDisplayPanel.Name = "MenuDisplayPanel";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // MenuTypeComboBox
            // 
            this.MenuTypeComboBox.FormattingEnabled = true;
            this.MenuTypeComboBox.Items.AddRange(new object[] {
            resources.GetString("MenuTypeComboBox.Items"),
            resources.GetString("MenuTypeComboBox.Items1"),
            resources.GetString("MenuTypeComboBox.Items2"),
            resources.GetString("MenuTypeComboBox.Items3")});
            resources.ApplyResources(this.MenuTypeComboBox, "MenuTypeComboBox");
            this.MenuTypeComboBox.Name = "MenuTypeComboBox";
            // 
            // AddToCartButton
            // 
            resources.ApplyResources(this.AddToCartButton, "AddToCartButton");
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // MenuListView
            // 
            this.MenuListView.LargeImageList = this.MenuListImageList;
            resources.ApplyResources(this.MenuListView, "MenuListView");
            this.MenuListView.MultiSelect = false;
            this.MenuListView.Name = "MenuListView";
            this.MenuListView.SmallImageList = this.MenuListImageList;
            this.MenuListView.UseCompatibleStateImageBehavior = false;
            // 
            // OrdersCart
            // 
            this.OrdersCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersCart.ColumnHeadersVisible = false;
            this.OrdersCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CommentButtonColumn,
            this.ItemNameColumn,
            this.DeleteButtonColumn,
            this.QuantityColumn,
            this.ItemID,
            this.PriceColumn,
            this.CommentHidden});
            resources.ApplyResources(this.OrdersCart, "OrdersCart");
            this.OrdersCart.Name = "OrdersCart";
            this.OrdersCart.RowHeadersVisible = false;
            this.OrdersCart.RowTemplate.Height = 24;
            // 
            // dataGridViewTextBoxColumn1
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // CommentButtonColumn
            // 
            resources.ApplyResources(this.CommentButtonColumn, "CommentButtonColumn");
            this.CommentButtonColumn.Name = "CommentButtonColumn";
            // 
            // ItemNameColumn
            // 
            resources.ApplyResources(this.ItemNameColumn, "ItemNameColumn");
            this.ItemNameColumn.Name = "ItemNameColumn";
            this.ItemNameColumn.ReadOnly = true;
            this.ItemNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DeleteButtonColumn
            // 
            resources.ApplyResources(this.DeleteButtonColumn, "DeleteButtonColumn");
            this.DeleteButtonColumn.Name = "DeleteButtonColumn";
            this.DeleteButtonColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteButtonColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // QuantityColumn
            // 
            resources.ApplyResources(this.QuantityColumn, "QuantityColumn");
            this.QuantityColumn.Name = "QuantityColumn";
            // 
            // ItemID
            // 
            resources.ApplyResources(this.ItemID, "ItemID");
            this.ItemID.Name = "ItemID";
            // 
            // PriceColumn
            // 
            resources.ApplyResources(this.PriceColumn, "PriceColumn");
            this.PriceColumn.Name = "PriceColumn";
            // 
            // CommentHidden
            // 
            resources.ApplyResources(this.CommentHidden, "CommentHidden");
            this.CommentHidden.Name = "CommentHidden";
            // 
            // MenuListImageList
            // 
            this.MenuListImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MenuListImageList.ImageStream")));
            this.MenuListImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.MenuListImageList.Images.SetKeyName(0, "1-salade-nicoise.jpg");
            this.MenuListImageList.Images.SetKeyName(1, "2-french-omelette.jpg");
            this.MenuListImageList.Images.SetKeyName(2, "3-Fennel.jpg");
            this.MenuListImageList.Images.SetKeyName(3, "4-quichie-of-the-day.jpg");
            this.MenuListImageList.Images.SetKeyName(4, "5-Croque-Monsieur-French-Toast.jpg");
            this.MenuListImageList.Images.SetKeyName(5, "6-croque-madame-toast.jpg");
            this.MenuListImageList.Images.SetKeyName(6, "7-homemade-soup-of-the-day.jpg");
            this.MenuListImageList.Images.SetKeyName(7, "8-homemade-onion-soup.jpg");
            this.MenuListImageList.Images.SetKeyName(8, "9-tortilla-chips.jpg");
            this.MenuListImageList.Images.SetKeyName(9, "10-crudites-with-olive-anchovy.jpg");
            this.MenuListImageList.Images.SetKeyName(10, "11-toast-belgian-prepare.jpg");
            this.MenuListImageList.Images.SetKeyName(11, "12-bread.jpg");
            this.MenuListImageList.Images.SetKeyName(12, "13-homemade-soup-of-the-day.jpg");
            this.MenuListImageList.Images.SetKeyName(13, "14-homemade-soup-of-the-day.jpg");
            this.MenuListImageList.Images.SetKeyName(14, "15-beef-carpaccio.jpg");
            this.MenuListImageList.Images.SetKeyName(15, "16-escargots.jpg");
            this.MenuListImageList.Images.SetKeyName(16, "17-goat-cheese.jpg");
            this.MenuListImageList.Images.SetKeyName(17, "18-tenderloin-from-black-angus.jpg");
            this.MenuListImageList.Images.SetKeyName(18, "19-butcher-steak.jpg");
            this.MenuListImageList.Images.SetKeyName(19, "20-lamb-chops.jpg");
            this.MenuListImageList.Images.SetKeyName(20, "21-rattatouille.jpg");
            this.MenuListImageList.Images.SetKeyName(21, "22-French-fish-stew.jpg");
            this.MenuListImageList.Images.SetKeyName(22, "23-whole-lobster.jpg");
            this.MenuListImageList.Images.SetKeyName(23, "24-creme-brulee.jpg");
            this.MenuListImageList.Images.SetKeyName(24, "25-chocolate-crumble.jpg");
            this.MenuListImageList.Images.SetKeyName(25, "26-dame-blanche.jpg");
            this.MenuListImageList.Images.SetKeyName(26, "27-cheese.jpg");
            this.MenuListImageList.Images.SetKeyName(27, "28-coca-cola.jpg");
            this.MenuListImageList.Images.SetKeyName(28, "29-sprite.jpg");
            this.MenuListImageList.Images.SetKeyName(29, "30-fanta-orange.jpg");
            this.MenuListImageList.Images.SetKeyName(30, "31-bitter-lemon.jpg");
            this.MenuListImageList.Images.SetKeyName(31, "32-tonic.jpg");
            this.MenuListImageList.Images.SetKeyName(32, "33-ginger-ale.jpg");
            this.MenuListImageList.Images.SetKeyName(33, "33-lipton-ice-tea.jpg");
            this.MenuListImageList.Images.SetKeyName(34, "34-coffee.jpg");
            this.MenuListImageList.Images.SetKeyName(35, "35-tea.jpg");
            this.MenuListImageList.Images.SetKeyName(36, "36-fresh-mint-tea.jpg");
            this.MenuListImageList.Images.SetKeyName(37, "37-espresso.jpg");
            this.MenuListImageList.Images.SetKeyName(38, "38-capuccino.jpg");
            this.MenuListImageList.Images.SetKeyName(39, "39-heineken-small.jpg");
            this.MenuListImageList.Images.SetKeyName(40, "40-heineken-medium.jpg");
            this.MenuListImageList.Images.SetKeyName(41, "41-palm.jpg");
            this.MenuListImageList.Images.SetKeyName(42, "42-beer.jpg");
            this.MenuListImageList.Images.SetKeyName(43, "43-corona.jpg");
            this.MenuListImageList.Images.SetKeyName(44, "44-sauvignon-blanc-bottle.jpg");
            this.MenuListImageList.Images.SetKeyName(45, "45-merlot-bottle.jpg");
            this.MenuListImageList.Images.SetKeyName(46, "45-sauvignon-blanc-glass.jpg");
            this.MenuListImageList.Images.SetKeyName(47, "46-merlot-glass.jpg");
            // 
            // OrderingForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OrderingSystemPanel);
            this.Name = "OrderingForm";
            this.OrderingSystemPanel.ResumeLayout(false);
            this.MenuDisplayPanel.ResumeLayout(false);
            this.MenuDisplayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel OrderingSystemPanel;
        private System.Windows.Forms.Button CancelOrderButton;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.ListView PriceOverviewListView;
        private System.Windows.Forms.Panel MenuDisplayPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox MenuTypeComboBox;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.ListView MenuListView;
        private System.Windows.Forms.DataGridView OrdersCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ColumnHeader ItemNamePriceOverview;
        private System.Windows.Forms.ColumnHeader dotsPriceOverview;
        private System.Windows.Forms.ColumnHeader ItemPriceOverview;
        private System.Windows.Forms.DataGridViewButtonColumn CommentButtonColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNameColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButtonColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentHidden;
        public System.Windows.Forms.ImageList MenuListImageList;
    }
}

