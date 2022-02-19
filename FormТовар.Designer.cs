namespace AppТовари
{
    partial class FormТовар
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxКод_товару = new System.Windows.Forms.TextBox();
            this.textBoxТовар = new System.Windows.Forms.TextBox();
            this.textBoxЦіна = new System.Windows.Forms.TextBox();
            this.textBoxЦіна_закупівлі = new System.Windows.Forms.TextBox();
            this.buttonЗберегти = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код_товару";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Товар";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ціна";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ціна_закупівлі";
            // 
            // textBoxКод_товару
            // 
            this.textBoxКод_товару.Enabled = false;
            this.textBoxКод_товару.Location = new System.Drawing.Point(194, 34);
            this.textBoxКод_товару.Name = "textBoxКод_товару";
            this.textBoxКод_товару.Size = new System.Drawing.Size(100, 22);
            this.textBoxКод_товару.TabIndex = 4;
            // 
            // textBoxТовар
            // 
            this.textBoxТовар.Location = new System.Drawing.Point(194, 81);
            this.textBoxТовар.Name = "textBoxТовар";
            this.textBoxТовар.Size = new System.Drawing.Size(100, 22);
            this.textBoxТовар.TabIndex = 5;
            // 
            // textBoxЦіна
            // 
            this.textBoxЦіна.Location = new System.Drawing.Point(194, 129);
            this.textBoxЦіна.Name = "textBoxЦіна";
            this.textBoxЦіна.Size = new System.Drawing.Size(100, 22);
            this.textBoxЦіна.TabIndex = 6;
            // 
            // textBoxЦіна_закупівлі
            // 
            this.textBoxЦіна_закупівлі.Location = new System.Drawing.Point(194, 182);
            this.textBoxЦіна_закупівлі.Name = "textBoxЦіна_закупівлі";
            this.textBoxЦіна_закупівлі.Size = new System.Drawing.Size(100, 22);
            this.textBoxЦіна_закупівлі.TabIndex = 7;
            // 
            // buttonЗберегти
            // 
            this.buttonЗберегти.Location = new System.Drawing.Point(116, 245);
            this.buttonЗберегти.Name = "buttonЗберегти";
            this.buttonЗберегти.Size = new System.Drawing.Size(120, 50);
            this.buttonЗберегти.TabIndex = 8;
            this.buttonЗберегти.Text = "Зберегти";
            this.buttonЗберегти.UseVisualStyleBackColor = true;
            this.buttonЗберегти.Click += new System.EventHandler(this.buttonЗберегти_Click);
            // 
            // FormТовар
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 325);
            this.Controls.Add(this.buttonЗберегти);
            this.Controls.Add(this.textBoxЦіна_закупівлі);
            this.Controls.Add(this.textBoxЦіна);
            this.Controls.Add(this.textBoxТовар);
            this.Controls.Add(this.textBoxКод_товару);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormТовар";
            this.Text = "Товар";
            this.Load += new System.EventHandler(this.FormТовар_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxКод_товару;
        private System.Windows.Forms.TextBox textBoxТовар;
        private System.Windows.Forms.TextBox textBoxЦіна;
        private System.Windows.Forms.TextBox textBoxЦіна_закупівлі;
        private System.Windows.Forms.Button buttonЗберегти;
    }
}