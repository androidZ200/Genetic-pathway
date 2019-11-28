namespace генетический_путь
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StartStopButton = new System.Windows.Forms.Button();
            this.MaxTrackBar = new System.Windows.Forms.TrackBar();
            this.DeapTrackBar = new System.Windows.Forms.TrackBar();
            this.AllCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DelCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeapTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(89, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(627, 476);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.SizeChanged += new System.EventHandler(this.pictureBox1_SizeChanged);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // StartStopButton
            // 
            this.StartStopButton.Location = new System.Drawing.Point(13, 13);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(70, 36);
            this.StartStopButton.TabIndex = 1;
            this.StartStopButton.Text = "Start";
            this.StartStopButton.UseVisualStyleBackColor = true;
            this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // MaxTrackBar
            // 
            this.MaxTrackBar.Location = new System.Drawing.Point(13, 56);
            this.MaxTrackBar.Maximum = 500;
            this.MaxTrackBar.Minimum = 1;
            this.MaxTrackBar.Name = "MaxTrackBar";
            this.MaxTrackBar.Size = new System.Drawing.Size(70, 45);
            this.MaxTrackBar.TabIndex = 2;
            this.MaxTrackBar.Value = 1;
            this.MaxTrackBar.Scroll += new System.EventHandler(this.MaxTrackBar_Scroll);
            // 
            // DeapTrackBar
            // 
            this.DeapTrackBar.Location = new System.Drawing.Point(13, 88);
            this.DeapTrackBar.Minimum = 1;
            this.DeapTrackBar.Name = "DeapTrackBar";
            this.DeapTrackBar.Size = new System.Drawing.Size(70, 45);
            this.DeapTrackBar.TabIndex = 3;
            this.DeapTrackBar.Value = 1;
            this.DeapTrackBar.Scroll += new System.EventHandler(this.DeapTrackBar_Scroll);
            // 
            // AllCheckBox
            // 
            this.AllCheckBox.AutoSize = true;
            this.AllCheckBox.Location = new System.Drawing.Point(13, 116);
            this.AllCheckBox.Name = "AllCheckBox";
            this.AllCheckBox.Size = new System.Drawing.Size(67, 17);
            this.AllCheckBox.TabIndex = 4;
            this.AllCheckBox.Text = "All Paths";
            this.AllCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // DelCheckBox
            // 
            this.DelCheckBox.AutoSize = true;
            this.DelCheckBox.Location = new System.Drawing.Point(13, 139);
            this.DelCheckBox.Name = "DelCheckBox";
            this.DelCheckBox.Size = new System.Drawing.Size(57, 17);
            this.DelCheckBox.TabIndex = 8;
            this.DelCheckBox.Text = "Delete";
            this.DelCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 501);
            this.Controls.Add(this.DelCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllCheckBox);
            this.Controls.Add(this.DeapTrackBar);
            this.Controls.Add(this.MaxTrackBar);
            this.Controls.Add(this.StartStopButton);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(451, 340);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeapTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button StartStopButton;
        private System.Windows.Forms.TrackBar MaxTrackBar;
        private System.Windows.Forms.TrackBar DeapTrackBar;
        private System.Windows.Forms.CheckBox AllCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox DelCheckBox;
    }
}

