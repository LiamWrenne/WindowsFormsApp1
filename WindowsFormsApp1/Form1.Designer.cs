
namespace WindowsFormsApp1
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
            this.b7 = new System.Windows.Forms.Button();
            this.textbox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.bDiv = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.bMul = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.bSub = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bEq = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.bpow = new System.Windows.Forms.Button();
            this.broot = new System.Windows.Forms.Button();
            this.bmc = new System.Windows.Forms.Button();
            this.textboxmem = new System.Windows.Forms.TextBox();
            this.bmem = new System.Windows.Forms.Button();
            this.bdot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b7
            // 
            this.b7.BackColor = System.Drawing.SystemColors.Desktop;
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b7.Location = new System.Drawing.Point(69, 169);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(73, 66);
            this.b7.TabIndex = 0;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = false;
            this.b7.Click += new System.EventHandler(this.NumEvent);
            // 
            // textbox
            // 
            this.textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox.Location = new System.Drawing.Point(69, 74);
            this.textbox.Name = "textbox";
            this.textbox.ReadOnly = true;
            this.textbox.Size = new System.Drawing.Size(311, 24);
            this.textbox.TabIndex = 1;
            this.textbox.Text = "0";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.Location = new System.Drawing.Point(67, 29);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 18);
            this.label.TabIndex = 2;
            // 
            // b8
            // 
            this.b8.BackColor = System.Drawing.SystemColors.Desktop;
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b8.Location = new System.Drawing.Point(148, 169);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(73, 66);
            this.b8.TabIndex = 0;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = false;
            this.b8.Click += new System.EventHandler(this.NumEvent);
            // 
            // b9
            // 
            this.b9.BackColor = System.Drawing.SystemColors.Desktop;
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b9.Location = new System.Drawing.Point(227, 169);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(73, 66);
            this.b9.TabIndex = 0;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = false;
            this.b9.Click += new System.EventHandler(this.NumEvent);
            // 
            // bDiv
            // 
            this.bDiv.BackColor = System.Drawing.SystemColors.Desktop;
            this.bDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bDiv.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bDiv.Location = new System.Drawing.Point(69, 96);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(73, 66);
            this.bDiv.TabIndex = 0;
            this.bDiv.Text = "/";
            this.bDiv.UseVisualStyleBackColor = false;
            this.bDiv.Click += new System.EventHandler(this.OperandEvent);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.SystemColors.Desktop;
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b4.Location = new System.Drawing.Point(69, 242);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(73, 66);
            this.b4.TabIndex = 0;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.NumEvent);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.SystemColors.Desktop;
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b5.Location = new System.Drawing.Point(148, 242);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(73, 66);
            this.b5.TabIndex = 0;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.NumEvent);
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.SystemColors.Desktop;
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b6.Location = new System.Drawing.Point(227, 242);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(73, 66);
            this.b6.TabIndex = 0;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = false;
            this.b6.Click += new System.EventHandler(this.NumEvent);
            // 
            // bMul
            // 
            this.bMul.BackColor = System.Drawing.SystemColors.Desktop;
            this.bMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bMul.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bMul.Location = new System.Drawing.Point(148, 96);
            this.bMul.Name = "bMul";
            this.bMul.Size = new System.Drawing.Size(73, 66);
            this.bMul.TabIndex = 0;
            this.bMul.Text = "*";
            this.bMul.UseVisualStyleBackColor = false;
            this.bMul.Click += new System.EventHandler(this.OperandEvent);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.SystemColors.Desktop;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b1.Location = new System.Drawing.Point(69, 315);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(73, 66);
            this.b1.TabIndex = 0;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.NumEvent);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.SystemColors.Desktop;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b2.Location = new System.Drawing.Point(148, 315);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(73, 66);
            this.b2.TabIndex = 0;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.NumEvent);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.SystemColors.Desktop;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b3.Location = new System.Drawing.Point(227, 315);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(73, 66);
            this.b3.TabIndex = 0;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.NumEvent);
            // 
            // bSub
            // 
            this.bSub.BackColor = System.Drawing.SystemColors.Desktop;
            this.bSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSub.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bSub.Location = new System.Drawing.Point(227, 96);
            this.bSub.Name = "bSub";
            this.bSub.Size = new System.Drawing.Size(73, 66);
            this.bSub.TabIndex = 0;
            this.bSub.Text = "-";
            this.bSub.UseVisualStyleBackColor = false;
            this.bSub.Click += new System.EventHandler(this.OperandEvent);
            // 
            // b0
            // 
            this.b0.BackColor = System.Drawing.SystemColors.Desktop;
            this.b0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b0.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b0.Location = new System.Drawing.Point(69, 387);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(73, 66);
            this.b0.TabIndex = 0;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = false;
            this.b0.Click += new System.EventHandler(this.NumEvent);
            // 
            // bEq
            // 
            this.bEq.BackColor = System.Drawing.SystemColors.Desktop;
            this.bEq.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bEq.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bEq.Location = new System.Drawing.Point(306, 315);
            this.bEq.Name = "bEq";
            this.bEq.Size = new System.Drawing.Size(73, 138);
            this.bEq.TabIndex = 0;
            this.bEq.Text = "=";
            this.bEq.UseVisualStyleBackColor = false;
            this.bEq.Click += new System.EventHandler(this.bEq_Click);
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.SystemColors.Desktop;
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bAdd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bAdd.Location = new System.Drawing.Point(306, 96);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(73, 66);
            this.bAdd.TabIndex = 0;
            this.bAdd.Text = "+";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.OperandEvent);
            // 
            // bC
            // 
            this.bC.BackColor = System.Drawing.SystemColors.Desktop;
            this.bC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bC.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bC.Location = new System.Drawing.Point(227, 387);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(73, 66);
            this.bC.TabIndex = 0;
            this.bC.Text = "C";
            this.bC.UseVisualStyleBackColor = false;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // bpow
            // 
            this.bpow.BackColor = System.Drawing.SystemColors.Desktop;
            this.bpow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bpow.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bpow.Location = new System.Drawing.Point(306, 169);
            this.bpow.Name = "bpow";
            this.bpow.Size = new System.Drawing.Size(73, 66);
            this.bpow.TabIndex = 4;
            this.bpow.Text = "^";
            this.bpow.UseVisualStyleBackColor = false;
            this.bpow.Click += new System.EventHandler(this.OperandEvent);
            // 
            // broot
            // 
            this.broot.BackColor = System.Drawing.SystemColors.Desktop;
            this.broot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.broot.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.broot.Location = new System.Drawing.Point(306, 242);
            this.broot.Name = "broot";
            this.broot.Size = new System.Drawing.Size(73, 66);
            this.broot.TabIndex = 5;
            this.broot.Text = "√";
            this.broot.UseVisualStyleBackColor = false;
            this.broot.Click += new System.EventHandler(this.OperandEvent);
            // 
            // bmc
            // 
            this.bmc.BackColor = System.Drawing.SystemColors.Desktop;
            this.bmc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bmc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bmc.Location = new System.Drawing.Point(612, 279);
            this.bmc.Name = "bmc";
            this.bmc.Size = new System.Drawing.Size(73, 138);
            this.bmc.TabIndex = 6;
            this.bmc.Text = "MC";
            this.bmc.UseVisualStyleBackColor = false;
            this.bmc.Click += new System.EventHandler(this.bMC_Click);
            // 
            // textboxmem
            // 
            this.textboxmem.Location = new System.Drawing.Point(413, 96);
            this.textboxmem.Multiline = true;
            this.textboxmem.Name = "textboxmem";
            this.textboxmem.ReadOnly = true;
            this.textboxmem.Size = new System.Drawing.Size(171, 357);
            this.textboxmem.TabIndex = 7;
            // 
            // bmem
            // 
            this.bmem.BackColor = System.Drawing.SystemColors.Desktop;
            this.bmem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bmem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bmem.Location = new System.Drawing.Point(612, 135);
            this.bmem.Name = "bmem";
            this.bmem.Size = new System.Drawing.Size(73, 138);
            this.bmem.TabIndex = 8;
            this.bmem.Text = "MEM";
            this.bmem.UseVisualStyleBackColor = false;
            this.bmem.Click += new System.EventHandler(this.bMEM_Click);
            // 
            // bdot
            // 
            this.bdot.BackColor = System.Drawing.SystemColors.Desktop;
            this.bdot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bdot.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bdot.Location = new System.Drawing.Point(148, 387);
            this.bdot.Name = "bdot";
            this.bdot.Size = new System.Drawing.Size(73, 66);
            this.bdot.TabIndex = 9;
            this.bdot.Text = ".";
            this.bdot.UseVisualStyleBackColor = false;
            this.bdot.Click += new System.EventHandler(this.NumEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(758, 529);
            this.Controls.Add(this.bdot);
            this.Controls.Add(this.bmem);
            this.Controls.Add(this.textboxmem);
            this.Controls.Add(this.bmc);
            this.Controls.Add(this.broot);
            this.Controls.Add(this.bpow);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bSub);
            this.Controls.Add(this.bMul);
            this.Controls.Add(this.bDiv);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.bC);
            this.Controls.Add(this.bEq);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator 9000";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button bDiv;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button bMul;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button bSub;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bEq;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Button bpow;
        private System.Windows.Forms.Button broot;
        private System.Windows.Forms.Button bmc;
        private System.Windows.Forms.TextBox textboxmem;
        private System.Windows.Forms.Button bmem;
        private System.Windows.Forms.Button bdot;
    }
}

