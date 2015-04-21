namespace VG2
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
            this.components = new System.ComponentModel.Container();
            this.pnlRenderArea = new System.Windows.Forms.Panel();
            this.gTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlRenderArea
            // 
            this.pnlRenderArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRenderArea.Location = new System.Drawing.Point(23, 13);
            this.pnlRenderArea.Name = "pnlRenderArea";
            this.pnlRenderArea.Size = new System.Drawing.Size(200, 100);
            this.pnlRenderArea.TabIndex = 0;
            this.pnlRenderArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlRenderArea_MouseDown);
            // 
            // gTimer
            // 
            this.gTimer.Interval = 50;
            this.gTimer.Tick += new System.EventHandler(this.gTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pnlRenderArea);
            this.Name = "Form1";
            this.Text = "VG2 - Test";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRenderArea;
        private System.Windows.Forms.Timer gTimer;
    }
}

