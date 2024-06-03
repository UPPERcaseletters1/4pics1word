using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4pics1word
{
	public partial class Level3 : Form
	{
		public Level3()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (label1.Text == "")
			{
				label1.Text = "M";
			}
			else if (label2.Text == "")
			{
				label2.Text = "M";
			}
			else if (label3.Text == "")
			{
				label3.Text = "M";
			}
			else
			{
				label4.Text = "M";
			}
		}
			private void button2_Click(object sender, EventArgs e)
		{
			
		}
		private void button3_Click(object sender, EventArgs e)
		{
			
		}
		private void button4_Click(object sender, EventArgs e)
		{
			
		}
		private void button5_Click(object sender, EventArgs e)
		{
			
		}
		private void button6_Click(object sender, EventArgs e)
		{
			
		}
		private void button7_Click(object sender, EventArgs e)
		{
			
		}
		private void button8_Click(object sender, EventArgs e)
		{
			
		}
		private void button9_Click(object sender, EventArgs e)
		{
			
		}
		private void button10_Click(object sender, EventArgs e)
		{
			
		}

		private void button11_Click(object sender, EventArgs e)
		{
			label1.Text = "";
			label2.Text = "";
			label3.Text = "";
			label4.Text = "";
		}

		private void button12_Click(object sender, EventArgs e)
		{
			if (label1.Text == "J" && label2.Text == "U" && label3.Text == "M" && label4.Text == "P")
			{
				MessageBox.Show("Your score is 30");
				MessageBox.Show("Press OK for next level");
				Level4 f4 = new Level4();
				f4.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("You Lose ! Try Again ");
			}
		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			if (label1.Text == "")
			{
				label1.Text = "P";
			}
			else if (label2.Text == "")
			{
				label2.Text = "P";
			}
			else if (label3.Text == "")
			{
				label3.Text = "P";
			}
			else
			{
				label4.Text = "P";
			}
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			if (label1.Text == "")
			{
				label1.Text = "O";
			}
			else if (label2.Text == "")
			{
				label2.Text = "O";
			}
			else if (label3.Text == "")
			{
				label3.Text = "O";
			}
			else
			{
				label4.Text = "O";
			}
		}

		private void button4_Click_1(object sender, EventArgs e)
		{
			if (label1.Text == "")
			{
				label1.Text = "E";
			}
			else if (label2.Text == "")
			{
				label2.Text = "E";
			}
			else if (label3.Text == "")
			{
				label3.Text = "E";
			}
			else
			{
				label4.Text = "E";
			}
		}

		private void button5_Click_1(object sender, EventArgs e)
		{
			if (label1.Text == "")
			{
				label1.Text = "L";
			}
			else if (label2.Text == "")
			{
				label2.Text = "L";
			}
			else if (label3.Text == "")
			{
				label3.Text = "L";
			}
			else
			{
				label4.Text = "L";
			}
		}

		private void button6_Click_1(object sender, EventArgs e)
		{
			if (label1.Text == "")
			{
				label1.Text = "U";
			}
			else if (label2.Text == "")
			{
				label2.Text = "U";
			}
			else if (label3.Text == "")
			{
				label3.Text = "U";
			}
			else
			{
				label4.Text = "U";
			}
		}

		private void button7_Click_1(object sender, EventArgs e)
		{
			if (label1.Text == "")
			{
				label1.Text = "D";
			}
			else if (label2.Text == "")
			{
				label2.Text = "D";
			}
			else if (label3.Text == "")
			{
				label3.Text = "D";
			}
			else
			{
				label4.Text = "D";
			}
		}

		private void button8_Click_1(object sender, EventArgs e)
		{
			if (label1.Text == "")
			{
				label1.Text = "J";
			}
			else if (label2.Text == "")
			{
				label2.Text = "J";
			}
			else if (label3.Text == "")
			{
				label3.Text = "J";
			}
			else
			{
				label4.Text = "J";
			}
		}

		private void button9_Click_1(object sender, EventArgs e)
		{
			if (label1.Text == "")
			{
				label1.Text = "C";
			}
			else if (label2.Text == "")
			{
				label2.Text = "C";
			}
			else if (label3.Text == "")
			{
				label3.Text = "C";
			}
			else
			{
				label4.Text = "C";
			}
		}

		private void button10_Click_1(object sender, EventArgs e)
		{
			if (label1.Text == "")
			{
				label1.Text = "Z";
			}
			else if (label2.Text == "")
			{
				label2.Text = "Z";
			}
			else if (label3.Text == "")
			{
				label3.Text = "Z";
			}
			else
			{
				label4.Text = "Z";
			}
		}

		int timeLeft = 120;
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (timeLeft > 0)
			{
				timeLeft = timeLeft - 1;
				label6.Text = timeLeft + " sec ";
			}
			else
			{
				label6.Text = "SORRY! Times Up";

				this.Close();

			}
		}
	}
}
