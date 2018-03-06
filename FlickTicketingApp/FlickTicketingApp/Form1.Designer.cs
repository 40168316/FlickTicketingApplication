namespace FlickTicketingApp
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
            this.addTicketButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectLabel = new System.Windows.Forms.Label();
            this.concessionRadioButton = new System.Windows.Forms.RadioButton();
            this.standardRadioButton = new System.Windows.Forms.RadioButton();
            this.addLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.imaxCheckBox = new System.Windows.Forms.CheckBox();
            this.realCheckBox = new System.Windows.Forms.CheckBox();
            this.overallTotalLabel = new System.Windows.Forms.Label();
            this.numberOfTicketsLabel = new System.Windows.Forms.Label();
            this.noTicketsToPayForLabel = new System.Windows.Forms.Label();
            this.noOfFreeTicketsLabel = new System.Windows.Forms.Label();
            this.totalSavingsLabel = new System.Windows.Forms.Label();
            this.totalButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addTicketButton
            // 
            this.addTicketButton.Location = new System.Drawing.Point(309, 10);
            this.addTicketButton.Name = "addTicketButton";
            this.addTicketButton.Size = new System.Drawing.Size(130, 23);
            this.addTicketButton.TabIndex = 1;
            this.addTicketButton.Text = "Add Ticket";
            this.addTicketButton.UseVisualStyleBackColor = true;
            this.addTicketButton.Click += new System.EventHandler(this.addTicketButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.selectLabel);
            this.panel1.Controls.Add(this.concessionRadioButton);
            this.panel1.Controls.Add(this.standardRadioButton);
            this.panel1.Location = new System.Drawing.Point(13, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 63);
            this.panel1.TabIndex = 2;
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Location = new System.Drawing.Point(0, 1);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(137, 13);
            this.selectLabel.TabIndex = 3;
            this.selectLabel.Text = "Please select a ticket type?";
            // 
            // concessionRadioButton
            // 
            this.concessionRadioButton.AutoSize = true;
            this.concessionRadioButton.Location = new System.Drawing.Point(24, 41);
            this.concessionRadioButton.Name = "concessionRadioButton";
            this.concessionRadioButton.Size = new System.Drawing.Size(113, 17);
            this.concessionRadioButton.TabIndex = 1;
            this.concessionRadioButton.TabStop = true;
            this.concessionRadioButton.Text = "Concession Ticket";
            this.concessionRadioButton.UseVisualStyleBackColor = true;
            this.concessionRadioButton.CheckedChanged += new System.EventHandler(this.concessionRadioButton_CheckedChanged);
            // 
            // standardRadioButton
            // 
            this.standardRadioButton.AutoSize = true;
            this.standardRadioButton.Location = new System.Drawing.Point(24, 17);
            this.standardRadioButton.Name = "standardRadioButton";
            this.standardRadioButton.Size = new System.Drawing.Size(101, 17);
            this.standardRadioButton.TabIndex = 0;
            this.standardRadioButton.TabStop = true;
            this.standardRadioButton.Text = "Standard Ticket";
            this.standardRadioButton.UseVisualStyleBackColor = true;
            this.standardRadioButton.CheckedChanged += new System.EventHandler(this.standardRadioButton_CheckedChanged);
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.Location = new System.Drawing.Point(210, 9);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(64, 13);
            this.addLabel.TabIndex = 5;
            this.addLabel.Text = "Add Extras?";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(13, 79);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(86, 13);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "Running Total: £";
            // 
            // imaxCheckBox
            // 
            this.imaxCheckBox.AutoSize = true;
            this.imaxCheckBox.Location = new System.Drawing.Point(213, 26);
            this.imaxCheckBox.Name = "imaxCheckBox";
            this.imaxCheckBox.Size = new System.Drawing.Size(52, 17);
            this.imaxCheckBox.TabIndex = 7;
            this.imaxCheckBox.Text = "IMAX";
            this.imaxCheckBox.UseVisualStyleBackColor = true;
            this.imaxCheckBox.CheckedChanged += new System.EventHandler(this.imaxCheckBox_CheckedChanged);
            // 
            // realCheckBox
            // 
            this.realCheckBox.AutoSize = true;
            this.realCheckBox.Location = new System.Drawing.Point(213, 50);
            this.realCheckBox.Name = "realCheckBox";
            this.realCheckBox.Size = new System.Drawing.Size(62, 17);
            this.realCheckBox.TabIndex = 8;
            this.realCheckBox.Text = "Real3D";
            this.realCheckBox.UseVisualStyleBackColor = true;
            this.realCheckBox.CheckedChanged += new System.EventHandler(this.realCheckBox_CheckedChanged);
            // 
            // overallTotalLabel
            // 
            this.overallTotalLabel.AutoSize = true;
            this.overallTotalLabel.Location = new System.Drawing.Point(173, 78);
            this.overallTotalLabel.Name = "overallTotalLabel";
            this.overallTotalLabel.Size = new System.Drawing.Size(79, 13);
            this.overallTotalLabel.TabIndex = 9;
            this.overallTotalLabel.Text = "Overall Total: £";
            // 
            // numberOfTicketsLabel
            // 
            this.numberOfTicketsLabel.AutoSize = true;
            this.numberOfTicketsLabel.Location = new System.Drawing.Point(13, 96);
            this.numberOfTicketsLabel.Name = "numberOfTicketsLabel";
            this.numberOfTicketsLabel.Size = new System.Drawing.Size(97, 13);
            this.numberOfTicketsLabel.TabIndex = 10;
            this.numberOfTicketsLabel.Text = "Number of Tickets:";
            // 
            // noTicketsToPayForLabel
            // 
            this.noTicketsToPayForLabel.AutoSize = true;
            this.noTicketsToPayForLabel.Location = new System.Drawing.Point(173, 96);
            this.noTicketsToPayForLabel.Name = "noTicketsToPayForLabel";
            this.noTicketsToPayForLabel.Size = new System.Drawing.Size(144, 13);
            this.noTicketsToPayForLabel.TabIndex = 11;
            this.noTicketsToPayForLabel.Text = "Number of Tickets to pay for:";
            // 
            // noOfFreeTicketsLabel
            // 
            this.noOfFreeTicketsLabel.AutoSize = true;
            this.noOfFreeTicketsLabel.Location = new System.Drawing.Point(393, 96);
            this.noOfFreeTicketsLabel.Name = "noOfFreeTicketsLabel";
            this.noOfFreeTicketsLabel.Size = new System.Drawing.Size(98, 13);
            this.noOfFreeTicketsLabel.TabIndex = 12;
            this.noOfFreeTicketsLabel.Text = "Offer (free) Tickets:";
            // 
            // totalSavingsLabel
            // 
            this.totalSavingsLabel.AutoSize = true;
            this.totalSavingsLabel.Location = new System.Drawing.Point(393, 79);
            this.totalSavingsLabel.Name = "totalSavingsLabel";
            this.totalSavingsLabel.Size = new System.Drawing.Size(79, 13);
            this.totalSavingsLabel.TabIndex = 13;
            this.totalSavingsLabel.Text = "Total Saving: £";
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(309, 40);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(130, 23);
            this.totalButton.TabIndex = 14;
            this.totalButton.Text = "Total and Pay";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 134);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.totalSavingsLabel);
            this.Controls.Add(this.noOfFreeTicketsLabel);
            this.Controls.Add(this.noTicketsToPayForLabel);
            this.Controls.Add(this.numberOfTicketsLabel);
            this.Controls.Add(this.overallTotalLabel);
            this.Controls.Add(this.realCheckBox);
            this.Controls.Add(this.imaxCheckBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.addLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addTicketButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addTicketButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton concessionRadioButton;
        private System.Windows.Forms.RadioButton standardRadioButton;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.CheckBox imaxCheckBox;
        private System.Windows.Forms.CheckBox realCheckBox;
        private System.Windows.Forms.Label overallTotalLabel;
        private System.Windows.Forms.Label numberOfTicketsLabel;
        private System.Windows.Forms.Label noTicketsToPayForLabel;
        private System.Windows.Forms.Label noOfFreeTicketsLabel;
        private System.Windows.Forms.Label totalSavingsLabel;
        private System.Windows.Forms.Button totalButton;
    }
}

