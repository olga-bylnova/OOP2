namespace OOP1._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.draw_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.line_color_dialog_button = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.line_color_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.clear_button = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.line_button = new System.Windows.Forms.Button();
            this.polygon_button = new System.Windows.Forms.Button();
            this.rect_button = new System.Windows.Forms.Button();
            this.square_button = new System.Windows.Forms.Button();
            this.ellipse_button = new System.Windows.Forms.Button();
            this.circle_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.fill_color_dialog_button = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.fill_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.check_line = new System.Windows.Forms.CheckBox();
            this.check_fill = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.brush_button = new System.Windows.Forms.Button();
            this.brush_checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(941, 518);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick_1);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // draw_button
            // 
            this.draw_button.Location = new System.Drawing.Point(818, 474);
            this.draw_button.Name = "draw_button";
            this.draw_button.Size = new System.Drawing.Size(112, 34);
            this.draw_button.TabIndex = 2;
            this.draw_button.Text = "Рисовать";
            this.draw_button.UseVisualStyleBackColor = true;
            this.draw_button.Click += new System.EventHandler(this.draw_button_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(949, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 113);
            this.panel1.TabIndex = 3;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(3, 44);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(156, 69);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Толщина линии";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.line_color_dialog_button);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.line_color_button);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(949, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 96);
            this.panel2.TabIndex = 4;
            // 
            // line_color_dialog_button
            // 
            this.line_color_dialog_button.Location = new System.Drawing.Point(150, 34);
            this.line_color_dialog_button.Name = "line_color_dialog_button";
            this.line_color_dialog_button.Size = new System.Drawing.Size(30, 30);
            this.line_color_dialog_button.TabIndex = 9;
            this.line_color_dialog_button.UseVisualStyleBackColor = true;
            this.line_color_dialog_button.Click += new System.EventHandler(this.line_color_dialog_button_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Lime;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(114, 34);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 30);
            this.button5.TabIndex = 8;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.line_color_button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(78, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 30);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.line_color_button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(42, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.line_color_button_Click);
            // 
            // line_color_button
            // 
            this.line_color_button.BackColor = System.Drawing.Color.Black;
            this.line_color_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.line_color_button.Location = new System.Drawing.Point(6, 34);
            this.line_color_button.Name = "line_color_button";
            this.line_color_button.Size = new System.Drawing.Size(30, 30);
            this.line_color_button.TabIndex = 5;
            this.line_color_button.UseVisualStyleBackColor = false;
            this.line_color_button.Click += new System.EventHandler(this.line_color_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Цвет линии";
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(952, 486);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(156, 34);
            this.clear_button.TabIndex = 5;
            this.clear_button.Text = "Очистка экрана";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.line_button);
            this.panel3.Controls.Add(this.polygon_button);
            this.panel3.Controls.Add(this.rect_button);
            this.panel3.Controls.Add(this.square_button);
            this.panel3.Controls.Add(this.ellipse_button);
            this.panel3.Controls.Add(this.circle_button);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(949, 236);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 95);
            this.panel3.TabIndex = 7;
            // 
            // line_button
            // 
            this.line_button.BackColor = System.Drawing.Color.White;
            this.line_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("line_button.BackgroundImage")));
            this.line_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.line_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.line_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.line_button.Location = new System.Drawing.Point(186, 34);
            this.line_button.Name = "line_button";
            this.line_button.Size = new System.Drawing.Size(30, 30);
            this.line_button.TabIndex = 10;
            this.line_button.UseVisualStyleBackColor = false;
            this.line_button.Click += new System.EventHandler(this.line_button_Click);
            // 
            // polygon_button
            // 
            this.polygon_button.BackColor = System.Drawing.Color.White;
            this.polygon_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("polygon_button.BackgroundImage")));
            this.polygon_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.polygon_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.polygon_button.Location = new System.Drawing.Point(150, 34);
            this.polygon_button.Name = "polygon_button";
            this.polygon_button.Size = new System.Drawing.Size(30, 30);
            this.polygon_button.TabIndex = 9;
            this.polygon_button.UseVisualStyleBackColor = false;
            this.polygon_button.Click += new System.EventHandler(this.polygon_button_Click);
            // 
            // rect_button
            // 
            this.rect_button.BackColor = System.Drawing.Color.White;
            this.rect_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rect_button.BackgroundImage")));
            this.rect_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rect_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rect_button.Location = new System.Drawing.Point(114, 34);
            this.rect_button.Name = "rect_button";
            this.rect_button.Size = new System.Drawing.Size(30, 30);
            this.rect_button.TabIndex = 8;
            this.rect_button.UseVisualStyleBackColor = false;
            this.rect_button.Click += new System.EventHandler(this.rect_button_Click);
            // 
            // square_button
            // 
            this.square_button.BackColor = System.Drawing.Color.White;
            this.square_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("square_button.BackgroundImage")));
            this.square_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.square_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.square_button.Location = new System.Drawing.Point(78, 34);
            this.square_button.Name = "square_button";
            this.square_button.Size = new System.Drawing.Size(30, 30);
            this.square_button.TabIndex = 7;
            this.square_button.UseVisualStyleBackColor = false;
            this.square_button.Click += new System.EventHandler(this.square_button_Click);
            // 
            // ellipse_button
            // 
            this.ellipse_button.BackColor = System.Drawing.Color.White;
            this.ellipse_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ellipse_button.BackgroundImage")));
            this.ellipse_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ellipse_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ellipse_button.Location = new System.Drawing.Point(42, 34);
            this.ellipse_button.Name = "ellipse_button";
            this.ellipse_button.Size = new System.Drawing.Size(30, 30);
            this.ellipse_button.TabIndex = 6;
            this.ellipse_button.UseVisualStyleBackColor = false;
            this.ellipse_button.Click += new System.EventHandler(this.ellipse_button_Click);
            // 
            // circle_button
            // 
            this.circle_button.BackColor = System.Drawing.Color.White;
            this.circle_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circle_button.BackgroundImage")));
            this.circle_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.circle_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circle_button.Image = ((System.Drawing.Image)(resources.GetObject("circle_button.Image")));
            this.circle_button.Location = new System.Drawing.Point(6, 34);
            this.circle_button.Name = "circle_button";
            this.circle_button.Size = new System.Drawing.Size(30, 30);
            this.circle_button.TabIndex = 5;
            this.circle_button.UseVisualStyleBackColor = false;
            this.circle_button.Click += new System.EventHandler(this.circle_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Фигура";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.fill_color_dialog_button);
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.button8);
            this.panel4.Controls.Add(this.button9);
            this.panel4.Controls.Add(this.fill_button);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(1153, 121);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(187, 96);
            this.panel4.TabIndex = 8;
            // 
            // fill_color_dialog_button
            // 
            this.fill_color_dialog_button.Location = new System.Drawing.Point(150, 34);
            this.fill_color_dialog_button.Name = "fill_color_dialog_button";
            this.fill_color_dialog_button.Size = new System.Drawing.Size(30, 30);
            this.fill_color_dialog_button.TabIndex = 9;
            this.fill_color_dialog_button.UseVisualStyleBackColor = true;
            this.fill_color_dialog_button.Click += new System.EventHandler(this.fill_color_dialog_button_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Lime;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(114, 34);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(30, 30);
            this.button7.TabIndex = 8;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.fill_button_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Blue;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(78, 34);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(30, 30);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.fill_button_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Red;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(42, 34);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(30, 30);
            this.button9.TabIndex = 6;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.fill_button_Click);
            // 
            // fill_button
            // 
            this.fill_button.BackColor = System.Drawing.Color.Black;
            this.fill_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fill_button.Location = new System.Drawing.Point(6, 34);
            this.fill_button.Name = "fill_button";
            this.fill_button.Size = new System.Drawing.Size(30, 30);
            this.fill_button.TabIndex = 5;
            this.fill_button.UseVisualStyleBackColor = false;
            this.fill_button.Click += new System.EventHandler(this.fill_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Цвет заливки";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.check_line);
            this.panel5.Controls.Add(this.check_fill);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(949, 347);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(237, 95);
            this.panel5.TabIndex = 9;
            // 
            // check_line
            // 
            this.check_line.AutoSize = true;
            this.check_line.Location = new System.Drawing.Point(179, 67);
            this.check_line.Name = "check_line";
            this.check_line.Size = new System.Drawing.Size(22, 21);
            this.check_line.TabIndex = 4;
            this.check_line.UseVisualStyleBackColor = true;
            // 
            // check_fill
            // 
            this.check_fill.AutoSize = true;
            this.check_fill.Location = new System.Drawing.Point(20, 67);
            this.check_fill.Name = "check_fill";
            this.check_fill.Size = new System.Drawing.Size(22, 21);
            this.check_fill.TabIndex = 3;
            this.check_fill.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Контур";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Заливка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Рисовка";
            // 
            // brush_button
            // 
            this.brush_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("brush_button.BackgroundImage")));
            this.brush_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.brush_button.Location = new System.Drawing.Point(1198, 46);
            this.brush_button.Name = "brush_button";
            this.brush_button.Size = new System.Drawing.Size(60, 60);
            this.brush_button.TabIndex = 10;
            this.brush_button.UseVisualStyleBackColor = true;
            // 
            // brush_checkBox
            // 
            this.brush_checkBox.AutoSize = true;
            this.brush_checkBox.Location = new System.Drawing.Point(1279, 73);
            this.brush_checkBox.Name = "brush_checkBox";
            this.brush_checkBox.Size = new System.Drawing.Size(22, 21);
            this.brush_checkBox.TabIndex = 11;
            this.brush_checkBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 615);
            this.Controls.Add(this.brush_checkBox);
            this.Controls.Add(this.brush_button);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.draw_button);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button draw_button;
        private Panel panel1;
        private Label label1;
        private TrackBar trackBar1;
        private Panel panel2;
        private Label label2;
        private Button line_color_button;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button line_color_dialog_button;
        private ColorDialog colorDialog1;
        private Button clear_button;
        private SaveFileDialog saveFileDialog1;
        private SaveFileDialog saveFileDialog2;
        private Panel panel3;
        private Button line_button;
        private Button polygon_button;
        private Button rect_button;
        private Button square_button;
        private Button ellipse_button;
        private Button circle_button;
        private Label label3;
        private Panel panel4;
        private Button fill_color_dialog_button;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button fill_button;
        private Label label4;
        private Panel panel5;
        private CheckBox check_line;
        private CheckBox check_fill;
        public Label label7;
        public Label label6;
        public Label label5;
        private ColorDialog colorDialog2;
        private Button brush_button;
        private CheckBox brush_checkBox;
    }
}