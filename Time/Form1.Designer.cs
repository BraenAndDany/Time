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
            this.List = new System.Windows.Forms.TextBox();
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
            // List
            // 
            this.List.Location = new System.Drawing.Point(510, 12);
            this.List.Multiline = true;
            this.List.Name = "List";
            this.List.ReadOnly = true;
            this.List.Size = new System.Drawing.Size(263, 428);
            this.List.TabIndex = 3;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 452);
            this.Controls.Add(this.List);
            this.Controls.Add(this.Time);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.size);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.click);
            this.Validated += new System.EventHandler(this.val);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.TextBox List;
    }
}

