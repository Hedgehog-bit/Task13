using System;
using System.Windows.Forms;

namespace _11_12_WF
{
	public class Matrix
	{
		private double[][] DoubleArray = null;
		private int n = 0, m = 0;

		public Matrix(int rows, int columns)
		{
			n = rows; m = columns;
			DoubleArray = new double[n][];
			for (int i = 0; i < n; i++)
				DoubleArray[i] = new double[m];
		}
		public int ElementCount
		{
			get
			{
				return n * m;
			}
		}
		public double ScalarMultiply
		{
			set
			{
				for (int i = 0; i < n; i++)
				{
					for (int j = 0; j < m; j++)
					{
						DoubleArray[i][j] = DoubleArray[i][j] + value;
					}
				}
			}
		}
		public void random_array()
		{
			Random rand = new Random();
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					DoubleArray[i][j] = rand.Next(-10, 10);
				}
			}
		}
		public void EnterElements()
		{
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					Console.Write("Введите элемент [{0}][{1}] :  ", i, j);
					DoubleArray[i][j] = Convert.ToDouble(Console.ReadLine());
				}
			}
		}
		public void SortMatrix()
		{
			for (int r = 0; r < n; r++)
			{
				for (int i = 0; i < m; i++)
				{
					for (int j = 0; j < m - 1; j++)
					{
						if (DoubleArray[r][j] < DoubleArray[r][j + 1])
						{
							double temp = DoubleArray[r][j];
							DoubleArray[r][j] = DoubleArray[r][j + 1];
							DoubleArray[r][j + 1] = temp;
						}
					}
				}
			}
		}
		public void PrintMatrix(DataGridView tabel)
		{
			tabel.RowCount = n;
			tabel.ColumnCount = m;
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					tabel.Columns[j].Width = 30;
					tabel.Rows[i].Cells[j].Value = DoubleArray[i][j];
				}
			}
		}

		// t 12

		public double this[int N, int M]
		{
			get
			{
				if (N >= n || M >= m)
					throw new Exception("Выход за пределы массива");
				return DoubleArray[N][M];
			}
			set
			{
				if (N >= n || M >= m)
					throw new Exception("Выход за пределы массива");
				DoubleArray[N][M] = value;
			}
		}
		public static Matrix operator ++(Matrix matrix)
		{
			for (int i = 0; i < matrix.n; i++)
				for (int j = 0; j < matrix.m; j++)
					matrix[i, j]++;
			return matrix;
		}
		public static Matrix operator --(Matrix matrix)
		{
			for (int i = 0; i < matrix.n; i++)
				for (int j = 0; j < matrix.m; j++)
					matrix[i, j]--;
			return matrix;
		}
		public static bool operator true(Matrix matrix)
		{
			bool flag = true;
			for (int i = 0; i < matrix.n; i++)
			{
				for (int j = 0; j < matrix.m - 1; j++)
				{
					if (matrix[i, j] > matrix[i, j + 1])
					{
						flag = false;
						break;
					}
					if (!flag) break;
				}
			}
			if (flag) return true;
			else return false;
		}
		public static bool operator false(Matrix matrix)
		{
			bool flag = true;
			for (int i = 0; i < matrix.n; i++)
			{
				for (int j = 0; j < matrix.m - 1; j++)
				{
					if (matrix[i, j] > matrix[i, j + 1])
					{
						flag = false;
						break;
					}
					if (!flag) break;
				}
			}
			if (flag) return true;
			else return false;
		}
		public static Matrix operator *(Matrix arr1, Matrix arr2)
		{
			if (arr1.n == arr2.n && arr1.m == arr2.m)
			{
				Matrix rez = new Matrix(arr1.n, arr1.m);
				for (int i = 0; i < rez.n; i++)
					for (int j = 0; j < rez.m; j++)
					{
						rez[i, j] = arr1[i, j] * arr2[i, j];
					}
				return rez;
			}
			else
			{
				throw new Exception("Массивы имеют разные размеры");
				return null;
			}
		}
		public double[,] ToArray()
		{
			double[,] rez = new double[n, m];
			for (int i = 0; i < n; i++)
				for (int j = 0; j < m; j++)
				{
					rez[i, j] = this[i, j];
				}
			return rez;
		}
		public Matrix ToMatrix(double[,] array)
		{
			Matrix matrix = new Matrix(array.GetLength(0), array.GetLength(1));
			for (int i = 0; i < matrix.n; i++)
				for (int j = 0; j < matrix.m; j++)
				{
					matrix[i, j] = array[i, j];
				}
			return matrix;
		}
	}
}
