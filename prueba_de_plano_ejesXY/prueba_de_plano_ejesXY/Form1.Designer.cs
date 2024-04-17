namespace prueba_de_plano_ejesXY
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
            components = new System.ComponentModel.Container();
            Tempo = new System.Windows.Forms.Timer(components);
            imageList1 = new ImageList(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            domainUpDown1 = new DomainUpDown();
            progressBar1 = new ProgressBar();
            checkBox1 = new CheckBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Tempo
            // 
            Tempo.Enabled = true;
            Tempo.Interval = 10;
            Tempo.Tag = "Hola";
            Tempo.Tick += Tempo_Tick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.HotTrack;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 124F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 139F));
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(507, 276);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(534, 128);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(240, 39);
            domainUpDown1.TabIndex = 1;
            domainUpDown1.Text = "domainUpDown1";
            domainUpDown1.SelectedItemChanged += domainUpDown1_SelectedItemChanged;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(271, 322);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(200, 46);
            progressBar1.TabIndex = 2;
            progressBar1.Click += progressBar1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(89, 328);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(159, 36);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(544, 282);
            label1.Name = "label1";
            label1.Size = new Size(63, 32);
            label1.TabIndex = 4;
            label1.Text = "Hola";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(progressBar1);
            Controls.Add(domainUpDown1);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private ImageList imageList1;
        private TableLayoutPanel tableLayoutPanel1;
        private DomainUpDown domainUpDown1;
        private ProgressBar progressBar1;
        private CheckBox checkBox1;
        public System.Windows.Forms.Timer Tempo;
        private Label label1;
    }
}
