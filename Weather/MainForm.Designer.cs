namespace Weather
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listBox = new System.Windows.Forms.ListBox();
            this.button_refill = new System.Windows.Forms.Button();
            this.button_take = new System.Windows.Forms.Button();
            this.label_count = new System.Windows.Forms.Label();
            this.label_info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(12, 43);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(223, 184);
            this.listBox.TabIndex = 10;
            // 
            // button_refill
            // 
            this.button_refill.Location = new System.Drawing.Point(320, 9);
            this.button_refill.Name = "button_refill";
            this.button_refill.Size = new System.Drawing.Size(119, 23);
            this.button_refill.TabIndex = 9;
            this.button_refill.Text = "Перезаполнить";
            this.button_refill.UseVisualStyleBackColor = true;
            this.button_refill.Click += new System.EventHandler(this.button_refill_Click);
            // 
            // button_take
            // 
            this.button_take.Location = new System.Drawing.Point(304, 43);
            this.button_take.Name = "button_take";
            this.button_take.Size = new System.Drawing.Size(75, 23);
            this.button_take.TabIndex = 8;
            this.button_take.Text = "Взять";
            this.button_take.UseVisualStyleBackColor = true;
            this.button_take.Click += new System.EventHandler(this.button_take_Click);
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Location = new System.Drawing.Point(11, 13);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(72, 15);
            this.label_count.TabIndex = 7;
            this.label_count.Text = "Количество";
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Location = new System.Drawing.Point(252, 85);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(81, 15);
            this.label_info.TabIndex = 6;
            this.label_info.Text = "Информация";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 239);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.button_refill);
            this.Controls.Add(this.button_take);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.label_info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Погода";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button button_refill;
        private System.Windows.Forms.Button button_take;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.Label label_info;
    }
}
