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
	public partial class Level5 : Form
	{
		public Level5()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (label1.Text == "")
			{
				label1.Text = "S";
			}
			else if (label2.Text == "")
			{
				label2.Text = "S";
			}
			else if (label3.Text == "")
			{
				label3.Text = "S";
			}
			else if (label4.Text == "")
			{
				label4.Text = "S";
			}
			else
			{
				label5.Text = "S";
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
			label5.Text = "";
		}

		private void button12_Click(object sender, EventArgs e)
		{
		if (label1.Text == "T" && label2.Text == "R" && label3.Text == "A" && label4.Text == "S" && label5.Text == "H")
			{
				MessageBox.Show("CONGRATULATION YOU WON !  Your Final Score is 50");
				this.Close();
			}
			else
			{
				MessageBox.Show("You Lost ! GAME OVER");
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
			else if (label4.Text == "")
			{
				label4.Text = "O";
			}
			else
			{
				label5.Text = "O";
			}
		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			if (label1.Text == "")
			{
				label1.Text = "I";
			}
			else if (label2.Text == "")
			{
				label2.Text = "I";
			}
			else if (label3.Text == "")
			{
				label3.Text = "I";
			}
			else if (label4.Text == "")
			{
				label4.Text = "I";
			}
			else
			{
				label5.Text = "I";
			}
		}

		private void button4_Click_1(object sender, EventArgs e)
		{
			if (label1.Text == "")
			{
				label1.Text = "H";
			}
			else if (label2.Text == "")
			{
				label2.Text = "H";
			}
			else if (label3.Text == "")
			{
				label3.Text = "H";
			}
			else if (label4.Text == "")
			{
				label4.Text = "H";
			}
			else
			{
				label5.Text = "H";
			}
		}

		private void button5_Click_1(object sender, EventArgs e)
		{
			if (label1.Text == "")
			{
				label1.Text = "A";
			}
			else if (label2.Text == "")
			{
				label2.Text = "A";
			}
			else if (label3.Text == "")
			{
				label3.Text = "A";
			}
			else if (label4.Text == "")
			{
				label4.Text = "A";
			}
			else
			{
				label5.Text = "A";
			}
		}

		private void button6_Click_1(object sender, EventArgs e)
		{
			if (label1.Text == "")
			{
				label1.Text = "Q";
			}
			else if (label2.Text == "")
			{
				label2.Text = "Q";
			}
			else if (label3.Text == "")
			{
				label3.Text = "Q";
			}
			else if (label4.Text == "")
			{
				label4.Text = "Q";
			}
			else
			{
				label5.Text = "Q";
			}
		}

		private void button7_Click_1(object sender, EventArgs e)
		{
			if (label1.Text == "")
			{
				label1.Text = "R";
			}
			else if (label2.Text == "")
			{
				label2.Text = "R";
			}
			else if (label3.Text == "")
			{
				label3.Text = "R";
			}
			else if (label4.Text == "")
			{
				label4.Text = "R";
			}
			else
			{
				label5.Text = "R";
			}
		}

		private void button8_Click_1(object sender, EventArgs e)
		{
			if (label1.Text == "")
			{
				label1.Text = "N";
			}
			else if (label2.Text == "")
			{
				label2.Text = "N";
			}
			else if (label3.Text == "")
			{
				label3.Text = "N";
			}
			else if (label4.Text == "")
			{
				label4.Text = "N";
			}
			else
			{
				label5.Text = "N";
			}
		}

		private void button10_Click_1(object sender, EventArgs e)
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
			else if (label4.Text == "")
			{
				label4.Text = "C";
			}
			else
			{
				label5.Text = "C";
			}
		}

		private void button9_Click_1(object sender, EventArgs e)
		{
			if (label1.Text == "")
			{
				label1.Text = "T";
			}
			else if (label2.Text == "")
			{
				label2.Text = "T";
			}
			else if (label3.Text == "")
			{
				label3.Text = "T";
			}
			else if (label4.Text == "")
			{
				label4.Text = "T";
			}
			else
			{
				label5.Text = "T";
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
