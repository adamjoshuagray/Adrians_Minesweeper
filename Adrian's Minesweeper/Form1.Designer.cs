namespace Adrian_s_Minesweeper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tstbWidth = new System.Windows.Forms.ToolStripTextBox();
            this.tslWidth = new System.Windows.Forms.ToolStripLabel();
            this.tslHeight = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.tslMines = new System.Windows.Forms.ToolStripLabel();
            this.tstbMines = new System.Windows.Forms.ToolStripTextBox();
            this.tstbStart = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tstbAutoFlag = new System.Windows.Forms.ToolStripButton();
            this.tstbAutoClear = new System.Windows.Forms.ToolStripButton();
            this.tstbDeepFlag = new System.Windows.Forms.ToolStripButton();
            this.tslTime = new System.Windows.Forms.ToolStripLabel();
            this.tslFlagged = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslWidth,
            this.tstbWidth,
            this.tslHeight,
            this.toolStripTextBox2,
            this.tslMines,
            this.tstbMines,
            this.tstbStart});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(897, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tstbWidth
            // 
            this.tstbWidth.Name = "tstbWidth";
            this.tstbWidth.Size = new System.Drawing.Size(40, 25);
            // 
            // tslWidth
            // 
            this.tslWidth.Name = "tslWidth";
            this.tslWidth.Size = new System.Drawing.Size(18, 22);
            this.tslWidth.Text = "W";
            // 
            // tslHeight
            // 
            this.tslHeight.Name = "tslHeight";
            this.tslHeight.Size = new System.Drawing.Size(16, 22);
            this.tslHeight.Text = "H";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(40, 25);
            // 
            // tslMines
            // 
            this.tslMines.Name = "tslMines";
            this.tslMines.Size = new System.Drawing.Size(18, 22);
            this.tslMines.Text = "M";
            // 
            // tstbMines
            // 
            this.tstbMines.Name = "tstbMines";
            this.tstbMines.Size = new System.Drawing.Size(40, 25);
            // 
            // tstbStart
            // 
            this.tstbStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstbStart.Image = ((System.Drawing.Image)(resources.GetObject("tstbStart.Image")));
            this.tstbStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstbStart.Name = "tstbStart";
            this.tstbStart.Size = new System.Drawing.Size(35, 22);
            this.tstbStart.Text = "Start";
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstbAutoFlag,
            this.tstbAutoClear,
            this.tstbDeepFlag,
            this.tslTime,
            this.tslFlagged});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(897, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tstbAutoFlag
            // 
            this.tstbAutoFlag.CheckOnClick = true;
            this.tstbAutoFlag.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstbAutoFlag.Image = ((System.Drawing.Image)(resources.GetObject("tstbAutoFlag.Image")));
            this.tstbAutoFlag.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstbAutoFlag.Name = "tstbAutoFlag";
            this.tstbAutoFlag.Size = new System.Drawing.Size(25, 22);
            this.tstbAutoFlag.Text = "AF";
            // 
            // tstbAutoClear
            // 
            this.tstbAutoClear.CheckOnClick = true;
            this.tstbAutoClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstbAutoClear.Image = ((System.Drawing.Image)(resources.GetObject("tstbAutoClear.Image")));
            this.tstbAutoClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstbAutoClear.Name = "tstbAutoClear";
            this.tstbAutoClear.Size = new System.Drawing.Size(27, 22);
            this.tstbAutoClear.Text = "AC";
            // 
            // tstbDeepFlag
            // 
            this.tstbDeepFlag.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstbDeepFlag.Image = ((System.Drawing.Image)(resources.GetObject("tstbDeepFlag.Image")));
            this.tstbDeepFlag.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstbDeepFlag.Name = "tstbDeepFlag";
            this.tstbDeepFlag.Size = new System.Drawing.Size(25, 22);
            this.tstbDeepFlag.Text = "DF";
            // 
            // tslTime
            // 
            this.tslTime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslTime.Name = "tslTime";
            this.tslTime.Size = new System.Drawing.Size(26, 22);
            this.tslTime.Text = "T: 0";
            // 
            // tslFlagged
            // 
            this.tslFlagged.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslFlagged.Name = "tslFlagged";
            this.tslFlagged.Size = new System.Drawing.Size(25, 22);
            this.tslFlagged.Text = "F: 0";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 478);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMain";
            this.Text = "Adrian\'s Minesweeper";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslWidth;
        private System.Windows.Forms.ToolStripTextBox tstbWidth;
        private System.Windows.Forms.ToolStripLabel tslHeight;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripLabel tslMines;
        private System.Windows.Forms.ToolStripTextBox tstbMines;
        private System.Windows.Forms.ToolStripButton tstbStart;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tstbAutoFlag;
        private System.Windows.Forms.ToolStripButton tstbAutoClear;
        private System.Windows.Forms.ToolStripButton tstbDeepFlag;
        private System.Windows.Forms.ToolStripLabel tslTime;
        private System.Windows.Forms.ToolStripLabel tslFlagged;
    }
}

