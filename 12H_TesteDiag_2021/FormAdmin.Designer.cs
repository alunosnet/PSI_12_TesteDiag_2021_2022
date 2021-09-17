
namespace _12H_TesteDiag_2021
{
    partial class FormAdmin
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNProcesso = new System.Windows.Forms.TextBox();
            this.dtPData = new System.Windows.Forms.DateTimePicker();
            this.rbProf = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbReg = new System.Windows.Forms.RadioButton();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbCampo1 = new System.Windows.Forms.Label();
            this.lbCampo2 = new System.Windows.Forms.Label();
            this.tbCampo1 = new System.Windows.Forms.TextBox();
            this.tbCampo2 = new System.Windows.Forms.TextBox();
            this.lbAlunos = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "N Processo";
            // 
            // tbNProcesso
            // 
            this.tbNProcesso.Location = new System.Drawing.Point(186, 45);
            this.tbNProcesso.Name = "tbNProcesso";
            this.tbNProcesso.Size = new System.Drawing.Size(204, 20);
            this.tbNProcesso.TabIndex = 2;
            // 
            // dtPData
            // 
            this.dtPData.Location = new System.Drawing.Point(186, 107);
            this.dtPData.Name = "dtPData";
            this.dtPData.Size = new System.Drawing.Size(176, 20);
            this.dtPData.TabIndex = 3;
            // 
            // rbProf
            // 
            this.rbProf.AutoSize = true;
            this.rbProf.Checked = true;
            this.rbProf.Location = new System.Drawing.Point(105, 183);
            this.rbProf.Name = "rbProf";
            this.rbProf.Size = new System.Drawing.Size(78, 17);
            this.rbProf.TabIndex = 4;
            this.rbProf.TabStop = true;
            this.rbProf.Text = "Profissional";
            this.rbProf.UseVisualStyleBackColor = true;
            this.rbProf.CheckedChanged += new System.EventHandler(this.rbProf_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Data Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tipo de aluno";
            // 
            // rbReg
            // 
            this.rbReg.AutoSize = true;
            this.rbReg.Location = new System.Drawing.Point(226, 183);
            this.rbReg.Name = "rbReg";
            this.rbReg.Size = new System.Drawing.Size(62, 17);
            this.rbReg.TabIndex = 4;
            this.rbReg.Text = "Regular";
            this.rbReg.UseVisualStyleBackColor = true;
            this.rbReg.CheckedChanged += new System.EventHandler(this.rbReg_CheckedChanged);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(186, 76);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(204, 20);
            this.tbNome.TabIndex = 2;
            // 
            // lbCampo1
            // 
            this.lbCampo1.AutoSize = true;
            this.lbCampo1.Location = new System.Drawing.Point(78, 223);
            this.lbCampo1.Name = "lbCampo1";
            this.lbCampo1.Size = new System.Drawing.Size(34, 13);
            this.lbCampo1.TabIndex = 1;
            this.lbCampo1.Text = "Curso";
            this.lbCampo1.Click += new System.EventHandler(this.lbCampo1_Click);
            // 
            // lbCampo2
            // 
            this.lbCampo2.AutoSize = true;
            this.lbCampo2.Location = new System.Drawing.Point(78, 257);
            this.lbCampo2.Name = "lbCampo2";
            this.lbCampo2.Size = new System.Drawing.Size(20, 13);
            this.lbCampo2.TabIndex = 1;
            this.lbCampo2.Text = "Nif";
            this.lbCampo2.Click += new System.EventHandler(this.lbCampo2_Click);
            // 
            // tbCampo1
            // 
            this.tbCampo1.Location = new System.Drawing.Point(176, 220);
            this.tbCampo1.Name = "tbCampo1";
            this.tbCampo1.Size = new System.Drawing.Size(204, 20);
            this.tbCampo1.TabIndex = 2;
            // 
            // tbCampo2
            // 
            this.tbCampo2.Location = new System.Drawing.Point(176, 254);
            this.tbCampo2.Name = "tbCampo2";
            this.tbCampo2.Size = new System.Drawing.Size(204, 20);
            this.tbCampo2.TabIndex = 2;
            // 
            // lbAlunos
            // 
            this.lbAlunos.FormattingEnabled = true;
            this.lbAlunos.Location = new System.Drawing.Point(81, 295);
            this.lbAlunos.Name = "lbAlunos";
            this.lbAlunos.Size = new System.Drawing.Size(299, 82);
            this.lbAlunos.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(489, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 66);
            this.button2.TabIndex = 6;
            this.button2.Text = "Remover";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 396);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbAlunos);
            this.Controls.Add(this.rbReg);
            this.Controls.Add(this.rbProf);
            this.Controls.Add(this.dtPData);
            this.Controls.Add(this.tbCampo2);
            this.Controls.Add(this.tbCampo1);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbNProcesso);
            this.Controls.Add(this.lbCampo2);
            this.Controls.Add(this.lbCampo1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNProcesso;
        private System.Windows.Forms.DateTimePicker dtPData;
        private System.Windows.Forms.RadioButton rbProf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbReg;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbCampo1;
        private System.Windows.Forms.Label lbCampo2;
        private System.Windows.Forms.TextBox tbCampo1;
        private System.Windows.Forms.TextBox tbCampo2;
        private System.Windows.Forms.ListBox lbAlunos;
        private System.Windows.Forms.Button button2;
    }
}