namespace FormUI
{
    partial class Dashboard
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
            this.peopleFoundListbox = new System.Windows.Forms.ListBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.bsearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.firstText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lastText = new System.Windows.Forms.TextBox();
            this.bCreate = new System.Windows.Forms.Button();
            this.bCreateCSV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peopleFoundListbox
            // 
            this.peopleFoundListbox.FormattingEnabled = true;
            this.peopleFoundListbox.ItemHeight = 25;
            this.peopleFoundListbox.Location = new System.Drawing.Point(12, 70);
            this.peopleFoundListbox.Name = "peopleFoundListbox";
            this.peopleFoundListbox.Size = new System.Drawing.Size(587, 104);
            this.peopleFoundListbox.TabIndex = 0;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(142, 14);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(183, 31);
            this.lastNameText.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(7, 14);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(115, 25);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // bsearchButton
            // 
            this.bsearchButton.Location = new System.Drawing.Point(360, 14);
            this.bsearchButton.Name = "bsearchButton";
            this.bsearchButton.Size = new System.Drawing.Size(130, 38);
            this.bsearchButton.TabIndex = 3;
            this.bsearchButton.Text = "Search";
            this.bsearchButton.UseVisualStyleBackColor = true;
            this.bsearchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Phone";
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(142, 300);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(183, 31);
            this.emailText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email";
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(142, 337);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(183, 31);
            this.phoneText.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "First Name";
            // 
            // firstText
            // 
            this.firstText.Location = new System.Drawing.Point(142, 225);
            this.firstText.Name = "firstText";
            this.firstText.Size = new System.Drawing.Size(183, 31);
            this.firstText.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Last Name";
            // 
            // lastText
            // 
            this.lastText.Location = new System.Drawing.Point(142, 262);
            this.lastText.Name = "lastText";
            this.lastText.Size = new System.Drawing.Size(183, 31);
            this.lastText.TabIndex = 10;
            // 
            // bCreate
            // 
            this.bCreate.Location = new System.Drawing.Point(331, 330);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(130, 38);
            this.bCreate.TabIndex = 12;
            this.bCreate.Text = "Create";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // bCreateCSV
            // 
            this.bCreateCSV.Location = new System.Drawing.Point(469, 330);
            this.bCreateCSV.Name = "bCreateCSV";
            this.bCreateCSV.Size = new System.Drawing.Size(130, 38);
            this.bCreateCSV.TabIndex = 13;
            this.bCreateCSV.Text = " CSV File";
            this.bCreateCSV.UseVisualStyleBackColor = true;
            this.bCreateCSV.Click += new System.EventHandler(this.bCreateCSV_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 395);
            this.Controls.Add(this.bCreateCSV);
            this.Controls.Add(this.bCreate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.bsearchButton);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.peopleFoundListbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Dashboard";
            this.Text = "SQL Data Access";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleFoundListbox;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button bsearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lastText;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.Button bCreateCSV;
    }
}

