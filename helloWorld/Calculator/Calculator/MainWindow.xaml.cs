using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private long num01 = 0;
		private long num02 = 0;
		string operation = "";

		public MainWindow()
		{
			InitializeComponent();
		}

		private void Btn1_Click(object sender, RoutedEventArgs e)
		{
			if (operation == "")
			{
				num01 = (num01 * 10) + 1;
				TxtDisplay.Text = num01.ToString();
			}
			else
			{
				num02 = (num02 * 10) + 1;
				TxtDisplay.Text = num02.ToString();
			}
			

		}

		private void Btn2_Click(object sender, RoutedEventArgs e)
		{
			if (operation == "")
			{
				num01 = (num01 * 10) + 2;
				TxtDisplay.Text = num01.ToString();
			}
			else
			{
				num02 = (num02 * 10) + 2;
				TxtDisplay.Text = num02.ToString();
			}
		}

		private void Btn3_Click(object sender, RoutedEventArgs e)
		{
			if (operation == "")
			{
				num01 = (num01 * 10) + 3;
				TxtDisplay.Text = num01.ToString();
			}
			else
			{
				num02 = (num02 * 10) + 3;
				TxtDisplay.Text = num02.ToString();
			}
		}

		private void Btn4_Click(object sender, RoutedEventArgs e)
		{
			if (operation == "")
			{
				num01 = (num01 * 10) + 4;
				TxtDisplay.Text = num01.ToString();
			}
			else
			{
				num02 = (num02 * 10) + 4;
				TxtDisplay.Text = num02.ToString();
			}
		}

		private void Btn5_Click(object sender, RoutedEventArgs e)
		{
			if (operation == "")
			{
				num01 = (num01 * 10) + 5;
				TxtDisplay.Text = num01.ToString();
			}
			else
			{
				num02 = (num02 * 10) + 5;
				TxtDisplay.Text = num02.ToString();
			}
		}

		private void Btn6_Click(object sender, RoutedEventArgs e)
		{
			if (operation == "")
			{
				num01 = (num01 * 10) + 6;
				TxtDisplay.Text = num01.ToString();
			}
			else
			{
				num02 = (num02 * 10) + 6;
				TxtDisplay.Text = num02.ToString();
			}
		}

		private void Btn7_Click(object sender, RoutedEventArgs e)
		{
			if (operation == "")
			{
				num01 = (num01 * 10) + 7;
				TxtDisplay.Text = num01.ToString();
			}
			else
			{
				num02 = (num02 * 10) + 7;
				TxtDisplay.Text = num02.ToString();
			}
		}

		private void Btn8_Click(object sender, RoutedEventArgs e)
		{
			if (operation == "")
			{
				num01 = (num01 * 10) + 8;
				TxtDisplay.Text = num01.ToString();
			}
			else
			{
				num02 = (num02 * 10) + 8;
				TxtDisplay.Text = num02.ToString();
			}
		}

		private void Btn9_Click(object sender, RoutedEventArgs e)
		{
			if (operation == "")
			{
				num01 = (num01 * 10) + 9;
				TxtDisplay.Text = num01.ToString();
			}
			else
			{
				num02 = (num02 * 10) + 9;
				TxtDisplay.Text = num02.ToString();
			}
		}

		private void Btn0_Click(object sender, RoutedEventArgs e)
		{
			if (operation == "")
			{
				num01 = (num01 * 10) + 0;
				TxtDisplay.Text = num01.ToString();
			}
			else
			{
				num02 = (num02 * 10) + 0;
				TxtDisplay.Text = num02.ToString();
			}
		}

		private void BtnPlus_Click(object sender, RoutedEventArgs e)
		{
			operation = "+";
			TxtDisplay.Text = "0";
		}

		private void BtnMinus_Click(object sender, RoutedEventArgs e)
		{
			operation = "-";
			TxtDisplay.Text = "0";
		}

		private void BtnTimes_Click(object sender, RoutedEventArgs e)
		{
			operation = "*";
			TxtDisplay.Text = "0";
		}

		private void BtnDivide_Click(object sender, RoutedEventArgs e)
		{
			operation = "/";
			TxtDisplay.Text = "0";
		}

		private void BtnEquel_Click(object sender, RoutedEventArgs e)
		{
			switch (operation)
			{
				case "+":
					TxtDisplay.Text = (num01 + num02).ToString();
					break;
				case "-":
					TxtDisplay.Text = (num01 - num02).ToString();
					break;
				case "*":
					TxtDisplay.Text = (num01 * num02).ToString();
					break;
				case "/":
					TxtDisplay.Text = (num01 / num02).ToString();
					break;
			}
		}

		private void BtnClearEntry_Click(object sender, RoutedEventArgs e)
		{
			if (operation == "")
			{
				num01 = 0;

			}
			else
			{
				num02 = 0; 
			}

			TxtDisplay.Text = "0";
		}

		private void BtnClear_Click(object sender, RoutedEventArgs e)
		{
			num01 = 0;
			num02 = 0;
			operation = "";
			TxtDisplay.Text = "0";
		}

		private void BtnBackSpace_Click(object sender, RoutedEventArgs e)
		{
			if (operation == "")
			{
				num01 = (num01 / 10) + 0;
				TxtDisplay.Text = num01.ToString();
			}
			else
			{
				num02 = (num02 / 10) + 0;
				TxtDisplay.Text = num02.ToString();
			}

		}

		private void BtnPlusMinus_Click(object sender, RoutedEventArgs e)
		{
			if (operation == "")
			{
				num01 *= -1;
				TxtDisplay.Text = num01.ToString();
			}
			else
			{
				num02 *= -1;
				TxtDisplay.Text = num02.ToString();
			}
		}
	}
}
