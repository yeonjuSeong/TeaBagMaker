using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
        MessageBoxButtons mbb; // 메시지 버튼 옵션 설정
        MessageBoxIcon mbi; // 메시지 버튼 아이콘 설정
        String[] SList = new string[] { "홍차(2분)", "녹차(3분)", "루이보스차(5분)", "국화차(2분)" };
        String orgStr = ""; // 선택 결과 저장

        private void Tea_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox tea = (ComboBox)sender;
            textBox.Text = (string)tea.SelectedItem;
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0; i< SList.Length;i++)
            {
                this.tea.Items.Add(SList[i]);
            }
            // this.orgStr= // 여기서 메시지 박스로
        }


        private void Label1_Click(object sender, EventArgs e)
        {

        }

    }
}
