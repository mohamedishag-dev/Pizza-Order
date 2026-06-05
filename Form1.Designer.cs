namespace Pizza
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lebel1 = new System.Windows.Forms.Label();
            this.lebel4 = new System.Windows.Forms.Label();
            this.lebel3 = new System.Windows.Forms.Label();
            this.lebel = new System.Windows.Forms.Label();
            this.gpOrderSummary = new System.Windows.Forms.GroupBox();
            this.ledel2 = new System.Windows.Forms.Label();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkTomatos = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.gbCrustType = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.gpCrustType = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSamll = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.gpOrderSummary.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gpCrustType.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cascadia Code", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(215, 31);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(335, 46);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "MAKE YOUR PIZZA";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.ForeColor = System.Drawing.Color.Black;
            this.lblToppings.Location = new System.Drawing.Point(77, 103);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(68, 13);
            this.lblToppings.TabIndex = 9;
            this.lblToppings.Text = "No Toppings";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereToEat.ForeColor = System.Drawing.Color.Black;
            this.lblWhereToEat.Location = new System.Drawing.Point(142, 178);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(21, 13);
            this.lblWhereToEat.TabIndex = 8;
            this.lblWhereToEat.Text = "No";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.ForeColor = System.Drawing.Color.Black;
            this.lblCrustType.Location = new System.Drawing.Point(123, 153);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(21, 13);
            this.lblCrustType.TabIndex = 7;
            this.lblCrustType.Text = "No";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.Black;
            this.lblSize.Location = new System.Drawing.Point(77, 36);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(21, 13);
            this.lblSize.TabIndex = 6;
            this.lblSize.Text = "No";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Green;
            this.lblTotalPrice.Location = new System.Drawing.Point(115, 240);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(46, 31);
            this.lblTotalPrice.TabIndex = 5;
            this.lblTotalPrice.Text = "$0";
            // 
            // lebel1
            // 
            this.lebel1.AutoSize = true;
            this.lebel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lebel1.Location = new System.Drawing.Point(34, 224);
            this.lebel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lebel1.Name = "lebel1";
            this.lebel1.Size = new System.Drawing.Size(91, 16);
            this.lebel1.TabIndex = 4;
            this.lebel1.Text = "Total Price: ";
            // 
            // lebel4
            // 
            this.lebel4.AutoSize = true;
            this.lebel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lebel4.Location = new System.Drawing.Point(34, 178);
            this.lebel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lebel4.Name = "lebel4";
            this.lebel4.Size = new System.Drawing.Size(110, 16);
            this.lebel4.TabIndex = 3;
            this.lebel4.Text = "Where To Eat: ";
            // 
            // lebel3
            // 
            this.lebel3.AutoSize = true;
            this.lebel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lebel3.Location = new System.Drawing.Point(34, 149);
            this.lebel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lebel3.Name = "lebel3";
            this.lebel3.Size = new System.Drawing.Size(90, 16);
            this.lebel3.TabIndex = 2;
            this.lebel3.Text = "Crust Type: ";
            // 
            // lebel
            // 
            this.lebel.AutoSize = true;
            this.lebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lebel.Location = new System.Drawing.Point(34, 69);
            this.lebel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lebel.Name = "lebel";
            this.lebel.Size = new System.Drawing.Size(81, 16);
            this.lebel.TabIndex = 1;
            this.lebel.Text = "Toppings: ";
            // 
            // gpOrderSummary
            // 
            this.gpOrderSummary.Controls.Add(this.lblToppings);
            this.gpOrderSummary.Controls.Add(this.lblWhereToEat);
            this.gpOrderSummary.Controls.Add(this.lblCrustType);
            this.gpOrderSummary.Controls.Add(this.lblSize);
            this.gpOrderSummary.Controls.Add(this.lblTotalPrice);
            this.gpOrderSummary.Controls.Add(this.lebel1);
            this.gpOrderSummary.Controls.Add(this.lebel4);
            this.gpOrderSummary.Controls.Add(this.lebel3);
            this.gpOrderSummary.Controls.Add(this.lebel);
            this.gpOrderSummary.Controls.Add(this.ledel2);
            this.gpOrderSummary.Location = new System.Drawing.Point(521, 101);
            this.gpOrderSummary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpOrderSummary.Name = "gpOrderSummary";
            this.gpOrderSummary.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpOrderSummary.Size = new System.Drawing.Size(276, 319);
            this.gpOrderSummary.TabIndex = 15;
            this.gpOrderSummary.TabStop = false;
            this.gpOrderSummary.Text = "Order Summary";
            // 
            // ledel2
            // 
            this.ledel2.AutoSize = true;
            this.ledel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ledel2.Location = new System.Drawing.Point(34, 33);
            this.ledel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ledel2.Name = "ledel2";
            this.ledel2.Size = new System.Drawing.Size(45, 16);
            this.ledel2.TabIndex = 0;
            this.ledel2.Text = "Size: ";
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(130, 103);
            this.chkGreenPeppers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(97, 17);
            this.chkGreenPeppers.TabIndex = 5;
            this.chkGreenPeppers.Tag = "5";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkTomatos
            // 
            this.chkTomatos.AutoSize = true;
            this.chkTomatos.Location = new System.Drawing.Point(20, 103);
            this.chkTomatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkTomatos.Name = "chkTomatos";
            this.chkTomatos.Size = new System.Drawing.Size(67, 17);
            this.chkTomatos.TabIndex = 4;
            this.chkTomatos.Tag = "5";
            this.chkTomatos.Text = "Tomatos";
            this.chkTomatos.UseVisualStyleBackColor = true;
            this.chkTomatos.CheckedChanged += new System.EventHandler(this.chkTomatos_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(130, 70);
            this.chkOlives.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(55, 17);
            this.chkOlives.TabIndex = 3;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(20, 70);
            this.chkMushrooms.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(80, 17);
            this.chkMushrooms.TabIndex = 2;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(130, 32);
            this.chkOnion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(54, 17);
            this.chkOnion.TabIndex = 1;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.Location = new System.Drawing.Point(20, 31);
            this.chkExtraChees.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(83, 17);
            this.chkExtraChees.TabIndex = 0;
            this.chkExtraChees.Tag = "5";
            this.chkExtraChees.Text = "Extra Chees";
            this.chkExtraChees.UseVisualStyleBackColor = true;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.chkExtraChees_CheckedChanged);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(407, 382);
            this.btnResetForm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(106, 38);
            this.btnResetForm.TabIndex = 13;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Location = new System.Drawing.Point(223, 382);
            this.btnOrderPizza.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(106, 38);
            this.btnOrderPizza.TabIndex = 12;
            this.btnOrderPizza.Text = "Oeder Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click_1);
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(130, 30);
            this.rbTakeOut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(70, 17);
            this.rbTakeOut.TabIndex = 2;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Location = new System.Drawing.Point(35, 30);
            this.rbEatIn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(53, 17);
            this.rbEatIn.TabIndex = 1;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Location = new System.Drawing.Point(223, 276);
            this.gbWhereToEat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbWhereToEat.Size = new System.Drawing.Size(290, 81);
            this.gbWhereToEat.TabIndex = 11;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Tag = "0";
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // gbCrustType
            // 
            this.gbCrustType.AutoSize = true;
            this.gbCrustType.Location = new System.Drawing.Point(35, 64);
            this.gbCrustType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(79, 17);
            this.gbCrustType.TabIndex = 2;
            this.gbCrustType.TabStop = true;
            this.gbCrustType.Tag = "10";
            this.gbCrustType.Text = "Think Crust";
            this.gbCrustType.UseVisualStyleBackColor = true;
            this.gbCrustType.CheckedChanged += new System.EventHandler(this.gbCrustType_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Location = new System.Drawing.Point(35, 30);
            this.rbThinCrust.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(73, 17);
            this.rbThinCrust.TabIndex = 1;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Tag = "0";
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // gpCrustType
            // 
            this.gpCrustType.Controls.Add(this.gbCrustType);
            this.gpCrustType.Controls.Add(this.rbThinCrust);
            this.gpCrustType.Location = new System.Drawing.Point(5, 276);
            this.gpCrustType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpCrustType.Name = "gpCrustType";
            this.gpCrustType.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpCrustType.Size = new System.Drawing.Size(203, 144);
            this.gpCrustType.TabIndex = 10;
            this.gpCrustType.TabStop = false;
            this.gpCrustType.Tag = "0";
            this.gpCrustType.Text = "Crust Type";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(35, 103);
            this.rbLarge.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(52, 17);
            this.rbLarge.TabIndex = 3;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "40";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(35, 70);
            this.rbMedium.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(62, 17);
            this.rbMedium.TabIndex = 2;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "30";
            this.rbMedium.Text = "Meduim";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSamll
            // 
            this.rbSamll.AutoSize = true;
            this.rbSamll.Location = new System.Drawing.Point(35, 31);
            this.rbSamll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbSamll.Name = "rbSamll";
            this.rbSamll.Size = new System.Drawing.Size(50, 17);
            this.rbSamll.TabIndex = 1;
            this.rbSamll.TabStop = true;
            this.rbSamll.Tag = "20";
            this.rbSamll.Text = "Small";
            this.rbSamll.UseVisualStyleBackColor = true;
            this.rbSamll.CheckedChanged += new System.EventHandler(this.rbSamll_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chkGreenPeppers);
            this.gbToppings.Controls.Add(this.chkTomatos);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkMushrooms);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkExtraChees);
            this.gbToppings.Location = new System.Drawing.Point(223, 101);
            this.gbToppings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbToppings.Size = new System.Drawing.Size(290, 144);
            this.gbToppings.TabIndex = 14;
            this.gbToppings.TabStop = false;
            this.gbToppings.Tag = "0";
            this.gbToppings.Text = "Toppings";
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSamll);
            this.gbSize.Location = new System.Drawing.Point(3, 101);
            this.gbSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbSize.Name = "gbSize";
            this.gbSize.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbSize.Size = new System.Drawing.Size(203, 144);
            this.gbSize.TabIndex = 9;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gpOrderSummary);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gpCrustType);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbSize);
            this.Name = "Form1";
            this.Text = "Pizza";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpOrderSummary.ResumeLayout(false);
            this.gpOrderSummary.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gpCrustType.ResumeLayout(false);
            this.gpCrustType.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lebel1;
        private System.Windows.Forms.Label lebel4;
        private System.Windows.Forms.Label lebel3;
        private System.Windows.Forms.Label lebel;
        private System.Windows.Forms.GroupBox gpOrderSummary;
        private System.Windows.Forms.Label ledel2;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkTomatos;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton gbCrustType;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.GroupBox gpCrustType;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSamll;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.GroupBox gbSize;
    }
}

