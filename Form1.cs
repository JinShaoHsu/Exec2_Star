using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			label2.Text =string.Empty;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int? rows = getrows();
			
			if(rows.HasValue == false)
			{
				MessageBox.Show("請輸入數列");
				return;
			}
			if(rows.Value <= 0)
			{
				MessageBox.Show("列數必須大於0");
				return ;
			}
			string stars = Generatestars(rows.Value);

			textBox2.Text = stars;
			label2.Text = stars;
		}

		private string Generatestars(int rows)
		{
			string result =string.Empty;
			for(int i = 1; i <=rows ; i++)
			{
				result += new string('*', i) + "\r\n";
			}
			return result;
		}

		private string Generatestars1(int rows)
		{
			string result = string.Empty;
			for (int i = 1; i <= rows; i++)
			{
				result += new string(' ', rows-i)+new string('*', i) + "\r\n";
			}
			return result;
		}
		private string Generatestars2(int rows)
		{
			string result = string.Empty;
			for (int i = 1; i <=rows; i++)
			{
				result += new string(' ', (rows - i)*2)+new string('*', (i*2)-1) + "\r\n";
			}
			return result;
		}

		private int? getrows()
		{
			string input =textBox1.Text;
			bool isint = int.TryParse(input, out int rows);
			if (isint)
			{
				return rows;
			}
			else
			{
				return null;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int? rows = getrows();

			if (rows.HasValue == false)
			{
				MessageBox.Show("請輸入數列");
				return;
			}
			if (rows.Value <= 0)
			{
				MessageBox.Show("列數必須大於0");
				return;
			}
			string stars = Generatestars1(rows.Value);

			textBox2.Text = stars;
			label2.Text = stars;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int? rows = getrows();

			if (rows.HasValue == false)
			{
				MessageBox.Show("請輸入數列");
				return;
			}
			if (rows.Value <= 0)
			{
				MessageBox.Show("列數必須大於0");
				return;
			}
			string stars = Generatestars2(rows.Value);

			textBox2.Text = stars;
			label2.Text = stars;
		}
	}
}
