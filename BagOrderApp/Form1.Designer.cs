
namespace BagOrderApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.designTypeListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.overnightRadioButton = new System.Windows.Forms.RadioButton();
            this.threeDayRadioButton = new System.Windows.Forms.RadioButton();
            this.standardRadioButton = new System.Windows.Forms.RadioButton();
            this.addToOrderButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bag Designs:";
            // 
            // designTypeListBox
            // 
            this.designTypeListBox.FormattingEnabled = true;
            this.designTypeListBox.ItemHeight = 25;
            this.designTypeListBox.Items.AddRange(new object[] {
            "Beaded",
            "Decorative",
            "Fringed",
            "Leather",
            "Pirate",
            "Plain"});
            this.designTypeListBox.Location = new System.Drawing.Point(84, 211);
            this.designTypeListBox.Name = "designTypeListBox";
            this.designTypeListBox.Size = new System.Drawing.Size(245, 154);
            this.designTypeListBox.TabIndex = 1;
            this.designTypeListBox.SelectedIndexChanged += new System.EventHandler(this.designTypeListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unit Price:";
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Location = new System.Drawing.Point(831, 211);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.ReadOnly = true;
            this.unitPriceTextBox.Size = new System.Drawing.Size(206, 31);
            this.unitPriceTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity to order:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(831, 272);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(206, 31);
            this.quantityTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 515);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Shipping";
            // 
            // overnightRadioButton
            // 
            this.overnightRadioButton.AutoSize = true;
            this.overnightRadioButton.Location = new System.Drawing.Point(89, 588);
            this.overnightRadioButton.Name = "overnightRadioButton";
            this.overnightRadioButton.Size = new System.Drawing.Size(199, 29);
            this.overnightRadioButton.TabIndex = 7;
            this.overnightRadioButton.TabStop = true;
            this.overnightRadioButton.Text = "Overnight (10%)";
            this.overnightRadioButton.UseVisualStyleBackColor = true;
            this.overnightRadioButton.CheckedChanged += new System.EventHandler(this.overnightRadioButton_CheckedChanged);
            // 
            // threeDayRadioButton
            // 
            this.threeDayRadioButton.AutoSize = true;
            this.threeDayRadioButton.Location = new System.Drawing.Point(393, 588);
            this.threeDayRadioButton.Name = "threeDayRadioButton";
            this.threeDayRadioButton.Size = new System.Drawing.Size(151, 29);
            this.threeDayRadioButton.TabIndex = 8;
            this.threeDayRadioButton.TabStop = true;
            this.threeDayRadioButton.Text = "3-Day (7%)";
            this.threeDayRadioButton.UseVisualStyleBackColor = true;
            // 
            // standardRadioButton
            // 
            this.standardRadioButton.AutoSize = true;
            this.standardRadioButton.Location = new System.Drawing.Point(635, 588);
            this.standardRadioButton.Name = "standardRadioButton";
            this.standardRadioButton.Size = new System.Drawing.Size(181, 29);
            this.standardRadioButton.TabIndex = 9;
            this.standardRadioButton.TabStop = true;
            this.standardRadioButton.Text = "Standard (5%)";
            this.standardRadioButton.UseVisualStyleBackColor = true;
            // 
            // addToOrderButton
            // 
            this.addToOrderButton.Location = new System.Drawing.Point(198, 721);
            this.addToOrderButton.Name = "addToOrderButton";
            this.addToOrderButton.Size = new System.Drawing.Size(250, 65);
            this.addToOrderButton.TabIndex = 10;
            this.addToOrderButton.Text = "Add to Order";
            this.addToOrderButton.UseVisualStyleBackColor = true;
            this.addToOrderButton.Click += new System.EventHandler(this.addToOrderButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(497, 721);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(250, 65);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear Current Selection";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1388, 42);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayOrderToolStripMenuItem,
            this.resetOrderToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(96, 38);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // displayOrderToolStripMenuItem
            // 
            this.displayOrderToolStripMenuItem.Name = "displayOrderToolStripMenuItem";
            this.displayOrderToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.displayOrderToolStripMenuItem.Text = "Display Order";
            this.displayOrderToolStripMenuItem.Click += new System.EventHandler(this.displayOrderToolStripMenuItem_Click);
            // 
            // resetOrderToolStripMenuItem
            // 
            this.resetOrderToolStripMenuItem.Name = "resetOrderToolStripMenuItem";
            this.resetOrderToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.resetOrderToolStripMenuItem.Text = "Reset Order";
            this.resetOrderToolStripMenuItem.Click += new System.EventHandler(this.resetOrderToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 859);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addToOrderButton);
            this.Controls.Add(this.standardRadioButton);
            this.Controls.Add(this.threeDayRadioButton);
            this.Controls.Add(this.overnightRadioButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.designTypeListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Bag Order App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox designTypeListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton overnightRadioButton;
        private System.Windows.Forms.RadioButton threeDayRadioButton;
        private System.Windows.Forms.RadioButton standardRadioButton;
        private System.Windows.Forms.Button addToOrderButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

