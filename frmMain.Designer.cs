namespace _16bitColorViewer
{
    partial class frmMain
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
            this.lblColor = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.cbTopMost = new System.Windows.Forms.CheckBox();
            this.lblRGB = new System.Windows.Forms.Label();
            this.btnExpand = new System.Windows.Forms.Button();
            this.pnBG = new System.Windows.Forms.Panel();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txt16bitFromRGB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.pnBG.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(10, 14);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(100, 13);
            this.lblColor.TabIndex = 0;
            this.lblColor.Text = "Insert 16 bit integer:";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(116, 11);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(118, 20);
            this.txtColor.TabIndex = 1;
            this.txtColor.Text = "0";
            this.txtColor.TextChanged += new System.EventHandler(this.txtColor_TextChanged);
            this.txtColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColor_KeyPress);
            // 
            // cbTopMost
            // 
            this.cbTopMost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbTopMost.AutoSize = true;
            this.cbTopMost.Location = new System.Drawing.Point(13, 160);
            this.cbTopMost.Name = "cbTopMost";
            this.cbTopMost.Size = new System.Drawing.Size(84, 17);
            this.cbTopMost.TabIndex = 2;
            this.cbTopMost.Text = "Keep on top";
            this.cbTopMost.UseVisualStyleBackColor = true;
            this.cbTopMost.CheckedChanged += new System.EventHandler(this.cbTopMost_CheckedChanged);
            // 
            // lblRGB
            // 
            this.lblRGB.AutoSize = true;
            this.lblRGB.Location = new System.Drawing.Point(113, 34);
            this.lblRGB.Name = "lblRGB";
            this.lblRGB.Size = new System.Drawing.Size(40, 13);
            this.lblRGB.TabIndex = 3;
            this.lblRGB.Text = "lblRGB";
            // 
            // btnExpand
            // 
            this.btnExpand.Location = new System.Drawing.Point(238, 83);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(14, 25);
            this.btnExpand.TabIndex = 4;
            this.btnExpand.Text = ">";
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // pnBG
            // 
            this.pnBG.Controls.Add(this.lblColor);
            this.pnBG.Controls.Add(this.txtColor);
            this.pnBG.Controls.Add(this.cbTopMost);
            this.pnBG.Controls.Add(this.lblRGB);
            this.pnBG.Location = new System.Drawing.Point(0, -1);
            this.pnBG.Name = "pnBG";
            this.pnBG.Size = new System.Drawing.Size(237, 190);
            this.pnBG.TabIndex = 5;
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(6, 15);
            this.txtR.MaxLength = 3;
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(37, 20);
            this.txtR.TabIndex = 8;
            this.txtR.TextChanged += new System.EventHandler(this.txtR_TextChanged);
            this.txtR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtR_KeyPress);
            // 
            // txt16bitFromRGB
            // 
            this.txt16bitFromRGB.Location = new System.Drawing.Point(6, 74);
            this.txt16bitFromRGB.Name = "txt16bitFromRGB";
            this.txt16bitFromRGB.ReadOnly = true;
            this.txt16bitFromRGB.Size = new System.Drawing.Size(144, 20);
            this.txt16bitFromRGB.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.txtG);
            this.groupBox1.Controls.Add(this.txt16bitFromRGB);
            this.groupBox1.Controls.Add(this.txtR);
            this.groupBox1.Location = new System.Drawing.Point(256, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RGB to 16bit";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(113, 15);
            this.txtB.MaxLength = 3;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(37, 20);
            this.txtB.TabIndex = 13;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_KeyPress);
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(60, 15);
            this.txtG.MaxLength = 3;
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(37, 20);
            this.txtG.TabIndex = 12;
            this.txtG.TextChanged += new System.EventHandler(this.txtG_TextChanged);
            this.txtG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtG_KeyPress);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 188);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnBG);
            this.Controls.Add(this.btnExpand);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "16 bit color viewer";
            this.pnBG.ResumeLayout(false);
            this.pnBG.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.CheckBox cbTopMost;
        private System.Windows.Forms.Label lblRGB;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Panel pnBG;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txt16bitFromRGB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtG;
    }
}

