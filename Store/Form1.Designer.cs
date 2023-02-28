namespace Store
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Receipt = new System.Windows.Forms.Label();
            this.shirttextbox = new System.Windows.Forms.TextBox();
            this.pantstextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sweaterstextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.calculatebutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.subtotallabel = new System.Windows.Forms.Label();
            this.taxlabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.totallabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.printReceiptbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1236, 80);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.ForestGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, -11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 91);
            this.label2.TabIndex = 1;
            this.label2.Text = "Store";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "# of Shirt\'s";
            // 
            // Receipt
            // 
            this.Receipt.BackColor = System.Drawing.Color.Transparent;
            this.Receipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Receipt.Location = new System.Drawing.Point(429, 114);
            this.Receipt.Name = "Receipt";
            this.Receipt.Size = new System.Drawing.Size(327, 575);
            this.Receipt.TabIndex = 3;
            // 
            // shirttextbox
            // 
            this.shirttextbox.Location = new System.Drawing.Point(297, 116);
            this.shirttextbox.Name = "shirttextbox";
            this.shirttextbox.Size = new System.Drawing.Size(100, 22);
            this.shirttextbox.TabIndex = 4;
            // 
            // pantstextbox
            // 
            this.pantstextbox.Location = new System.Drawing.Point(297, 177);
            this.pantstextbox.Name = "pantstextbox";
            this.pantstextbox.Size = new System.Drawing.Size(100, 22);
            this.pantstextbox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 38);
            this.label4.TabIndex = 5;
            this.label4.Text = "# of Pant\'s";
            // 
            // sweaterstextbox
            // 
            this.sweaterstextbox.Location = new System.Drawing.Point(297, 241);
            this.sweaterstextbox.Name = "sweaterstextbox";
            this.sweaterstextbox.Size = new System.Drawing.Size(100, 22);
            this.sweaterstextbox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 38);
            this.label5.TabIndex = 7;
            this.label5.Text = "# of sweater\'s";
            // 
            // calculatebutton
            // 
            this.calculatebutton.AutoSize = true;
            this.calculatebutton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.calculatebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.calculatebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.calculatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatebutton.Location = new System.Drawing.Point(132, 303);
            this.calculatebutton.Name = "calculatebutton";
            this.calculatebutton.Size = new System.Drawing.Size(180, 52);
            this.calculatebutton.TabIndex = 9;
            this.calculatebutton.Text = "Calculate";
            this.calculatebutton.UseVisualStyleBackColor = false;
            this.calculatebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 38);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sub Total:";
            // 
            // subtotallabel
            // 
            this.subtotallabel.BackColor = System.Drawing.Color.White;
            this.subtotallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotallabel.Location = new System.Drawing.Point(297, 415);
            this.subtotallabel.Name = "subtotallabel";
            this.subtotallabel.Size = new System.Drawing.Size(100, 23);
            this.subtotallabel.TabIndex = 11;
            this.subtotallabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // taxlabel
            // 
            this.taxlabel.BackColor = System.Drawing.Color.White;
            this.taxlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxlabel.Location = new System.Drawing.Point(297, 492);
            this.taxlabel.Name = "taxlabel";
            this.taxlabel.Size = new System.Drawing.Size(100, 23);
            this.taxlabel.TabIndex = 13;
            this.taxlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 477);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 38);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tax:";
            // 
            // totallabel
            // 
            this.totallabel.BackColor = System.Drawing.Color.White;
            this.totallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallabel.Location = new System.Drawing.Point(297, 565);
            this.totallabel.Name = "totallabel";
            this.totallabel.Size = new System.Drawing.Size(100, 23);
            this.totallabel.TabIndex = 15;
            this.totallabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(45, 550);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 38);
            this.label10.TabIndex = 14;
            this.label10.Text = "Total:";
            // 
            // printReceiptbutton
            // 
            this.printReceiptbutton.AutoSize = true;
            this.printReceiptbutton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.printReceiptbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.printReceiptbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.printReceiptbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printReceiptbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printReceiptbutton.Location = new System.Drawing.Point(116, 637);
            this.printReceiptbutton.Name = "printReceiptbutton";
            this.printReceiptbutton.Size = new System.Drawing.Size(215, 41);
            this.printReceiptbutton.TabIndex = 22;
            this.printReceiptbutton.Text = "Print Receipt";
            this.printReceiptbutton.UseVisualStyleBackColor = false;
            this.printReceiptbutton.Click += new System.EventHandler(this.printReceiptbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 715);
            this.Controls.Add(this.printReceiptbutton);
            this.Controls.Add(this.totallabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.taxlabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.subtotallabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.calculatebutton);
            this.Controls.Add(this.sweaterstextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pantstextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.shirttextbox);
            this.Controls.Add(this.Receipt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Receipt;
        private System.Windows.Forms.TextBox shirttextbox;
        private System.Windows.Forms.TextBox pantstextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sweaterstextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button calculatebutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label subtotallabel;
        private System.Windows.Forms.Label taxlabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label totallabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button printReceiptbutton;
    }
}

