namespace Adrians_Minesweeper
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslWidth = new System.Windows.Forms.ToolStripLabel();
            this.tstbWidth = new System.Windows.Forms.ToolStripTextBox();
            this.tslHeight = new System.Windows.Forms.ToolStripLabel();
            this.tstbHeight = new System.Windows.Forms.ToolStripTextBox();
            this.tslMines = new System.Windows.Forms.ToolStripLabel();
            this.tstbMines = new System.Windows.Forms.ToolStripTextBox();
            this.tstbStart = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tstbAutoFlag = new System.Windows.Forms.ToolStripButton();
            this.tstbAutoClear = new System.Windows.Forms.ToolStripButton();
            this.tslTime = new System.Windows.Forms.ToolStripLabel();
            this.tslFlagged = new System.Windows.Forms.ToolStripLabel();
            this.tslWinLoose = new System.Windows.Forms.ToolStripLabel();
            this.panMain = new System.Windows.Forms.Panel();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
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
            this.tstbHeight,
            this.tslMines,
            this.tstbMines,
            this.tstbStart});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(897, 37);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslWidth
            // 
            this.tslWidth.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslWidth.Name = "tslWidth";
            this.tslWidth.Size = new System.Drawing.Size(34, 34);
            this.tslWidth.Text = "W";
            // 
            // tstbWidth
            // 
            this.tstbWidth.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstbWidth.Name = "tstbWidth";
            this.tstbWidth.Size = new System.Drawing.Size(40, 37);
            this.tstbWidth.Text = "30";
            // 
            // tslHeight
            // 
            this.tslHeight.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslHeight.Name = "tslHeight";
            this.tslHeight.Size = new System.Drawing.Size(29, 34);
            this.tslHeight.Text = "H";
            // 
            // tstbHeight
            // 
            this.tstbHeight.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstbHeight.Name = "tstbHeight";
            this.tstbHeight.Size = new System.Drawing.Size(40, 37);
            this.tstbHeight.Text = "20";
            // 
            // tslMines
            // 
            this.tslMines.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslMines.Name = "tslMines";
            this.tslMines.Size = new System.Drawing.Size(33, 34);
            this.tslMines.Text = "M";
            // 
            // tstbMines
            // 
            this.tstbMines.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstbMines.Name = "tstbMines";
            this.tstbMines.Size = new System.Drawing.Size(50, 37);
            this.tstbMines.Text = "100";
            // 
            // tstbStart
            // 
            this.tstbStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstbStart.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstbStart.Image = ((System.Drawing.Image)(resources.GetObject("tstbStart.Image")));
            this.tstbStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstbStart.Name = "tstbStart";
            this.tstbStart.Size = new System.Drawing.Size(64, 34);
            this.tstbStart.Text = "Start";
            this.tstbStart.Click += new System.EventHandler(this.tstbStart_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstbAutoFlag,
            this.tstbAutoClear,
            this.tslTime,
            this.tslFlagged,
            this.tslWinLoose});
            this.toolStrip2.Location = new System.Drawing.Point(0, 37);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(897, 37);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tstbAutoFlag
            // 
            this.tstbAutoFlag.CheckOnClick = true;
            this.tstbAutoFlag.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstbAutoFlag.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstbAutoFlag.Image = ((System.Drawing.Image)(resources.GetObject("tstbAutoFlag.Image")));
            this.tstbAutoFlag.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstbAutoFlag.Name = "tstbAutoFlag";
            this.tstbAutoFlag.Size = new System.Drawing.Size(43, 34);
            this.tstbAutoFlag.Text = "AF";
            this.tstbAutoFlag.CheckStateChanged += new System.EventHandler(this.tstbAutoFlag_CheckStateChanged);
            // 
            // tstbAutoClear
            // 
            this.tstbAutoClear.CheckOnClick = true;
            this.tstbAutoClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstbAutoClear.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstbAutoClear.Image = ((System.Drawing.Image)(resources.GetObject("tstbAutoClear.Image")));
            this.tstbAutoClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstbAutoClear.Name = "tstbAutoClear";
            this.tstbAutoClear.Size = new System.Drawing.Size(45, 34);
            this.tstbAutoClear.Text = "AC";
            this.tstbAutoClear.CheckStateChanged += new System.EventHandler(this.tstbAutoClear_CheckStateChanged);
            // 
            // tslTime
            // 
            this.tslTime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslTime.Name = "tslTime";
            this.tslTime.Size = new System.Drawing.Size(49, 34);
            this.tslTime.Text = "T: 0";
            // 
            // tslFlagged
            // 
            this.tslFlagged.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslFlagged.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslFlagged.Name = "tslFlagged";
            this.tslFlagged.Size = new System.Drawing.Size(48, 34);
            this.tslFlagged.Text = "F: 0";
            // 
            // tslWinLoose
            // 
            this.tslWinLoose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslWinLoose.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslWinLoose.Name = "tslWinLoose";
            this.tslWinLoose.Size = new System.Drawing.Size(163, 34);
            this.tslWinLoose.Text = "toolStripLabel1";
            this.tslWinLoose.Visible = false;
            // 
            // panMain
            // 
            this.panMain.AutoScroll = true;
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(0, 74);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(897, 404);
            this.panMain.TabIndex = 2;
            // 
            // tmrMain
            // 
            this.tmrMain.Interval = 1000;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(897, 478);
            this.Controls.Add(this.panMain);
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
        private System.Windows.Forms.ToolStripTextBox tstbHeight;
        private System.Windows.Forms.ToolStripLabel tslMines;
        private System.Windows.Forms.ToolStripTextBox tstbMines;
        private System.Windows.Forms.ToolStripButton tstbStart;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tstbAutoFlag;
        private System.Windows.Forms.ToolStripButton tstbAutoClear;
        private System.Windows.Forms.ToolStripLabel tslTime;
        private System.Windows.Forms.ToolStripLabel tslFlagged;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.ToolStripLabel tslWinLoose;
        private System.Windows.Forms.Timer tmrMain;
    }
}

