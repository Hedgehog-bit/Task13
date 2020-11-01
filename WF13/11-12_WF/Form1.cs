using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_12_WF
{
	public partial class Form1 : Form
	{
		Matrix matrix = new Matrix(3, 3);
		Matrix matrix2 = new Matrix(3, 3);
		public Form1()
		{
			InitializeComponent();
			matrix.random_array();
			matrix2.random_array();
			matrix.PrintMatrix(matrix1_table);
			matrix2.PrintMatrix(matrix2_table);
			if (matrix2)
				condition_label.Text = "все строки отсортированны в порядке возрастания";
			else
				condition_label.Text = "строки не отсортированны в порядке возрастания";

		}

		private void inc_button_Click(object sender, EventArgs e)
		{
			matrix++.PrintMatrix(matrix1_table);
		}

		private void dec_button_Click(object sender, EventArgs e)
		{
			matrix2--.PrintMatrix(matrix2_table);
		}

		private void prod_button_Click(object sender, EventArgs e)
		{
			matrix2 = matrix * matrix2;
			matrix2.PrintMatrix(rezult_table);
		}

		private void sort_button_Click(object sender, EventArgs e)
		{
			matrix.SortMatrix();
			matrix.PrintMatrix(matrix1_table);
		}
	}
}
