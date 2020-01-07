namespace ColorClassifierShow
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
            this.tb_red = new System.Windows.Forms.TrackBar();
            this.tb_green = new System.Windows.Forms.TrackBar();
            this.tb_blue = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_red = new System.Windows.Forms.Label();
            this.lb_green = new System.Windows.Forms.Label();
            this.lb_blue = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_decision = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_red
            // 
            this.tb_red.Location = new System.Drawing.Point(335, 13);
            this.tb_red.Maximum = 255;
            this.tb_red.Name = "tb_red";
            this.tb_red.Size = new System.Drawing.Size(143, 45);
            this.tb_red.TabIndex = 0;
            this.tb_red.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // tb_green
            // 
            this.tb_green.Location = new System.Drawing.Point(335, 64);
            this.tb_green.Maximum = 255;
            this.tb_green.Name = "tb_green";
            this.tb_green.Size = new System.Drawing.Size(143, 45);
            this.tb_green.TabIndex = 1;
            this.tb_green.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // tb_blue
            // 
            this.tb_blue.Location = new System.Drawing.Point(335, 115);
            this.tb_blue.Maximum = 255;
            this.tb_blue.Name = "tb_blue";
            this.tb_blue.Size = new System.Drawing.Size(143, 45);
            this.tb_blue.TabIndex = 2;
            this.tb_blue.Scroll += new System.EventHandler(this.tb_blue_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "RED:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "GREEN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "BLUE:";
            // 
            // lb_red
            // 
            this.lb_red.AutoSize = true;
            this.lb_red.Location = new System.Drawing.Point(484, 21);
            this.lb_red.Name = "lb_red";
            this.lb_red.Size = new System.Drawing.Size(13, 13);
            this.lb_red.TabIndex = 6;
            this.lb_red.Text = "0";
            // 
            // lb_green
            // 
            this.lb_green.AutoSize = true;
            this.lb_green.Location = new System.Drawing.Point(484, 72);
            this.lb_green.Name = "lb_green";
            this.lb_green.Size = new System.Drawing.Size(13, 13);
            this.lb_green.TabIndex = 7;
            this.lb_green.Text = "0";
            // 
            // lb_blue
            // 
            this.lb_blue.AutoSize = true;
            this.lb_blue.Location = new System.Drawing.Point(484, 123);
            this.lb_blue.Name = "lb_blue";
            this.lb_blue.Size = new System.Drawing.Size(13, 13);
            this.lb_blue.TabIndex = 8;
            this.lb_blue.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 150);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lb_decision
            // 
            this.lb_decision.AutoSize = true;
            this.lb_decision.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_decision.Location = new System.Drawing.Point(87, 163);
            this.lb_decision.Name = "lb_decision";
            this.lb_decision.Size = new System.Drawing.Size(45, 32);
            this.lb_decision.TabIndex = 10;
            this.lb_decision.Text = "NA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_decision);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_blue);
            this.Controls.Add(this.lb_green);
            this.Controls.Add(this.lb_red);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_blue);
            this.Controls.Add(this.tb_green);
            this.Controls.Add(this.tb_red);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tb_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tb_red;
        private System.Windows.Forms.TrackBar tb_green;
        private System.Windows.Forms.TrackBar tb_blue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_red;
        private System.Windows.Forms.Label lb_green;
        private System.Windows.Forms.Label lb_blue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_decision;
    }
}

