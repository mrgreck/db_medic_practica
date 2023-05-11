
namespace базза_данных
{
    partial class Reports
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
            this.item_list = new System.Windows.Forms.ListBox();
            this.child_item_list = new System.Windows.Forms.ListBox();
            this.report_textBox = new System.Windows.Forms.TextBox();
            this.selest_list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Exit_button
            // 
            this.Exit_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_button.AutoSize = true;
            this.Exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_button.Location = new System.Drawing.Point(483, 9);
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
            this.Back_Button.Location = new System.Drawing.Point(5, -10);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(61, 46);
            this.Back_Button.TabIndex = 6;
            this.Back_Button.Text = "←";
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // item_list
            // 
            this.item_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.item_list.FormattingEnabled = true;
            this.item_list.Location = new System.Drawing.Point(319, 99);
            this.item_list.Name = "item_list";
            this.item_list.Size = new System.Drawing.Size(191, 69);
            this.item_list.TabIndex = 9;
            this.item_list.SelectedIndexChanged += new System.EventHandler(this.item_list_SelectedIndexChanged);
            // 
            // child_item_list
            // 
            this.child_item_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.child_item_list.FormattingEnabled = true;
            this.child_item_list.Location = new System.Drawing.Point(318, 174);
            this.child_item_list.Name = "child_item_list";
            this.child_item_list.Size = new System.Drawing.Size(191, 95);
            this.child_item_list.TabIndex = 9;
            this.child_item_list.SelectedIndexChanged += new System.EventHandler(this.child_item_list_SelectedIndexChanged);
            // 
            // report_textBox
            // 
            this.report_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.report_textBox.Location = new System.Drawing.Point(7, 46);
            this.report_textBox.Multiline = true;
            this.report_textBox.Name = "report_textBox";
            this.report_textBox.ReadOnly = true;
            this.report_textBox.Size = new System.Drawing.Size(305, 223);
            this.report_textBox.TabIndex = 10;
            // 
            // selest_list
            // 
            this.selest_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selest_list.FormattingEnabled = true;
            this.selest_list.Location = new System.Drawing.Point(318, 46);
            this.selest_list.Name = "selest_list";
            this.selest_list.Size = new System.Drawing.Size(191, 43);
            this.selest_list.TabIndex = 9;
            this.selest_list.SelectedIndexChanged += new System.EventHandler(this.selest_list_SelectedIndexChanged);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 285);
            this.Controls.Add(this.report_textBox);
            this.Controls.Add(this.child_item_list);
            this.Controls.Add(this.selest_list);
            this.Controls.Add(this.item_list);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Exit_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.Text = "Reports";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Exit_button;
        private System.Windows.Forms.Label Back_Button;
        private System.Windows.Forms.ListBox item_list;
        private System.Windows.Forms.ListBox child_item_list;
        private System.Windows.Forms.TextBox report_textBox;
        private System.Windows.Forms.ListBox selest_list;
    }
}