using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fusen
{
    public partial class FormFusen : Form
    {
        private int mouseX;     //マウスの横の位置
        private int mouseY;     //マウスの縦の位置


        public FormFusen()
        {
            InitializeComponent();
        }

        private void TextFusenMemo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();       //ESCボタンでアプリ終了
            }
        }

        private void TextFusenMemo_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.mouseX = e.X;      //左クリックした場合、マウスの位置を記憶
                this.mouseY = e.Y;
            }
        }

        private void TextFusenMemo_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - mouseX;      //マウスを移動させた場合、フォームの位置を更新
                this.Top += e.Y - mouseY;
            }            
        }

        private void TextFusenMemo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            colorDialogFusen.ShowDialog();      //ダブルクリックした時、色の設定ダイアログを表示
            textFusenMemo.BackColor = colorDialogFusen.Color;       //背景を選んだ色に変更
        }
    }
}
