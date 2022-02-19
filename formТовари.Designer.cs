namespace AppТовари
{
    partial class formТовари
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
            this.listBoxТовари = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxСередня_ціна = new System.Windows.Forms.TextBox();
            this.buttonЗмінити = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxТовари
            // 
            this.listBoxТовари.FormattingEnabled = true;
            this.listBoxТовари.ItemHeight = 16;
            this.listBoxТовари.Location = new System.Drawing.Point(12, 12);
            this.listBoxТовари.Name = "listBoxТовари";
            this.listBoxТовари.Size = new System.Drawing.Size(388, 260);
            this.listBoxТовари.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F);
            this.label1.Location = new System.Drawing.Point(56, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Середня ціна:";
            // 
            // textBoxСередня_ціна
            // 
            this.textBoxСередня_ціна.Location = new System.Drawing.Point(215, 313);
            this.textBoxСередня_ціна.Name = "textBoxСередня_ціна";
            this.textBoxСередня_ціна.Size = new System.Drawing.Size(100, 22);
            this.textBoxСередня_ціна.TabIndex = 2;
            // 
            // buttonЗмінити
            // 
            this.buttonЗмінити.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonЗмінити.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonЗмінити.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonЗмінити.FlatAppearance.BorderSize = 2;
            this.buttonЗмінити.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonЗмінити.Font = new System.Drawing.Font("Consolas", 12F);
            this.buttonЗмінити.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonЗмінити.Location = new System.Drawing.Point(60, 361);
            this.buttonЗмінити.Name = "buttonЗмінити";
            this.buttonЗмінити.Size = new System.Drawing.Size(149, 41);
            this.buttonЗмінити.TabIndex = 3;
            this.buttonЗмінити.Text = "Змінити";
            this.buttonЗмінити.UseVisualStyleBackColor = false;
            this.buttonЗмінити.Click += new System.EventHandler(this.buttonЗмінити_Click);
            // 
            // formТовари
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.buttonЗмінити);
            this.Controls.Add(this.textBoxСередня_ціна);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxТовари);
            this.Name = "formТовари";
            this.Text = "Товари";
            this.Load += new System.EventHandler(this.formТовари_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBoxТовари;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxСередня_ціна;
        private System.Windows.Forms.Button buttonЗмінити;
    }
}

