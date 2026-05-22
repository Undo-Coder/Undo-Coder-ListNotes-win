namespace Memosoft
{
    partial class Form2
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
            this.Apply = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.KeySetting = new System.Windows.Forms.TabPage();
            this.InputKey = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.KeySetting.SuspendLayout();
            this.InputKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(560, 388);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(75, 23);
            this.Apply.TabIndex = 1;
            this.Apply.Text = "適用";
            this.Apply.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(479, 388);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "キャンセル";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(1, 392);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(41, 19);
            this.Edit.TabIndex = 3;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.KeySetting);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(634, 386);
            this.tabControl1.TabIndex = 4;
            // 
            // KeySetting
            // 
            this.KeySetting.BackColor = System.Drawing.SystemColors.Menu;
            this.KeySetting.Controls.Add(this.InputKey);
            this.KeySetting.Location = new System.Drawing.Point(4, 22);
            this.KeySetting.Name = "KeySetting";
            this.KeySetting.Padding = new System.Windows.Forms.Padding(3);
            this.KeySetting.Size = new System.Drawing.Size(626, 360);
            this.KeySetting.TabIndex = 0;
            this.KeySetting.Text = "キー設定";
            // 
            // InputKey
            // 
            this.InputKey.Controls.Add(this.radioButton1);
            this.InputKey.Location = new System.Drawing.Point(7, 6);
            this.InputKey.Name = "InputKey";
            this.InputKey.Size = new System.Drawing.Size(613, 98);
            this.InputKey.TabIndex = 0;
            this.InputKey.TabStop = false;
            this.InputKey.Text = "入力する時のキー設定";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(88, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Apply);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.KeySetting.ResumeLayout(false);
            this.InputKey.ResumeLayout(false);
            this.InputKey.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage KeySetting;
        private System.Windows.Forms.GroupBox InputKey;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}