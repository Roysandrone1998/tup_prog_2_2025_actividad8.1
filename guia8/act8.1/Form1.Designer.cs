namespace act8._1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbNombre = new TextBox();
            tbDNI = new TextBox();
            tbImporte = new TextBox();
            listBox1 = new ListBox();
            btnConfirmar = new Button();
            btnActualizar = new Button();
            button1 = new Button();
            btnImportar = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 48);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 99);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 1;
            label2.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 140);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Importe";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(277, 35);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(130, 23);
            tbNombre.TabIndex = 3;
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(281, 83);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(108, 23);
            tbDNI.TabIndex = 4;
            // 
            // tbImporte
            // 
            tbImporte.Location = new Point(277, 137);
            tbImporte.Name = "tbImporte";
            tbImporte.Size = new Size(108, 23);
            tbImporte.TabIndex = 5;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(124, 232);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(286, 124);
            listBox1.TabIndex = 6;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(535, 35);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(129, 69);
            btnConfirmar.TabIndex = 7;
            btnConfirmar.Text = "button1";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(526, 140);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(156, 86);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "button2";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(721, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(512, 271);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(172, 74);
            btnImportar.TabIndex = 10;
            btnImportar.Text = "button2";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnImportar);
            Controls.Add(button1);
            Controls.Add(btnActualizar);
            Controls.Add(btnConfirmar);
            Controls.Add(listBox1);
            Controls.Add(tbImporte);
            Controls.Add(tbDNI);
            Controls.Add(tbNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbNombre;
        private TextBox tbDNI;
        private TextBox tbImporte;
        private ListBox listBox1;
        private Button btnConfirmar;
        private Button btnActualizar;
        private Button button1;
        private Button btnImportar;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
