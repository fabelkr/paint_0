using System.Windows.Forms;

namespace paint_0
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
            this.canvas = new System.Windows.Forms.PictureBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.brushSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.lblBrushSize = new System.Windows.Forms.Label();
            this.numBrushSize = new System.Windows.Forms.NumericUpDown();
            this.cboBrushType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brushSizeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrushSize)).BeginInit();
            this.SuspendLayout();

            this.canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Location = new System.Drawing.Point(23, 98);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1950, 1082);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(1282, 32);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "COLOR";
            this.btnColor.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1405, 32);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // brushSizeTrackBar
            // 
            this.brushSizeTrackBar.Location = new System.Drawing.Point(190, 14);
            this.brushSizeTrackBar.Maximum = 250;
            this.brushSizeTrackBar.Minimum = 1;
            this.brushSizeTrackBar.Name = "brushSizeTrackBar";
            this.brushSizeTrackBar.Size = new System.Drawing.Size(200, 45);
            this.brushSizeTrackBar.TabIndex = 3;
            this.brushSizeTrackBar.Value = 3;
            this.brushSizeTrackBar.Scroll += new System.EventHandler(this.brushSizeTrackBar_Scroll);
            // 
            // lblBrushSize
            // 
            this.lblBrushSize.AutoSize = true;
            this.lblBrushSize.Location = new System.Drawing.Point(410, 25);
            this.lblBrushSize.Name = "lblBrushSize";
            this.lblBrushSize.Size = new System.Drawing.Size(99, 13);
            this.lblBrushSize.TabIndex = 4;
            this.lblBrushSize.Text = "Velikost štětce: 3px";
            // 
            // numBrushSize
            // 
            this.numBrushSize.Location = new System.Drawing.Point(515, 23);
            this.numBrushSize.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numBrushSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBrushSize.Name = "numBrushSize";
            this.numBrushSize.Size = new System.Drawing.Size(50, 20);
            this.numBrushSize.TabIndex = 5;
            this.numBrushSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numBrushSize.ValueChanged += new System.EventHandler(this.numBrushSize_ValueChanged);
            // 
            // cboBrushType
            // 
            this.cboBrushType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBrushType.Items.AddRange(new object[] {
            "Default",
            "Spray",
            "Crayon",
            "Calligraphy",
            "Marker",
            "Oil Paint"});
            this.cboBrushType.Location = new System.Drawing.Point(644, 22);
            this.cboBrushType.Name = "cboBrushType";
            this.cboBrushType.Size = new System.Drawing.Size(120, 21);
            this.cboBrushType.TabIndex = 0;
            this.cboBrushType.SelectedIndexChanged += new System.EventHandler(this.cboBrushType_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1995, 1235);
            this.Controls.Add(this.cboBrushType);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.numBrushSize);
            this.Controls.Add(this.lblBrushSize);
            this.Controls.Add(this.brushSizeTrackBar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brushSizeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrushSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnClear;
        private TrackBar brushSizeTrackBar;
        private Label lblBrushSize;
        private NumericUpDown numBrushSize;
        private ComboBox cboBrushType;
    }
}

