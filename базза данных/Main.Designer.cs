
namespace базза_данных
{
    partial class Main
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
            this.button_people = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Label();
            this.button_doctor = new System.Windows.Forms.Button();
            this.button_sick = new System.Windows.Forms.Button();
            this.button_disgnos = new System.Windows.Forms.Button();
            this.Name_form_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_people
            // 
            this.button_people.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_people.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_people.Location = new System.Drawing.Point(12, 50);
            this.button_people.Name = "button_people";
            this.button_people.Size = new System.Drawing.Size(245, 52);
            this.button_people.TabIndex = 0;
            this.button_people.Text = "Карты поциентов";
            this.button_people.UseVisualStyleBackColor = true;
            this.button_people.Click += new System.EventHandler(this.button_people_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_button.AutoSize = true;
            this.Exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_button.Location = new System.Drawing.Point(230, 9);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(27, 25);
            this.Exit_button.TabIndex = 1;
            this.Exit_button.Text = "X";
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            this.Exit_button.MouseEnter += new System.EventHandler(this.Exit_button_MouseEnter);
            this.Exit_button.MouseLeave += new System.EventHandler(this.Exit_button_MouseLeave);
            // 
            // button_doctor
            // 
            this.button_doctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_doctor.Location = new System.Drawing.Point(12, 108);
            this.button_doctor.Name = "button_doctor";
            this.button_doctor.Size = new System.Drawing.Size(245, 52);
            this.button_doctor.TabIndex = 0;
            this.button_doctor.Text = "Врачи";
            this.button_doctor.UseVisualStyleBackColor = true;
            this.button_doctor.Click += new System.EventHandler(this.button_doctor_Click);
            // 
            // button_sick
            // 
            this.button_sick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_sick.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_sick.Location = new System.Drawing.Point(12, 166);
            this.button_sick.Name = "button_sick";
            this.button_sick.Size = new System.Drawing.Size(245, 52);
            this.button_sick.TabIndex = 0;
            this.button_sick.Text = "Болезни";
            this.button_sick.UseVisualStyleBackColor = true;
            this.button_sick.Click += new System.EventHandler(this.button_sick_Click);
            // 
            // button_disgnos
            // 
            this.button_disgnos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_disgnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_disgnos.Location = new System.Drawing.Point(12, 224);
            this.button_disgnos.Name = "button_disgnos";
            this.button_disgnos.Size = new System.Drawing.Size(245, 52);
            this.button_disgnos.TabIndex = 0;
            this.button_disgnos.Text = "Диагнозы";
            this.button_disgnos.UseVisualStyleBackColor = true;
            this.button_disgnos.Click += new System.EventHandler(this.button_disgnos_Click);
            // 
            // Name_form_label
            // 
            this.Name_form_label.AutoSize = true;
            this.Name_form_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_form_label.Location = new System.Drawing.Point(85, 9);
            this.Name_form_label.Name = "Name_form_label";
            this.Name_form_label.Size = new System.Drawing.Size(88, 25);
            this.Name_form_label.TabIndex = 22;
            this.Name_form_label.Text = "Главная";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Отчёты диагнозов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 354);
            this.Controls.Add(this.Name_form_label);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_disgnos);
            this.Controls.Add(this.button_sick);
            this.Controls.Add(this.button_doctor);
            this.Controls.Add(this.button_people);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_people;
        private System.Windows.Forms.Label Exit_button;
        private System.Windows.Forms.Button button_doctor;
        private System.Windows.Forms.Button button_sick;
        private System.Windows.Forms.Button button_disgnos;
        private System.Windows.Forms.Label Name_form_label;
        private System.Windows.Forms.Button button1;
    }
}

