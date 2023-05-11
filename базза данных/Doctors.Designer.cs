
namespace базза_данных
{
    partial class Doctors
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
            this.Exit_button = new System.Windows.Forms.Label();
            this.Back_Button = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.Doct_list = new System.Windows.Forms.ListBox();
            this.Load_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.first_name_textBox = new System.Windows.Forms.TextBox();
            this.first_name_label = new System.Windows.Forms.Label();
            this.Name_form_label = new System.Windows.Forms.Label();
            this.cabin_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Pskill_numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.cabin_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pskill_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit_button
            // 
            this.Exit_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_button.AutoSize = true;
            this.Exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_button.Location = new System.Drawing.Point(279, 9);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(27, 25);
            this.Exit_button.TabIndex = 3;
            this.Exit_button.Text = "X";
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.AutoSize = true;
            this.Back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_Button.Location = new System.Drawing.Point(12, -8);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(61, 46);
            this.Back_Button.TabIndex = 4;
            this.Back_Button.Text = "←";
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(151, 139);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(152, 41);
            this.add_button.TabIndex = 13;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(151, 233);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(152, 41);
            this.Delete_button.TabIndex = 14;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(151, 186);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(152, 41);
            this.update_button.TabIndex = 15;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // Doct_list
            // 
            this.Doct_list.FormattingEnabled = true;
            this.Doct_list.Location = new System.Drawing.Point(12, 139);
            this.Doct_list.Name = "Doct_list";
            this.Doct_list.Size = new System.Drawing.Size(120, 95);
            this.Doct_list.TabIndex = 12;
            this.Doct_list.Click += new System.EventHandler(this.Load_button_Click);
            // 
            // Load_button
            // 
            this.Load_button.Location = new System.Drawing.Point(12, 240);
            this.Load_button.Name = "Load_button";
            this.Load_button.Size = new System.Drawing.Size(120, 37);
            this.Load_button.TabIndex = 11;
            this.Load_button.Text = "Load";
            this.Load_button.UseVisualStyleBackColor = true;
            this.Load_button.Click += new System.EventHandler(this.Load_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Кабинет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(142, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Пропускная способность";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(13, 62);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(120, 20);
            this.name_textBox.TabIndex = 16;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_label.Location = new System.Drawing.Point(51, 42);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(35, 17);
            this.name_label.TabIndex = 17;
            this.name_label.Text = "Имя";
            // 
            // first_name_textBox
            // 
            this.first_name_textBox.Location = new System.Drawing.Point(152, 62);
            this.first_name_textBox.Name = "first_name_textBox";
            this.first_name_textBox.Size = new System.Drawing.Size(152, 20);
            this.first_name_textBox.TabIndex = 16;
            // 
            // first_name_label
            // 
            this.first_name_label.AutoSize = true;
            this.first_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.first_name_label.Location = new System.Drawing.Point(186, 42);
            this.first_name_label.Name = "first_name_label";
            this.first_name_label.Size = new System.Drawing.Size(70, 17);
            this.first_name_label.TabIndex = 17;
            this.first_name_label.Text = "Фамилия";
            // 
            // Name_form_label
            // 
            this.Name_form_label.AutoSize = true;
            this.Name_form_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_form_label.Location = new System.Drawing.Point(109, 9);
            this.Name_form_label.Name = "Name_form_label";
            this.Name_form_label.Size = new System.Drawing.Size(94, 25);
            this.Name_form_label.TabIndex = 22;
            this.Name_form_label.Text = "Доктора";
            // 
            // cabin_numericUpDown
            // 
            this.cabin_numericUpDown.Location = new System.Drawing.Point(12, 113);
            this.cabin_numericUpDown.Name = "cabin_numericUpDown";
            this.cabin_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.cabin_numericUpDown.TabIndex = 23;
            // 
            // Pskill_numericUpDown
            // 
            this.Pskill_numericUpDown.Location = new System.Drawing.Point(152, 113);
            this.Pskill_numericUpDown.Name = "Pskill_numericUpDown";
            this.Pskill_numericUpDown.Size = new System.Drawing.Size(151, 20);
            this.Pskill_numericUpDown.TabIndex = 24;
            // 
            // Doctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 289);
            this.Controls.Add(this.Pskill_numericUpDown);
            this.Controls.Add(this.cabin_numericUpDown);
            this.Controls.Add(this.Name_form_label);
            this.Controls.Add(this.first_name_label);
            this.Controls.Add(this.first_name_textBox);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.Doct_list);
            this.Controls.Add(this.Load_button);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Exit_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Doctors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctors";
            this.Load += new System.EventHandler(this.Doctors_Load);
            this.Click += new System.EventHandler(this.Exit_button_Click);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.cabin_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pskill_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Exit_button;
        private System.Windows.Forms.Label Back_Button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.ListBox Doct_list;
        private System.Windows.Forms.Button Load_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox first_name_textBox;
        private System.Windows.Forms.Label first_name_label;
        private System.Windows.Forms.Label Name_form_label;
        private System.Windows.Forms.NumericUpDown cabin_numericUpDown;
        private System.Windows.Forms.NumericUpDown Pskill_numericUpDown;
    }
}