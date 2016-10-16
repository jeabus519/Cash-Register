namespace Cash_Register
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
            this.itemLabel = new System.Windows.Forms.Label();
            this.qtyLabel = new System.Windows.Forms.Label();
            this.burgerLabel = new System.Windows.Forms.Label();
            this.friedLabel = new System.Windows.Forms.Label();
            this.drinkLabel = new System.Windows.Forms.Label();
            this.burgerBox = new System.Windows.Forms.TextBox();
            this.friesBox = new System.Windows.Forms.TextBox();
            this.drinkBox = new System.Windows.Forms.TextBox();
            this.d = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Font = new System.Drawing.Font("Comic Sans MS", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.itemLabel.ForeColor = System.Drawing.Color.Gold;
            this.itemLabel.Location = new System.Drawing.Point(30, 30);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(57, 27);
            this.itemLabel.TabIndex = 0;
            this.itemLabel.Text = "Item";
            this.itemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // qtyLabel
            // 
            this.qtyLabel.AutoSize = true;
            this.qtyLabel.Font = new System.Drawing.Font("Comic Sans MS", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyLabel.ForeColor = System.Drawing.Color.Gold;
            this.qtyLabel.Location = new System.Drawing.Point(150, 30);
            this.qtyLabel.Name = "qtyLabel";
            this.qtyLabel.Size = new System.Drawing.Size(49, 27);
            this.qtyLabel.TabIndex = 1;
            this.qtyLabel.Text = "Qty";
            this.qtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // burgerLabel
            // 
            this.burgerLabel.AutoSize = true;
            this.burgerLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.burgerLabel.ForeColor = System.Drawing.Color.Gold;
            this.burgerLabel.Location = new System.Drawing.Point(30, 70);
            this.burgerLabel.Name = "burgerLabel";
            this.burgerLabel.Size = new System.Drawing.Size(67, 25);
            this.burgerLabel.TabIndex = 2;
            this.burgerLabel.Text = "Burger";
            this.burgerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // friedLabel
            // 
            this.friedLabel.AutoSize = true;
            this.friedLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.friedLabel.ForeColor = System.Drawing.Color.Gold;
            this.friedLabel.Location = new System.Drawing.Point(30, 100);
            this.friedLabel.Name = "friedLabel";
            this.friedLabel.Size = new System.Drawing.Size(53, 25);
            this.friedLabel.TabIndex = 3;
            this.friedLabel.Text = "Fries";
            this.friedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // drinkLabel
            // 
            this.drinkLabel.AutoSize = true;
            this.drinkLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.drinkLabel.ForeColor = System.Drawing.Color.Gold;
            this.drinkLabel.Location = new System.Drawing.Point(30, 130);
            this.drinkLabel.Name = "drinkLabel";
            this.drinkLabel.Size = new System.Drawing.Size(55, 25);
            this.drinkLabel.TabIndex = 4;
            this.drinkLabel.Text = "Drink";
            this.drinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // burgerBox
            // 
            this.burgerBox.Location = new System.Drawing.Point(155, 70);
            this.burgerBox.Name = "burgerBox";
            this.burgerBox.Size = new System.Drawing.Size(30, 22);
            this.burgerBox.TabIndex = 5;
            // 
            // friesBox
            // 
            this.friesBox.Location = new System.Drawing.Point(155, 100);
            this.friesBox.Name = "friesBox";
            this.friesBox.Size = new System.Drawing.Size(30, 22);
            this.friesBox.TabIndex = 6;
            // 
            // drinkBox
            // 
            this.drinkBox.Location = new System.Drawing.Point(155, 130);
            this.drinkBox.Name = "drinkBox";
            this.drinkBox.Size = new System.Drawing.Size(30, 22);
            this.drinkBox.TabIndex = 7;
            // 
            // d
            // 
            this.d.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d.ForeColor = System.Drawing.Color.Gold;
            this.d.Location = new System.Drawing.Point(30, 170);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(169, 35);
            this.d.TabIndex = 8;
            this.d.Text = "Calculate Totals";
            this.d.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.d);
            this.Controls.Add(this.drinkBox);
            this.Controls.Add(this.friesBox);
            this.Controls.Add(this.burgerBox);
            this.Controls.Add(this.drinkLabel);
            this.Controls.Add(this.friedLabel);
            this.Controls.Add(this.burgerLabel);
            this.Controls.Add(this.qtyLabel);
            this.Controls.Add(this.itemLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.Label qtyLabel;
        private System.Windows.Forms.Label burgerLabel;
        private System.Windows.Forms.Label friedLabel;
        private System.Windows.Forms.Label drinkLabel;
        private System.Windows.Forms.TextBox burgerBox;
        private System.Windows.Forms.TextBox friesBox;
        private System.Windows.Forms.TextBox drinkBox;
        private System.Windows.Forms.Button d;
    }
}

