namespace Time
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
            this.Time = new System.Windows.Forms.Label();
            this.Btn = new System.Windows.Forms.Button();
            this.Field = new System.Windows.Forms.TextBox();
            this.Btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.Time.Location = new System.Drawing.Point(13, 6);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(121, 44);
            this.Time.TabIndex = 2;
            this.Time.Text = "label1";
            // 
            // Btn
            // 
            this.Btn.Location = new System.Drawing.Point(21, 111);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(113, 39);
            this.Btn.TabIndex = 4;
            this.Btn.Text = "button1";
            this.Btn.UseVisualStyleBackColor = true;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Field
            // 
            this.Field.Location = new System.Drawing.Point(469, 6);
            this.Field.Multiline = true;
            this.Field.Name = "Field";
            this.Field.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Field.Size = new System.Drawing.Size(300, 445);
            this.Field.TabIndex = 5;
            this.Field.TextChanged += new System.EventHandler(this.Field_TextChanged);
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(141, 111);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(125, 39);
            this.Btn2.TabIndex = 6;
            this.Btn2.Text = "button1";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Field);
            this.Controls.Add(this.Btn);
            this.Controls.Add(this.Time);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.size);
            this.Validated += new System.EventHandler(this.val);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Button Btn;
        private System.Windows.Forms.TextBox Field;
        private System.Windows.Forms.Button Btn2;
    }
}

