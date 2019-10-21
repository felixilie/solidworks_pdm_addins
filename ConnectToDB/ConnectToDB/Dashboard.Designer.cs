namespace ConnectToDB
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
            this.M1ListBox = new System.Windows.Forms.ListBox();
            this.PartNumberText = new System.Windows.Forms.TextBox();
            this.PNlabel = new System.Windows.Forms.Label();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // M1ListBox
            // 
            this.M1ListBox.FormattingEnabled = true;
            this.M1ListBox.ItemHeight = 25;
            this.M1ListBox.Location = new System.Drawing.Point(55, 145);
            this.M1ListBox.Name = "M1ListBox";
            this.M1ListBox.Size = new System.Drawing.Size(896, 229);
            this.M1ListBox.TabIndex = 0;
            // 
            // PartNumberText
            // 
            this.PartNumberText.Location = new System.Drawing.Point(194, 45);
            this.PartNumberText.Name = "PartNumberText";
            this.PartNumberText.Size = new System.Drawing.Size(291, 31);
            this.PartNumberText.TabIndex = 1;
            // 
            // PNlabel
            // 
            this.PNlabel.AutoSize = true;
            this.PNlabel.Location = new System.Drawing.Point(51, 48);
            this.PNlabel.Name = "PNlabel";
            this.PNlabel.Size = new System.Drawing.Size(132, 25);
            this.PNlabel.TabIndex = 2;
            this.PNlabel.Text = "Part Number";
            // 
            // Searchbutton
            // 
            this.Searchbutton.Location = new System.Drawing.Point(318, 93);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(167, 33);
            this.Searchbutton.TabIndex = 3;
            this.Searchbutton.Text = "Search";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 520);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.PNlabel);
            this.Controls.Add(this.PartNumberText);
            this.Controls.Add(this.M1ListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "M1 Part Properties";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox M1ListBox;
        private System.Windows.Forms.TextBox PartNumberText;
        private System.Windows.Forms.Label PNlabel;
        private System.Windows.Forms.Button Searchbutton;
    }
}

