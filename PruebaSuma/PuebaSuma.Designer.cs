namespace PruebaSuma
{
    partial class PuebaSuma
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PrimertextBox = new System.Windows.Forms.TextBox();
            this.SegundotextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultadotextBox = new System.Windows.Forms.TextBox();
            this.Sumabutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primer Nro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Segundo Nro:";
            // 
            // PrimertextBox
            // 
            this.PrimertextBox.Location = new System.Drawing.Point(110, 41);
            this.PrimertextBox.Name = "PrimertextBox";
            this.PrimertextBox.Size = new System.Drawing.Size(100, 20);
            this.PrimertextBox.TabIndex = 2;
            // 
            // SegundotextBox
            // 
            this.SegundotextBox.Location = new System.Drawing.Point(110, 103);
            this.SegundotextBox.Name = "SegundotextBox";
            this.SegundotextBox.Size = new System.Drawing.Size(100, 20);
            this.SegundotextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resultado";
            // 
            // ResultadotextBox
            // 
            this.ResultadotextBox.Location = new System.Drawing.Point(110, 167);
            this.ResultadotextBox.Name = "ResultadotextBox";
            this.ResultadotextBox.Size = new System.Drawing.Size(141, 20);
            this.ResultadotextBox.TabIndex = 5;
            // 
            // Sumabutton
            // 
            this.Sumabutton.Location = new System.Drawing.Point(100, 216);
            this.Sumabutton.Name = "Sumabutton";
            this.Sumabutton.Size = new System.Drawing.Size(75, 23);
            this.Sumabutton.TabIndex = 6;
            this.Sumabutton.Text = "Sumar";
            this.Sumabutton.UseVisualStyleBackColor = true;
            this.Sumabutton.Click += new System.EventHandler(this.Sumabutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Sumabutton);
            this.Controls.Add(this.ResultadotextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SegundotextBox);
            this.Controls.Add(this.PrimertextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "PuebaSuma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PrimertextBox;
        private System.Windows.Forms.TextBox SegundotextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ResultadotextBox;
        private System.Windows.Forms.Button Sumabutton;
    }
}

