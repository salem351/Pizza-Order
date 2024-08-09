namespace PizzaProject
{
    partial class PizzaOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaOrder));
            this.label1 = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rdLarge_Sz = new System.Windows.Forms.RadioButton();
            this.rdMedium_Sz = new System.Windows.Forms.RadioButton();
            this.rdSmall_Sz = new System.Windows.Forms.RadioButton();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rdThickCrust = new System.Windows.Forms.RadioButton();
            this.rdThinCrust = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.ckGreenPapers_Tp = new System.Windows.Forms.CheckBox();
            this.ckOlives_Tp = new System.Windows.Forms.CheckBox();
            this.ckOnine_Tp = new System.Windows.Forms.CheckBox();
            this.ckTomatoes_Tp = new System.Windows.Forms.CheckBox();
            this.ckMushrooms_Tp = new System.Windows.Forms.CheckBox();
            this.ckExtraChees_Tp = new System.Windows.Forms.CheckBox();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rdTakeOff_WTE = new System.Windows.Forms.RadioButton();
            this.rdEatin_WTE = new System.Windows.Forms.RadioButton();
            this.btn_OrderPizza = new System.Windows.Forms.Button();
            this.btn_ResetForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labSize = new System.Windows.Forms.Label();
            this.labCrustType = new System.Windows.Forms.Label();
            this.labWhereToEat = new System.Windows.Forms.Label();
            this.labTopping = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(839, 103);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Your Pizza";
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.Transparent;
            this.gbSize.Controls.Add(this.rdLarge_Sz);
            this.gbSize.Controls.Add(this.rdMedium_Sz);
            this.gbSize.Controls.Add(this.rdSmall_Sz);
            this.gbSize.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.ForeColor = System.Drawing.Color.White;
            this.gbSize.Location = new System.Drawing.Point(359, 115);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(124, 264);
            this.gbSize.TabIndex = 0;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rdLarge_Sz
            // 
            this.rdLarge_Sz.AutoSize = true;
            this.rdLarge_Sz.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdLarge_Sz.ForeColor = System.Drawing.Color.White;
            this.rdLarge_Sz.Location = new System.Drawing.Point(16, 204);
            this.rdLarge_Sz.Name = "rdLarge_Sz";
            this.rdLarge_Sz.Size = new System.Drawing.Size(89, 32);
            this.rdLarge_Sz.TabIndex = 2;
            this.rdLarge_Sz.Tag = "15";
            this.rdLarge_Sz.Text = "Large";
            this.rdLarge_Sz.UseVisualStyleBackColor = true;
            this.rdLarge_Sz.CheckedChanged += new System.EventHandler(this.rdLarge_Sz_CheckedChanged);
            // 
            // rdMedium_Sz
            // 
            this.rdMedium_Sz.AutoSize = true;
            this.rdMedium_Sz.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMedium_Sz.ForeColor = System.Drawing.Color.White;
            this.rdMedium_Sz.Location = new System.Drawing.Point(16, 124);
            this.rdMedium_Sz.Name = "rdMedium_Sz";
            this.rdMedium_Sz.Size = new System.Drawing.Size(113, 32);
            this.rdMedium_Sz.TabIndex = 0;
            this.rdMedium_Sz.Tag = "10";
            this.rdMedium_Sz.Text = "Medium";
            this.rdMedium_Sz.UseVisualStyleBackColor = true;
            this.rdMedium_Sz.CheckedChanged += new System.EventHandler(this.rdMedium_Sz_CheckedChanged);
            // 
            // rdSmall_Sz
            // 
            this.rdSmall_Sz.AutoSize = true;
            this.rdSmall_Sz.Checked = true;
            this.rdSmall_Sz.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSmall_Sz.ForeColor = System.Drawing.Color.White;
            this.rdSmall_Sz.Location = new System.Drawing.Point(16, 44);
            this.rdSmall_Sz.Name = "rdSmall_Sz";
            this.rdSmall_Sz.Size = new System.Drawing.Size(87, 32);
            this.rdSmall_Sz.TabIndex = 1;
            this.rdSmall_Sz.TabStop = true;
            this.rdSmall_Sz.Tag = "5";
            this.rdSmall_Sz.Text = "Small";
            this.rdSmall_Sz.UseVisualStyleBackColor = true;
            this.rdSmall_Sz.CheckedChanged += new System.EventHandler(this.rdSmall_Sz_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.BackColor = System.Drawing.Color.Transparent;
            this.gbCrustType.Controls.Add(this.rdThickCrust);
            this.gbCrustType.Controls.Add(this.rdThinCrust);
            this.gbCrustType.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrustType.ForeColor = System.Drawing.Color.White;
            this.gbCrustType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbCrustType.Location = new System.Drawing.Point(345, 389);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(162, 186);
            this.gbCrustType.TabIndex = 1;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // rdThickCrust
            // 
            this.rdThickCrust.AutoSize = true;
            this.rdThickCrust.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdThickCrust.ForeColor = System.Drawing.Color.White;
            this.rdThickCrust.Location = new System.Drawing.Point(16, 124);
            this.rdThickCrust.Name = "rdThickCrust";
            this.rdThickCrust.Size = new System.Drawing.Size(146, 32);
            this.rdThickCrust.TabIndex = 1;
            this.rdThickCrust.Tag = "10";
            this.rdThickCrust.Text = "Thick Crust";
            this.rdThickCrust.UseVisualStyleBackColor = true;
            this.rdThickCrust.CheckedChanged += new System.EventHandler(this.rdThickCrust_CheckedChanged);
            // 
            // rdThinCrust
            // 
            this.rdThinCrust.AutoSize = true;
            this.rdThinCrust.Checked = true;
            this.rdThinCrust.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdThinCrust.ForeColor = System.Drawing.Color.White;
            this.rdThinCrust.Location = new System.Drawing.Point(16, 44);
            this.rdThinCrust.Name = "rdThinCrust";
            this.rdThinCrust.Size = new System.Drawing.Size(137, 32);
            this.rdThinCrust.TabIndex = 0;
            this.rdThinCrust.TabStop = true;
            this.rdThinCrust.Tag = "0";
            this.rdThinCrust.Text = "Thin Crust";
            this.rdThinCrust.UseVisualStyleBackColor = true;
            this.rdThinCrust.CheckedChanged += new System.EventHandler(this.rdThinCrust_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.BackColor = System.Drawing.Color.Transparent;
            this.gbToppings.Controls.Add(this.ckGreenPapers_Tp);
            this.gbToppings.Controls.Add(this.ckOlives_Tp);
            this.gbToppings.Controls.Add(this.ckOnine_Tp);
            this.gbToppings.Controls.Add(this.ckTomatoes_Tp);
            this.gbToppings.Controls.Add(this.ckMushrooms_Tp);
            this.gbToppings.Controls.Add(this.ckExtraChees_Tp);
            this.gbToppings.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.ForeColor = System.Drawing.Color.White;
            this.gbToppings.Location = new System.Drawing.Point(494, 115);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(480, 219);
            this.gbToppings.TabIndex = 3;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // ckGreenPapers_Tp
            // 
            this.ckGreenPapers_Tp.AutoSize = true;
            this.ckGreenPapers_Tp.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckGreenPapers_Tp.ForeColor = System.Drawing.Color.White;
            this.ckGreenPapers_Tp.Location = new System.Drawing.Point(310, 167);
            this.ckGreenPapers_Tp.Name = "ckGreenPapers_Tp";
            this.ckGreenPapers_Tp.Size = new System.Drawing.Size(169, 32);
            this.ckGreenPapers_Tp.TabIndex = 5;
            this.ckGreenPapers_Tp.Tag = "1";
            this.ckGreenPapers_Tp.Text = "Green Papers";
            this.ckGreenPapers_Tp.UseVisualStyleBackColor = true;
            this.ckGreenPapers_Tp.CheckedChanged += new System.EventHandler(this.ckGreenPapers_Tp_CheckedChanged);
            // 
            // ckOlives_Tp
            // 
            this.ckOlives_Tp.AutoSize = true;
            this.ckOlives_Tp.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckOlives_Tp.ForeColor = System.Drawing.Color.White;
            this.ckOlives_Tp.Location = new System.Drawing.Point(310, 105);
            this.ckOlives_Tp.Name = "ckOlives_Tp";
            this.ckOlives_Tp.Size = new System.Drawing.Size(93, 32);
            this.ckOlives_Tp.TabIndex = 4;
            this.ckOlives_Tp.Tag = "1";
            this.ckOlives_Tp.Text = "Olives";
            this.ckOlives_Tp.UseVisualStyleBackColor = true;
            this.ckOlives_Tp.CheckedChanged += new System.EventHandler(this.ckOlives_Tp_CheckedChanged);
            // 
            // ckOnine_Tp
            // 
            this.ckOnine_Tp.AutoSize = true;
            this.ckOnine_Tp.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckOnine_Tp.ForeColor = System.Drawing.Color.White;
            this.ckOnine_Tp.Location = new System.Drawing.Point(310, 44);
            this.ckOnine_Tp.Name = "ckOnine_Tp";
            this.ckOnine_Tp.Size = new System.Drawing.Size(93, 32);
            this.ckOnine_Tp.TabIndex = 3;
            this.ckOnine_Tp.Tag = "1";
            this.ckOnine_Tp.Text = "Onine";
            this.ckOnine_Tp.CheckedChanged += new System.EventHandler(this.ckOnine_Tp_CheckedChanged);
            // 
            // ckTomatoes_Tp
            // 
            this.ckTomatoes_Tp.AutoSize = true;
            this.ckTomatoes_Tp.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckTomatoes_Tp.ForeColor = System.Drawing.Color.White;
            this.ckTomatoes_Tp.Location = new System.Drawing.Point(46, 167);
            this.ckTomatoes_Tp.Name = "ckTomatoes_Tp";
            this.ckTomatoes_Tp.Size = new System.Drawing.Size(132, 32);
            this.ckTomatoes_Tp.TabIndex = 2;
            this.ckTomatoes_Tp.Tag = "1";
            this.ckTomatoes_Tp.Text = "Tomatoes";
            this.ckTomatoes_Tp.UseVisualStyleBackColor = true;
            this.ckTomatoes_Tp.CheckedChanged += new System.EventHandler(this.ckTomatoes_Tp_CheckedChanged);
            // 
            // ckMushrooms_Tp
            // 
            this.ckMushrooms_Tp.AutoSize = true;
            this.ckMushrooms_Tp.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckMushrooms_Tp.ForeColor = System.Drawing.Color.White;
            this.ckMushrooms_Tp.Location = new System.Drawing.Point(46, 105);
            this.ckMushrooms_Tp.Name = "ckMushrooms_Tp";
            this.ckMushrooms_Tp.Size = new System.Drawing.Size(149, 32);
            this.ckMushrooms_Tp.TabIndex = 1;
            this.ckMushrooms_Tp.Tag = "2";
            this.ckMushrooms_Tp.Text = "Mushrooms";
            this.ckMushrooms_Tp.UseVisualStyleBackColor = true;
            this.ckMushrooms_Tp.CheckedChanged += new System.EventHandler(this.ckMushrooms_Tp_CheckedChanged);
            // 
            // ckExtraChees_Tp
            // 
            this.ckExtraChees_Tp.AutoSize = true;
            this.ckExtraChees_Tp.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckExtraChees_Tp.ForeColor = System.Drawing.Color.White;
            this.ckExtraChees_Tp.Location = new System.Drawing.Point(46, 43);
            this.ckExtraChees_Tp.Name = "ckExtraChees_Tp";
            this.ckExtraChees_Tp.Size = new System.Drawing.Size(154, 32);
            this.ckExtraChees_Tp.TabIndex = 0;
            this.ckExtraChees_Tp.Tag = "1";
            this.ckExtraChees_Tp.Text = "Extra Chees";
            this.ckExtraChees_Tp.UseVisualStyleBackColor = true;
            this.ckExtraChees_Tp.CheckedChanged += new System.EventHandler(this.ckExtraChees_Tp_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.gbWhereToEat.Controls.Add(this.rdTakeOff_WTE);
            this.gbWhereToEat.Controls.Add(this.rdEatin_WTE);
            this.gbWhereToEat.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWhereToEat.ForeColor = System.Drawing.Color.White;
            this.gbWhereToEat.Location = new System.Drawing.Point(523, 347);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(461, 100);
            this.gbWhereToEat.TabIndex = 4;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rdTakeOff_WTE
            // 
            this.rdTakeOff_WTE.AutoSize = true;
            this.rdTakeOff_WTE.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTakeOff_WTE.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdTakeOff_WTE.Location = new System.Drawing.Point(263, 44);
            this.rdTakeOff_WTE.Name = "rdTakeOff_WTE";
            this.rdTakeOff_WTE.Size = new System.Drawing.Size(118, 32);
            this.rdTakeOff_WTE.TabIndex = 1;
            this.rdTakeOff_WTE.Text = "Take Off";
            this.rdTakeOff_WTE.UseVisualStyleBackColor = true;
            this.rdTakeOff_WTE.CheckedChanged += new System.EventHandler(this.rdTakeOff_WTE_CheckedChanged);
            // 
            // rdEatin_WTE
            // 
            this.rdEatin_WTE.AutoSize = true;
            this.rdEatin_WTE.Checked = true;
            this.rdEatin_WTE.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdEatin_WTE.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdEatin_WTE.Location = new System.Drawing.Point(16, 44);
            this.rdEatin_WTE.Name = "rdEatin_WTE";
            this.rdEatin_WTE.Size = new System.Drawing.Size(91, 32);
            this.rdEatin_WTE.TabIndex = 0;
            this.rdEatin_WTE.TabStop = true;
            this.rdEatin_WTE.Text = "Eat in";
            this.rdEatin_WTE.UseVisualStyleBackColor = true;
            this.rdEatin_WTE.CheckedChanged += new System.EventHandler(this.rdEatin_WTE_CheckedChanged);
            // 
            // btn_OrderPizza
            // 
            this.btn_OrderPizza.BackColor = System.Drawing.Color.Lime;
            this.btn_OrderPizza.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OrderPizza.ForeColor = System.Drawing.Color.Black;
            this.btn_OrderPizza.Location = new System.Drawing.Point(539, 466);
            this.btn_OrderPizza.Name = "btn_OrderPizza";
            this.btn_OrderPizza.Size = new System.Drawing.Size(191, 62);
            this.btn_OrderPizza.TabIndex = 5;
            this.btn_OrderPizza.Text = "Order Pizza";
            this.btn_OrderPizza.UseVisualStyleBackColor = false;
            this.btn_OrderPizza.Click += new System.EventHandler(this.OrderPizza_Click);
            // 
            // btn_ResetForm
            // 
            this.btn_ResetForm.BackColor = System.Drawing.Color.Red;
            this.btn_ResetForm.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetForm.ForeColor = System.Drawing.Color.Black;
            this.btn_ResetForm.Location = new System.Drawing.Point(786, 466);
            this.btn_ResetForm.Name = "btn_ResetForm";
            this.btn_ResetForm.Size = new System.Drawing.Size(191, 62);
            this.btn_ResetForm.TabIndex = 6;
            this.btn_ResetForm.Text = "Reset Form";
            this.btn_ResetForm.UseVisualStyleBackColor = false;
            this.btn_ResetForm.Click += new System.EventHandler(this.ResetForm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Limelight", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(998, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 34);
            this.label2.TabIndex = 8;
            this.label2.Text = "Order Summary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(998, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Size : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(999, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Topping : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(998, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Crust Type : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(998, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Where to Eat : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(999, 486);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 28);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total Price : ";
            // 
            // labSize
            // 
            this.labSize.AutoSize = true;
            this.labSize.BackColor = System.Drawing.Color.Transparent;
            this.labSize.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSize.ForeColor = System.Drawing.Color.White;
            this.labSize.Location = new System.Drawing.Point(1070, 168);
            this.labSize.Name = "labSize";
            this.labSize.Size = new System.Drawing.Size(95, 28);
            this.labSize.TabIndex = 14;
            this.labSize.Text = "lab_Size";
            // 
            // labCrustType
            // 
            this.labCrustType.AutoSize = true;
            this.labCrustType.BackColor = System.Drawing.Color.Transparent;
            this.labCrustType.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCrustType.ForeColor = System.Drawing.Color.White;
            this.labCrustType.Location = new System.Drawing.Point(1147, 363);
            this.labCrustType.Name = "labCrustType";
            this.labCrustType.Size = new System.Drawing.Size(108, 28);
            this.labCrustType.TabIndex = 15;
            this.labCrustType.Text = "lab_Crust";
            // 
            // labWhereToEat
            // 
            this.labWhereToEat.AutoSize = true;
            this.labWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.labWhereToEat.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWhereToEat.ForeColor = System.Drawing.Color.White;
            this.labWhereToEat.Location = new System.Drawing.Point(1172, 422);
            this.labWhereToEat.Name = "labWhereToEat";
            this.labWhereToEat.Size = new System.Drawing.Size(88, 28);
            this.labWhereToEat.TabIndex = 16;
            this.labWhereToEat.Text = "lab_Eat";
            // 
            // labTopping
            // 
            this.labTopping.AutoSize = true;
            this.labTopping.BackColor = System.Drawing.Color.Transparent;
            this.labTopping.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTopping.ForeColor = System.Drawing.Color.White;
            this.labTopping.Location = new System.Drawing.Point(1012, 262);
            this.labTopping.Name = "labTopping";
            this.labTopping.Size = new System.Drawing.Size(137, 28);
            this.labTopping.TabIndex = 17;
            this.labTopping.Text = "lab_Topping";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.BackColor = System.Drawing.Color.Transparent;
            this.Price.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Price.Location = new System.Drawing.Point(1133, 521);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(99, 57);
            this.Price.TabIndex = 18;
            this.Price.Text = "$ 0";
            // 
            // PizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1335, 609);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.labTopping);
            this.Controls.Add(this.labWhereToEat);
            this.Controls.Add(this.labCrustType);
            this.Controls.Add(this.labSize);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ResetForm);
            this.Controls.Add(this.btn_OrderPizza);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.label1);
            this.Name = "PizzaOrder";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.PizzaOrder_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rdLarge_Sz;
        private System.Windows.Forms.RadioButton rdMedium_Sz;
        private System.Windows.Forms.RadioButton rdSmall_Sz;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton rdThickCrust;
        private System.Windows.Forms.RadioButton rdThinCrust;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox ckOnine_Tp;
        private System.Windows.Forms.CheckBox ckTomatoes_Tp;
        private System.Windows.Forms.CheckBox ckMushrooms_Tp;
        private System.Windows.Forms.CheckBox ckExtraChees_Tp;
        private System.Windows.Forms.CheckBox ckGreenPapers_Tp;
        private System.Windows.Forms.CheckBox ckOlives_Tp;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rdTakeOff_WTE;
        private System.Windows.Forms.RadioButton rdEatin_WTE;
        private System.Windows.Forms.Button btn_OrderPizza;
        private System.Windows.Forms.Button btn_ResetForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labSize;
        private System.Windows.Forms.Label labCrustType;
        private System.Windows.Forms.Label labWhereToEat;
        private System.Windows.Forms.Label labTopping;
        private System.Windows.Forms.Label Price;
    }
}

