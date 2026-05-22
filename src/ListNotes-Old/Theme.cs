using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memosoft
{
    internal class Theme
    {
        /// <summary>
        /// プログラムが識別する名前
        /// </summary>
        private string themenName;

        /// <summary>
        /// フォームのテーマ
        /// </summary>
        private Hashtable Contents;

        /// <summary>
        /// formテーマを設定する
        /// </summary>
        /// <param name="name">テーマの名前</param>
        /// <param name="BackColor">バックのカラー</param>
        /// <param name="UIFontColor">UIのフォントカラー</param>
        /// <param name="UIButtonColor">UIのボタンのカラー</param>
        /// <param name="UIButtonFontColor">UIのボタンのフォントカラー</param>
        /// <param name="TxtboxBackColor">テキストボックスのバックカラー</param>
        /// <param name="TxtboxFontColor">テキストボックスのフォントカラー</param>
        /// <param name="FontSizeInfoBackColor">フォントサイズのバックカラー</param>
        /// <param name="FontSizeInfoFontColor">フォントサイズのフォントカラー</param>
        public void SetTheme(
            string name,
            Color BackColor,
            Color UIFontColor,
            Color UIButtonColor,
            Color UIButtonFontColor,
            Color TxtboxBackColor,
            Color TxtboxFontColor,
            Color FontSizeInfoBackColor,
            Color FontSizeInfoFontColor
        )
        {
            themenName = name;

            Contents = new Hashtable()
            {
                //バックカラー
                ["BackColor_R"] = BackColor.R.ToString(),
                ["BackColor_G"] = BackColor.G.ToString(),
                ["BackColor_B"] = BackColor.B.ToString(),
                
                //UIフォントカラー
                ["UIFontColor_R"] = UIFontColor.R.ToString(),
                ["UIFontColor_G"] = UIFontColor.G.ToString(),
                ["UIFontColor_B"] = UIFontColor.B.ToString(),

                //UIボタンカラー
                ["UIButtonColor_R"] = UIButtonColor.R.ToString(),
                ["UIButtonColor_G"] = UIButtonColor.G.ToString(),
                ["UIButtonColor_B"] = UIButtonColor.B.ToString(),

                //UIボタンフォントカラー
                ["UIButtonFontColor_R"] = UIButtonFontColor.R.ToString(),
                ["UIButtonFontColor_G"] = UIButtonFontColor.G.ToString(),
                ["UIButtonFontColor_B"] = UIButtonFontColor.B.ToString(),

                //テキストボックスバックカラー
                ["TxtboxBackColor_R"] = TxtboxBackColor.R.ToString(),
                ["TxtboxBackColor_G"] = TxtboxBackColor.G.ToString(),
                ["TxtboxBackColor_B"] = TxtboxBackColor.B.ToString(),
                
                //テキストボックスフォントカラー
                ["TxtboxFontColor_R"] = TxtboxFontColor.R.ToString(),
                ["TxtboxFontColor_G"] = TxtboxFontColor.G.ToString(),
                ["TxtboxFontColor_B"] = TxtboxBackColor.B.ToString(),

                //テキストサイズバックカラー
                ["FontSizeInfoBackColor_R"] = FontSizeInfoBackColor.R.ToString(),
                ["FontSizeInfoBackColor_G"] = FontSizeInfoBackColor.G.ToString(),
                ["FontSizeInfoBackColor_B"] = FontSizeInfoBackColor.B.ToString(),

                //テキストサイズフォントカラー
                ["FontSizeInfoFontColor_R"] = FontSizeInfoFontColor.R.ToString(),
                ["FontSizeInfoFontColor_G"] = FontSizeInfoFontColor.G.ToString(),
                ["FontSizeInfoBackColor_B"] = FontSizeInfoBackColor.B.ToString()

            };
        }
    }
}
