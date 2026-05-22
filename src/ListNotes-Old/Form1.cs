using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics.Eventing.Reader;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Memosoft
{
    public partial class Form1 : Form
    {
        const int SB_HORZ = 0x00;
        const int SB_VERT = 0x01;
        const int WM_HSCROLL = 0x0114;
        const int WM_VSCROLL = 0x0115;
        const int SB_THUMBPOSITION = 4;

        [DllImport("USER32.DLL", CharSet = CharSet.Auto)]
        static extern int GetScrollPos(IntPtr hWnd, Int32 nBar);
        [DllImport("user32.dll")]
        static extern int SetScrollPos(IntPtr hWnd, Int32 nBar, int nPos, bool bRedraw);
        [DllImport("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public static Point GetTextBoxScrollPos(TextBox textBox)
        {
            return new Point(GetScrollPos(textBox.Handle, SB_HORZ), GetScrollPos(textBox.Handle, SB_VERT));
        }

        public static void SetTextBoxScrollPos(TextBox textBox, Point newPos)
        {
            SendMessage(textBox.Handle, WM_HSCROLL, (newPos.X << 16) + SB_THUMBPOSITION, 0);
            SendMessage(textBox.Handle, WM_VSCROLL, (newPos.Y << 16) + SB_THUMBPOSITION, 0);
        }

        //ファイル関係の変数
        String FileType = "txt";
        String FilePath = "NewFile";
        bool FileSave = false;
        //############################

        ImeMode Ime;
        int TextSize = 18;
        int SelectLine = 0;
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// MSとTXTの変換（引数１,引数２）
        /// </summary>
        /// <param name="Text">変換する内容</param>
        /// <param name="B_to_A">どちらに変換するのかを決める</param>
        /// <returns>変換した結果</returns>
        private String MSReplace(String Text ,String B_to_A)
        {
            String result = Text;
            if(B_to_A == "ms => txt")
            {

            }else if (B_to_A == "ms <= txt")
            {

            }
            return result;
        }
        /// <summary>
        /// 新しいメモを新規作成 (引数１)
        /// </summary>
        /// <param name="NewFileType">作るファイルの拡張子</param>
        /// <returns>成功したかどうか</returns>
        private bool CreateNewMemo(String NewFileType)
        {
            if (!FileSave)
            {
                DialogResult result = MessageBox.Show(
                  "保存されてませんがよろしいですか？",
                  "確認",
                  MessageBoxButtons.OKCancel,
                  MessageBoxIcon.Question,
                  MessageBoxDefaultButton.Button1
                );
                if (result == DialogResult.Cancel) 
                {
                    return false;
                }
            }
            FileType = NewFileType;
            FilePath = "NewFile";
            FileSave = false;
            String SaveOR = FileSave ? "" : "*";
            Text = "MemoSoft：無題." + NewFileType + SaveOR;

            MemoContents.Text = "";
            return true;
        }
        /// <summary>
        /// ファイルを選択するダイアログを作る（引数１,引数２）
        /// </summary>
        /// <param name="Title">開く　または、保存する役割を選択</param>
        /// <param name="NewFileType">ファイルの拡張子</param>
        private void FileDialogue(String Title,String NewFileType)
        {
            if ("開く" == Title)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "テキストファイル(*." + NewFileType + ")|*." + NewFileType;
                dialog.Title = Title;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    String Contents;
                    Contents = System.IO.File.ReadAllText(dialog.FileName);

                    FileSave = true;
                    TextBoxLoad(FileType, Contents);
                    FileType = NewFileType;
                    FilePath = dialog.FileName;
                    FileSave = true;
                    String[] FileNum = dialog.FileName.Split(Key.Text[0]);
                    String OpenFileName = FileNum[FileNum.Length - 1].Split('.')[0];
                    String SaveOR = FileSave ? "" : "*";
                    Text = "MemoSoft："+OpenFileName+"." + NewFileType + SaveOR;

                }
            }
            else if (Title.Contains("保存"))
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "テキストファイル(*." + NewFileType + ")|*." + NewFileType;
                dialog.Title = Title;

                String Path = FilePath;

                String Contents = MemoContents.Text;
                if (NewFileType == "ms")
                {
                    Contents = MSReplace(Contents, "ms => txt");
                }

                if (Title == "保存" || FilePath == "NewFile")
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        Path = dialog.FileName;
                    }
                }

                FileSave = true;
                
                String[] FileNum = dialog.FileName.Split(Key.Text[0]);
                
                String OpenFileName = FileNum[FileNum.Length - 1].Split('.')[0];
                System.IO.File.WriteAllText(Path, Contents);
                String SaveOR = FileSave ? "" : "*";
                Text = "MemoSoft：" + OpenFileName + "." + NewFileType + SaveOR;
            }
        }
        /// <summary>
        /// テキストボックスの文字の大きさ変更（引数１）
        /// </summary>
        /// <param name="Txtbox">テキストボックス</param>
        /// <returns></returns>
        private int TextSizeUpdate(TextBox Txtbox)
        {
            
            Txtbox.Font = new Font("MS UI Gothic ",TextSize);

            return 0;
        }
        /// <summary>
        /// 字下げの回数を計算（引数１）
        /// </summary>
        /// <param name="Line">その行の文字列</param>
        /// <returns>字下げの回数</returns>
        private int TabCountGet(String Line)
        {
            int Count = 0;
            if (Line.Contains("・"))
            {
                //Count += 1;
                var ContentsList = Line.Split('・');
                var Contents = ContentsList[0];
                Contents += " ";
                Contents = Contents.Replace("  ","S");

                Count = (Contents.Split('S').Length) - 1;
                
            }

            return Count ;
        }
        /// <summary>
        /// テキストボックスの選択している行
        /// </summary>
        /// <param name="textBox1">テキストボックス</param>
        /// <returns>行の場所</returns>
        private int GetLogicalLine(TextBox textBox1)
        {
            var posStart = textBox1.SelectionStart;
            var lineStart = textBox1.Text.Take(posStart).Count(p => p == '\r');
            label1.Text = lineStart.ToString();
            return lineStart;
        }

        void SettingUpdate(Theme theme,KeySetting key)
        {
            
        }

        //###################
        //フォームの関数   ##
        //###################

        private void MemoKeydown(object sender, KeyEventArgs e)
        {
            Point Pos = GetTextBoxScrollPos(MemoContents);

            Ime = MemoContents.ImeMode;

            if (e.KeyCode == Keys.Enter)
            {
                Pos.Y += 1;
                //字下げの処理
                String str2 = MemoContents.Text;
                String[] strList = str2.Split('\r');

                int TabCount = TabCountGet(strList[GetLogicalLine(MemoContents)]);

                string str = "";
                for (int i = 0; i < TabCount; i++)
                {
                    str += "  ";
                }
                if (str != "")
                {
                    str += "・";
                }

                //選択している行を登録
                SelectLine = GetLogicalLine(MemoContents);

                MemoContents.ReadOnly = true; //通常のアクションを遮断する

                strList[SelectLine] += "\r\n" + str; //箇条書きにする
                MemoContents.Text = string.Join("\r", strList);

                //カーソルの位置をリセット

                int Num = 0;
                for (int i = 0; i < SelectLine + 1; i++)
                {
                    
                    Num += strList[i].Length;
                    Num += 1;
                }
                Num -= 1;
                
                MemoContents.SelectionStart = Num;
                MemoContents.SelectionLength = 0;
                MemoContents.Focus();
                MemoContents.ImeMode = Ime;
                //MemoContents.Text = TabCount.ToString();


            }
            else if (e.KeyCode == Keys.Tab)
            {
                String str = MemoContents.Text;
                String[] strList = str.Split('\n');

                int TabCount = TabCountGet(strList[GetLogicalLine(MemoContents)]);

                SelectLine = GetLogicalLine(MemoContents);

                TabCount += 1;

                MemoContents.ReadOnly = true; //通常のアクションを遮断する

                //字下げをする
                String Indent = "";
                for (int i = 0; i < TabCount; i++)
                {
                    Indent += "  ";
                }
                if (Indent != "")
                {
                    Indent += "・";
                }

                String[] Contents;
                if (strList[SelectLine].Contains("・"))
                {
                    Contents = strList[SelectLine].Split('・');
                    strList[SelectLine] = Indent + Contents[1];
                } else if (true)
                {
                    strList[SelectLine] = Indent + strList[SelectLine];
                }    
                MemoContents.Text = string.Join("\n", strList);
                //カーソルの位置をリセット
                int Num = 0;
                for (int i = 0; i < SelectLine + 1; i++)
                {

                    Num += strList[i].Length;
                    Num += 1;
                }
                //Num -= 1;
                MemoContents.SelectionStart = Num;
                MemoContents.SelectionLength = 0;
                MemoContents.Focus();
                MemoContents.ImeMode = Ime;


            }
            else if (e.KeyCode == Keys.Back)
            {
                MemoContents.ReadOnly = false;
                SelectLine = GetLogicalLine(MemoContents);

                String str = MemoContents.Text;
                String[] strList = str.Split('\n');
                String[] Contents;
                if (strList[SelectLine].Contains("・")) 
                {
                    int TabCount = TabCountGet(strList[GetLogicalLine(MemoContents)]);

                    Contents = strList[SelectLine].Split('・');
                    if (Contents[1] == "")
                    {
                        MemoContents.ReadOnly = true;
                        TabCount -= 1;
                        String Indent = "";
                        for (int i = 0; i < TabCount; i++)
                        {
                            Indent += "  ";
                        }
                        if (Indent != "")
                        {
                            Indent += "・";
                        }
                        strList[SelectLine] = Indent;
                        MemoContents.Text = string.Join("\n", strList);

                        //カーソルの位置をリセット
                        
                        int Num = 0;
                        for (int i = 0; i < SelectLine + 1; i++)
                        {

                            Num += strList[i].Length;
                            Num += 1;
                        }
                        Num -= 1;
                        MemoContents.SelectionStart = Num;
                        MemoContents.SelectionLength = 0;
                        MemoContents.Focus();
                        MemoContents.ImeMode = Ime;
                    }
                }
                
            }
            else if (e.KeyCode != Keys.Enter)
            {
                MemoContents.ReadOnly = false;
            }

            
            SetTextBoxScrollPos(MemoContents, Pos);
        }

        private void MemoContents_TextChanged(object sender, EventArgs e)
        {
            FileSave = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Magenta;
            this.TopMost = true;
        }

        private void BoxZoomIn(object sender, EventArgs e)
        {
            TextSize += 2;
            TextSizeUpdate(MemoContents);
            FontSizeInfo.Text = TextSize.ToString() + "pt";

        }

        private void BoxZoomOut(object sender, EventArgs e)
        {
            TextSize -= 2;
            TextSizeUpdate(MemoContents);
            FontSizeInfo.Text = TextSize.ToString()+"pt";

        }

        public void TextBoxLoad(String FileType,String LoadText) 
        {
            /*/
            MessageBox.Show(
              FileType,
              LoadText,
              MessageBoxButtons.OK,
              MessageBoxIcon.Hand
            );
            /*/
            if (FileType == "txt")
            {
                MemoContents.Text = LoadText;
            }
            else if (FileType == "ms")
            {
                MemoContents.Text = LoadText;
            }
        }

        private void MemoRibbon_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void File_Open_txtClick(object sender, EventArgs e)
        {
            FileDialogue("開く","txt");
        }

        private void File_Create_txtClick(object sender, EventArgs e)
        {
            CreateNewMemo("txt");
        }


        private void SettingClick(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.Show();
        }

        private void File_Save_NameSaveClick(object sender, EventArgs e)
        {
            FileDialogue("保存", FileType);
        }

        private void File_Save_StdSaveClick(object sender, EventArgs e)
        {
            FileDialogue("保存1", FileType);
        }

        private void WordWrapChange(object sender, EventArgs e)
        {
            MemoContents.WordWrap = WordWrap.Checked;
        }

        private void ChangeIme(object sender, EventArgs e)
        {
            //MemoContents.ImeMode = 
        }
    }
}
