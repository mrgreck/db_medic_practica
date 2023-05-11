
namespace базза_данных
{
    partial class Sick
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
            this.Name_label = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.coment_label = new System.Windows.Forms.Label();
            this.coment_textBox = new System.Windows.Forms.TextBox();
            this.Load_button = new System.Windows.Forms.Button();
            this.Sick_list = new System.Windows.Forms.ListBox();
            this.update_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.Name_form_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exit_button
            // 
            this.Exit_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_button.AutoSize = true;
            this.Exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_button.Location = new System.Drawing.Point(272, 9);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(27, 25);
            this.Exit_button.TabIndex = 3;
            this.Exit_button.Text = "X";
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            this.Exit_button.MouseEnter += new System.EventHandler(this.Exit_button_MouseEnter);
            this.Exit_button.MouseLeave += new System.EventHandler(this.Exit_button_MouseLeave);
            // 
            // Back_Button
            // 
            this.Back_Button.AutoSize = true;
            this.Back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_Button.Location = new System.Drawing.Point(2, -8);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(61, 46);
            this.Back_Button.TabIndex = 5;
            this.Back_Button.Text = "←";
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Name_label
            // 
            this.Name_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_label.Location = new System.Drawing.Point(105, 45);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(92, 22);
            this.Name_label.TabIndex = 6;
            this.Name_label.Text = "Название";
            // 
            // name_textBox
            // 
            this.name_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.name_textBox.Location = new System.Drawing.Point(101, 70);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(100, 20);
            this.name_textBox.TabIndex = 7;
            // 
            // coment_label
            // 
            this.coment_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.coment_label.AutoSize = true;
            this.coment_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coment_label.Location = new System.Drawing.Point(16, 93);
            this.coment_label.Name = "coment_label";
            this.coment_label.Size = new System.Drawing.Size(285, 22);
            this.coment_label.TabIndex = 6;
            this.coment_label.Text = "Рекомендации при заболевании";
            // 
            // coment_textBox
            // 
            this.coment_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.coment_textBox.Location = new System.Drawing.Point(12, 118);
            this.coment_textBox.Multiline = true;
            this.coment_textBox.Name = "coment_textBox";
            this.coment_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.coment_textBox.Size = new System.Drawing.Size(287, 78);
            this.coment_textBox.TabIndex = 7;
            // 
            // Load_button
            // 
            this.Load_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Load_button.Location = new System.Drawing.Point(10, 303);
            this.Load_button.Name = "Load_button";
            this.Load_button.Size = new System.Drawing.Size(120, 37);
            this.Load_button.TabIndex = 8;
            this.Load_button.Text = "Load";
            this.Load_button.UseVisualStyleBackColor = true;
            this.Load_button.Click += new System.EventHandler(this.Load_button_Click);
            // 
            // Sick_list
            // 
            this.Sick_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Sick_list.FormattingEnabled = true;
            this.Sick_list.Location = new System.Drawing.Point(10, 202);
            this.Sick_list.Name = "Sick_list";
            this.Sick_list.Size = new System.Drawing.Size(120, 95);
            this.Sick_list.TabIndex = 9;
            this.Sick_list.Click += new System.EventHandler(this.Load_button_Click);
            // 
            // update_button
            // 
            this.update_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.update_button.Location = new System.Drawing.Point(149, 249);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(152, 41);
            this.update_button.TabIndex = 10;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Delete_button.Location = new System.Drawing.Point(149, 296);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(152, 41);
            this.Delete_button.TabIndex = 10;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // add_button
            // 
            this.add_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.add_button.Location = new System.Drawing.Point(149, 202);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(152, 41);
            this.add_button.TabIndex = 10;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // Name_form_label
            // 
            this.Name_form_label.AutoSize = true;
            this.Name_form_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_form_label.Location = new System.Drawing.Point(104, 9);
            this.Name_form_label.Name = "Name_form_label";
            this.Name_form_label.Size = new System.Drawing.Size(91, 25);
            this.Name_form_label.TabIndex = 22;
            this.Name_form_label.Text = "Болезни";
            // 
            // Sick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 352);
            this.Controls.Add(this.Name_form_label);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.Sick_list);
            this.Controls.Add(this.Load_button);
            this.Controls.Add(this.coment_textBox);
            this.Controls.Add(this.coment_label);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Exit_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sick";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sick";
            this.Load += new System.EventHandler(this.Sick_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Exit_button;
        private System.Windows.Forms.Label Back_Button;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label coment_label;
        private System.Windows.Forms.TextBox coment_textBox;
        private System.Windows.Forms.Button Load_button;
        private System.Windows.Forms.ListBox Sick_list;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label Name_form_label;
    }
}