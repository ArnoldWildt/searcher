namespace searcher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Google = new System.Windows.Forms.RadioButton();
            this.Wikipedia = new System.Windows.Forms.RadioButton();
            this.Linguee = new System.Windows.Forms.RadioButton();
            this.DeepL = new System.Windows.Forms.RadioButton();
            this.search_button = new System.Windows.Forms.Button();
            this.search_box = new System.Windows.Forms.TextBox();
            this.search_label = new System.Windows.Forms.Label();
            this.clear_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Google
            // 
            this.Google.AutoSize = true;
            this.Google.Location = new System.Drawing.Point(12, 79);
            this.Google.Name = "Google";
            this.Google.Size = new System.Drawing.Size(59, 17);
            this.Google.TabIndex = 3;
            this.Google.TabStop = true;
            this.Google.Text = "Google";
            this.Google.UseVisualStyleBackColor = true;
            // 
            // Wikipedia
            // 
            this.Wikipedia.AutoSize = true;
            this.Wikipedia.Location = new System.Drawing.Point(12, 102);
            this.Wikipedia.Name = "Wikipedia";
            this.Wikipedia.Size = new System.Drawing.Size(72, 17);
            this.Wikipedia.TabIndex = 4;
            this.Wikipedia.TabStop = true;
            this.Wikipedia.Text = "Wikipedia";
            this.Wikipedia.UseVisualStyleBackColor = true;
            // 
            // Linguee
            // 
            this.Linguee.AutoSize = true;
            this.Linguee.Location = new System.Drawing.Point(12, 125);
            this.Linguee.Name = "Linguee";
            this.Linguee.Size = new System.Drawing.Size(63, 17);
            this.Linguee.TabIndex = 5;
            this.Linguee.TabStop = true;
            this.Linguee.Text = "Linguee";
            this.Linguee.UseVisualStyleBackColor = true;
            // 
            // DeepL
            // 
            this.DeepL.AutoSize = true;
            this.DeepL.Location = new System.Drawing.Point(12, 148);
            this.DeepL.Name = "DeepL";
            this.DeepL.Size = new System.Drawing.Size(57, 17);
            this.DeepL.TabIndex = 6;
            this.DeepL.TabStop = true;
            this.DeepL.Text = "DeepL";
            this.DeepL.UseVisualStyleBackColor = true;
            // 
            // search_button
            // 
            this.search_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.search_button.BackColor = System.Drawing.Color.SeaGreen;
            this.search_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.search_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.ForeColor = System.Drawing.Color.White;
            this.search_button.Image = ((System.Drawing.Image)(resources.GetObject("search_button.Image")));
            this.search_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search_button.Location = new System.Drawing.Point(390, 217);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(241, 47);
            this.search_button.TabIndex = 7;
            this.search_button.Text = "Search!";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // search_box
            // 
            this.search_box.Location = new System.Drawing.Point(12, 43);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(244, 20);
            this.search_box.TabIndex = 8;
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.Location = new System.Drawing.Point(13, 24);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(62, 13);
            this.search_label.TabIndex = 9;
            this.search_label.Text = "Search-Box";
            // 
            // clear_button
            // 
            this.clear_button.AllowDrop = true;
            this.clear_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clear_button.BackgroundImage")));
            this.clear_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clear_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_button.Location = new System.Drawing.Point(262, 43);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(20, 20);
            this.clear_button.TabIndex = 10;
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(643, 276);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.search_label);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.DeepL);
            this.Controls.Add(this.Linguee);
            this.Controls.Add(this.Wikipedia);
            this.Controls.Add(this.Google);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Searcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton Google;
        private System.Windows.Forms.RadioButton Wikipedia;
        private System.Windows.Forms.RadioButton Linguee;
        private System.Windows.Forms.RadioButton DeepL;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.Button clear_button;
    }
}

