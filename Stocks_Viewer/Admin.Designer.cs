namespace Stocks_Viewer
{
    partial class Admin
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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgrid_arhivestocks = new System.Windows.Forms.DataGridView();
            this.dtgrid_orders = new System.Windows.Forms.DataGridView();
            this.radio_stocks = new System.Windows.Forms.RadioButton();
            this.radio_orders = new System.Windows.Forms.RadioButton();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.lbl_garlicherb = new System.Windows.Forms.Label();
            this.lbl_saladoil = new System.Windows.Forms.Label();
            this.lbl_cucumber = new System.Windows.Forms.Label();
            this.lbl_parmesancheese = new System.Windows.Forms.Label();
            this.lbl_ham = new System.Windows.Forms.Label();
            this.lbl_sausage = new System.Windows.Forms.Label();
            this.lbl_bacon = new System.Windows.Forms.Label();
            this.lbl_pepperoni = new System.Windows.Forms.Label();
            this.lbl_sauce = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_arhivestocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_orders)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back to Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgrid_arhivestocks);
            this.groupBox1.Controls.Add(this.dtgrid_orders);
            this.groupBox1.Controls.Add(this.radio_stocks);
            this.groupBox1.Controls.Add(this.radio_orders);
            this.groupBox1.Controls.Add(this.lbl_timer);
            this.groupBox1.Controls.Add(this.btn_refresh);
            this.groupBox1.Controls.Add(this.lbl_garlicherb);
            this.groupBox1.Controls.Add(this.lbl_saladoil);
            this.groupBox1.Controls.Add(this.lbl_cucumber);
            this.groupBox1.Controls.Add(this.lbl_parmesancheese);
            this.groupBox1.Controls.Add(this.lbl_ham);
            this.groupBox1.Controls.Add(this.lbl_sausage);
            this.groupBox1.Controls.Add(this.lbl_bacon);
            this.groupBox1.Controls.Add(this.lbl_pepperoni);
            this.groupBox1.Controls.Add(this.lbl_sauce);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1326, 637);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary";
            // 
            // dtgrid_arhivestocks
            // 
            this.dtgrid_arhivestocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_arhivestocks.Location = new System.Drawing.Point(6, 123);
            this.dtgrid_arhivestocks.Name = "dtgrid_arhivestocks";
            this.dtgrid_arhivestocks.ReadOnly = true;
            this.dtgrid_arhivestocks.Size = new System.Drawing.Size(1314, 508);
            this.dtgrid_arhivestocks.TabIndex = 48;
            this.dtgrid_arhivestocks.Visible = false;
            // 
            // dtgrid_orders
            // 
            this.dtgrid_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_orders.Location = new System.Drawing.Point(6, 123);
            this.dtgrid_orders.Name = "dtgrid_orders";
            this.dtgrid_orders.ReadOnly = true;
            this.dtgrid_orders.Size = new System.Drawing.Size(1314, 508);
            this.dtgrid_orders.TabIndex = 47;
            // 
            // radio_stocks
            // 
            this.radio_stocks.AutoSize = true;
            this.radio_stocks.Location = new System.Drawing.Point(83, 94);
            this.radio_stocks.Name = "radio_stocks";
            this.radio_stocks.Size = new System.Drawing.Size(120, 23);
            this.radio_stocks.TabIndex = 46;
            this.radio_stocks.Text = "Archive Stocks";
            this.radio_stocks.UseVisualStyleBackColor = true;
            this.radio_stocks.CheckedChanged += new System.EventHandler(this.radio_stocks_CheckedChanged);
            // 
            // radio_orders
            // 
            this.radio_orders.AutoSize = true;
            this.radio_orders.Checked = true;
            this.radio_orders.Location = new System.Drawing.Point(6, 94);
            this.radio_orders.Name = "radio_orders";
            this.radio_orders.Size = new System.Drawing.Size(71, 23);
            this.radio_orders.TabIndex = 45;
            this.radio_orders.TabStop = true;
            this.radio_orders.Text = "Orders";
            this.radio_orders.UseVisualStyleBackColor = true;
            this.radio_orders.CheckedChanged += new System.EventHandler(this.radio_orders_CheckedChanged);
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Location = new System.Drawing.Point(1158, 37);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(0, 19);
            this.lbl_timer.TabIndex = 44;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(6, 26);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(65, 62);
            this.btn_refresh.TabIndex = 43;
            this.btn_refresh.Text = "REFRESH";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // lbl_garlicherb
            // 
            this.lbl_garlicherb.AutoSize = true;
            this.lbl_garlicherb.Location = new System.Drawing.Point(864, 56);
            this.lbl_garlicherb.Name = "lbl_garlicherb";
            this.lbl_garlicherb.Size = new System.Drawing.Size(0, 19);
            this.lbl_garlicherb.TabIndex = 42;
            // 
            // lbl_saladoil
            // 
            this.lbl_saladoil.AutoSize = true;
            this.lbl_saladoil.Location = new System.Drawing.Point(778, 56);
            this.lbl_saladoil.Name = "lbl_saladoil";
            this.lbl_saladoil.Size = new System.Drawing.Size(0, 19);
            this.lbl_saladoil.TabIndex = 41;
            // 
            // lbl_cucumber
            // 
            this.lbl_cucumber.AutoSize = true;
            this.lbl_cucumber.Location = new System.Drawing.Point(688, 56);
            this.lbl_cucumber.Name = "lbl_cucumber";
            this.lbl_cucumber.Size = new System.Drawing.Size(0, 19);
            this.lbl_cucumber.TabIndex = 40;
            // 
            // lbl_parmesancheese
            // 
            this.lbl_parmesancheese.AutoSize = true;
            this.lbl_parmesancheese.Location = new System.Drawing.Point(546, 56);
            this.lbl_parmesancheese.Name = "lbl_parmesancheese";
            this.lbl_parmesancheese.Size = new System.Drawing.Size(0, 19);
            this.lbl_parmesancheese.TabIndex = 39;
            // 
            // lbl_ham
            // 
            this.lbl_ham.AutoSize = true;
            this.lbl_ham.Location = new System.Drawing.Point(481, 56);
            this.lbl_ham.Name = "lbl_ham";
            this.lbl_ham.Size = new System.Drawing.Size(0, 19);
            this.lbl_ham.TabIndex = 38;
            // 
            // lbl_sausage
            // 
            this.lbl_sausage.AutoSize = true;
            this.lbl_sausage.Location = new System.Drawing.Point(391, 56);
            this.lbl_sausage.Name = "lbl_sausage";
            this.lbl_sausage.Size = new System.Drawing.Size(0, 19);
            this.lbl_sausage.TabIndex = 37;
            // 
            // lbl_bacon
            // 
            this.lbl_bacon.AutoSize = true;
            this.lbl_bacon.Location = new System.Drawing.Point(319, 56);
            this.lbl_bacon.Name = "lbl_bacon";
            this.lbl_bacon.Size = new System.Drawing.Size(0, 19);
            this.lbl_bacon.TabIndex = 36;
            // 
            // lbl_pepperoni
            // 
            this.lbl_pepperoni.AutoSize = true;
            this.lbl_pepperoni.Location = new System.Drawing.Point(222, 56);
            this.lbl_pepperoni.Name = "lbl_pepperoni";
            this.lbl_pepperoni.Size = new System.Drawing.Size(0, 19);
            this.lbl_pepperoni.TabIndex = 35;
            // 
            // lbl_sauce
            // 
            this.lbl_sauce.AutoSize = true;
            this.lbl_sauce.Location = new System.Drawing.Point(154, 56);
            this.lbl_sauce.Name = "lbl_sauce";
            this.lbl_sauce.Size = new System.Drawing.Size(0, 19);
            this.lbl_sauce.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(79, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 19);
            this.label11.TabIndex = 32;
            this.label11.Text = "Quantity:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(864, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 19);
            this.label10.TabIndex = 31;
            this.label10.Text = "Garlic Herb";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(778, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 19);
            this.label9.TabIndex = 30;
            this.label9.Text = "Salad Oil";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(688, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 19);
            this.label8.TabIndex = 29;
            this.label8.Text = "Cucumber";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(546, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 19);
            this.label7.TabIndex = 28;
            this.label7.Text = "Parmesan Cheese";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(481, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "Ham";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Sausage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Bacon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Pepperoni";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(154, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 19);
            this.label12.TabIndex = 23;
            this.label12.Text = "Sauce";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stocks_Viewer.Properties.Resources.b7241a_pizza_pepperoni;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_arhivestocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label lbl_garlicherb;
        private System.Windows.Forms.Label lbl_saladoil;
        private System.Windows.Forms.Label lbl_cucumber;
        private System.Windows.Forms.Label lbl_parmesancheese;
        private System.Windows.Forms.Label lbl_ham;
        private System.Windows.Forms.Label lbl_sausage;
        private System.Windows.Forms.Label lbl_bacon;
        private System.Windows.Forms.Label lbl_pepperoni;
        private System.Windows.Forms.Label lbl_sauce;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton radio_stocks;
        private System.Windows.Forms.RadioButton radio_orders;
        private System.Windows.Forms.DataGridView dtgrid_arhivestocks;
        private System.Windows.Forms.DataGridView dtgrid_orders;
    }
}