namespace WindowsFormsApp1
{
    partial class 轰炸
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(轰炸));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 300F);
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(767, 400);
            this.label1.TabIndex = 0;
            this.label1.Text = "TNT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 50F);
            this.button1.Location = new System.Drawing.Point(100, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 157);
            this.button1.TabIndex = 1;
            this.button1.Text = "点火";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 40F);
            this.label2.Location = new System.Drawing.Point(392, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 54);
            this.label2.TabIndex = 3;
            this.label2.Text = "威力巨大";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 40F);
            this.label3.Location = new System.Drawing.Point(392, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 54);
            this.label3.TabIndex = 4;
            this.label3.Text = "无真实作用";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 40F);
            this.label4.Location = new System.Drawing.Point(392, 523);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 54);
            this.label4.TabIndex = 5;
            this.label4.Text = "（测试版）";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 40F);
            this.label5.Location = new System.Drawing.Point(342, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 54);
            this.label5.TabIndex = 6;
            this.label5.Text = "超级";
            // 
            // 轰炸
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 630);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "轰炸";
            this.Text = "轰炸";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}