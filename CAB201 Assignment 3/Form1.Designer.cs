namespace CAB201_Assignment_3
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sauceDropdown = new System.Windows.Forms.ComboBox();
            this.toppingsGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.thinButton = new System.Windows.Forms.RadioButton();
            this.thickButton = new System.Windows.Forms.RadioButton();
            this.gfButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.crustGroup = new System.Windows.Forms.GroupBox();
            this.doneButton = new System.Windows.Forms.Button();
            this.toppingsGroup.SuspendLayout();
            this.crustGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(110, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Welcome to Beagle Boys";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(175, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Online Order Form";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(28, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Please enter a name for your order: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.Color.Black;
            this.nameTextBox.Location = new System.Drawing.Point(299, 85);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(241, 23);
            this.nameTextBox.TabIndex = 5;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(286, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Select the sauce for your pizza";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sauceDropdown
            // 
            this.sauceDropdown.Enabled = false;
            this.sauceDropdown.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sauceDropdown.ForeColor = System.Drawing.Color.Black;
            this.sauceDropdown.FormattingEnabled = true;
            this.sauceDropdown.Items.AddRange(new object[] {
            "BBQ",
            "Tomato"});
            this.sauceDropdown.Location = new System.Drawing.Point(365, 174);
            this.sauceDropdown.Name = "sauceDropdown";
            this.sauceDropdown.Size = new System.Drawing.Size(166, 23);
            this.sauceDropdown.TabIndex = 7;
            this.sauceDropdown.TextChanged += new System.EventHandler(this.sauceChanged);
            // 
            // toppingsGroup
            // 
            this.toppingsGroup.Controls.Add(this.label1);
            this.toppingsGroup.Controls.Add(this.checkBox13);
            this.toppingsGroup.Controls.Add(this.checkBox14);
            this.toppingsGroup.Controls.Add(this.checkBox15);
            this.toppingsGroup.Controls.Add(this.checkBox16);
            this.toppingsGroup.Controls.Add(this.checkBox9);
            this.toppingsGroup.Controls.Add(this.checkBox10);
            this.toppingsGroup.Controls.Add(this.checkBox11);
            this.toppingsGroup.Controls.Add(this.checkBox12);
            this.toppingsGroup.Controls.Add(this.checkBox5);
            this.toppingsGroup.Controls.Add(this.checkBox6);
            this.toppingsGroup.Controls.Add(this.checkBox7);
            this.toppingsGroup.Controls.Add(this.checkBox8);
            this.toppingsGroup.Controls.Add(this.checkBox4);
            this.toppingsGroup.Controls.Add(this.checkBox3);
            this.toppingsGroup.Controls.Add(this.checkBox2);
            this.toppingsGroup.Controls.Add(this.checkBox1);
            this.toppingsGroup.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toppingsGroup.ForeColor = System.Drawing.Color.Yellow;
            this.toppingsGroup.Location = new System.Drawing.Point(28, 245);
            this.toppingsGroup.Name = "toppingsGroup";
            this.toppingsGroup.Size = new System.Drawing.Size(517, 175);
            this.toppingsGroup.TabIndex = 8;
            this.toppingsGroup.TabStop = false;
            this.toppingsGroup.Text = "Toppings";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose the toppings for your pizza.  Each topping after 4 will incur a $1.00 cost" +
    " per topping.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(375, 107);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(107, 19);
            this.checkBox13.TabIndex = 15;
            this.checkBox13.Text = "Cheddar Cheese";
            this.checkBox13.UseVisualStyleBackColor = true;
            this.checkBox13.CheckedChanged += new System.EventHandler(this.checkedChanged);
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(363, 79);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(57, 19);
            this.checkBox14.TabIndex = 14;
            this.checkBox14.Text = "Bacon";
            this.checkBox14.UseVisualStyleBackColor = true;
            this.checkBox14.CheckedChanged += new System.EventHandler(this.checkedChanged);
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(350, 51);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(75, 19);
            this.checkBox15.TabIndex = 13;
            this.checkBox15.Text = "Pineapple";
            this.checkBox15.UseVisualStyleBackColor = true;
            this.checkBox15.CheckedChanged += new System.EventHandler(this.checkedChanged);
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(363, 31);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(74, 19);
            this.checkBox16.TabIndex = 12;
            this.checkBox16.Text = "Capsicum";
            this.checkBox16.UseVisualStyleBackColor = true;
            this.checkBox16.CheckedChanged += new System.EventHandler(this.checkedChanged);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(241, 100);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(87, 19);
            this.checkBox9.TabIndex = 11;
            this.checkBox9.Text = "Feta Cheese";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkedChanged);
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(248, 76);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(78, 19);
            this.checkBox10.TabIndex = 10;
            this.checkBox10.Text = "Mushroom";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.checkedChanged);
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(241, 54);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(68, 19);
            this.checkBox11.TabIndex = 9;
            this.checkBox11.Text = "Spinach";
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.CheckedChanged += new System.EventHandler(this.checkedChanged);
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(237, 33);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(77, 19);
            this.checkBox12.TabIndex = 8;
            this.checkBox12.Text = "Pepperoni";
            this.checkBox12.UseVisualStyleBackColor = true;
            this.checkBox12.CheckedChanged += new System.EventHandler(this.checkedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(122, 106);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(116, 19);
            this.checkBox5.TabIndex = 7;
            this.checkBox5.Text = "Mozarella Cheese";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(125, 77);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(91, 19);
            this.checkBox6.TabIndex = 6;
            this.checkBox6.Text = "Ground Beef";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(118, 54);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(48, 19);
            this.checkBox7.TabIndex = 5;
            this.checkBox7.Text = "Ham";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(125, 31);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(59, 19);
            this.checkBox8.TabIndex = 4;
            this.checkBox8.Text = "Olives";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(14, 100);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(57, 19);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Prawn";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 79);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(67, 19);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Chicken";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(19, 59);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 19);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Jalapeno";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(14, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Tomatoes";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkedChanged);
            // 
            // thinButton
            // 
            this.thinButton.AutoSize = true;
            this.thinButton.Location = new System.Drawing.Point(14, 31);
            this.thinButton.Name = "thinButton";
            this.thinButton.Size = new System.Drawing.Size(48, 19);
            this.thinButton.TabIndex = 0;
            this.thinButton.TabStop = true;
            this.thinButton.Text = "Thin";
            this.thinButton.UseVisualStyleBackColor = true;
            this.thinButton.UseWaitCursor = true;
            this.thinButton.CheckedChanged += new System.EventHandler(this.rButtonChanged);
            // 
            // thickButton
            // 
            this.thickButton.AutoSize = true;
            this.thickButton.Location = new System.Drawing.Point(67, 24);
            this.thickButton.Name = "thickButton";
            this.thickButton.Size = new System.Drawing.Size(54, 19);
            this.thickButton.TabIndex = 1;
            this.thickButton.TabStop = true;
            this.thickButton.Text = "Thick";
            this.thickButton.UseVisualStyleBackColor = true;
            this.thickButton.UseWaitCursor = true;
            this.thickButton.CheckedChanged += new System.EventHandler(this.rButtonChanged);
            // 
            // gfButton
            // 
            this.gfButton.AutoSize = true;
            this.gfButton.Enabled = false;
            this.gfButton.Location = new System.Drawing.Point(125, 34);
            this.gfButton.Name = "gfButton";
            this.gfButton.Size = new System.Drawing.Size(93, 19);
            this.gfButton.TabIndex = 2;
            this.gfButton.TabStop = true;
            this.gfButton.Text = "Gluten Free *";
            this.gfButton.UseVisualStyleBackColor = true;
            this.gfButton.UseWaitCursor = true;
            this.gfButton.CheckedChanged += new System.EventHandler(this.rButtonChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "* Incurs $2 surcharge";
            this.label2.UseWaitCursor = true;
            // 
            // crustGroup
            // 
            this.crustGroup.Controls.Add(this.thickButton);
            this.crustGroup.Controls.Add(this.label2);
            this.crustGroup.Controls.Add(this.thinButton);
            this.crustGroup.Controls.Add(this.gfButton);
            this.crustGroup.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crustGroup.ForeColor = System.Drawing.Color.Yellow;
            this.crustGroup.Location = new System.Drawing.Point(50, 123);
            this.crustGroup.Name = "crustGroup";
            this.crustGroup.Size = new System.Drawing.Size(219, 100);
            this.crustGroup.TabIndex = 9;
            this.crustGroup.TabStop = false;
            this.crustGroup.Text = "Crust";
            this.crustGroup.UseWaitCursor = true;
            this.crustGroup.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // doneButton
            // 
            this.doneButton.Enabled = false;
            this.doneButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneButton.ForeColor = System.Drawing.Color.Black;
            this.doneButton.Location = new System.Drawing.Point(179, 442);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(121, 53);
            this.doneButton.TabIndex = 0;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(566, 505);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.crustGroup);
            this.Controls.Add(this.toppingsGroup);
            this.Controls.Add(this.sauceDropdown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toppingsGroup.ResumeLayout(false);
            this.toppingsGroup.PerformLayout();
            this.crustGroup.ResumeLayout(false);
            this.crustGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sauceDropdown;
        private System.Windows.Forms.GroupBox toppingsGroup;
        private System.Windows.Forms.RadioButton thinButton;
        private System.Windows.Forms.RadioButton thickButton;
        private System.Windows.Forms.RadioButton gfButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox crustGroup;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button doneButton;
    }
}

