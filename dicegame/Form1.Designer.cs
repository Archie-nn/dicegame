namespace dicegame
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
            this.btnRoll = new System.Windows.Forms.Button();
            this.numBet = new System.Windows.Forms.NumericUpDown();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.picP1 = new System.Windows.Forms.PictureBox();
            this.picP2 = new System.Windows.Forms.PictureBox();
            this.picP3 = new System.Windows.Forms.PictureBox();
            this.picP4 = new System.Windows.Forms.PictureBox();
            this.picC1 = new System.Windows.Forms.PictureBox();
            this.picC2 = new System.Windows.Forms.PictureBox();
            this.picC3 = new System.Windows.Forms.PictureBox();
            this.picC4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picC3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picC4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(236, 371);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 23);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "擲骰";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // numBet
            // 
            this.numBet.Location = new System.Drawing.Point(515, 371);
            this.numBet.Name = "numBet";
            this.numBet.Size = new System.Drawing.Size(120, 22);
            this.numBet.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(351, 297);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 12);
            this.lblResult.TabIndex = 6;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(379, 376);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(33, 12);
            this.lblMoney.TabIndex = 7;
            this.lblMoney.Text = "label6";
            this.lblMoney.Click += new System.EventHandler(this.lblMoney_Click);
            // 
            // picP1
            // 
            this.picP1.Location = new System.Drawing.Point(666, 116);
            this.picP1.Name = "picP1";
            this.picP1.Size = new System.Drawing.Size(100, 50);
            this.picP1.TabIndex = 8;
            this.picP1.TabStop = false;
            // 
            // picP2
            // 
            this.picP2.Location = new System.Drawing.Point(524, 116);
            this.picP2.Name = "picP2";
            this.picP2.Size = new System.Drawing.Size(100, 50);
            this.picP2.TabIndex = 9;
            this.picP2.TabStop = false;
            // 
            // picP3
            // 
            this.picP3.Location = new System.Drawing.Point(524, 222);
            this.picP3.Name = "picP3";
            this.picP3.Size = new System.Drawing.Size(100, 50);
            this.picP3.TabIndex = 10;
            this.picP3.TabStop = false;
            // 
            // picP4
            // 
            this.picP4.Location = new System.Drawing.Point(666, 222);
            this.picP4.Name = "picP4";
            this.picP4.Size = new System.Drawing.Size(100, 50);
            this.picP4.TabIndex = 11;
            this.picP4.TabStop = false;
            // 
            // picC1
            // 
            this.picC1.Location = new System.Drawing.Point(12, 116);
            this.picC1.Name = "picC1";
            this.picC1.Size = new System.Drawing.Size(100, 50);
            this.picC1.TabIndex = 12;
            this.picC1.TabStop = false;
            // 
            // picC2
            // 
            this.picC2.Location = new System.Drawing.Point(128, 116);
            this.picC2.Name = "picC2";
            this.picC2.Size = new System.Drawing.Size(100, 50);
            this.picC2.TabIndex = 13;
            this.picC2.TabStop = false;
            // 
            // picC3
            // 
            this.picC3.Location = new System.Drawing.Point(12, 222);
            this.picC3.Name = "picC3";
            this.picC3.Size = new System.Drawing.Size(100, 50);
            this.picC3.TabIndex = 14;
            this.picC3.TabStop = false;
            // 
            // picC4
            // 
            this.picC4.Location = new System.Drawing.Point(128, 222);
            this.picC4.Name = "picC4";
            this.picC4.Size = new System.Drawing.Size(100, 50);
            this.picC4.TabIndex = 15;
            this.picC4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picC4);
            this.Controls.Add(this.picC3);
            this.Controls.Add(this.picC2);
            this.Controls.Add(this.picC1);
            this.Controls.Add(this.picP4);
            this.Controls.Add(this.picP3);
            this.Controls.Add(this.picP2);
            this.Controls.Add(this.picP1);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.numBet);
            this.Controls.Add(this.btnRoll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picC3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picC4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.NumericUpDown numBet;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.PictureBox picP1;
        private System.Windows.Forms.PictureBox picP2;
        private System.Windows.Forms.PictureBox picP3;
        private System.Windows.Forms.PictureBox picP4;
        private System.Windows.Forms.PictureBox picC1;
        private System.Windows.Forms.PictureBox picC2;
        private System.Windows.Forms.PictureBox picC3;
        private System.Windows.Forms.PictureBox picC4;
    }
}

