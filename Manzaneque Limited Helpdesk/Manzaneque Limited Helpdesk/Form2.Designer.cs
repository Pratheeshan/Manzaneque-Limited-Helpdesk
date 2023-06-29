namespace Manzaneque_Limited_Helpdesk
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnlogOut = new System.Windows.Forms.Button();
            this.btnresolution = new System.Windows.Forms.Button();
            this.btncallLog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnlogOut
            // 
            this.btnlogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnlogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnlogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogOut.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogOut.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnlogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnlogOut.Image")));
            this.btnlogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlogOut.Location = new System.Drawing.Point(672, 27);
            this.btnlogOut.Name = "btnlogOut";
            this.btnlogOut.Size = new System.Drawing.Size(148, 53);
            this.btnlogOut.TabIndex = 132;
            this.btnlogOut.Text = "Logout";
            this.btnlogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogOut.UseVisualStyleBackColor = false;
            this.btnlogOut.Click += new System.EventHandler(this.btnlogOut_Click);
            // 
            // btnresolution
            // 
            this.btnresolution.BackColor = System.Drawing.Color.Transparent;
            this.btnresolution.BackgroundImage = global::Manzaneque_Limited_Helpdesk.Properties.Resources.button;
            this.btnresolution.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnresolution.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnresolution.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresolution.ForeColor = System.Drawing.Color.White;
            this.btnresolution.Image = ((System.Drawing.Image)(resources.GetObject("btnresolution.Image")));
            this.btnresolution.Location = new System.Drawing.Point(452, 228);
            this.btnresolution.Name = "btnresolution";
            this.btnresolution.Size = new System.Drawing.Size(223, 219);
            this.btnresolution.TabIndex = 131;
            this.btnresolution.Text = "Resolution Log";
            this.btnresolution.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnresolution.UseVisualStyleBackColor = false;
            this.btnresolution.Click += new System.EventHandler(this.btnresolution_Click);
            // 
            // btncallLog
            // 
            this.btncallLog.BackColor = System.Drawing.Color.Transparent;
            this.btncallLog.BackgroundImage = global::Manzaneque_Limited_Helpdesk.Properties.Resources.button;
            this.btncallLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncallLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncallLog.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncallLog.ForeColor = System.Drawing.Color.White;
            this.btncallLog.Image = ((System.Drawing.Image)(resources.GetObject("btncallLog.Image")));
            this.btncallLog.Location = new System.Drawing.Point(147, 228);
            this.btncallLog.Name = "btncallLog";
            this.btncallLog.Size = new System.Drawing.Size(223, 219);
            this.btncallLog.TabIndex = 130;
            this.btncallLog.Text = "Caller Log";
            this.btncallLog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncallLog.UseVisualStyleBackColor = false;
            this.btncallLog.Click += new System.EventHandler(this.btncallLog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(309, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 45);
            this.label1.TabIndex = 129;
            this.label1.Text = "Dashboard";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(690, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 133;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Manzaneque_Limited_Helpdesk.Properties.Resources.Ui1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(832, 614);
            this.Controls.Add(this.btnlogOut);
            this.Controls.Add(this.btnresolution);
            this.Controls.Add(this.btncallLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogOut;
        private System.Windows.Forms.Button btnresolution;
        private System.Windows.Forms.Button btncallLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}