using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(50);

            MessageBox.Show(list.Count.ToString());//lengthのリストバージョン
            MessageBox.Show(list[2].ToString());
            list.Remove(20); //リストから引数の値が消される
            list.RemoveAt(0); //リストから引数の配列番号の値が消される
            list.Clear(); //リストすべてが消える

        }
    }
}
