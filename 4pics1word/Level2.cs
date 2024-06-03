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
	public partial class Level2 : Form
	{
		public Level2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			//letters used
			if (label1.Text == "")
			{
				label1.Text = "A";


			}
			else if (label2.Text == "")
			{
				label2.Text = "A";

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

		private void button2_Click(object sender, EventArgs e)
		{
			if (label1.Text == "")
			{
				label1.Text = "O";


			}
			else if (label2.Text == "")
			{
				label2.Text = "O";

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

		private void button3_Click(object sender, EventArgs e)
		{
			if (label1.Text == "")
			{
				label1.Text = "I";


			}
			else if (label2.Text == "")
			{
				label2.Text = "I";

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

		private void button4_Click(object sender, EventArgs e)
		{
			if (label1.Text == "")
			{
				label1.Text = "E";


			}
			else if (label2.Text == "")
			{
				label2.Text = "E";

			}
			else if (label4.Text == "")
			{
				label4.Text = "E";

			}
			else
			{
				label5.Text = "E";


			}

		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (label1.Text == "")
			{
				label1.Text = "V";


			}
			else if (label2.Text == "")
			{
				label2.Text = "V";

			}
			else if (label4.Text == "")
			{
				label4.Text = "V";

			}
			else
			{
				label5.Text = "V";


			}

		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (label1.Text == "")
			{
				label1.Text = "L";


			}
			else if (label2.Text == "")
			{
				label2.Text = "L";

			}
			else if (label4.Text == "")
			{
				label4.Text = "L";

			}
			else
			{
				label5.Text = "L";


			}

		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (label1.Text == "")
			{
				label1.Text = "H";


			}
			else if (label2.Text == "")
			{
				label2.Text = "H";

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

		private void button8_Click(object sender, EventArgs e)
		{
			if (label1.Text == "")
			{
				label1.Text = "D";


			}
			else if (label2.Text == "")
			{
				label2.Text = "D";

			}
			else if (label4.Text == "")
			{
				label4.Text = "D";

			}
			else
			{
				label5.Text = "D";


			}

		}

		private void button9_Click(object sender, EventArgs e)
		{
			if (label1.Text == "")
			{
				label1.Text = "C";


			}
			else if (label2.Text == "")
			{
				label2.Text = "C";

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

		private void button10_Click(object sender, EventArgs e)
		{
			if (label1.Text == "")
			{
				label1.Text = "Y";


			}
			else if (label2.Text == "")
			{
				label2.Text = "Y";

			}
			else if (label4.Text == "")
			{
				label4.Text = "Y";

			}
			else
			{
				label5.Text = "Y";


			}

		}

		private void button11_Click(object sender, EventArgs e)
		{
			
			label1.Text = "";
			label2.Text = "";
			label4.Text = "";
			label5.Text = "";
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
	
		private void button12_Click_1(object sender, EventArgs e)
		{
			if (label1.Text == "H" && label2.Text == "E" && label3.Text == "A" && label4.Text == "V" && label5.Text == "Y")
			{
				//score increases by 10 for each correct level, totaling to 60
				MessageBox.Show("Your score is 20");
				MessageBox.Show("Press OK for next level");
				Level3 f3 = new Level3();
				f3.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("You Lose ! Try Again ");
			}
		}
	}
}
