namespace Exception_2_Prog
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
            this.collapse = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.chose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // collapse
            // 
            this.collapse.BackColor = System.Drawing.Color.White;
            this.collapse.BackgroundImage = global::Exception_2_Prog.Properties.Resources.Свернуть;
            this.collapse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.collapse.Location = new System.Drawing.Point(397, 12);
            this.collapse.Name = "collapse";
            this.collapse.Size = new System.Drawing.Size(23, 23);
            this.collapse.TabIndex = 5;
            this.collapse.UseVisualStyleBackColor = false;
            this.collapse.Click += new System.EventHandler(this.collapse_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.White;
            this.close.BackgroundImage = global::Exception_2_Prog.Properties.Resources.Закрыть;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.Location = new System.Drawing.Point(435, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(23, 23);
            this.close.TabIndex = 6;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // chose
            // 
            this.chose.BackColor = System.Drawing.Color.White;
            this.chose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chose.Location = new System.Drawing.Point(154, 121);
            this.chose.Name = "chose";
            this.chose.Size = new System.Drawing.Size(159, 88);
            this.chose.TabIndex = 7;
            this.chose.Text = "Вибрати файл";
            this.chose.UseVisualStyleBackColor = false;
            this.chose.Click += new System.EventHandler(this.chose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 350);
            this.Controls.Add(this.chose);
            this.Controls.Add(this.close);
            this.Controls.Add(this.collapse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button collapse;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button chose;
    }
}

