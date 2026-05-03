namespace PizzaApplication
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
            this.laTitleText = new System.Windows.Forms.Label();
            this.grSize = new System.Windows.Forms.GroupBox();
            this.radLarge = new System.Windows.Forms.RadioButton();
            this.radMedium = new System.Windows.Forms.RadioButton();
            this.radSmall = new System.Windows.Forms.RadioButton();
            this.grCrustType = new System.Windows.Forms.GroupBox();
            this.radThikCrust = new System.Windows.Forms.RadioButton();
            this.radThinCrust = new System.Windows.Forms.RadioButton();
            this.graToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.graWhrerYouEat = new System.Windows.Forms.GroupBox();
            this.radEatIn = new System.Windows.Forms.RadioButton();
            this.radTakeOut = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butOrderPizza = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.laSize = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.laToppings = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.laWhere = new System.Windows.Forms.Label();
            this.laWhereYouEat = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            this.laTotalPrice = new System.Windows.Forms.Label();
            this.laCrust = new System.Windows.Forms.Label();
            this.grSize.SuspendLayout();
            this.grCrustType.SuspendLayout();
            this.graToppings.SuspendLayout();
            this.graWhrerYouEat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // laTitleText
            // 
            this.laTitleText.AutoSize = true;
            this.laTitleText.Font = new System.Drawing.Font("Microsoft Uighur", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.laTitleText.ForeColor = System.Drawing.Color.Red;
            this.laTitleText.Location = new System.Drawing.Point(285, 9);
            this.laTitleText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laTitleText.Name = "laTitleText";
            this.laTitleText.Size = new System.Drawing.Size(423, 72);
            this.laTitleText.TabIndex = 0;
            this.laTitleText.Text = "MAKE YOUR PIZZA";
            // 
            // grSize
            // 
            this.grSize.Controls.Add(this.radLarge);
            this.grSize.Controls.Add(this.radMedium);
            this.grSize.Controls.Add(this.radSmall);
            this.grSize.Location = new System.Drawing.Point(25, 96);
            this.grSize.Name = "grSize";
            this.grSize.Size = new System.Drawing.Size(227, 129);
            this.grSize.TabIndex = 1;
            this.grSize.TabStop = false;
            this.grSize.Text = "Size";
            // 
            // radLarge
            // 
            this.radLarge.AutoSize = true;
            this.radLarge.Location = new System.Drawing.Point(7, 86);
            this.radLarge.Name = "radLarge";
            this.radLarge.Size = new System.Drawing.Size(78, 24);
            this.radLarge.TabIndex = 4;
            this.radLarge.TabStop = true;
            this.radLarge.Tag = "30";
            this.radLarge.Text = "Large";
            this.radLarge.UseVisualStyleBackColor = true;
            this.radLarge.CheckedChanged += new System.EventHandler(this.radLarge_CheckedChanged);
            // 
            // radMedium
            // 
            this.radMedium.AutoSize = true;
            this.radMedium.Location = new System.Drawing.Point(7, 56);
            this.radMedium.Name = "radMedium";
            this.radMedium.Size = new System.Drawing.Size(95, 24);
            this.radMedium.TabIndex = 3;
            this.radMedium.TabStop = true;
            this.radMedium.Tag = "20";
            this.radMedium.Text = "Medium";
            this.radMedium.UseVisualStyleBackColor = true;
            this.radMedium.CheckedChanged += new System.EventHandler(this.radMedium_CheckedChanged);
            // 
            // radSmall
            // 
            this.radSmall.AutoSize = true;
            this.radSmall.Location = new System.Drawing.Point(7, 26);
            this.radSmall.Name = "radSmall";
            this.radSmall.Size = new System.Drawing.Size(77, 24);
            this.radSmall.TabIndex = 2;
            this.radSmall.TabStop = true;
            this.radSmall.Tag = "10";
            this.radSmall.Text = "Small";
            this.radSmall.UseVisualStyleBackColor = true;
            this.radSmall.CheckedChanged += new System.EventHandler(this.radSmall_CheckedChanged);
            // 
            // grCrustType
            // 
            this.grCrustType.Controls.Add(this.radThikCrust);
            this.grCrustType.Controls.Add(this.radThinCrust);
            this.grCrustType.Location = new System.Drawing.Point(32, 343);
            this.grCrustType.Name = "grCrustType";
            this.grCrustType.Size = new System.Drawing.Size(220, 104);
            this.grCrustType.TabIndex = 5;
            this.grCrustType.TabStop = false;
            this.grCrustType.Text = "Crust Type";
            // 
            // radThikCrust
            // 
            this.radThikCrust.AutoSize = true;
            this.radThikCrust.Location = new System.Drawing.Point(7, 56);
            this.radThikCrust.Name = "radThikCrust";
            this.radThikCrust.Size = new System.Drawing.Size(117, 24);
            this.radThikCrust.TabIndex = 3;
            this.radThikCrust.Tag = "10";
            this.radThikCrust.Text = "Thik Crust";
            this.radThikCrust.UseVisualStyleBackColor = true;
            this.radThikCrust.CheckedChanged += new System.EventHandler(this.radThikCrust_CheckedChanged);
            // 
            // radThinCrust
            // 
            this.radThinCrust.AutoSize = true;
            this.radThinCrust.Checked = true;
            this.radThinCrust.Location = new System.Drawing.Point(7, 26);
            this.radThinCrust.Name = "radThinCrust";
            this.radThinCrust.Size = new System.Drawing.Size(118, 24);
            this.radThinCrust.TabIndex = 2;
            this.radThinCrust.TabStop = true;
            this.radThinCrust.Tag = "0";
            this.radThinCrust.Text = "Thin Crust";
            this.radThinCrust.UseVisualStyleBackColor = true;
            this.radThinCrust.CheckedChanged += new System.EventHandler(this.radThinCrust_CheckedChanged);
            // 
            // graToppings
            // 
            this.graToppings.Controls.Add(this.chkGreenPeppers);
            this.graToppings.Controls.Add(this.chkOlives);
            this.graToppings.Controls.Add(this.chkOnion);
            this.graToppings.Controls.Add(this.chkTomatoes);
            this.graToppings.Controls.Add(this.chkMushrooms);
            this.graToppings.Controls.Add(this.chkExtraChees);
            this.graToppings.Location = new System.Drawing.Point(340, 96);
            this.graToppings.Name = "graToppings";
            this.graToppings.Size = new System.Drawing.Size(368, 153);
            this.graToppings.TabIndex = 5;
            this.graToppings.TabStop = false;
            this.graToppings.Text = "Toppings";
            this.graToppings.Enter += new System.EventHandler(this.graToppings_Enter);
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(199, 86);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(157, 24);
            this.chkGreenPeppers.TabIndex = 5;
            this.chkGreenPeppers.Tag = "5";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(199, 58);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(84, 24);
            this.chkOlives.TabIndex = 4;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(199, 28);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(80, 24);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(19, 87);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(113, 24);
            this.chkTomatoes.TabIndex = 2;
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(19, 59);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(128, 24);
            this.chkMushrooms.TabIndex = 1;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.Location = new System.Drawing.Point(19, 29);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(140, 24);
            this.chkExtraChees.TabIndex = 0;
            this.chkExtraChees.Tag = "5";
            this.chkExtraChees.Text = "Extra Chees ";
            this.chkExtraChees.UseVisualStyleBackColor = true;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.chkExtraChees_CheckedChanged);
            // 
            // graWhrerYouEat
            // 
            this.graWhrerYouEat.Controls.Add(this.radTakeOut);
            this.graWhrerYouEat.Controls.Add(this.radEatIn);
            this.graWhrerYouEat.Location = new System.Drawing.Point(340, 294);
            this.graWhrerYouEat.Name = "graWhrerYouEat";
            this.graWhrerYouEat.Size = new System.Drawing.Size(331, 76);
            this.graWhrerYouEat.TabIndex = 6;
            this.graWhrerYouEat.TabStop = false;
            this.graWhrerYouEat.Text = "Where You Eat";
            // 
            // radEatIn
            // 
            this.radEatIn.AutoSize = true;
            this.radEatIn.Location = new System.Drawing.Point(19, 28);
            this.radEatIn.Name = "radEatIn";
            this.radEatIn.Size = new System.Drawing.Size(85, 24);
            this.radEatIn.TabIndex = 0;
            this.radEatIn.Text = "Eat In ";
            this.radEatIn.UseVisualStyleBackColor = true;
            this.radEatIn.CheckedChanged += new System.EventHandler(this.radEatIn_CheckedChanged);
            // 
            // radTakeOut
            // 
            this.radTakeOut.AutoSize = true;
            this.radTakeOut.Checked = true;
            this.radTakeOut.Location = new System.Drawing.Point(189, 31);
            this.radTakeOut.Name = "radTakeOut";
            this.radTakeOut.Size = new System.Drawing.Size(112, 24);
            this.radTakeOut.TabIndex = 1;
            this.radTakeOut.TabStop = true;
            this.radTakeOut.Text = "Take Out ";
            this.radTakeOut.UseVisualStyleBackColor = true;
            this.radTakeOut.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.laWhereYouEat);
            this.groupBox1.Controls.Add(this.laWhere);
            this.groupBox1.Controls.Add(this.laCrust);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.laToppings);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.laSize);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(771, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 307);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Summary";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // butOrderPizza
            // 
            this.butOrderPizza.Location = new System.Drawing.Point(340, 413);
            this.butOrderPizza.Name = "butOrderPizza";
            this.butOrderPizza.Size = new System.Drawing.Size(119, 43);
            this.butOrderPizza.TabIndex = 8;
            this.butOrderPizza.Text = "Order Pizza";
            this.butOrderPizza.UseVisualStyleBackColor = true;
            this.butOrderPizza.Click += new System.EventHandler(this.butOrderPizza_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size: ";
            // 
            // laSize
            // 
            this.laSize.AutoSize = true;
            this.laSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laSize.Location = new System.Drawing.Point(81, 33);
            this.laSize.Name = "laSize";
            this.laSize.Size = new System.Drawing.Size(52, 20);
            this.laSize.TabIndex = 1;
            this.laSize.Text = "Size: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Toppings:";
            // 
            // laToppings
            // 
            this.laToppings.AutoSize = true;
            this.laToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laToppings.Location = new System.Drawing.Point(6, 93);
            this.laToppings.Name = "laToppings";
            this.laToppings.Size = new System.Drawing.Size(103, 20);
            this.laToppings.TabIndex = 3;
            this.laToppings.Text = "No Toppings";
            this.laToppings.Click += new System.EventHandler(this.laToppings_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Crust Type:  ";
            // 
            // laWhere
            // 
            this.laWhere.AutoSize = true;
            this.laWhere.Location = new System.Drawing.Point(27, 208);
            this.laWhere.Name = "laWhere";
            this.laWhere.Size = new System.Drawing.Size(146, 20);
            this.laWhere.TabIndex = 6;
            this.laWhere.Text = "Where You Eat: ";
            // 
            // laWhereYouEat
            // 
            this.laWhereYouEat.AutoSize = true;
            this.laWhereYouEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laWhereYouEat.Location = new System.Drawing.Point(81, 228);
            this.laWhereYouEat.Name = "laWhereYouEat";
            this.laWhereYouEat.Size = new System.Drawing.Size(103, 20);
            this.laWhereYouEat.TabIndex = 7;
            this.laWhereYouEat.Text = "No Toppings";
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(601, 413);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(119, 43);
            this.btReset.TabIndex = 9;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // laTotalPrice
            // 
            this.laTotalPrice.AutoSize = true;
            this.laTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTotalPrice.ForeColor = System.Drawing.Color.Green;
            this.laTotalPrice.Location = new System.Drawing.Point(897, 423);
            this.laTotalPrice.Name = "laTotalPrice";
            this.laTotalPrice.Size = new System.Drawing.Size(47, 52);
            this.laTotalPrice.TabIndex = 10;
            this.laTotalPrice.Text = "0";
            this.laTotalPrice.Click += new System.EventHandler(this.laTotalPrice_Click);
            // 
            // laCrust
            // 
            this.laCrust.AutoSize = true;
            this.laCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laCrust.Location = new System.Drawing.Point(81, 162);
            this.laCrust.Name = "laCrust";
            this.laCrust.Size = new System.Drawing.Size(0, 20);
            this.laCrust.TabIndex = 5;
            this.laCrust.Click += new System.EventHandler(this.label4_Click);
            // 
            // PizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 515);
            this.Controls.Add(this.laTotalPrice);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.butOrderPizza);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.graWhrerYouEat);
            this.Controls.Add(this.graToppings);
            this.Controls.Add(this.grCrustType);
            this.Controls.Add(this.grSize);
            this.Controls.Add(this.laTitleText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PizzaOrder";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.PizzaOrder_Load);
            this.grSize.ResumeLayout(false);
            this.grSize.PerformLayout();
            this.grCrustType.ResumeLayout(false);
            this.grCrustType.PerformLayout();
            this.graToppings.ResumeLayout(false);
            this.graToppings.PerformLayout();
            this.graWhrerYouEat.ResumeLayout(false);
            this.graWhrerYouEat.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laTitleText;
        private System.Windows.Forms.GroupBox grSize;
        private System.Windows.Forms.RadioButton radLarge;
        private System.Windows.Forms.RadioButton radMedium;
        private System.Windows.Forms.RadioButton radSmall;
        private System.Windows.Forms.GroupBox grCrustType;
        private System.Windows.Forms.RadioButton radThikCrust;
        private System.Windows.Forms.RadioButton radThinCrust;
        private System.Windows.Forms.GroupBox graToppings;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.GroupBox graWhrerYouEat;
        private System.Windows.Forms.RadioButton radTakeOut;
        private System.Windows.Forms.RadioButton radEatIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butOrderPizza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label laSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label laToppings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label laWhereYouEat;
        private System.Windows.Forms.Label laWhere;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label laTotalPrice;
        private System.Windows.Forms.Label laCrust;
    }
}