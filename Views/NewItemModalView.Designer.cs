namespace inventory_management_system_kap.Views
{
    partial class NewItemModalView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewItemModalView));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSupplier = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUnitPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBuyingPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOemNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPartNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSupplier = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblQuantity = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblUnitPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblBuyingPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblBrand = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCategory = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDescription = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblOemNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPartNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAddItem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.imgBtnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblHeading = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbBrand = new Guna.UI2.WinForms.Guna2ComboBox();
            this.nudQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cmbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Panel5);
            this.guna2Panel1.Controls.Add(this.guna2Panel4);
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(15);
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(441, 634);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Controls.Add(this.cmbCategory);
            this.guna2Panel5.Controls.Add(this.nudQuantity);
            this.guna2Panel5.Controls.Add(this.cmbBrand);
            this.guna2Panel5.Controls.Add(this.txtSupplier);
            this.guna2Panel5.Controls.Add(this.txtUnitPrice);
            this.guna2Panel5.Controls.Add(this.txtBuyingPrice);
            this.guna2Panel5.Controls.Add(this.txtDescription);
            this.guna2Panel5.Controls.Add(this.txtOemNumber);
            this.guna2Panel5.Controls.Add(this.txtPartNumber);
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel5.Location = new System.Drawing.Point(172, 83);
            this.guna2Panel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.ShadowDecoration.Parent = this.guna2Panel5;
            this.guna2Panel5.Size = new System.Drawing.Size(254, 484);
            this.guna2Panel5.TabIndex = 3;
            // 
            // txtSupplier
            // 
            this.txtSupplier.BackColor = System.Drawing.Color.Transparent;
            this.txtSupplier.BorderColor = System.Drawing.Color.Transparent;
            this.txtSupplier.BorderRadius = 6;
            this.txtSupplier.BorderThickness = 0;
            this.txtSupplier.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupplier.DefaultText = "Enter supplier";
            this.txtSupplier.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSupplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSupplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupplier.DisabledState.Parent = this.txtSupplier;
            this.txtSupplier.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupplier.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.txtSupplier.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSupplier.FocusedState.Parent = this.txtSupplier;
            this.txtSupplier.Font = new System.Drawing.Font("Inter Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(179)))), ((int)(((byte)(184)))));
            this.txtSupplier.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSupplier.HoverState.Parent = this.txtSupplier;
            this.txtSupplier.Location = new System.Drawing.Point(8, 438);
            this.txtSupplier.Margin = new System.Windows.Forms.Padding(4, 3, 4, 15);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.PasswordChar = '\0';
            this.txtSupplier.PlaceholderText = "";
            this.txtSupplier.SelectedText = "";
            this.txtSupplier.ShadowDecoration.Parent = this.txtSupplier;
            this.txtSupplier.Size = new System.Drawing.Size(229, 36);
            this.txtSupplier.TabIndex = 6;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtUnitPrice.BorderColor = System.Drawing.Color.Transparent;
            this.txtUnitPrice.BorderRadius = 6;
            this.txtUnitPrice.BorderThickness = 0;
            this.txtUnitPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUnitPrice.DefaultText = "Enter unit price";
            this.txtUnitPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUnitPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUnitPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUnitPrice.DisabledState.Parent = this.txtUnitPrice;
            this.txtUnitPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUnitPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.txtUnitPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUnitPrice.FocusedState.Parent = this.txtUnitPrice;
            this.txtUnitPrice.Font = new System.Drawing.Font("Inter Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(179)))), ((int)(((byte)(184)))));
            this.txtUnitPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUnitPrice.HoverState.Parent = this.txtUnitPrice;
            this.txtUnitPrice.Location = new System.Drawing.Point(8, 330);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 15);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.PasswordChar = '\0';
            this.txtUnitPrice.PlaceholderText = "";
            this.txtUnitPrice.SelectedText = "";
            this.txtUnitPrice.ShadowDecoration.Parent = this.txtUnitPrice;
            this.txtUnitPrice.Size = new System.Drawing.Size(229, 36);
            this.txtUnitPrice.TabIndex = 5;
            // 
            // txtBuyingPrice
            // 
            this.txtBuyingPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtBuyingPrice.BorderColor = System.Drawing.Color.Transparent;
            this.txtBuyingPrice.BorderRadius = 6;
            this.txtBuyingPrice.BorderThickness = 0;
            this.txtBuyingPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuyingPrice.DefaultText = "Enter buying price";
            this.txtBuyingPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuyingPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuyingPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuyingPrice.DisabledState.Parent = this.txtBuyingPrice;
            this.txtBuyingPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuyingPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.txtBuyingPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuyingPrice.FocusedState.Parent = this.txtBuyingPrice;
            this.txtBuyingPrice.Font = new System.Drawing.Font("Inter Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuyingPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(179)))), ((int)(((byte)(184)))));
            this.txtBuyingPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuyingPrice.HoverState.Parent = this.txtBuyingPrice;
            this.txtBuyingPrice.Location = new System.Drawing.Point(8, 276);
            this.txtBuyingPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 15);
            this.txtBuyingPrice.Name = "txtBuyingPrice";
            this.txtBuyingPrice.PasswordChar = '\0';
            this.txtBuyingPrice.PlaceholderText = "";
            this.txtBuyingPrice.SelectedText = "";
            this.txtBuyingPrice.ShadowDecoration.Parent = this.txtBuyingPrice;
            this.txtBuyingPrice.Size = new System.Drawing.Size(229, 36);
            this.txtBuyingPrice.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.Transparent;
            this.txtDescription.BorderColor = System.Drawing.Color.Transparent;
            this.txtDescription.BorderRadius = 6;
            this.txtDescription.BorderThickness = 0;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "Enter description";
            this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.DisabledState.Parent = this.txtDescription;
            this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.FocusedState.Parent = this.txtDescription;
            this.txtDescription.Font = new System.Drawing.Font("Inter Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(179)))), ((int)(((byte)(184)))));
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.HoverState.Parent = this.txtDescription;
            this.txtDescription.Location = new System.Drawing.Point(8, 114);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 15);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.SelectedText = "";
            this.txtDescription.ShadowDecoration.Parent = this.txtDescription;
            this.txtDescription.Size = new System.Drawing.Size(229, 36);
            this.txtDescription.TabIndex = 2;
            // 
            // txtOemNumber
            // 
            this.txtOemNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtOemNumber.BorderColor = System.Drawing.Color.Transparent;
            this.txtOemNumber.BorderRadius = 6;
            this.txtOemNumber.BorderThickness = 0;
            this.txtOemNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOemNumber.DefaultText = "Enter OEM number";
            this.txtOemNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOemNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOemNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOemNumber.DisabledState.Parent = this.txtOemNumber;
            this.txtOemNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOemNumber.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.txtOemNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOemNumber.FocusedState.Parent = this.txtOemNumber;
            this.txtOemNumber.Font = new System.Drawing.Font("Inter Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOemNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(179)))), ((int)(((byte)(184)))));
            this.txtOemNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOemNumber.HoverState.Parent = this.txtOemNumber;
            this.txtOemNumber.Location = new System.Drawing.Point(8, 60);
            this.txtOemNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 15);
            this.txtOemNumber.Name = "txtOemNumber";
            this.txtOemNumber.PasswordChar = '\0';
            this.txtOemNumber.PlaceholderText = "";
            this.txtOemNumber.SelectedText = "";
            this.txtOemNumber.ShadowDecoration.Parent = this.txtOemNumber;
            this.txtOemNumber.Size = new System.Drawing.Size(229, 36);
            this.txtOemNumber.TabIndex = 1;
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtPartNumber.BorderColor = System.Drawing.Color.Transparent;
            this.txtPartNumber.BorderRadius = 6;
            this.txtPartNumber.BorderThickness = 0;
            this.txtPartNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPartNumber.DefaultText = "Enter part number";
            this.txtPartNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPartNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPartNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPartNumber.DisabledState.Parent = this.txtPartNumber;
            this.txtPartNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPartNumber.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.txtPartNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPartNumber.FocusedState.Parent = this.txtPartNumber;
            this.txtPartNumber.Font = new System.Drawing.Font("Inter Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(179)))), ((int)(((byte)(184)))));
            this.txtPartNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPartNumber.HoverState.Parent = this.txtPartNumber;
            this.txtPartNumber.Location = new System.Drawing.Point(8, 6);
            this.txtPartNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 15);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.PasswordChar = '\0';
            this.txtPartNumber.PlaceholderText = "";
            this.txtPartNumber.SelectedText = "";
            this.txtPartNumber.SelectionStart = 17;
            this.txtPartNumber.ShadowDecoration.Parent = this.txtPartNumber;
            this.txtPartNumber.Size = new System.Drawing.Size(229, 36);
            this.txtPartNumber.TabIndex = 0;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.lblSupplier);
            this.guna2Panel4.Controls.Add(this.lblQuantity);
            this.guna2Panel4.Controls.Add(this.lblUnitPrice);
            this.guna2Panel4.Controls.Add(this.lblBuyingPrice);
            this.guna2Panel4.Controls.Add(this.lblBrand);
            this.guna2Panel4.Controls.Add(this.lblCategory);
            this.guna2Panel4.Controls.Add(this.lblDescription);
            this.guna2Panel4.Controls.Add(this.lblOemNumber);
            this.guna2Panel4.Controls.Add(this.lblPartNumber);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel4.Location = new System.Drawing.Point(15, 83);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(157, 484);
            this.guna2Panel4.TabIndex = 2;
            // 
            // lblSupplier
            // 
            this.lblSupplier.BackColor = System.Drawing.Color.Transparent;
            this.lblSupplier.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(179)))), ((int)(((byte)(184)))));
            this.lblSupplier.Location = new System.Drawing.Point(13, 449);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(63, 21);
            this.lblSupplier.TabIndex = 10;
            this.lblSupplier.Text = "Supplier";
            // 
            // lblQuantity
            // 
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(179)))), ((int)(((byte)(184)))));
            this.lblQuantity.Location = new System.Drawing.Point(13, 395);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(62, 21);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblUnitPrice.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(179)))), ((int)(((byte)(184)))));
            this.lblUnitPrice.Location = new System.Drawing.Point(13, 341);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(73, 21);
            this.lblUnitPrice.TabIndex = 8;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // lblBuyingPrice
            // 
            this.lblBuyingPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblBuyingPrice.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyingPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(179)))), ((int)(((byte)(184)))));
            this.lblBuyingPrice.Location = new System.Drawing.Point(13, 287);
            this.lblBuyingPrice.Name = "lblBuyingPrice";
            this.lblBuyingPrice.Size = new System.Drawing.Size(93, 21);
            this.lblBuyingPrice.TabIndex = 7;
            this.lblBuyingPrice.Text = "Buying Price";
            // 
            // lblBrand
            // 
            this.lblBrand.BackColor = System.Drawing.Color.Transparent;
            this.lblBrand.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(179)))), ((int)(((byte)(184)))));
            this.lblBrand.Location = new System.Drawing.Point(13, 233);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(45, 21);
            this.lblBrand.TabIndex = 6;
            this.lblBrand.Text = "Brand";
            // 
            // lblCategory
            // 
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(179)))), ((int)(((byte)(184)))));
            this.lblCategory.Location = new System.Drawing.Point(13, 179);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(68, 21);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Category";
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(179)))), ((int)(((byte)(184)))));
            this.lblDescription.Location = new System.Drawing.Point(13, 125);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(85, 21);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            // 
            // lblOemNumber
            // 
            this.lblOemNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblOemNumber.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOemNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(179)))), ((int)(((byte)(184)))));
            this.lblOemNumber.Location = new System.Drawing.Point(13, 71);
            this.lblOemNumber.Name = "lblOemNumber";
            this.lblOemNumber.Size = new System.Drawing.Size(97, 21);
            this.lblOemNumber.TabIndex = 3;
            this.lblOemNumber.Text = "OEM Number";
            // 
            // lblPartNumber
            // 
            this.lblPartNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPartNumber.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(179)))), ((int)(((byte)(184)))));
            this.lblPartNumber.Location = new System.Drawing.Point(13, 17);
            this.lblPartNumber.Name = "lblPartNumber";
            this.lblPartNumber.Size = new System.Drawing.Size(93, 21);
            this.lblPartNumber.TabIndex = 2;
            this.lblPartNumber.Text = "Part Number";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.btnClear);
            this.guna2Panel3.Controls.Add(this.btnAddItem);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel3.Location = new System.Drawing.Point(15, 567);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(411, 52);
            this.guna2Panel3.TabIndex = 1;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BorderRadius = 6;
            this.btnAddItem.CheckedState.Parent = this.btnAddItem;
            this.btnAddItem.CustomImages.Parent = this.btnAddItem;
            this.btnAddItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(116)))), ((int)(((byte)(225)))));
            this.btnAddItem.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.HoverState.Parent = this.btnAddItem;
            this.btnAddItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAddItem.Image")));
            this.btnAddItem.ImageSize = new System.Drawing.Size(11, 11);
            this.btnAddItem.Location = new System.Drawing.Point(310, 21);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.ShadowDecoration.Parent = this.btnAddItem;
            this.btnAddItem.Size = new System.Drawing.Size(86, 28);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "Add Item";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.imgBtnClose);
            this.guna2Panel2.Controls.Add(this.lblHeading);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(15, 15);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(411, 68);
            this.guna2Panel2.TabIndex = 0;
            // 
            // imgBtnClose
            // 
            this.imgBtnClose.CheckedState.Parent = this.imgBtnClose;
            this.imgBtnClose.HoverState.Parent = this.imgBtnClose;
            this.imgBtnClose.Image = ((System.Drawing.Image)(resources.GetObject("imgBtnClose.Image")));
            this.imgBtnClose.ImageSize = new System.Drawing.Size(15, 15);
            this.imgBtnClose.Location = new System.Drawing.Point(349, 7);
            this.imgBtnClose.Name = "imgBtnClose";
            this.imgBtnClose.PressedState.Parent = this.imgBtnClose;
            this.imgBtnClose.Size = new System.Drawing.Size(30, 23);
            this.imgBtnClose.TabIndex = 1;
            // 
            // lblHeading
            // 
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Inter Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lblHeading.Location = new System.Drawing.Point(11, 5);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(111, 31);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "New Item";
            // 
            // cmbBrand
            // 
            this.cmbBrand.BackColor = System.Drawing.Color.Transparent;
            this.cmbBrand.BorderColor = System.Drawing.Color.Transparent;
            this.cmbBrand.BorderRadius = 6;
            this.cmbBrand.BorderThickness = 0;
            this.cmbBrand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.cmbBrand.FocusedColor = System.Drawing.Color.Empty;
            this.cmbBrand.FocusedState.Parent = this.cmbBrand;
            this.cmbBrand.Font = new System.Drawing.Font("Inter Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(179)))), ((int)(((byte)(184)))));
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.HoverState.Parent = this.cmbBrand;
            this.cmbBrand.ItemHeight = 30;
            this.cmbBrand.ItemsAppearance.Parent = this.cmbBrand;
            this.cmbBrand.Location = new System.Drawing.Point(8, 222);
            this.cmbBrand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 15);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.ShadowDecoration.Parent = this.cmbBrand;
            this.cmbBrand.Size = new System.Drawing.Size(229, 36);
            this.cmbBrand.TabIndex = 7;
            // 
            // nudQuantity
            // 
            this.nudQuantity.BackColor = System.Drawing.Color.Transparent;
            this.nudQuantity.BorderColor = System.Drawing.Color.Transparent;
            this.nudQuantity.BorderRadius = 6;
            this.nudQuantity.BorderThickness = 0;
            this.nudQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nudQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nudQuantity.DisabledState.Parent = this.nudQuantity;
            this.nudQuantity.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nudQuantity.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nudQuantity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.nudQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nudQuantity.FocusedState.Parent = this.nudQuantity;
            this.nudQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(179)))), ((int)(((byte)(184)))));
            this.nudQuantity.Location = new System.Drawing.Point(8, 384);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 15);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.ShadowDecoration.Parent = this.nudQuantity;
            this.nudQuantity.Size = new System.Drawing.Size(229, 36);
            this.nudQuantity.TabIndex = 8;
            this.nudQuantity.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(179)))), ((int)(((byte)(184)))));
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmbCategory.BorderColor = System.Drawing.Color.Transparent;
            this.cmbCategory.BorderRadius = 6;
            this.cmbCategory.BorderThickness = 0;
            this.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.cmbCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cmbCategory.FocusedState.Parent = this.cmbCategory;
            this.cmbCategory.Font = new System.Drawing.Font("Inter Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(179)))), ((int)(((byte)(184)))));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.HoverState.Parent = this.cmbCategory;
            this.cmbCategory.ItemHeight = 30;
            this.cmbCategory.ItemsAppearance.Parent = this.cmbCategory;
            this.cmbCategory.Location = new System.Drawing.Point(8, 168);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 15);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.ShadowDecoration.Parent = this.cmbCategory;
            this.cmbCategory.Size = new System.Drawing.Size(229, 36);
            this.cmbCategory.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(179)))), ((int)(((byte)(184)))));
            this.btnClear.BorderRadius = 6;
            this.btnClear.BorderThickness = 1;
            this.btnClear.CheckedState.Parent = this.btnClear;
            this.btnClear.CustomImages.Parent = this.btnClear;
            this.btnClear.FillColor = System.Drawing.Color.Transparent;
            this.btnClear.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(179)))), ((int)(((byte)(184)))));
            this.btnClear.HoverState.Parent = this.btnClear;
            this.btnClear.ImageSize = new System.Drawing.Size(11, 11);
            this.btnClear.Location = new System.Drawing.Point(243, 21);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(58, 28);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            // 
            // NewItemModalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(441, 634);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NewItemModalView";
            this.Text = "NewItemModalView";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHeading;
        private Guna.UI2.WinForms.Guna2ImageButton imgBtnClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPartNumber;
        private Guna.UI2.WinForms.Guna2Button btnAddItem;
        private Guna.UI2.WinForms.Guna2TextBox txtSupplier;
        private Guna.UI2.WinForms.Guna2TextBox txtUnitPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtBuyingPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtOemNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtPartNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSupplier;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblQuantity;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUnitPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBuyingPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBrand;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCategory;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDescription;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblOemNumber;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCategory;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudQuantity;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBrand;
        private Guna.UI2.WinForms.Guna2Button btnClear;
    }
}