
namespace базза_данных
{
    partial class People
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
            this.People_list = new System.Windows.Forms.ListBox();
            this.Load_button = new System.Windows.Forms.Button();
            this.Name_form_label = new System.Windows.Forms.Label();
            this.l_label = new System.Windows.Forms.Label();
            this.l_textBox = new System.Windows.Forms.TextBox();
            this.otmet_label = new System.Windows.Forms.Label();
            this.otmet_textBox = new System.Windows.Forms.TextBox();
            this.p_label = new System.Windows.Forms.Label();
            this.p_textBox = new System.Windows.Forms.TextBox();
            this.last_date_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.age_label = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.first_name_label = new System.Windows.Forms.Label();
            this.pl_label = new System.Windows.Forms.Label();
            this.first_name_textBox = new System.Windows.Forms.TextBox();
            this.pl_textBox = new System.Windows.Forms.TextBox();
            this.last_date_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.age_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Id_L = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.age_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit_button
            // 
            this.Exit_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_button.AutoSize = true;
            this.Exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_button.Location = new System.Drawing.Point(281, 9);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(27, 25);
            this.Exit_button.TabIndex = 2;
            this.Exit_button.Text = "X";
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            this.Exit_button.MouseEnter += new System.EventHandler(this.Exit_button_MouseEnter);
            this.Exit_button.MouseLeave += new System.EventHandler(this.Exit_button_MouseLeave);
            // 
            // Back_Button
            // 
            this.Back_Button.AutoSize = true;
            this.Back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_Button.Location = new System.Drawing.Point(4, -8);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(61, 46);
            this.Back_Button.TabIndex = 5;
            this.Back_Button.Text = "←";
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // add_button
            // 
            this.add_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.add_button.Location = new System.Drawing.Point(151, 263);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(152, 41);
            this.add_button.TabIndex = 18;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Delete_button.Location = new System.Drawing.Point(151, 357);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(152, 41);
            this.Delete_button.TabIndex = 19;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // update_button
            // 
            this.update_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.update_button.Location = new System.Drawing.Point(151, 310);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(152, 41);
            this.update_button.TabIndex = 20;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // People_list
            // 
            this.People_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.People_list.FormattingEnabled = true;
            this.People_list.Location = new System.Drawing.Point(12, 263);
            this.People_list.Name = "People_list";
            this.People_list.Size = new System.Drawing.Size(120, 95);
            this.People_list.TabIndex = 17;
            this.People_list.Click += new System.EventHandler(this.Load_button_Click);
            // 
            // Load_button
            // 
            this.Load_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Load_button.Location = new System.Drawing.Point(12, 364);
            this.Load_button.Name = "Load_button";
            this.Load_button.Size = new System.Drawing.Size(120, 37);
            this.Load_button.TabIndex = 16;
            this.Load_button.Text = "Load";
            this.Load_button.UseVisualStyleBackColor = true;
            this.Load_button.Click += new System.EventHandler(this.Load_button_Click);
            // 
            // Name_form_label
            // 
            this.Name_form_label.AutoSize = true;
            this.Name_form_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_form_label.Location = new System.Drawing.Point(57, 9);
            this.Name_form_label.Name = "Name_form_label";
            this.Name_form_label.Size = new System.Drawing.Size(205, 25);
            this.Name_form_label.TabIndex = 21;
            this.Name_form_label.Text = "Карточки поциентов";
            // 
            // l_label
            // 
            this.l_label.AutoSize = true;
            this.l_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.l_label.Location = new System.Drawing.Point(194, 122);
            this.l_label.Name = "l_label";
            this.l_label.Size = new System.Drawing.Size(57, 20);
            this.l_label.TabIndex = 22;
            this.l_label.Text = "Адрес";
            // 
            // l_textBox
            // 
            this.l_textBox.Location = new System.Drawing.Point(151, 145);
            this.l_textBox.Name = "l_textBox";
            this.l_textBox.Size = new System.Drawing.Size(152, 20);
            this.l_textBox.TabIndex = 23;
            // 
            // otmet_label
            // 
            this.otmet_label.AutoSize = true;
            this.otmet_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.otmet_label.Location = new System.Drawing.Point(171, 168);
            this.otmet_label.Name = "otmet_label";
            this.otmet_label.Size = new System.Drawing.Size(117, 20);
            this.otmet_label.TabIndex = 22;
            this.otmet_label.Text = "Особые метки";
            // 
            // otmet_textBox
            // 
            this.otmet_textBox.Location = new System.Drawing.Point(151, 191);
            this.otmet_textBox.Name = "otmet_textBox";
            this.otmet_textBox.Size = new System.Drawing.Size(152, 20);
            this.otmet_textBox.TabIndex = 23;
            // 
            // p_label
            // 
            this.p_label.AutoSize = true;
            this.p_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.p_label.Location = new System.Drawing.Point(26, 214);
            this.p_label.Name = "p_label";
            this.p_label.Size = new System.Drawing.Size(89, 20);
            this.p_label.TabIndex = 22;
            this.p_label.Text = "Професия";
            // 
            // p_textBox
            // 
            this.p_textBox.Location = new System.Drawing.Point(12, 237);
            this.p_textBox.Name = "p_textBox";
            this.p_textBox.Size = new System.Drawing.Size(120, 20);
            this.p_textBox.TabIndex = 23;
            // 
            // last_date_label
            // 
            this.last_date_label.AutoSize = true;
            this.last_date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.last_date_label.Location = new System.Drawing.Point(135, 214);
            this.last_date_label.Name = "last_date_label";
            this.last_date_label.Size = new System.Drawing.Size(183, 20);
            this.last_date_label.TabIndex = 22;
            this.last_date_label.Text = "Последние посещение";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.name_label.Location = new System.Drawing.Point(48, 76);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(40, 20);
            this.name_label.TabIndex = 22;
            this.name_label.Text = "Имя";
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.age_label.Location = new System.Drawing.Point(43, 123);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(72, 20);
            this.age_label.TabIndex = 22;
            this.age_label.Text = "Возраст";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(12, 99);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(120, 20);
            this.name_textBox.TabIndex = 23;
            this.name_textBox.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // first_name_label
            // 
            this.first_name_label.AutoSize = true;
            this.first_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.first_name_label.Location = new System.Drawing.Point(181, 76);
            this.first_name_label.Name = "first_name_label";
            this.first_name_label.Size = new System.Drawing.Size(81, 20);
            this.first_name_label.TabIndex = 22;
            this.first_name_label.Text = "Фамилия";
            // 
            // pl_label
            // 
            this.pl_label.AutoSize = true;
            this.pl_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pl_label.Location = new System.Drawing.Point(15, 168);
            this.pl_label.Name = "pl_label";
            this.pl_label.Size = new System.Drawing.Size(117, 20);
            this.pl_label.TabIndex = 22;
            this.pl_label.Text = "Место работы";
            // 
            // first_name_textBox
            // 
            this.first_name_textBox.Location = new System.Drawing.Point(151, 99);
            this.first_name_textBox.Name = "first_name_textBox";
            this.first_name_textBox.Size = new System.Drawing.Size(152, 20);
            this.first_name_textBox.TabIndex = 23;
            // 
            // pl_textBox
            // 
            this.pl_textBox.Location = new System.Drawing.Point(12, 191);
            this.pl_textBox.Name = "pl_textBox";
            this.pl_textBox.Size = new System.Drawing.Size(120, 20);
            this.pl_textBox.TabIndex = 23;
            // 
            // last_date_dateTimePicker
            // 
            this.last_date_dateTimePicker.CustomFormat = "MM/DD/YYYY";
            this.last_date_dateTimePicker.Location = new System.Drawing.Point(151, 237);
            this.last_date_dateTimePicker.Name = "last_date_dateTimePicker";
            this.last_date_dateTimePicker.Size = new System.Drawing.Size(152, 20);
            this.last_date_dateTimePicker.TabIndex = 24;
            // 
            // age_numericUpDown
            // 
            this.age_numericUpDown.Location = new System.Drawing.Point(12, 146);
            this.age_numericUpDown.Name = "age_numericUpDown";
            this.age_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.age_numericUpDown.TabIndex = 25;
            this.age_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Id_L
            // 
            this.Id_L.AutoSize = true;
            this.Id_L.Location = new System.Drawing.Point(28, 49);
            this.Id_L.Name = "Id_L";
            this.Id_L.Size = new System.Drawing.Size(0, 13);
            this.Id_L.TabIndex = 26;
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(9, 49);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(21, 13);
            this.id_label.TabIndex = 27;
            this.id_label.Text = "ID:";
            // 
            // People
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 413);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.Id_L);
            this.Controls.Add(this.age_numericUpDown);
            this.Controls.Add(this.last_date_dateTimePicker);
            this.Controls.Add(this.pl_textBox);
            this.Controls.Add(this.first_name_textBox);
            this.Controls.Add(this.otmet_textBox);
            this.Controls.Add(this.pl_label);
            this.Controls.Add(this.last_date_label);
            this.Controls.Add(this.first_name_label);
            this.Controls.Add(this.otmet_label);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.p_textBox);
            this.Controls.Add(this.age_label);
            this.Controls.Add(this.l_textBox);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.p_label);
            this.Controls.Add(this.l_label);
            this.Controls.Add(this.Name_form_label);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.People_list);
            this.Controls.Add(this.Load_button);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Exit_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "People";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "People";
            this.Load += new System.EventHandler(this.People_Load);
            ((System.ComponentModel.ISupportInitialize)(this.age_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Exit_button;
        private System.Windows.Forms.Label Back_Button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.ListBox People_list;
        private System.Windows.Forms.Button Load_button;
        private System.Windows.Forms.Label Name_form_label;
        private System.Windows.Forms.Label l_label;
        private System.Windows.Forms.TextBox l_textBox;
        private System.Windows.Forms.Label otmet_label;
        private System.Windows.Forms.TextBox otmet_textBox;
        private System.Windows.Forms.Label p_label;
        private System.Windows.Forms.TextBox p_textBox;
        private System.Windows.Forms.Label last_date_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label first_name_label;
        private System.Windows.Forms.Label pl_label;
        private System.Windows.Forms.TextBox first_name_textBox;
        private System.Windows.Forms.TextBox pl_textBox;
        private System.Windows.Forms.DateTimePicker last_date_dateTimePicker;
        private System.Windows.Forms.NumericUpDown age_numericUpDown;
        private System.Windows.Forms.Label Id_L;
        private System.Windows.Forms.Label id_label;
    }
}