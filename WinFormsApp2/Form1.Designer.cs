namespace WinFormsApp2
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
            picBox1 = new PictureBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnBranco = new Button();
            btnCorrigir = new Button();
            btnConfirmar = new Button();
            lblNome = new Label();
            lblPartido = new Label();
            txtPresidente1 = new TextBox();
            txtPresidente2 = new TextBox();
            Relogio = new System.Windows.Forms.Timer(components);
            pnFim = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)picBox1).BeginInit();
            pnFim.SuspendLayout();
            SuspendLayout();
            // 
            // picBox1
            // 
            picBox1.Image = Properties.Resources.justi;
            picBox1.Location = new Point(37, 29);
            picBox1.Name = "picBox1";
            picBox1.Size = new Size(200, 150);
            picBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            picBox1.TabIndex = 0;
            picBox1.TabStop = false;
            picBox1.Click += picBox1_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(482, 29);
            btn1.Name = "btn1";
            btn1.Size = new Size(73, 53);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(561, 29);
            btn2.Name = "btn2";
            btn2.Size = new Size(73, 53);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(640, 29);
            btn3.Name = "btn3";
            btn3.Size = new Size(73, 53);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(482, 88);
            btn4.Name = "btn4";
            btn4.Size = new Size(73, 53);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(561, 88);
            btn5.Name = "btn5";
            btn5.Size = new Size(73, 53);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(640, 88);
            btn6.Name = "btn6";
            btn6.Size = new Size(73, 53);
            btn6.TabIndex = 4;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(482, 147);
            btn7.Name = "btn7";
            btn7.Size = new Size(73, 53);
            btn7.TabIndex = 9;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(561, 147);
            btn8.Name = "btn8";
            btn8.Size = new Size(73, 53);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(640, 147);
            btn9.Name = "btn9";
            btn9.Size = new Size(73, 53);
            btn9.TabIndex = 7;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(561, 210);
            btn0.Name = "btn0";
            btn0.Size = new Size(73, 53);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnBranco
            // 
            btnBranco.Location = new Point(482, 276);
            btnBranco.Name = "btnBranco";
            btnBranco.Size = new Size(73, 53);
            btnBranco.TabIndex = 11;
            btnBranco.Text = "Branco";
            btnBranco.UseVisualStyleBackColor = true;
            btnBranco.Click += btnBranco_Click;
            // 
            // btnCorrigir
            // 
            btnCorrigir.Location = new Point(561, 276);
            btnCorrigir.Name = "btnCorrigir";
            btnCorrigir.Size = new Size(73, 53);
            btnCorrigir.TabIndex = 12;
            btnCorrigir.Text = "Corrigir";
            btnCorrigir.UseVisualStyleBackColor = true;
            btnCorrigir.Click += btnCorrigir_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(640, 276);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(73, 53);
            btnConfirmar.TabIndex = 13;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.Location = new Point(83, 276);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(0, 30);
            lblNome.TabIndex = 16;
            // 
            // lblPartido
            // 
            lblPartido.AutoSize = true;
            lblPartido.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblPartido.Location = new Point(74, 306);
            lblPartido.Name = "lblPartido";
            lblPartido.Size = new Size(0, 32);
            lblPartido.TabIndex = 17;
            // 
            // txtPresidente1
            // 
            txtPresidente1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPresidente1.Location = new Point(313, 29);
            txtPresidente1.Name = "txtPresidente1";
            txtPresidente1.Size = new Size(50, 54);
            txtPresidente1.TabIndex = 18;
            txtPresidente1.TextChanged += textBox1_TextChanged;
            // 
            // txtPresidente2
            // 
            txtPresidente2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPresidente2.Location = new Point(371, 29);
            txtPresidente2.Name = "txtPresidente2";
            txtPresidente2.Size = new Size(50, 54);
            txtPresidente2.TabIndex = 19;
            txtPresidente2.TextChanged += textBox2_TextChanged;
            // 
            // Relogio
            // 
            Relogio.Tick += Relogio_Tick;
            // 
            // pnFim
            // 
            pnFim.Controls.Add(label2);
            pnFim.Location = new Point(2, 12);
            pnFim.Name = "pnFim";
            pnFim.Size = new Size(474, 349);
            pnFim.TabIndex = 21;
            pnFim.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(131, 94);
            label2.Name = "label2";
            label2.Size = new Size(213, 128);
            label2.TabIndex = 0;
            label2.Text = "FIM";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnFim);
            Controls.Add(txtPresidente2);
            Controls.Add(txtPresidente1);
            Controls.Add(lblPartido);
            Controls.Add(lblNome);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCorrigir);
            Controls.Add(btnBranco);
            Controls.Add(btn0);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(picBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picBox1).EndInit();
            pnFim.ResumeLayout(false);
            pnFim.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBox1;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnBranco;
        private Button btnCorrigir;
        private Button btnConfirmar;
        private Label lblNome;
        private Label lblPartido;
        private TextBox txtPresidente1;
        private TextBox txtPresidente2;
        private System.Windows.Forms.Timer Relogio;
        private Panel pnFim;
        private Label label2;
    }
}