
namespace P.O.S_System
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.TableofSelected = new System.Windows.Forms.DataGridView();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.TextBox();
            this.Reset = new System.Windows.Forms.Button();
            this.ADD = new System.Windows.Forms.Button();
            this.SalataStock = new System.Windows.Forms.TextBox();
            this.EtStock = new System.Windows.Forms.TextBox();
            this.TavukStock = new System.Windows.Forms.TextBox();
            this.PizzaStock = new System.Windows.Forms.TextBox();
            this.HamburgerStock = new System.Windows.Forms.TextBox();
            this.PatatesStock = new System.Windows.Forms.TextBox();
            this.SalataCB = new System.Windows.Forms.CheckBox();
            this.EtCB = new System.Windows.Forms.CheckBox();
            this.TavukCB = new System.Windows.Forms.CheckBox();
            this.PizzaCB = new System.Windows.Forms.CheckBox();
            this.HamburgerCB = new System.Windows.Forms.CheckBox();
            this.PatetesCB = new System.Windows.Forms.CheckBox();
            this.Salata = new System.Windows.Forms.TextBox();
            this.Et = new System.Windows.Forms.TextBox();
            this.Tavuk = new System.Windows.Forms.TextBox();
            this.Pizza = new System.Windows.Forms.TextBox();
            this.Hamburger = new System.Windows.Forms.TextBox();
            this.Patates = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableofSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TableofSelected);
            this.panel1.Controls.Add(this.Total);
            this.panel1.Controls.Add(this.Reset);
            this.panel1.Controls.Add(this.ADD);
            this.panel1.Controls.Add(this.SalataStock);
            this.panel1.Controls.Add(this.EtStock);
            this.panel1.Controls.Add(this.TavukStock);
            this.panel1.Controls.Add(this.PizzaStock);
            this.panel1.Controls.Add(this.HamburgerStock);
            this.panel1.Controls.Add(this.PatatesStock);
            this.panel1.Controls.Add(this.SalataCB);
            this.panel1.Controls.Add(this.EtCB);
            this.panel1.Controls.Add(this.TavukCB);
            this.panel1.Controls.Add(this.PizzaCB);
            this.panel1.Controls.Add(this.HamburgerCB);
            this.panel1.Controls.Add(this.PatetesCB);
            this.panel1.Controls.Add(this.Salata);
            this.panel1.Controls.Add(this.Et);
            this.panel1.Controls.Add(this.Tavuk);
            this.panel1.Controls.Add(this.Pizza);
            this.panel1.Controls.Add(this.Hamburger);
            this.panel1.Controls.Add(this.Patates);
            this.panel1.Location = new System.Drawing.Point(6, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 696);
            this.panel1.TabIndex = 0;
            // 
            // TableofSelected
            // 
            this.TableofSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableofSelected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stock,
            this.Name,
            this.Price});
            this.TableofSelected.Location = new System.Drawing.Point(6, 335);
            this.TableofSelected.Name = "TableofSelected";
            this.TableofSelected.RowHeadersWidth = 51;
            this.TableofSelected.RowTemplate.Height = 29;
            this.TableofSelected.Size = new System.Drawing.Size(429, 283);
            this.TableofSelected.TabIndex = 20;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Adet";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 125;
            // 
            // Name
            // 
            this.Name.HeaderText = "Ürün";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Ücret";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // Total
            // 
            this.Total.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Total.Location = new System.Drawing.Point(182, 624);
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Size = new System.Drawing.Size(145, 34);
            this.Total.TabIndex = 19;
            this.Total.Text = "Total: ";
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(237, 300);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(94, 29);
            this.Reset.TabIndex = 18;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(67, 300);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(94, 29);
            this.ADD.TabIndex = 0;
            this.ADD.Text = "Ekle";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // SalataStock
            // 
            this.SalataStock.Enabled = false;
            this.SalataStock.Location = new System.Drawing.Point(237, 250);
            this.SalataStock.Name = "SalataStock";
            this.SalataStock.Size = new System.Drawing.Size(90, 27);
            this.SalataStock.TabIndex = 17;
            this.SalataStock.Text = "0";
            // 
            // EtStock
            // 
            this.EtStock.Enabled = false;
            this.EtStock.Location = new System.Drawing.Point(237, 210);
            this.EtStock.Name = "EtStock";
            this.EtStock.Size = new System.Drawing.Size(90, 27);
            this.EtStock.TabIndex = 16;
            this.EtStock.Text = "0";
            // 
            // TavukStock
            // 
            this.TavukStock.Enabled = false;
            this.TavukStock.Location = new System.Drawing.Point(237, 170);
            this.TavukStock.Name = "TavukStock";
            this.TavukStock.Size = new System.Drawing.Size(90, 27);
            this.TavukStock.TabIndex = 15;
            this.TavukStock.Text = "0";
            // 
            // PizzaStock
            // 
            this.PizzaStock.Enabled = false;
            this.PizzaStock.Location = new System.Drawing.Point(237, 130);
            this.PizzaStock.Name = "PizzaStock";
            this.PizzaStock.Size = new System.Drawing.Size(90, 27);
            this.PizzaStock.TabIndex = 14;
            this.PizzaStock.Text = "0";
            // 
            // HamburgerStock
            // 
            this.HamburgerStock.Enabled = false;
            this.HamburgerStock.Location = new System.Drawing.Point(237, 90);
            this.HamburgerStock.Name = "HamburgerStock";
            this.HamburgerStock.Size = new System.Drawing.Size(90, 27);
            this.HamburgerStock.TabIndex = 13;
            this.HamburgerStock.Text = "0";
            // 
            // PatatesStock
            // 
            this.PatatesStock.Enabled = false;
            this.PatatesStock.Location = new System.Drawing.Point(237, 54);
            this.PatatesStock.Name = "PatatesStock";
            this.PatatesStock.Size = new System.Drawing.Size(90, 27);
            this.PatatesStock.TabIndex = 12;
            this.PatatesStock.Text = "0";
            // 
            // SalataCB
            // 
            this.SalataCB.AutoSize = true;
            this.SalataCB.Location = new System.Drawing.Point(29, 260);
            this.SalataCB.Name = "SalataCB";
            this.SalataCB.Size = new System.Drawing.Size(18, 17);
            this.SalataCB.TabIndex = 11;
            this.SalataCB.UseVisualStyleBackColor = true;
            this.SalataCB.CheckedChanged += new System.EventHandler(this.SalataCB_CheckedChanged);
            // 
            // EtCB
            // 
            this.EtCB.AutoSize = true;
            this.EtCB.Location = new System.Drawing.Point(29, 220);
            this.EtCB.Name = "EtCB";
            this.EtCB.Size = new System.Drawing.Size(18, 17);
            this.EtCB.TabIndex = 10;
            this.EtCB.UseVisualStyleBackColor = true;
            this.EtCB.CheckedChanged += new System.EventHandler(this.EtCB_CheckedChanged);
            // 
            // TavukCB
            // 
            this.TavukCB.AutoSize = true;
            this.TavukCB.Location = new System.Drawing.Point(29, 180);
            this.TavukCB.Name = "TavukCB";
            this.TavukCB.Size = new System.Drawing.Size(18, 17);
            this.TavukCB.TabIndex = 9;
            this.TavukCB.UseVisualStyleBackColor = true;
            this.TavukCB.CheckedChanged += new System.EventHandler(this.TavukCB_CheckedChanged);
            // 
            // PizzaCB
            // 
            this.PizzaCB.AutoSize = true;
            this.PizzaCB.Location = new System.Drawing.Point(29, 140);
            this.PizzaCB.Name = "PizzaCB";
            this.PizzaCB.Size = new System.Drawing.Size(18, 17);
            this.PizzaCB.TabIndex = 8;
            this.PizzaCB.UseVisualStyleBackColor = true;
            this.PizzaCB.CheckedChanged += new System.EventHandler(this.PizzaCB_CheckedChanged);
            // 
            // HamburgerCB
            // 
            this.HamburgerCB.AutoSize = true;
            this.HamburgerCB.Location = new System.Drawing.Point(29, 100);
            this.HamburgerCB.Name = "HamburgerCB";
            this.HamburgerCB.Size = new System.Drawing.Size(18, 17);
            this.HamburgerCB.TabIndex = 7;
            this.HamburgerCB.UseVisualStyleBackColor = true;
            this.HamburgerCB.CheckedChanged += new System.EventHandler(this.HamburgerCB_CheckedChanged);
            // 
            // PatetesCB
            // 
            this.PatetesCB.AutoSize = true;
            this.PatetesCB.Location = new System.Drawing.Point(29, 60);
            this.PatetesCB.Name = "PatetesCB";
            this.PatetesCB.Size = new System.Drawing.Size(18, 17);
            this.PatetesCB.TabIndex = 6;
            this.PatetesCB.UseVisualStyleBackColor = true;
            this.PatetesCB.CheckedChanged += new System.EventHandler(this.PatetesCB_CheckedChanged);
            // 
            // Salata
            // 
            this.Salata.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Salata.Location = new System.Drawing.Point(63, 247);
            this.Salata.Name = "Salata";
            this.Salata.ReadOnly = true;
            this.Salata.Size = new System.Drawing.Size(145, 34);
            this.Salata.TabIndex = 5;
            this.Salata.Text = "Salata 20₺";
            // 
            // Et
            // 
            this.Et.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Et.Location = new System.Drawing.Point(63, 207);
            this.Et.Name = "Et";
            this.Et.ReadOnly = true;
            this.Et.Size = new System.Drawing.Size(145, 34);
            this.Et.TabIndex = 4;
            this.Et.Text = "Et 80₺";
            // 
            // Tavuk
            // 
            this.Tavuk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tavuk.Location = new System.Drawing.Point(63, 167);
            this.Tavuk.Name = "Tavuk";
            this.Tavuk.ReadOnly = true;
            this.Tavuk.Size = new System.Drawing.Size(145, 34);
            this.Tavuk.TabIndex = 3;
            this.Tavuk.Text = "Tavuk 40₺";
            // 
            // Pizza
            // 
            this.Pizza.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Pizza.Location = new System.Drawing.Point(63, 127);
            this.Pizza.Name = "Pizza";
            this.Pizza.ReadOnly = true;
            this.Pizza.Size = new System.Drawing.Size(145, 34);
            this.Pizza.TabIndex = 2;
            this.Pizza.Text = "Pizza 50₺";
            // 
            // Hamburger
            // 
            this.Hamburger.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Hamburger.Location = new System.Drawing.Point(63, 87);
            this.Hamburger.Name = "Hamburger";
            this.Hamburger.ReadOnly = true;
            this.Hamburger.Size = new System.Drawing.Size(145, 34);
            this.Hamburger.TabIndex = 1;
            this.Hamburger.Text = "Hamburger 30₺";
            // 
            // Patates
            // 
            this.Patates.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Patates.Location = new System.Drawing.Point(63, 47);
            this.Patates.Name = "Patates";
            this.Patates.ReadOnly = true;
            this.Patates.Size = new System.Drawing.Size(145, 34);
            this.Patates.TabIndex = 0;
            this.Patates.Text = "Patates 20₺";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 682);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.Text = "P.O.S";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableofSelected)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Patates;
        private System.Windows.Forms.TextBox Salata;
        private System.Windows.Forms.TextBox Et;
        private System.Windows.Forms.TextBox Tavuk;
        private System.Windows.Forms.TextBox Pizza;
        private System.Windows.Forms.TextBox Hamburger;
        private System.Windows.Forms.CheckBox PatetesCB;
        private System.Windows.Forms.CheckBox HamburgerCB;
        private System.Windows.Forms.CheckBox PizzaCB;
        private System.Windows.Forms.CheckBox TavukCB;
        private System.Windows.Forms.CheckBox EtCB;
        private System.Windows.Forms.CheckBox SalataCB;
        private System.Windows.Forms.TextBox SalataStock;
        private System.Windows.Forms.TextBox EtStock;
        private System.Windows.Forms.TextBox TavukStock;
        private System.Windows.Forms.TextBox PizzaStock;
        private System.Windows.Forms.TextBox HamburgerStock;
        private System.Windows.Forms.TextBox PatatesStock;
        private System.Windows.Forms.Button ADD;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.DataGridView TableofSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
    }
}

