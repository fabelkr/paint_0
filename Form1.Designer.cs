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
            this.btnClear = new System.Windows.Forms.Button();
            this.brushSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.lblBrushSize = new System.Windows.Forms.Label();
            this.numBrushSize = new System.Windows.Forms.NumericUpDown();
            this.cboBrushType = new System.Windows.Forms.ComboBox();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnGray = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnPurple = new System.Windows.Forms.Button();
            this.btnDBlue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupShapes = new System.Windows.Forms.GroupBox();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnRect = new System.Windows.Forms.Button();
            this.btnCanvasColor = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.brushSizeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrushSize)).BeginInit();
            this.groupShapes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
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
            "Oil Paint",
            "Eraser"});
            this.cboBrushType.Location = new System.Drawing.Point(644, 22);
            this.cboBrushType.Name = "cboBrushType";
            this.cboBrushType.Size = new System.Drawing.Size(120, 21);
            this.cboBrushType.TabIndex = 0;
            this.cboBrushType.SelectedIndexChanged += new System.EventHandler(this.cboBrushType_SelectedIndexChanged);
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.Location = new System.Drawing.Point(1061, 25);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(27, 23);
            this.btnBlack.TabIndex = 6;
            this.btnBlack.UseVisualStyleBackColor = false;
            // 
            // btnGray
            // 
            this.btnGray.BackColor = System.Drawing.Color.Gray;
            this.btnGray.Location = new System.Drawing.Point(1094, 25);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(27, 23);
            this.btnGray.TabIndex = 7;
            this.btnGray.UseVisualStyleBackColor = false;
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRed.Location = new System.Drawing.Point(1127, 25);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(27, 23);
            this.btnRed.TabIndex = 8;
            this.btnRed.UseVisualStyleBackColor = false;
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.Location = new System.Drawing.Point(1160, 25);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(27, 23);
            this.btnYellow.TabIndex = 9;
            this.btnYellow.UseVisualStyleBackColor = false;
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBlue.Location = new System.Drawing.Point(1061, 54);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(27, 23);
            this.btnBlue.TabIndex = 10;
            this.btnBlue.UseVisualStyleBackColor = false;
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGreen.Location = new System.Drawing.Point(1094, 54);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(27, 23);
            this.btnGreen.TabIndex = 11;
            this.btnGreen.UseVisualStyleBackColor = false;
            // 
            // btnPurple
            // 
            this.btnPurple.BackColor = System.Drawing.Color.Purple;
            this.btnPurple.Location = new System.Drawing.Point(1127, 54);
            this.btnPurple.Name = "btnPurple";
            this.btnPurple.Size = new System.Drawing.Size(27, 23);
            this.btnPurple.TabIndex = 12;
            this.btnPurple.UseVisualStyleBackColor = false;
            // 
            // btnDBlue
            // 
            this.btnDBlue.BackColor = System.Drawing.Color.Blue;
            this.btnDBlue.Location = new System.Drawing.Point(1160, 54);
            this.btnDBlue.Name = "btnDBlue";
            this.btnDBlue.Size = new System.Drawing.Size(27, 23);
            this.btnDBlue.TabIndex = 13;
            this.btnDBlue.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1091, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Preset Colours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1219, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Custom Colour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1311, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Canvas Colour";
            // 
            // groupShapes
            // 
            this.groupShapes.Controls.Add(this.btnCircle);
            this.groupShapes.Controls.Add(this.btnEllipse);
            this.groupShapes.Controls.Add(this.btnSquare);
            this.groupShapes.Controls.Add(this.btnRect);
            this.groupShapes.Location = new System.Drawing.Point(807, 9);
            this.groupShapes.Name = "groupShapes";
            this.groupShapes.Size = new System.Drawing.Size(200, 69);
            this.groupShapes.TabIndex = 18;
            this.groupShapes.TabStop = false;
            this.groupShapes.Text = "Shapes";
            // 
            // btnCircle
            // 
            this.btnCircle.BackColor = System.Drawing.Color.Transparent;
            this.btnCircle.BackgroundImage = global::paint_0.Properties.Resources.circle_thin_svgrepo_com;
            this.btnCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCircle.Location = new System.Drawing.Point(158, 19);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(36, 32);
            this.btnCircle.TabIndex = 19;
            this.btnCircle.UseVisualStyleBackColor = false;
            // 
            // btnEllipse
            // 
            this.btnEllipse.BackColor = System.Drawing.Color.Transparent;
            this.btnEllipse.BackgroundImage = global::paint_0.Properties.Resources.ellipse_outline_shape_variant_svgrepo_com;
            this.btnEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEllipse.Location = new System.Drawing.Point(104, 17);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(44, 35);
            this.btnEllipse.TabIndex = 20;
            this.btnEllipse.UseVisualStyleBackColor = false;
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.Color.Transparent;
            this.btnSquare.BackgroundImage = global::paint_0.Properties.Resources.square_svgrepo_com;
            this.btnSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSquare.Location = new System.Drawing.Point(59, 19);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(32, 32);
            this.btnSquare.TabIndex = 21;
            this.btnSquare.UseVisualStyleBackColor = false;
            // 
            // btnRect
            // 
            this.btnRect.BackColor = System.Drawing.Color.Transparent;
            this.btnRect.BackgroundImage = global::paint_0.Properties.Resources.rectangle_wide_svgrepo_com;
            this.btnRect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRect.Location = new System.Drawing.Point(11, 19);
            this.btnRect.Name = "btnRect";
            this.btnRect.Size = new System.Drawing.Size(42, 32);
            this.btnRect.TabIndex = 22;
            this.btnRect.UseVisualStyleBackColor = false;
            // 
            // btnCanvasColor
            // 
            this.btnCanvasColor.BackgroundImage = global::paint_0.Properties.Resources.canvas_svgrepo_com;
            this.btnCanvasColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCanvasColor.Location = new System.Drawing.Point(1311, 26);
            this.btnCanvasColor.Name = "btnCanvasColor";
            this.btnCanvasColor.Size = new System.Drawing.Size(75, 59);
            this.btnCanvasColor.TabIndex = 16;
            this.btnCanvasColor.UseVisualStyleBackColor = true;
            // 
            // btnColor
            // 
            this.btnColor.BackgroundImage = global::paint_0.Properties.Resources.gradient_design_svgrepo_com;
            this.btnColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColor.Location = new System.Drawing.Point(1219, 25);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 60);
            this.btnColor.TabIndex = 1;
            this.btnColor.UseVisualStyleBackColor = true;
            // 
            // canvas
            // 
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1995, 1235);
            this.Controls.Add(this.btnBlack);
            this.Controls.Add(this.groupShapes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCanvasColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDBlue);
            this.Controls.Add(this.btnPurple);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnGray);
            this.Controls.Add(this.cboBrushType);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.numBrushSize);
            this.Controls.Add(this.lblBrushSize);
            this.Controls.Add(this.brushSizeTrackBar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.brushSizeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrushSize)).EndInit();
            this.groupShapes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
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
        private Button btnBlack;
        private Button btnGray;
        private Button btnRed;
        private Button btnYellow;
        private Button btnBlue;
        private Button btnGreen;
        private Button btnPurple;
        private Button btnDBlue;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCanvasColor;
        private GroupBox groupShapes;
        private Button btnCircle;
        private Button btnEllipse;
        private Button btnSquare;
        private Button btnRect;
    }
}

