using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double[,] A = ParseMatrix(txtMatrizEntrada.Text);
                var (Q, R) = GramSchmidt(A);

                txtMatrizQ.Text = MatrixToString(Q);
                txtMatrizR.Text = MatrixToString(R);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private static (double[,], double[,]) GramSchmidt(double[,] A)
        {
            int m = A.GetLength(0);
            int n = A.GetLength(1);
            double[,] Q = new double[m, n];
            double[,] R = new double[n, n];

            for (int j = 0; j < n; j++)
            {
                double[] v = new double[m];
                for (int i = 0; i < m; i++)
                    v[i] = A[i, j];

                for (int k = 0; k < j; k++)
                {
                    double dot = 0.0;
                    for (int i = 0; i < m; i++)
                        dot += Q[i, k] * A[i, j];

                    R[k, j] = dot;
                    for (int i = 0; i < m; i++)
                        v[i] -= dot * Q[i, k];
                }

                double norm = Math.Sqrt(DotProduct(v, v));
                R[j, j] = norm;

                if (norm == 0)
                    throw new Exception("La matriz contiene columnas linealmente dependientes.");

                for (int i = 0; i < m; i++)
                    Q[i, j] = v[i] / norm;
            }

            return (Q, R);
        }

        private static double DotProduct(double[] v1, double[] v2)
        {
            double sum = 0;
            for (int i = 0; i < v1.Length; i++)
                sum += v1[i] * v2[i];
            return sum;
        }

        private static double[,] ParseMatrix(string input)
        {
            var rows = input.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            int rowCount = rows.Length;
            int colCount = rows[0].Split(' ').Length;
            double[,] matrix = new double[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                var values = rows[i].Split(' ').Select(double.Parse).ToArray();
                if (values.Length != colCount)
                    throw new Exception("Todas las filas deben tener el mismo número de columnas.");

                for (int j = 0; j < colCount; j++)
                    matrix[i, j] = values[j];
            }

            return matrix;
        }

        private static string MatrixToString(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            string result = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    result += $"{matrix[i, j]:F4} ";
                result += "\r\n";
            }

            return result;
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            try
            {
                double[,] A = ParseMatrix(txtMatrizEntrada.Text);
                var (Q, R) = GramSchmidt(A);

                txtMatrizQ.Text = MatrixToString(Q);
                txtMatrizR.Text = MatrixToString(R);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtMatrizQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatrizR_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatrizEntrada_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMatrizEntrada.Clear();
            txtMatrizQ.Clear();
            txtMatrizR.Clear();
        }
    }
}
