namespace C_Sharp_to_Tkinter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.name_label = new System.Windows.Forms.Label();
            this.age_label = new System.Windows.Forms.Label();
            this.name_entry = new System.Windows.Forms.TextBox();
            this.age_entry = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.error_label = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.phone_number_label = new System.Windows.Forms.Label();
            this.phone_number_entry = new System.Windows.Forms.TextBox();
            this.padge_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.address_entry = new System.Windows.Forms.TextBox();
            this.exit_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.name_label.Location = new System.Drawing.Point(8, 52);
            this.name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(82, 32);
            this.name_label.TabIndex = 1;
            this.name_label.Text = "Name";
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.age_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.age_label.Location = new System.Drawing.Point(432, 52);
            this.age_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(59, 32);
            this.age_label.TabIndex = 2;
            this.age_label.Text = "Age";
            // 
            // name_entry
            // 
            this.name_entry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_entry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.name_entry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_entry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.name_entry.Location = new System.Drawing.Point(11, 87);
            this.name_entry.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.name_entry.Name = "name_entry";
            this.name_entry.Size = new System.Drawing.Size(420, 32);
            this.name_entry.TabIndex = 1;
            // 
            // age_entry
            // 
            this.age_entry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.age_entry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.age_entry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.age_entry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.age_entry.Location = new System.Drawing.Point(435, 87);
            this.age_entry.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.age_entry.Name = "age_entry";
            this.age_entry.Size = new System.Drawing.Size(83, 32);
            this.age_entry.TabIndex = 2;
            // 
            // save_button
            // 
            this.save_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.save_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.save_button.FlatAppearance.BorderSize = 0;
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.save_button.Location = new System.Drawing.Point(8, 476);
            this.save_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(166, 59);
            this.save_button.TabIndex = 5;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // error_label
            // 
            this.error_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.error_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.error_label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.error_label.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.error_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(217)))), ((int)(((byte)(182)))));
            this.error_label.Location = new System.Drawing.Point(0, 546);
            this.error_label.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(530, 20);
            this.error_label.TabIndex = 8;
            // 
            // search_button
            // 
            this.search_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.search_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.search_button.Location = new System.Drawing.Point(180, 476);
            this.search_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.search_button.Name = "search_button";
            this.search_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.search_button.Size = new System.Drawing.Size(166, 59);
            this.search_button.TabIndex = 6;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clear_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.clear_button.Location = new System.Drawing.Point(352, 476);
            this.clear_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.clear_button.Name = "clear_button";
            this.clear_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clear_button.Size = new System.Drawing.Size(166, 59);
            this.clear_button.TabIndex = 7;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = false;
            // 
            // phone_number_label
            // 
            this.phone_number_label.AutoSize = true;
            this.phone_number_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.phone_number_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.phone_number_label.Location = new System.Drawing.Point(8, 122);
            this.phone_number_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phone_number_label.Name = "phone_number_label";
            this.phone_number_label.Size = new System.Drawing.Size(189, 32);
            this.phone_number_label.TabIndex = 3;
            this.phone_number_label.Text = "Phone Number";
            // 
            // phone_number_entry
            // 
            this.phone_number_entry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.phone_number_entry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.phone_number_entry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phone_number_entry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.phone_number_entry.Location = new System.Drawing.Point(11, 157);
            this.phone_number_entry.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.phone_number_entry.Name = "phone_number_entry";
            this.phone_number_entry.Size = new System.Drawing.Size(259, 32);
            this.phone_number_entry.TabIndex = 3;
            // 
            // padge_label
            // 
            this.padge_label.AutoSize = true;
            this.padge_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.padge_label.Font = new System.Drawing.Font("Wide Latin", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.padge_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(217)))), ((int)(((byte)(182)))));
            this.padge_label.Location = new System.Drawing.Point(3, 4);
            this.padge_label.Name = "padge_label";
            this.padge_label.Size = new System.Drawing.Size(461, 40);
            this.padge_label.TabIndex = 0;
            this.padge_label.Text = "Branding Shoes";
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.address_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.address_label.Location = new System.Drawing.Point(8, 192);
            this.address_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(105, 32);
            this.address_label.TabIndex = 4;
            this.address_label.Text = "Address";
            // 
            // address_entry
            // 
            this.address_entry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.address_entry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.address_entry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.address_entry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.address_entry.Location = new System.Drawing.Point(11, 227);
            this.address_entry.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.address_entry.Name = "address_entry";
            this.address_entry.Size = new System.Drawing.Size(420, 32);
            this.address_entry.TabIndex = 4;
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.exit_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_button.BackgroundImage")));
            this.exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.exit_button.Location = new System.Drawing.Point(477, 0);
            this.exit_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(53, 49);
            this.exit_button.TabIndex = 9;
            this.exit_button.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.panel1.Controls.Add(this.exit_button);
            this.panel1.Controls.Add(this.padge_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 49);
            this.panel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(530, 566);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.address_entry);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.phone_number_entry);
            this.Controls.Add(this.phone_number_label);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.age_entry);
            this.Controls.Add(this.name_entry);
            this.Controls.Add(this.age_label);
            this.Controls.Add(this.name_label);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label name_label;
        private Label age_label;
        private TextBox name_entry;
        private TextBox age_entry;
        private Button save_button;
        private TextBox error_label;
        private Button search_button;
        private Button clear_button;
        private Label phone_number_label;
        private TextBox phone_number_entry;
        private Label padge_label;
        private Label address_label;
        private TextBox address_entry;
        private Button exit_button;
        private Panel panel1;
    }
}