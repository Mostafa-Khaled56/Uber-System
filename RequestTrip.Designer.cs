
namespace Uber_System
{
    partial class Request
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
            this.LOCATION = new System.Windows.Forms.TextBox();
            this.destination = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.allcars = new System.Windows.Forms.ComboBox();
            this.allDriver = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cash = new System.Windows.Forms.RadioButton();
            this.wallet = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.requestTrip = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.carNumber = new System.Windows.Forms.TextBox();
            this.PayOfDriver = new System.Windows.Forms.TextBox();
            this.Pay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LOCATION
            // 
            this.LOCATION.Location = new System.Drawing.Point(314, 49);
            this.LOCATION.Name = "LOCATION";
            this.LOCATION.Size = new System.Drawing.Size(296, 22);
            this.LOCATION.TabIndex = 0;
            // 
            // destination
            // 
            this.destination.Location = new System.Drawing.Point(314, 126);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(296, 22);
            this.destination.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(115, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(115, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination";
            // 
            // allcars
            // 
            this.allcars.FormattingEnabled = true;
            this.allcars.Location = new System.Drawing.Point(314, 207);
            this.allcars.Name = "allcars";
            this.allcars.Size = new System.Drawing.Size(296, 24);
            this.allcars.TabIndex = 4;
            this.allcars.DropDown += new System.EventHandler(this.allcars_DropDown);
            this.allcars.SelectedIndexChanged += new System.EventHandler(this.allcars_SelectedIndexChanged);
            // 
            // allDriver
            // 
            this.allDriver.FormattingEnabled = true;
            this.allDriver.Location = new System.Drawing.Point(314, 293);
            this.allDriver.Name = "allDriver";
            this.allDriver.Size = new System.Drawing.Size(296, 24);
            this.allDriver.TabIndex = 5;
            this.allDriver.SelectedIndexChanged += new System.EventHandler(this.allDriver_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(115, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vehicle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(115, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 38);
            this.label4.TabIndex = 8;
            this.label4.Text = "Driver";
            // 
            // cash
            // 
            this.cash.AutoSize = true;
            this.cash.BackColor = System.Drawing.Color.Transparent;
            this.cash.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash.Location = new System.Drawing.Point(314, 521);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(74, 29);
            this.cash.TabIndex = 9;
            this.cash.TabStop = true;
            this.cash.Text = "Cash";
            this.cash.UseVisualStyleBackColor = false;
            // 
            // wallet
            // 
            this.wallet.AutoSize = true;
            this.wallet.BackColor = System.Drawing.Color.Transparent;
            this.wallet.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wallet.Location = new System.Drawing.Point(420, 521);
            this.wallet.Name = "wallet";
            this.wallet.Size = new System.Drawing.Size(88, 29);
            this.wallet.TabIndex = 10;
            this.wallet.TabStop = true;
            this.wallet.Text = "Wallet";
            this.wallet.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(115, 513);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 38);
            this.label5.TabIndex = 11;
            this.label5.Text = "Payment";
            // 
            // requestTrip
            // 
            this.requestTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.requestTrip.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestTrip.ForeColor = System.Drawing.Color.White;
            this.requestTrip.Location = new System.Drawing.Point(614, 547);
            this.requestTrip.Name = "requestTrip";
            this.requestTrip.Size = new System.Drawing.Size(190, 62);
            this.requestTrip.TabIndex = 12;
            this.requestTrip.Text = "Request";
            this.requestTrip.UseVisualStyleBackColor = false;
            this.requestTrip.Click += new System.EventHandler(this.requestTrip_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(115, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 38);
            this.label6.TabIndex = 13;
            this.label6.Text = "Car Number";
            // 
            // carNumber
            // 
            this.carNumber.Location = new System.Drawing.Point(314, 379);
            this.carNumber.Name = "carNumber";
            this.carNumber.Size = new System.Drawing.Size(296, 22);
            this.carNumber.TabIndex = 14;
            // 
            // PayOfDriver
            // 
            this.PayOfDriver.Location = new System.Drawing.Point(314, 452);
            this.PayOfDriver.Name = "PayOfDriver";
            this.PayOfDriver.Size = new System.Drawing.Size(296, 22);
            this.PayOfDriver.TabIndex = 15;
            // 
            // Pay
            // 
            this.Pay.AutoSize = true;
            this.Pay.BackColor = System.Drawing.Color.Transparent;
            this.Pay.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Pay.Location = new System.Drawing.Point(115, 438);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(63, 38);
            this.Pay.TabIndex = 16;
            this.Pay.Text = "Pay";
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 621);
            this.Controls.Add(this.Pay);
            this.Controls.Add(this.PayOfDriver);
            this.Controls.Add(this.carNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.requestTrip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.wallet);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.allDriver);
            this.Controls.Add(this.allcars);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.LOCATION);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Name = "Request";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Request Trip";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LOCATION;
        private System.Windows.Forms.TextBox destination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox allcars;
        private System.Windows.Forms.ComboBox allDriver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton cash;
        private System.Windows.Forms.RadioButton wallet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button requestTrip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox carNumber;
        private System.Windows.Forms.TextBox PayOfDriver;
        private System.Windows.Forms.Label Pay;
    }
}

