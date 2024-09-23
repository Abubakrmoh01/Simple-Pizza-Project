namespace Pizza_Project
{
    partial class Pizza_proj
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
            this.pizzaLable = new System.Windows.Forms.Label();
            this.gpSize = new System.Windows.Forms.GroupBox();
            this.rdblarg = new System.Windows.Forms.RadioButton();
            this.rdbmeduim = new System.Windows.Forms.RadioButton();
            this.rdbsmall = new System.Windows.Forms.RadioButton();
            this.gpToppings = new System.Windows.Forms.GroupBox();
            this.chkgreenpapper = new System.Windows.Forms.CheckBox();
            this.chkolvies = new System.Windows.Forms.CheckBox();
            this.chkonion = new System.Windows.Forms.CheckBox();
            this.chktomatos = new System.Windows.Forms.CheckBox();
            this.chkmashroum = new System.Windows.Forms.CheckBox();
            this.chkextrachees = new System.Windows.Forms.CheckBox();
            this.gpOrdersumary = new System.Windows.Forms.GroupBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblwheretoeat = new System.Windows.Forms.Label();
            this.lblcrustype = new System.Windows.Forms.Label();
            this.lbltoppings = new System.Windows.Forms.Label();
            this.lblsize = new System.Windows.Forms.Label();
            this.lbWheretoeat = new System.Windows.Forms.Label();
            this.lbCrustTypy = new System.Windows.Forms.Label();
            this.lbTopping = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.gpWhereToEat = new System.Windows.Forms.GroupBox();
            this.rdbEAT_OUT = new System.Windows.Forms.RadioButton();
            this.rdbEat_IN = new System.Windows.Forms.RadioButton();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.gpCrustType = new System.Windows.Forms.GroupBox();
            this.rdbthink_crust = new System.Windows.Forms.RadioButton();
            this.rdbthin_Crust = new System.Windows.Forms.RadioButton();
            this.gpSize.SuspendLayout();
            this.gpToppings.SuspendLayout();
            this.gpOrdersumary.SuspendLayout();
            this.gpWhereToEat.SuspendLayout();
            this.gpCrustType.SuspendLayout();
            this.SuspendLayout();
            // 
            // pizzaLable
            // 
            this.pizzaLable.AutoSize = true;
            this.pizzaLable.BackColor = System.Drawing.Color.Transparent;
            this.pizzaLable.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaLable.ForeColor = System.Drawing.Color.Red;
            this.pizzaLable.Location = new System.Drawing.Point(269, -14);
            this.pizzaLable.Name = "pizzaLable";
            this.pizzaLable.Size = new System.Drawing.Size(663, 105);
            this.pizzaLable.TabIndex = 0;
            this.pizzaLable.Text = "MAKE YOUR PIZZA";
            this.pizzaLable.Click += new System.EventHandler(this.pizzaLable_Click);
            // 
            // gpSize
            // 
            this.gpSize.BackColor = System.Drawing.Color.Transparent;
            this.gpSize.Controls.Add(this.rdblarg);
            this.gpSize.Controls.Add(this.rdbmeduim);
            this.gpSize.Controls.Add(this.rdbsmall);
            this.gpSize.Location = new System.Drawing.Point(12, 108);
            this.gpSize.Name = "gpSize";
            this.gpSize.Size = new System.Drawing.Size(173, 175);
            this.gpSize.TabIndex = 1;
            this.gpSize.TabStop = false;
            this.gpSize.Text = "Size";
            // 
            // rdblarg
            // 
            this.rdblarg.AutoSize = true;
            this.rdblarg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdblarg.ForeColor = System.Drawing.Color.Red;
            this.rdblarg.Location = new System.Drawing.Point(31, 119);
            this.rdblarg.Name = "rdblarg";
            this.rdblarg.Size = new System.Drawing.Size(65, 26);
            this.rdblarg.TabIndex = 2;
            this.rdblarg.TabStop = true;
            this.rdblarg.Tag = "40";
            this.rdblarg.Text = "larg";
            this.rdblarg.UseVisualStyleBackColor = true;
            this.rdblarg.CheckedChanged += new System.EventHandler(this.rdblarg_CheckedChanged);
            // 
            // rdbmeduim
            // 
            this.rdbmeduim.AutoSize = true;
            this.rdbmeduim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbmeduim.ForeColor = System.Drawing.Color.Red;
            this.rdbmeduim.Location = new System.Drawing.Point(31, 78);
            this.rdbmeduim.Name = "rdbmeduim";
            this.rdbmeduim.Size = new System.Drawing.Size(99, 26);
            this.rdbmeduim.TabIndex = 1;
            this.rdbmeduim.TabStop = true;
            this.rdbmeduim.Tag = "30";
            this.rdbmeduim.Text = "meduim";
            this.rdbmeduim.UseVisualStyleBackColor = true;
            this.rdbmeduim.CheckedChanged += new System.EventHandler(this.rdbmeduim_CheckedChanged);
            // 
            // rdbsmall
            // 
            this.rdbsmall.AutoSize = true;
            this.rdbsmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbsmall.ForeColor = System.Drawing.Color.Red;
            this.rdbsmall.Location = new System.Drawing.Point(31, 39);
            this.rdbsmall.Name = "rdbsmall";
            this.rdbsmall.Size = new System.Drawing.Size(77, 26);
            this.rdbsmall.TabIndex = 0;
            this.rdbsmall.TabStop = true;
            this.rdbsmall.Tag = "20";
            this.rdbsmall.Text = "small";
            this.rdbsmall.UseVisualStyleBackColor = true;
            this.rdbsmall.CheckedChanged += new System.EventHandler(this.rdbsmall_CheckedChanged);
            // 
            // gpToppings
            // 
            this.gpToppings.BackColor = System.Drawing.Color.Transparent;
            this.gpToppings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gpToppings.Controls.Add(this.chkgreenpapper);
            this.gpToppings.Controls.Add(this.chkolvies);
            this.gpToppings.Controls.Add(this.chkonion);
            this.gpToppings.Controls.Add(this.chktomatos);
            this.gpToppings.Controls.Add(this.chkmashroum);
            this.gpToppings.Controls.Add(this.chkextrachees);
            this.gpToppings.Location = new System.Drawing.Point(191, 186);
            this.gpToppings.Name = "gpToppings";
            this.gpToppings.Size = new System.Drawing.Size(408, 246);
            this.gpToppings.TabIndex = 2;
            this.gpToppings.TabStop = false;
            this.gpToppings.Text = "Toppings";
            // 
            // chkgreenpapper
            // 
            this.chkgreenpapper.AutoSize = true;
            this.chkgreenpapper.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkgreenpapper.ForeColor = System.Drawing.Color.Lime;
            this.chkgreenpapper.Location = new System.Drawing.Point(195, 144);
            this.chkgreenpapper.Name = "chkgreenpapper";
            this.chkgreenpapper.Size = new System.Drawing.Size(193, 33);
            this.chkgreenpapper.TabIndex = 5;
            this.chkgreenpapper.Tag = "5";
            this.chkgreenpapper.Text = "green papper";
            this.chkgreenpapper.UseVisualStyleBackColor = true;
            this.chkgreenpapper.CheckedChanged += new System.EventHandler(this.chkgreenpapper_CheckedChanged);
            // 
            // chkolvies
            // 
            this.chkolvies.AutoSize = true;
            this.chkolvies.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkolvies.ForeColor = System.Drawing.Color.Lime;
            this.chkolvies.Location = new System.Drawing.Point(195, 106);
            this.chkolvies.Name = "chkolvies";
            this.chkolvies.Size = new System.Drawing.Size(104, 33);
            this.chkolvies.TabIndex = 4;
            this.chkolvies.Tag = "5";
            this.chkolvies.Text = "olvies";
            this.chkolvies.UseVisualStyleBackColor = true;
            this.chkolvies.CheckedChanged += new System.EventHandler(this.chkolvies_CheckedChanged);
            // 
            // chkonion
            // 
            this.chkonion.AutoSize = true;
            this.chkonion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkonion.ForeColor = System.Drawing.Color.Lime;
            this.chkonion.Location = new System.Drawing.Point(195, 62);
            this.chkonion.Name = "chkonion";
            this.chkonion.Size = new System.Drawing.Size(100, 33);
            this.chkonion.TabIndex = 3;
            this.chkonion.Tag = "5";
            this.chkonion.Text = "onion";
            this.chkonion.UseVisualStyleBackColor = true;
            this.chkonion.CheckedChanged += new System.EventHandler(this.chkonion_CheckedChanged);
            // 
            // chktomatos
            // 
            this.chktomatos.AutoSize = true;
            this.chktomatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chktomatos.ForeColor = System.Drawing.Color.Lime;
            this.chktomatos.Location = new System.Drawing.Point(36, 144);
            this.chktomatos.Name = "chktomatos";
            this.chktomatos.Size = new System.Drawing.Size(127, 33);
            this.chktomatos.TabIndex = 2;
            this.chktomatos.Tag = "5";
            this.chktomatos.Text = "tomatos";
            this.chktomatos.UseVisualStyleBackColor = true;
            this.chktomatos.CheckedChanged += new System.EventHandler(this.chktomatos_CheckedChanged);
            // 
            // chkmashroum
            // 
            this.chkmashroum.AutoSize = true;
            this.chkmashroum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkmashroum.ForeColor = System.Drawing.Color.Lime;
            this.chkmashroum.Location = new System.Drawing.Point(36, 106);
            this.chkmashroum.Name = "chkmashroum";
            this.chkmashroum.Size = new System.Drawing.Size(156, 33);
            this.chkmashroum.TabIndex = 1;
            this.chkmashroum.Tag = "5";
            this.chkmashroum.Text = "mashroum";
            this.chkmashroum.UseVisualStyleBackColor = true;
            this.chkmashroum.CheckedChanged += new System.EventHandler(this.chkmashroum_CheckedChanged);
            // 
            // chkextrachees
            // 
            this.chkextrachees.AutoSize = true;
            this.chkextrachees.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkextrachees.ForeColor = System.Drawing.Color.Lime;
            this.chkextrachees.Location = new System.Drawing.Point(36, 62);
            this.chkextrachees.Name = "chkextrachees";
            this.chkextrachees.Size = new System.Drawing.Size(169, 33);
            this.chkextrachees.TabIndex = 0;
            this.chkextrachees.Tag = "5";
            this.chkextrachees.Text = "extra chees";
            this.chkextrachees.UseVisualStyleBackColor = true;
            this.chkextrachees.CheckedChanged += new System.EventHandler(this.chkextrachees_CheckedChanged);
            // 
            // gpOrdersumary
            // 
            this.gpOrdersumary.BackColor = System.Drawing.Color.Transparent;
            this.gpOrdersumary.Controls.Add(this.lblTotalPrice);
            this.gpOrdersumary.Controls.Add(this.label1);
            this.gpOrdersumary.Controls.Add(this.lblwheretoeat);
            this.gpOrdersumary.Controls.Add(this.lblcrustype);
            this.gpOrdersumary.Controls.Add(this.lbltoppings);
            this.gpOrdersumary.Controls.Add(this.lblsize);
            this.gpOrdersumary.Controls.Add(this.lbWheretoeat);
            this.gpOrdersumary.Controls.Add(this.lbCrustTypy);
            this.gpOrdersumary.Controls.Add(this.lbTopping);
            this.gpOrdersumary.Controls.Add(this.lbSize);
            this.gpOrdersumary.Location = new System.Drawing.Point(843, 94);
            this.gpOrdersumary.Name = "gpOrdersumary";
            this.gpOrdersumary.Size = new System.Drawing.Size(467, 468);
            this.gpOrdersumary.TabIndex = 2;
            this.gpOrdersumary.TabStop = false;
            this.gpOrdersumary.Text = "oreder summary";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(174, 393);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(60, 51);
            this.lblTotalPrice.TabIndex = 9;
            this.lblTotalPrice.Text = "$:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(11, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total Price:";
            // 
            // lblwheretoeat
            // 
            this.lblwheretoeat.AutoSize = true;
            this.lblwheretoeat.BackColor = System.Drawing.Color.Transparent;
            this.lblwheretoeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwheretoeat.ForeColor = System.Drawing.Color.Snow;
            this.lblwheretoeat.Location = new System.Drawing.Point(183, 315);
            this.lblwheretoeat.Name = "lblwheretoeat";
            this.lblwheretoeat.Size = new System.Drawing.Size(79, 29);
            this.lblwheretoeat.TabIndex = 7;
            this.lblwheretoeat.Text = "Eat In";
            // 
            // lblcrustype
            // 
            this.lblcrustype.AutoSize = true;
            this.lblcrustype.BackColor = System.Drawing.Color.Transparent;
            this.lblcrustype.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcrustype.ForeColor = System.Drawing.Color.Snow;
            this.lblcrustype.Location = new System.Drawing.Point(144, 265);
            this.lblcrustype.Name = "lblcrustype";
            this.lblcrustype.Size = new System.Drawing.Size(135, 29);
            this.lblcrustype.TabIndex = 6;
            this.lblcrustype.Text = "Thin Crudt";
            // 
            // lbltoppings
            // 
            this.lbltoppings.AutoSize = true;
            this.lbltoppings.BackColor = System.Drawing.Color.Transparent;
            this.lbltoppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltoppings.ForeColor = System.Drawing.Color.Snow;
            this.lbltoppings.Location = new System.Drawing.Point(63, 145);
            this.lbltoppings.MaximumSize = new System.Drawing.Size(300, 0);
            this.lbltoppings.Name = "lbltoppings";
            this.lbltoppings.Size = new System.Drawing.Size(157, 29);
            this.lbltoppings.TabIndex = 5;
            this.lbltoppings.Text = "NO Topping";
            // 
            // lblsize
            // 
            this.lblsize.AutoSize = true;
            this.lblsize.BackColor = System.Drawing.Color.Transparent;
            this.lblsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsize.ForeColor = System.Drawing.Color.Snow;
            this.lblsize.Location = new System.Drawing.Point(100, 43);
            this.lblsize.Name = "lblsize";
            this.lblsize.Size = new System.Drawing.Size(75, 29);
            this.lblsize.TabIndex = 4;
            this.lblsize.Text = "samll";
            // 
            // lbWheretoeat
            // 
            this.lbWheretoeat.AutoSize = true;
            this.lbWheretoeat.BackColor = System.Drawing.Color.Transparent;
            this.lbWheretoeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWheretoeat.ForeColor = System.Drawing.Color.Red;
            this.lbWheretoeat.Location = new System.Drawing.Point(11, 303);
            this.lbWheretoeat.Name = "lbWheretoeat";
            this.lbWheretoeat.Size = new System.Drawing.Size(168, 29);
            this.lbWheretoeat.TabIndex = 3;
            this.lbWheretoeat.Text = "Where to eat:";
            // 
            // lbCrustTypy
            // 
            this.lbCrustTypy.AutoSize = true;
            this.lbCrustTypy.BackColor = System.Drawing.Color.Transparent;
            this.lbCrustTypy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrustTypy.ForeColor = System.Drawing.Color.Red;
            this.lbCrustTypy.Location = new System.Drawing.Point(15, 238);
            this.lbCrustTypy.Name = "lbCrustTypy";
            this.lbCrustTypy.Size = new System.Drawing.Size(144, 29);
            this.lbCrustTypy.TabIndex = 2;
            this.lbCrustTypy.Text = "Crust Typy:";
            // 
            // lbTopping
            // 
            this.lbTopping.AutoSize = true;
            this.lbTopping.BackColor = System.Drawing.Color.Transparent;
            this.lbTopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTopping.ForeColor = System.Drawing.Color.Red;
            this.lbTopping.Location = new System.Drawing.Point(11, 101);
            this.lbTopping.Name = "lbTopping";
            this.lbTopping.Size = new System.Drawing.Size(118, 29);
            this.lbTopping.TabIndex = 1;
            this.lbTopping.Text = "Topping:";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.BackColor = System.Drawing.Color.Transparent;
            this.lbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.ForeColor = System.Drawing.Color.Red;
            this.lbSize.Location = new System.Drawing.Point(27, 39);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(71, 29);
            this.lbSize.TabIndex = 0;
            this.lbSize.Text = "Size:";
            // 
            // gpWhereToEat
            // 
            this.gpWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.gpWhereToEat.Controls.Add(this.rdbEAT_OUT);
            this.gpWhereToEat.Controls.Add(this.rdbEat_IN);
            this.gpWhereToEat.Location = new System.Drawing.Point(202, 434);
            this.gpWhereToEat.Name = "gpWhereToEat";
            this.gpWhereToEat.Size = new System.Drawing.Size(288, 99);
            this.gpWhereToEat.TabIndex = 4;
            this.gpWhereToEat.TabStop = false;
            this.gpWhereToEat.Text = "Where To Eat";
            // 
            // rdbEAT_OUT
            // 
            this.rdbEAT_OUT.AutoSize = true;
            this.rdbEAT_OUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEAT_OUT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdbEAT_OUT.Location = new System.Drawing.Point(121, 47);
            this.rdbEAT_OUT.Name = "rdbEAT_OUT";
            this.rdbEAT_OUT.Size = new System.Drawing.Size(134, 29);
            this.rdbEAT_OUT.TabIndex = 2;
            this.rdbEAT_OUT.TabStop = true;
            this.rdbEAT_OUT.Text = "EAT_OUT";
            this.rdbEAT_OUT.UseVisualStyleBackColor = true;
            this.rdbEAT_OUT.CheckedChanged += new System.EventHandler(this.rdbEAT_OUT_CheckedChanged);
            // 
            // rdbEat_IN
            // 
            this.rdbEat_IN.AutoSize = true;
            this.rdbEat_IN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEat_IN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdbEat_IN.Location = new System.Drawing.Point(6, 48);
            this.rdbEat_IN.Name = "rdbEat_IN";
            this.rdbEat_IN.Size = new System.Drawing.Size(98, 29);
            this.rdbEat_IN.TabIndex = 1;
            this.rdbEat_IN.TabStop = true;
            this.rdbEat_IN.Text = "Eat_IN";
            this.rdbEat_IN.UseVisualStyleBackColor = true;
            this.rdbEat_IN.CheckedChanged += new System.EventHandler(this.rdbEat_IN_CheckedChanged);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.Color.Lime;
            this.btnOrderPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPizza.Location = new System.Drawing.Point(516, 498);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(137, 70);
            this.btnOrderPizza.TabIndex = 5;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.BackColor = System.Drawing.Color.Red;
            this.btnResetForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.Location = new System.Drawing.Point(700, 498);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(137, 70);
            this.btnResetForm.TabIndex = 6;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = false;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // gpCrustType
            // 
            this.gpCrustType.BackColor = System.Drawing.Color.Transparent;
            this.gpCrustType.Controls.Add(this.rdbthink_crust);
            this.gpCrustType.Controls.Add(this.rdbthin_Crust);
            this.gpCrustType.Location = new System.Drawing.Point(12, 399);
            this.gpCrustType.Name = "gpCrustType";
            this.gpCrustType.Size = new System.Drawing.Size(173, 117);
            this.gpCrustType.TabIndex = 3;
            this.gpCrustType.TabStop = false;
            this.gpCrustType.Text = "Crust Type";
            // 
            // rdbthink_crust
            // 
            this.rdbthink_crust.AutoSize = true;
            this.rdbthink_crust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbthink_crust.ForeColor = System.Drawing.Color.Yellow;
            this.rdbthink_crust.Location = new System.Drawing.Point(20, 76);
            this.rdbthink_crust.Name = "rdbthink_crust";
            this.rdbthink_crust.Size = new System.Drawing.Size(129, 26);
            this.rdbthink_crust.TabIndex = 1;
            this.rdbthink_crust.TabStop = true;
            this.rdbthink_crust.Tag = "10";
            this.rdbthink_crust.Text = "think_crust";
            this.rdbthink_crust.UseVisualStyleBackColor = true;
            this.rdbthink_crust.CheckedChanged += new System.EventHandler(this.rdbthink_crust_CheckedChanged);
            // 
            // rdbthin_Crust
            // 
            this.rdbthin_Crust.AutoSize = true;
            this.rdbthin_Crust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbthin_Crust.ForeColor = System.Drawing.Color.Yellow;
            this.rdbthin_Crust.Location = new System.Drawing.Point(20, 35);
            this.rdbthin_Crust.Name = "rdbthin_Crust";
            this.rdbthin_Crust.Size = new System.Drawing.Size(123, 26);
            this.rdbthin_Crust.TabIndex = 0;
            this.rdbthin_Crust.TabStop = true;
            this.rdbthin_Crust.Tag = "0";
            this.rdbthin_Crust.Text = "thin_Crust";
            this.rdbthin_Crust.UseVisualStyleBackColor = true;
            this.rdbthin_Crust.CheckedChanged += new System.EventHandler(this.rdbthin_Crust_CheckedChanged);
            // 
            // Pizza_proj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1311, 600);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gpCrustType);
            this.Controls.Add(this.gpOrdersumary);
            this.Controls.Add(this.gpToppings);
            this.Controls.Add(this.gpSize);
            this.Controls.Add(this.gpWhereToEat);
            this.Controls.Add(this.pizzaLable);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Name = "Pizza_proj";
            this.Text = "Pizza_proj";
            this.Load += new System.EventHandler(this.Pizza_proj_Load);
            this.gpSize.ResumeLayout(false);
            this.gpSize.PerformLayout();
            this.gpToppings.ResumeLayout(false);
            this.gpToppings.PerformLayout();
            this.gpOrdersumary.ResumeLayout(false);
            this.gpOrdersumary.PerformLayout();
            this.gpWhereToEat.ResumeLayout(false);
            this.gpWhereToEat.PerformLayout();
            this.gpCrustType.ResumeLayout(false);
            this.gpCrustType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pizzaLable;
        private System.Windows.Forms.GroupBox gpSize;
        private System.Windows.Forms.GroupBox gpToppings;
        private System.Windows.Forms.GroupBox gpOrdersumary;
        private System.Windows.Forms.RadioButton rdblarg;
        private System.Windows.Forms.RadioButton rdbmeduim;
        private System.Windows.Forms.RadioButton rdbsmall;
        private System.Windows.Forms.GroupBox gpWhereToEat;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.RadioButton rdbEAT_OUT;
        private System.Windows.Forms.RadioButton rdbEat_IN;
        private System.Windows.Forms.GroupBox gpCrustType;
        private System.Windows.Forms.RadioButton rdbthink_crust;
        private System.Windows.Forms.RadioButton rdbthin_Crust;
        private System.Windows.Forms.Label lbWheretoeat;
        private System.Windows.Forms.Label lbCrustTypy;
        private System.Windows.Forms.Label lbTopping;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.CheckBox chkgreenpapper;
        private System.Windows.Forms.CheckBox chkolvies;
        private System.Windows.Forms.CheckBox chkonion;
        private System.Windows.Forms.CheckBox chktomatos;
        private System.Windows.Forms.CheckBox chkmashroum;
        private System.Windows.Forms.CheckBox chkextrachees;
        private System.Windows.Forms.Label lblwheretoeat;
        private System.Windows.Forms.Label lblcrustype;
        private System.Windows.Forms.Label lbltoppings;
        private System.Windows.Forms.Label lblsize;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label1;
    }
}

