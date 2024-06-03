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
	// Name: Jack Moore    Year: 12
	// Assesment task 2    2024
	// Declaration:
	// I herbey certify that this assignment is entirely my own work, except where i have 'acknowledged all material and sources used in the preparation of the assignment. I certify 'that all typing / keystokes have been done by me.
	// I also certify that the material contained in this assignment has not been previously submitted by me for assessment in any formal course of study, and that i have not copied 'part of whole', or otherwise plagiarised the work of other students and/or persons.
	// This program is designed as a free user friendly, interactive and recreational product.
{
	public partial class Level1 : Form
	{
		public Level1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
		//Creating the timer
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
				// if the timer runs out the level closes (change to skip to next level?)
				label6.Text = "SORRY! Times Up";

				this.Close();

			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//Letters used for Level1
			if (label2.Text == "")
			{
				label2.Text = "S";


			}
		    else if (label3.Text == "")
			{
				label3.Text = "S";

			}
		    else 
			{
				label4.Text = "S";


			}
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (label2.Text == "")
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

		private void button3_Click(object sender, EventArgs e)
		{
			if (label2.Text == "")
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

		private void button4_Click(object sender, EventArgs e)
		{
			if (label2.Text == "")
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

		private void button9_Click(object sender, EventArgs e)
		{
			if (label2.Text == "")
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

		private void button5_Click(object sender, EventArgs e)
		{
			if (label2.Text == "")
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

		private void button6_Click(object sender, EventArgs e)
		{
			if (label2.Text == "")
			{
				label2.Text = "T";


			}
			else if (label3.Text == "")
			{
				label3.Text = "T";

			}
			else
			{
				label4.Text = "T";


			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (label2.Text == "")
			{
				label2.Text = "A";


			}
			else if (label3.Text == "")
			{
				label3.Text = "A";

			}
			else
			{
				label4.Text = "A";


			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			if (label2.Text == "")
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

		private void button10_Click(object sender, EventArgs e)
		{
			if (label2.Text == "")
			{
				label2.Text = "R";


			}
			else if (label3.Text == "")
			{
				label3.Text = "R";

			}
			else
			{
				label4.Text = "R";


			}
		}

		private void button11_Click(object sender, EventArgs e)
		{
			
			label2.Text = "";
			label3.Text = "";
			label4.Text = "";
		}

		private void button12_Click(object sender, EventArgs e)
		{ // determining whether the user has selected the correct letters for the pictures
			if (label1.Text == "C" && label2.Text == "O" && label3.Text == "L" && label4.Text == "D")
			{
				// score is increased by 10 per correct level (could think about scre being related to howver much time is left?)
				MessageBox.Show("Your score is 10");
				MessageBox.Show("Press OK for next level");
				Level2 f2 = new Level2();
				f2.Show();
				this.Hide();
			}
			else
			{ // if user does not select the correct letters, unlimited attempts until the timer runs out
				MessageBox.Show("You Lose ! Try Again ");
			}
				
		}
	}
}
