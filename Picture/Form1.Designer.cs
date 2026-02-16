namespace Picture
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
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Cl_button = new Button();
            SetTheBack_button = new Button();
            Clear_button = new Button();
            Show_button = new Button();
            openFileDialog1 = new OpenFileDialog();
            colorDialog1 = new ColorDialog();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.125F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 89.875F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(checkBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.1111145F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.8888893F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            tableLayoutPanel1.SetColumnSpan(pictureBox1, 2);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(794, 395);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 404);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(63, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Stretch";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(Cl_button);
            flowLayoutPanel1.Controls.Add(SetTheBack_button);
            flowLayoutPanel1.Controls.Add(Clear_button);
            flowLayoutPanel1.Controls.Add(Show_button);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(84, 404);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(713, 43);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // Cl_button
            // 
            Cl_button.Dock = DockStyle.Top;
            Cl_button.Location = new Point(635, 3);
            Cl_button.Name = "Cl_button";
            Cl_button.Size = new Size(75, 23);
            Cl_button.TabIndex = 0;
            Cl_button.Text = "Close";
            Cl_button.UseVisualStyleBackColor = true;
            Cl_button.Click += Cl_button_Click;
            // 
            // SetTheBack_button
            // 
            SetTheBack_button.Dock = DockStyle.Top;
            SetTheBack_button.Location = new Point(447, 3);
            SetTheBack_button.Name = "SetTheBack_button";
            SetTheBack_button.Size = new Size(182, 23);
            SetTheBack_button.TabIndex = 1;
            SetTheBack_button.Text = "Set the backgraund colour";
            SetTheBack_button.UseVisualStyleBackColor = true;
            SetTheBack_button.Click += SetTheBack_button_Click;
            // 
            // Clear_button
            // 
            Clear_button.Dock = DockStyle.Top;
            Clear_button.Location = new Point(327, 3);
            Clear_button.Name = "Clear_button";
            Clear_button.Size = new Size(114, 23);
            Clear_button.TabIndex = 3;
            Clear_button.Text = "Clear the picture";
            Clear_button.UseVisualStyleBackColor = true;
            Clear_button.Click += Clear_button_Click;
            // 
            // Show_button
            // 
            Show_button.Dock = DockStyle.Top;
            Show_button.Location = new Point(175, 3);
            Show_button.Name = "Show_button";
            Show_button.Size = new Size(146, 23);
            Show_button.TabIndex = 2;
            Show_button.Text = "Show the picture";
            Show_button.UseVisualStyleBackColor = true;
            Show_button.Click += ShowButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button Cl_button;
        private Button SetTheBack_button;
        private Button Show_button;
        private Button Clear_button;
        private OpenFileDialog openFileDialog1;
        private ColorDialog colorDialog1;
    }
}
