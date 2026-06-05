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
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSamll = new System.Windows.Forms.RadioButton();
            this.gpCrustType = new System.Windows.Forms.GroupBox();
            this.gbCrustType = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkTomatos = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.gpOrderSummary = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labToppings = new System.Windows.Forms.Label();
            this.labWhereToEat = new System.Windows.Forms.Label();
            this.labCrustType = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lebTotalPriceOrder = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lebSize = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gpCrustType.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gpOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSamll);
            this.gbSize.Location = new System.Drawing.Point(10, 89);
            this.gbSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbSize.Name = "gbSize";
            this.gbSize.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbSize.Size = new System.Drawing.Size(203, 144);
            this.gbSize.TabIndex = 0;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(35, 103);
            this.rbLarge.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(57, 17);
            this.rbLarge.TabIndex = 3;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "40";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(35, 70);
            this.rbMedium.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(68, 17);
            this.rbMedium.TabIndex = 2;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "30";
            this.rbMedium.Text = "Meduim";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbSamll
            // 
            this.rbSamll.AutoSize = true;
            this.rbSamll.Location = new System.Drawing.Point(35, 31);
            this.rbSamll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbSamll.Name = "rbSamll";
            this.rbSamll.Size = new System.Drawing.Size(55, 17);
            this.rbSamll.TabIndex = 1;
            this.rbSamll.TabStop = true;
            this.rbSamll.Tag = "20";
            this.rbSamll.Text = "Small";
            this.rbSamll.UseVisualStyleBackColor = true;
            // 
            // gpCrustType
            // 
            this.gpCrustType.Controls.Add(this.gbCrustType);
            this.gpCrustType.Controls.Add(this.rbThinCrust);
            this.gpCrustType.Location = new System.Drawing.Point(12, 264);
            this.gpCrustType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpCrustType.Name = "gpCrustType";
            this.gpCrustType.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpCrustType.Size = new System.Drawing.Size(203, 144);
            this.gpCrustType.TabIndex = 1;
            this.gpCrustType.TabStop = false;
            this.gpCrustType.Tag = "0";
            this.gpCrustType.Text = "Crust Type";
            // 
            // gbCrustType
            // 
            this.gbCrustType.AutoSize = true;
            this.gbCrustType.Location = new System.Drawing.Point(35, 64);
            this.gbCrustType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(90, 17);
            this.gbCrustType.TabIndex = 2;
            this.gbCrustType.TabStop = true;
            this.gbCrustType.Tag = "10";
            this.gbCrustType.Text = "Think Crust";
            this.gbCrustType.UseVisualStyleBackColor = true;
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Location = new System.Drawing.Point(35, 30);
            this.rbThinCrust.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(83, 17);
            this.rbThinCrust.TabIndex = 1;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Tag = "0";
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Location = new System.Drawing.Point(230, 264);
            this.gbWhereToEat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbWhereToEat.Size = new System.Drawing.Size(290, 81);
            this.gbWhereToEat.TabIndex = 3;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Tag = "0";
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(130, 30);
            this.rbTakeOut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(78, 17);
            this.rbTakeOut.TabIndex = 2;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Location = new System.Drawing.Point(35, 30);
            this.rbEatIn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(59, 17);
            this.rbEatIn.TabIndex = 1;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Location = new System.Drawing.Point(230, 370);
            this.btnOrderPizza.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(106, 38);
            this.btnOrderPizza.TabIndex = 4;
            this.btnOrderPizza.Text = "Oeder Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(414, 370);
            this.btnResetForm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(106, 38);
            this.btnResetForm.TabIndex = 5;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chkGreenPeppers);
            this.gbToppings.Controls.Add(this.chkTomatos);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkMushrooms);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkExtraChees);
            this.gbToppings.Location = new System.Drawing.Point(230, 89);
            this.gbToppings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbToppings.Size = new System.Drawing.Size(290, 144);
            this.gbToppings.TabIndex = 6;
            this.gbToppings.TabStop = false;
            this.gbToppings.Tag = "0";
            this.gbToppings.Text = "Toppings";
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(130, 103);
            this.chkGreenPeppers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(110, 17);
            this.chkGreenPeppers.TabIndex = 5;
            this.chkGreenPeppers.Tag = "5";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            // 
            // chkTomatos
            // 
            this.chkTomatos.AutoSize = true;
            this.chkTomatos.Location = new System.Drawing.Point(20, 103);
            this.chkTomatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkTomatos.Name = "chkTomatos";
            this.chkTomatos.Size = new System.Drawing.Size(74, 17);
            this.chkTomatos.TabIndex = 4;
            this.chkTomatos.Tag = "5";
            this.chkTomatos.Text = "Tomatos";
            this.chkTomatos.UseVisualStyleBackColor = true;
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(130, 70);
            this.chkOlives.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(61, 17);
            this.chkOlives.TabIndex = 3;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(20, 70);
            this.chkMushrooms.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(89, 17);
            this.chkMushrooms.TabIndex = 2;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(130, 32);
            this.chkOnion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(59, 17);
            this.chkOnion.TabIndex = 1;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.Location = new System.Drawing.Point(20, 31);
            this.chkExtraChees.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(94, 17);
            this.chkExtraChees.TabIndex = 0;
            this.chkExtraChees.Tag = "5";
            this.chkExtraChees.Text = "Extra Chees";
            this.chkExtraChees.UseVisualStyleBackColor = true;
            // 
            // gpOrderSummary
            // 
            this.gpOrderSummary.Controls.Add(this.label1);
            this.gpOrderSummary.Controls.Add(this.labToppings);
            this.gpOrderSummary.Controls.Add(this.labWhereToEat);
            this.gpOrderSummary.Controls.Add(this.labCrustType);
            this.gpOrderSummary.Controls.Add(this.lblSize);
            this.gpOrderSummary.Controls.Add(this.lebTotalPriceOrder);
            this.gpOrderSummary.Controls.Add(this.lblTotalPrice);
            this.gpOrderSummary.Controls.Add(this.lblWhereToEat);
            this.gpOrderSummary.Controls.Add(this.lblCrustType);
            this.gpOrderSummary.Controls.Add(this.lblToppings);
            this.gpOrderSummary.Controls.Add(this.lebSize);
            this.gpOrderSummary.Location = new System.Drawing.Point(528, 89);
            this.gpOrderSummary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpOrderSummary.Name = "gpOrderSummary";
            this.gpOrderSummary.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpOrderSummary.Size = new System.Drawing.Size(276, 319);
            this.gpOrderSummary.TabIndex = 7;
            this.gpOrderSummary.TabStop = false;
            this.gpOrderSummary.Text = "Order Summary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(121, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "$";
            // 
            // labToppings
            // 
            this.labToppings.AutoSize = true;
            this.labToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labToppings.ForeColor = System.Drawing.Color.Black;
            this.labToppings.Location = new System.Drawing.Point(77, 103);
            this.labToppings.Name = "labToppings";
            this.labToppings.Size = new System.Drawing.Size(68, 13);
            this.labToppings.TabIndex = 9;
            this.labToppings.Text = "No Toppings";
            // 
            // labWhereToEat
            // 
            this.labWhereToEat.AutoSize = true;
            this.labWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWhereToEat.ForeColor = System.Drawing.Color.Black;
            this.labWhereToEat.Location = new System.Drawing.Point(142, 178);
            this.labWhereToEat.Name = "labWhereToEat";
            this.labWhereToEat.Size = new System.Drawing.Size(21, 13);
            this.labWhereToEat.TabIndex = 8;
            this.labWhereToEat.Text = "No";
            // 
            // labCrustType
            // 
            this.labCrustType.AutoSize = true;
            this.labCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCrustType.ForeColor = System.Drawing.Color.Black;
            this.labCrustType.Location = new System.Drawing.Point(123, 153);
            this.labCrustType.Name = "labCrustType";
            this.labCrustType.Size = new System.Drawing.Size(21, 13);
            this.labCrustType.TabIndex = 7;
            this.labCrustType.Text = "No";
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
            // lebTotalPriceOrder
            // 
            this.lebTotalPriceOrder.AutoSize = true;
            this.lebTotalPriceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lebTotalPriceOrder.ForeColor = System.Drawing.Color.Green;
            this.lebTotalPriceOrder.Location = new System.Drawing.Point(139, 240);
            this.lebTotalPriceOrder.Name = "lebTotalPriceOrder";
            this.lebTotalPriceOrder.Size = new System.Drawing.Size(30, 31);
            this.lebTotalPriceOrder.TabIndex = 5;
            this.lebTotalPriceOrder.Text = "$";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(34, 224);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(91, 16);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "Total Price: ";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereToEat.Location = new System.Drawing.Point(34, 175);
            this.lblWhereToEat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(110, 16);
            this.lblWhereToEat.TabIndex = 3;
            this.lblWhereToEat.Text = "Where To Eat: ";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.Location = new System.Drawing.Point(34, 149);
            this.lblCrustType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(90, 16);
            this.lblCrustType.TabIndex = 2;
            this.lblCrustType.Text = "Crust Type: ";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(34, 69);
            this.lblToppings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(81, 16);
            this.lblToppings.TabIndex = 1;
            this.lblToppings.Text = "Toppings: ";
            // 
            // lebSize
            // 
            this.lebSize.AutoSize = true;
            this.lebSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lebSize.Location = new System.Drawing.Point(34, 33);
            this.lebSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lebSize.Name = "lebSize";
            this.lebSize.Size = new System.Drawing.Size(45, 16);
            this.lebSize.TabIndex = 0;
            this.lebSize.Text = "Size: ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cascadia Code", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(222, 19);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(335, 46);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "MAKE YOUR PIZZA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gpOrderSummary);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gpCrustType);
            this.Controls.Add(this.gbSize);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gpCrustType.ResumeLayout(false);
            this.gpCrustType.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gpOrderSummary.ResumeLayout(false);
            this.gpOrderSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbSamll;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.GroupBox gpCrustType;
        private System.Windows.Forms.RadioButton gbCrustType;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkTomatos;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.GroupBox gpOrderSummary;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lebSize;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lebTotalPriceOrder;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label labCrustType;
        private System.Windows.Forms.Label labWhereToEat;
        private System.Windows.Forms.Label labToppings;
        private System.Windows.Forms.Label label1;
    }
}

