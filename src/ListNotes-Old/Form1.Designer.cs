namespace Memosoft
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.BoxZoomInBtn = new System.Windows.Forms.Button();
            this.BoxZoomOutBtn = new System.Windows.Forms.Button();
            this.FontSizeInfo = new System.Windows.Forms.TextBox();
            this.MemoContents = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.NewMemo = new System.Windows.Forms.ToolStripMenuItem();
            this.テキストファイル = new System.Windows.Forms.ToolStripMenuItem();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.テキストファイルtxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MemoSave = new System.Windows.Forms.ToolStripMenuItem();
            this.上書き保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.名前を付けて保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SoftSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.Key = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WordWrap = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoxZoomInBtn
            // 
            this.BoxZoomInBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxZoomInBtn.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BoxZoomInBtn.Location = new System.Drawing.Point(754, 1);
            this.BoxZoomInBtn.Name = "BoxZoomInBtn";
            this.BoxZoomInBtn.Size = new System.Drawing.Size(19, 20);
            this.BoxZoomInBtn.TabIndex = 6;
            this.BoxZoomInBtn.Text = "＋";
            this.BoxZoomInBtn.UseVisualStyleBackColor = true;
            this.BoxZoomInBtn.Click += new System.EventHandler(this.BoxZoomIn);
            // 
            // BoxZoomOutBtn
            // 
            this.BoxZoomOutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxZoomOutBtn.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BoxZoomOutBtn.Location = new System.Drawing.Point(779, 1);
            this.BoxZoomOutBtn.Name = "BoxZoomOutBtn";
            this.BoxZoomOutBtn.Size = new System.Drawing.Size(20, 20);
            this.BoxZoomOutBtn.TabIndex = 7;
            this.BoxZoomOutBtn.Text = "－";
            this.BoxZoomOutBtn.UseVisualStyleBackColor = true;
            this.BoxZoomOutBtn.Click += new System.EventHandler(this.BoxZoomOut);
            // 
            // FontSizeInfo
            // 
            this.FontSizeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FontSizeInfo.BackColor = System.Drawing.SystemColors.Desktop;
            this.FontSizeInfo.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FontSizeInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FontSizeInfo.Location = new System.Drawing.Point(0, 438);
            this.FontSizeInfo.Name = "FontSizeInfo";
            this.FontSizeInfo.ReadOnly = true;
            this.FontSizeInfo.Size = new System.Drawing.Size(799, 23);
            this.FontSizeInfo.TabIndex = 8;
            // 
            // MemoContents
            // 
            this.MemoContents.AcceptsReturn = true;
            this.MemoContents.AcceptsTab = true;
            this.MemoContents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MemoContents.BackColor = System.Drawing.SystemColors.Menu;
            this.MemoContents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MemoContents.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MemoContents.HideSelection = false;
            this.MemoContents.Location = new System.Drawing.Point(0, 27);
            this.MemoContents.Multiline = true;
            this.MemoContents.Name = "MemoContents";
            this.MemoContents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MemoContents.Size = new System.Drawing.Size(799, 413);
            this.MemoContents.TabIndex = 5;
            this.MemoContents.TextChanged += new System.EventHandler(this.MemoContents_TextChanged);
            this.MemoContents.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MemoKeydown);
            this.MemoContents.ImeModeChanged += new System.EventHandler(this.ChangeIme);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.SoftSetting});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(142, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "MemoRibbon";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MemoRibbon_ItemClicked);
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMemo,
            this.Open,
            this.MemoSave});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(83, 20);
            this.File.Text = "ファイル";
            // 
            // NewMemo
            // 
            this.NewMemo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.テキストファイル});
            this.NewMemo.Name = "NewMemo";
            this.NewMemo.Size = new System.Drawing.Size(138, 22);
            this.NewMemo.Text = "新規作成";
            // 
            // テキストファイル
            // 
            this.テキストファイル.Name = "テキストファイル";
            this.テキストファイル.Size = new System.Drawing.Size(258, 22);
            this.テキストファイル.Text = "テキストファイル（txt）";
            this.テキストファイル.Click += new System.EventHandler(this.File_Create_txtClick);
            // 
            // Open
            // 
            this.Open.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.テキストファイルtxtToolStripMenuItem});
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(138, 22);
            this.Open.Text = "開く";
            // 
            // テキストファイルtxtToolStripMenuItem
            // 
            this.テキストファイルtxtToolStripMenuItem.Name = "テキストファイルtxtToolStripMenuItem";
            this.テキストファイルtxtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.テキストファイルtxtToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.テキストファイルtxtToolStripMenuItem.Text = "テキストファイル（txt）";
            this.テキストファイルtxtToolStripMenuItem.Click += new System.EventHandler(this.File_Open_txtClick);
            // 
            // MemoSave
            // 
            this.MemoSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.上書き保存ToolStripMenuItem,
            this.名前を付けて保存ToolStripMenuItem});
            this.MemoSave.Name = "MemoSave";
            this.MemoSave.Size = new System.Drawing.Size(138, 22);
            this.MemoSave.Text = "保存";
            // 
            // 上書き保存ToolStripMenuItem
            // 
            this.上書き保存ToolStripMenuItem.Name = "上書き保存ToolStripMenuItem";
            this.上書き保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.上書き保存ToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.上書き保存ToolStripMenuItem.Text = "保存";
            this.上書き保存ToolStripMenuItem.Click += new System.EventHandler(this.File_Save_StdSaveClick);
            // 
            // 名前を付けて保存ToolStripMenuItem
            // 
            this.名前を付けて保存ToolStripMenuItem.Name = "名前を付けて保存ToolStripMenuItem";
            this.名前を付けて保存ToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.名前を付けて保存ToolStripMenuItem.Text = "名前を付けて保存";
            this.名前を付けて保存ToolStripMenuItem.Click += new System.EventHandler(this.File_Save_NameSaveClick);
            // 
            // SoftSetting
            // 
            this.SoftSetting.Name = "SoftSetting";
            this.SoftSetting.Size = new System.Drawing.Size(51, 20);
            this.SoftSetting.Text = "設定";
            this.SoftSetting.Click += new System.EventHandler(this.SettingClick);
            // 
            // Key
            // 
            this.Key.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Key.AutoSize = true;
            this.Key.BackColor = System.Drawing.SystemColors.Desktop;
            this.Key.Location = new System.Drawing.Point(777, 443);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(11, 12);
            this.Key.TabIndex = 10;
            this.Key.Text = "\\";
            this.Key.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // WordWrap
            // 
            this.WordWrap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WordWrap.AutoSize = true;
            this.WordWrap.BackColor = System.Drawing.SystemColors.Highlight;
            this.WordWrap.Location = new System.Drawing.Point(683, 5);
            this.WordWrap.Name = "WordWrap";
            this.WordWrap.Size = new System.Drawing.Size(65, 16);
            this.WordWrap.TabIndex = 12;
            this.WordWrap.Text = "折り返し";
            this.WordWrap.UseVisualStyleBackColor = false;
            this.WordWrap.CheckedChanged += new System.EventHandler(this.WordWrapChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(799, 461);
            this.Controls.Add(this.WordWrap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.FontSizeInfo);
            this.Controls.Add(this.BoxZoomOutBtn);
            this.Controls.Add(this.BoxZoomInBtn);
            this.Controls.Add(this.MemoContents);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MemoSoft";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BoxZoomInBtn;
        private System.Windows.Forms.Button BoxZoomOutBtn;
        private System.Windows.Forms.TextBox FontSizeInfo;
        public System.Windows.Forms.TextBox MemoContents;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem NewMemo;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.ToolStripMenuItem MemoSave;
        private System.Windows.Forms.ToolStripMenuItem SoftSetting;
        private System.Windows.Forms.ToolStripMenuItem テキストファイルtxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem テキストファイル;
        private System.Windows.Forms.ToolStripMenuItem 上書き保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 名前を付けて保存ToolStripMenuItem;
        private System.Windows.Forms.Label Key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox WordWrap;
    }
}

