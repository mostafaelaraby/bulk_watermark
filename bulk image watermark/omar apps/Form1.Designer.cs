namespace  watermark_generator

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
            this.label1 = new System.Windows.Forms.Label();
            this.watermark_image = new System.Windows.Forms.TextBox();
            this.select_watermark_image = new System.Windows.Forms.Button();
            this.openfiledialog_watermark = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.images = new System.Windows.Forms.TextBox();
            this.select_images = new System.Windows.Forms.Button();
            this.openfiledialog_images = new System.Windows.Forms.OpenFileDialog();
            this.output = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.output_text = new System.Windows.Forms.TextBox();
            this.select_output_folder = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Start = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.watermark_position = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trancparency = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.scale = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trancparency)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "watermark image";
            // 
            // watermark_image
            // 
            this.watermark_image.Font = new System.Drawing.Font("Orbitron", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watermark_image.Location = new System.Drawing.Point(201, 25);
            this.watermark_image.Name = "watermark_image";
            this.watermark_image.ReadOnly = true;
            this.watermark_image.Size = new System.Drawing.Size(198, 30);
            this.watermark_image.TabIndex = 1;
            // 
            // select_watermark_image
            // 
            this.select_watermark_image.Font = new System.Drawing.Font("Orbitron", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_watermark_image.Location = new System.Drawing.Point(399, 25);
            this.select_watermark_image.Name = "select_watermark_image";
            this.select_watermark_image.Size = new System.Drawing.Size(102, 30);
            this.select_watermark_image.TabIndex = 2;
            this.select_watermark_image.Text = "browse";
            this.select_watermark_image.UseVisualStyleBackColor = true;
            this.select_watermark_image.Click += new System.EventHandler(this.select_watermark_image_Click);
            // 
            // openfiledialog_watermark
            // 
            this.openfiledialog_watermark.FileName = "openFileDialog1";
            this.openfiledialog_watermark.Title = "Select Watermark image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select images";
            // 
            // images
            // 
            this.images.Font = new System.Drawing.Font("Orbitron", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.images.Location = new System.Drawing.Point(201, 76);
            this.images.Name = "images";
            this.images.ReadOnly = true;
            this.images.Size = new System.Drawing.Size(198, 30);
            this.images.TabIndex = 4;
            // 
            // select_images
            // 
            this.select_images.Font = new System.Drawing.Font("Orbitron", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_images.Location = new System.Drawing.Point(399, 76);
            this.select_images.Name = "select_images";
            this.select_images.Size = new System.Drawing.Size(102, 29);
            this.select_images.TabIndex = 5;
            this.select_images.Text = "browse";
            this.select_images.UseVisualStyleBackColor = true;
            this.select_images.Click += new System.EventHandler(this.select_images_Click);
            // 
            // openfiledialog_images
            // 
            this.openfiledialog_images.FileName = "select images";
            this.openfiledialog_images.Multiselect = true;
            this.openfiledialog_images.Title = "Select images";
            // 
            // output
            // 
            this.output.Description = "Select output file";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "select output folder";
            // 
            // output_text
            // 
            this.output_text.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_text.Location = new System.Drawing.Point(201, 117);
            this.output_text.Name = "output_text";
            this.output_text.ReadOnly = true;
            this.output_text.Size = new System.Drawing.Size(198, 27);
            this.output_text.TabIndex = 7;
            // 
            // select_output_folder
            // 
            this.select_output_folder.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_output_folder.Location = new System.Drawing.Point(399, 112);
            this.select_output_folder.Name = "select_output_folder";
            this.select_output_folder.Size = new System.Drawing.Size(102, 32);
            this.select_output_folder.TabIndex = 8;
            this.select_output_folder.Text = "browse";
            this.select_output_folder.UseVisualStyleBackColor = true;
            this.select_output_folder.Click += new System.EventHandler(this.select_output_folder_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(5, 328);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(536, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Orbitron", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(399, 273);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(102, 49);
            this.Start.TabIndex = 10;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click_1);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Orbitron", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(235, 273);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(142, 48);
            this.clear.TabIndex = 11;
            this.clear.Text = "Clear inputs";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // watermark_position
            // 
            this.watermark_position.Font = new System.Drawing.Font("Orbitron", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watermark_position.FormattingEnabled = true;
            this.watermark_position.Items.AddRange(new object[] {
            "Top Right",
            "Top Left",
            "Bottom Right",
            "Bottom Left"});
            this.watermark_position.Location = new System.Drawing.Point(296, 160);
            this.watermark_position.Name = "watermark_position";
            this.watermark_position.Size = new System.Drawing.Size(245, 30);
            this.watermark_position.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Orbitron", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Select watermark position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Orbitron", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(328, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Set Watermark Trancparency";
            // 
            // trancparency
            // 
            this.trancparency.Font = new System.Drawing.Font("Orbitron", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trancparency.Location = new System.Drawing.Point(340, 212);
            this.trancparency.Name = "trancparency";
            this.trancparency.Size = new System.Drawing.Size(74, 30);
            this.trancparency.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Orbitron", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(420, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "%";
            // 
            // scale
            // 
            this.scale.AutoSize = true;
            this.scale.Font = new System.Drawing.Font("Orbitron", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scale.Location = new System.Drawing.Point(9, 251);
            this.scale.Name = "scale";
            this.scale.Size = new System.Drawing.Size(157, 26);
            this.scale.TabIndex = 17;
            this.scale.Text = "With scaling";
            this.scale.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 363);
            this.Controls.Add(this.scale);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trancparency);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.watermark_position);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.select_output_folder);
            this.Controls.Add(this.output_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.select_images);
            this.Controls.Add(this.images);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.select_watermark_image);
            this.Controls.Add(this.watermark_image);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Professional Bulk Watermark Adder";
            ((System.ComponentModel.ISupportInitialize)(this.trancparency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox watermark_image;
        private System.Windows.Forms.Button select_watermark_image;
        private System.Windows.Forms.OpenFileDialog openfiledialog_watermark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox images;
        private System.Windows.Forms.Button select_images;
        private System.Windows.Forms.OpenFileDialog openfiledialog_images;
        private System.Windows.Forms.FolderBrowserDialog output;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox output_text;
        private System.Windows.Forms.Button select_output_folder;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.ComboBox watermark_position;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown trancparency;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox scale;
    }
}

