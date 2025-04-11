using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        // Variables para almacenar las matrices
        private double[,] matrizA;
        private double[,] matrizB;
        private int filasA, columnasA, filasB, columnasB;


        /*  // Controles principales para la interfaz
          private TextBox txtFilasA, txtColumnasA, txtFilasB, txtColumnasB;
          private Panel panelMatrizA, panelMatrizB, panelResultado;
          private TextBox txtResultado1;
        */
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;

        }
        // Botones para Matriz A
        private void btnCreateA_Click(object sender, EventArgs e)
        {
            // Validar que haya datos en los campos
            if (string.IsNullOrEmpty(txtFilasMatrizA.Text) || string.IsNullOrEmpty(txtColumnasMatrizA.Text))
            {
                MessageBox.Show("Ingrese dimensiones válidas para la matriz A");
                return;
            }

            // Obtener las dimensiones
            filasA = int.Parse(txtFilasMatrizA.Text);
            columnasA = int.Parse(txtColumnasMatrizA.Text);

            // Validar dimensiones positivas
            if (filasA <= 0 || columnasA <= 0)
            {
                MessageBox.Show("Las dimensiones deben ser mayores a cero");
                return;
            }

            // Crear la matriz
            matrizA = new double[filasA, columnasA];

            // Limpiar el panel de entrada
           // Panel panelInputMatrizA = (Panel)panMatrizA.Controls[7]; // El panel de entrada es el 6to control
            panMatrizA.Controls.Clear();

            // Crear TextBox para cada celda de la matriz
            for (int i = 0; i < filasA; i++)
            {
                for (int j = 0; j < columnasA; j++)
                {
                    TextBox txtCelda = new TextBox();
                    txtCelda.Location = new Point(j * 40 + 5, i * 20 + 5);
                    txtCelda.Size = new Size(35, 20);
                    txtCelda.Text = "0";
                    txtCelda.Name = $"txtA_{i}_{j}";

                    // Validar entrada numérica para la celda
                    txtCelda.KeyPress += new KeyPressEventHandler(ValidarNumeroDecimal);

                    // Agregar al panel
                    panMatrizA.Controls.Add(txtCelda);
                }
            }
        }
        private void btnClearA_Click(object sender, EventArgs e)
        {
            // Limpiar el panel de entrada
           // Panel panelInputMatrizA = (Panel)panMatrizA.Controls[5];
            panMatrizA.Controls.Clear();

            // Limpiar las dimensiones
            txtFilasMatrizA.Text = "";
            txtColumnasMatrizA.Text = "";

            // Liberar la matriz
            matrizA = null;
            filasA = 0;
            columnasA = 0;
        }



        private void btnShowMatrizA_Click(object sender, EventArgs e)
        {
            // Verificar si la matriz existe
            if (matrizA == null)
            {
                MessageBox.Show("La matriz A no ha sido creada");
                return;
            }

            // Obtener valores actuales
            ObtenerValoresMatrizA();

            // Construir cadena para mostrar la matriz
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Matriz A:");

            for (int i = 0; i < filasA; i++)
            {
                for (int j = 0; j < columnasA; j++)
                {
                    sb.Append(matrizA[i, j] + "\t");
                }
                sb.AppendLine();
            }
            sb.AppendLine();

            // Mostrar en el panel de resultados
            txtResultado.Text += sb.ToString();

            // Desplazar al final
            txtResultado.SelectionStart = txtResultado.Text.Length;
            txtResultado.ScrollToCaret();
        }



        private void btnTranspuestaA_Click(object sender, EventArgs e)
        {
            // Verificar si la matriz existe
            if (matrizA == null)
            {
                MessageBox.Show("La matriz A no ha sido creada");
                return;
            }

            // Obtener valores actuales
            ObtenerValoresMatrizA();

            // Crear matriz transpuesta
            double[,] transpuesta = new double[columnasA, filasA];

            // Calcular transpuesta (intercambiar filas por columnas)
            for (int i = 0; i < filasA; i++)
            {
                for (int j = 0; j < columnasA; j++)
                {
                    transpuesta[j, i] = matrizA[i, j];
                }
            }

            // Mostrar resultado
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Transpuesta de Matriz A:");

            for (int i = 0; i < columnasA; i++)
            {
                for (int j = 0; j < filasA; j++)
                {
                    sb.Append(transpuesta[i, j] + "\t");
                }
                sb.AppendLine();
            }
            sb.AppendLine();

            // Mostrar en el panel de resultados
            txtResultado.Text += sb.ToString();

            // Desplazar al final
            txtResultado.SelectionStart = txtResultado.Text.Length;
            txtResultado.ScrollToCaret();
        }

        private void btnRandomA_Click(object sender, EventArgs e)
        {
            // Verificar si la matriz existe
            if (matrizA == null)
            {
                MessageBox.Show("La matriz A no ha sido creada");
                return;
            }

            Random random = new Random();
            // Panel panelInputMatrizA = (Panel)panelMatrizA.Controls[5];

            // Llenar con valores aleatorios
            for (int i = 0; i < filasA; i++)
            {
                for (int j = 0; j < columnasA; j++)
                {
                    // Generar valor aleatorio entero entre -10 y 10
                    int valor = random.Next(0, 20);

                    // Actualizar la matriz
                    matrizA[i, j] = valor;

                    // Actualizar el TextBox
                    TextBox txtCelda = panMatrizA.Controls[$"txtA_{i}_{j}"] as TextBox;
                    if (txtCelda != null)
                    {
                        txtCelda.Text = valor.ToString();
                    }
                }
            }
        }

        private void btnInversaA_Click(object sender, EventArgs e)
        {
            // Verificar si la matriz existe
            if (matrizA == null)
            {
                MessageBox.Show("La matriz A no ha sido creada");
                return;
            }

            // Obtener valores actuales
            ObtenerValoresMatrizA();

            // Verificar si la matriz es cuadrada
            if (filasA != columnasA)
            {
                MessageBox.Show("Para calcular la inversa, la matriz debe ser cuadrada");
                return;
            }

            try
            {
                // Calcular la inversa
                double[,] inversa = CalcularInversa(matrizA, filasA);

                // Mostrar resultado
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Inversa de Matriz A:");

                for (int i = 0; i < filasA; i++)
                {
                    for (int j = 0; j < columnasA; j++)
                    {
                        sb.Append(Math.Round(inversa[i, j], 2) + "\t");
                    }
                    sb.AppendLine();
                }
                sb.AppendLine();

                // Mostrar en el panel de resultados
                txtResultado.Text += sb.ToString();

                // Desplazar al final
                txtResultado.SelectionStart = txtResultado.Text.Length;
                txtResultado.ScrollToCaret();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede calcular la inversa: " + ex.Message);
            }
        }

        // Método para obtener los valores actuales de la matriz A
        private void ObtenerValoresMatrizA()
        {
            // Verificar si la matriz existe
            if (matrizA == null) return;

           // Panel panelInputMatrizA = (Panel)panMatrizA.Controls[5];

            // Recorrer los controles del panel
            for (int i = 0; i < filasA; i++)
            {
                for (int j = 0; j < columnasA; j++)
                {
                    // Buscar el TextBox por su nombre
                    TextBox txtCelda = panMatrizA.Controls[$"txtA_{i}_{j}"] as TextBox;
                    if (txtCelda != null)
                    {
                        // Obtener el valor y guardarlo en la matriz
                        double valor;
                        if (double.TryParse(txtCelda.Text, out valor))
                        {
                            matrizA[i, j] = valor;
                        }
                        else
                        {
                            matrizA[i, j] = 0;
                            txtCelda.Text = "0";
                        }
                    }
                }
            }
        }


        // Botones para Matriz B
        private void btnCreateB_Click(object sender, EventArgs e)
        {
            // Validar que haya datos en los campos
            if (string.IsNullOrEmpty(txtFilasMatrizB.Text) || string.IsNullOrEmpty(txtColumnasMatrizB.Text))
            {
                MessageBox.Show("Ingrese dimensiones válidas para la matriz B");
                return;
            }

            // Obtener las dimensiones
            filasB = int.Parse(txtFilasMatrizB.Text);
            columnasB = int.Parse(txtColumnasMatrizB.Text);

            // Validar dimensiones positivas
            if (filasB <= 0 || columnasB <= 0)
            {
                MessageBox.Show("Las dimensiones deben ser mayores a cero");
                return;
            }

            // Crear la matriz
            matrizB = new double[filasB, columnasB];

            // Limpiar el panel de entrada
            //Panel panelInputMatrizB = (Panel)panelMatrizB.Controls[5]; // El panel de entrada es el 6to control
            panMatrizB.Controls.Clear();

            // Crear TextBox para cada celda de la matriz
            for (int i = 0; i < filasB; i++)
            {
                for (int j = 0; j < columnasB; j++)
                {
                    TextBox txtCelda = new TextBox();
                    txtCelda.Location = new Point(j * 40 + 5, i * 20 + 5);
                    txtCelda.Size = new Size(35, 20);
                    txtCelda.Text = "0";
                    txtCelda.Name = $"txtB_{i}_{j}";

                    // Validar entrada numérica para la celda
                    txtCelda.KeyPress += new KeyPressEventHandler(ValidarNumeroDecimal);

                    // Agregar al panel
                    panMatrizB.Controls.Add(txtCelda);
                }
            }
        }

        private void btnRandomB_Click(object sender, EventArgs e)
        {
            // Verificar si la matriz existe
            if (matrizB == null)
            {
                MessageBox.Show("La matriz B no ha sido creada");
                return;
            }

            Random random = new Random();
          //  Panel panelInputMatrizB = (Panel)panelMatrizB.Controls[5];

            // Llenar con valores aleatorios
            for (int i = 0; i < filasB; i++)
            {
                for (int j = 0; j < columnasB; j++)
                {
                    // Generar valor aleatorio entre -10 y 10
                    // double valor = (random.NextDouble() * 20) - 10;
                    //valor = Math.Round(valor, 1); // Redondear a 1 decimal

                    int valor = random.Next(0, 20);
                    // Actualizar la matriz
                    matrizB[i, j] = valor;

                    // Actualizar el TextBox
                    TextBox txtCelda = panMatrizB.Controls[$"txtB_{i}_{j}"] as TextBox;
                    if (txtCelda != null)
                    {
                        txtCelda.Text = valor.ToString();
                    }
                }
            }
        }

        private void btnClearB_Click(object sender, EventArgs e)
        {
            // Limpiar el panel de entrada
           // Panel panelInputMatrizB = (Panel)panelMatrizB.Controls[5];
            panMatrizB.Controls.Clear();

            // Limpiar las dimensiones
            txtFilasMatrizB.Text = "";
            txtColumnasMatrizB.Text = "";

            // Liberar la matriz
            matrizB = null;
            filasB = 0;
            columnasB = 0;
        }

        private void btnShowMatrizB_Click(object sender, EventArgs e)
        {
            // Verificar si la matriz existe
            if (matrizB == null)
            {
                MessageBox.Show("La matriz B no ha sido creada");
                return;
            }

            // Obtener valores actuales
            ObtenerValoresMatrizB();

            // Construir cadena para mostrar la matriz
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Matriz B:");

            for (int i = 0; i < filasB; i++)
            {
                for (int j = 0; j < columnasB; j++)
                {
                    sb.Append(matrizB[i, j] + "\t");
                }
                sb.AppendLine();
            }
            sb.AppendLine();

            // Mostrar en el panel de resultados
            txtResultado.Text += sb.ToString();

            // Desplazar al final
            txtResultado.SelectionStart = txtResultado.Text.Length;
            txtResultado.ScrollToCaret();
        }

        private void btnTranspuestaB_Click(object sender, EventArgs e)
        {
            // Verificar si la matriz existe
            if (matrizB == null)
            {
                MessageBox.Show("La matriz B no ha sido creada");
                return;
            }

            // Obtener valores actuales
            ObtenerValoresMatrizB();

            // Crear matriz transpuesta
            double[,] transpuesta = new double[columnasB, filasB];

            // Calcular transpuesta (intercambiar filas por columnas)
            for (int i = 0; i < filasB; i++)
            {
                for (int j = 0; j < columnasB; j++)
                {
                    transpuesta[j, i] = matrizB[i, j];
                }
            }

            // Mostrar resultado
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Transpuesta de Matriz B:");

            for (int i = 0; i < columnasB; i++)
            {
                for (int j = 0; j < filasB; j++)
                {
                    sb.Append(transpuesta[i, j] + "\t");
                }
                sb.AppendLine();
            }
            sb.AppendLine();

            // Mostrar en el panel de resultados
            txtResultado.Text += sb.ToString();

            // Desplazar al final
            txtResultado.SelectionStart = txtResultado.Text.Length;
            txtResultado.ScrollToCaret();
        }
        // Método para obtener los valores actuales de la matriz B
        private void ObtenerValoresMatrizB()
        {
            // Verificar si la matriz existe
            if (matrizB == null) return;

          //  Panel panelInputMatrizB = (Panel)panMatrizB.Controls[5];

            // Recorrer los controles del panel
            for (int i = 0; i < filasB; i++)
            {
                for (int j = 0; j < columnasB; j++)
                {
                    // Buscar el TextBox por su nombre
                    TextBox txtCelda = panMatrizB.Controls[$"txtB_{i}_{j}"] as TextBox;
                    if (txtCelda != null)
                    {
                        // Obtener el valor y guardarlo en la matriz
                        double valor;
                        if (double.TryParse(txtCelda.Text, out valor))
                        {
                            matrizB[i, j] = valor;
                        }
                        else
                        {
                            matrizB[i, j] = 0;
                            txtCelda.Text = "0";
                        }
                    }
                }
            }
        }
        private void btnInversaB_Click(object sender, EventArgs e)
        {
            // Verificar si la matriz existe
            if (matrizB == null)
            {
                MessageBox.Show("La matriz B no ha sido creada");
                return;
            }

            // Obtener valores actuales
            ObtenerValoresMatrizB();

            // Verificar si la matriz es cuadrada
            if (filasB != columnasB)
            {
                MessageBox.Show("Para calcular la inversa, la matriz debe ser cuadrada");
                return;
            }

            try
            {
                // Calcular la inversa
                double[,] inversa = CalcularInversa(matrizB, filasB);

                // Mostrar resultado
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Inversa de Matriz B:");

                for (int i = 0; i < filasB; i++)
                {
                    for (int j = 0; j < columnasB; j++)
                    {
                        sb.Append(Math.Round(inversa[i, j], 2) + "\t");
                    }
                    sb.AppendLine();
                }
                sb.AppendLine();

                // Mostrar en el panel de resultados
                txtResultado.Text += sb.ToString();

                // Desplazar al final
                txtResultado.SelectionStart = txtResultado.Text.Length;
                txtResultado.ScrollToCaret();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede calcular la inversa: " + ex.Message);
            }
        }

        // Botones de operaciones

        private void btnSuma_Click(object sender, EventArgs e)
        {
            // Verificar si ambas matrices existen
            if (matrizA == null || matrizB == null)
            {
                MessageBox.Show("Ambas matrices deben ser creadas antes de realizar operaciones");
                return;
            }

            // Obtener valores actuales
            ObtenerValoresMatrizA();
            ObtenerValoresMatrizB();

            // Verificar si las matrices tienen las mismas dimensiones
            if (filasA != filasB || columnasA != columnasB)
            {
                MessageBox.Show("Para sumar matrices, ambas deben tener las mismas dimensiones");
                return;
            }

            // Crear matriz resultado
            double[,] resultado = new double[filasA, columnasA];

            // Realizar la suma
            for (int i = 0; i < filasA; i++)
            {
                for (int j = 0; j < columnasA; j++)
                {
                    resultado[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }

            // Mostrar resultado
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Resultado de A + B:");

            for (int i = 0; i < filasA; i++)
            {
                for (int j = 0; j < columnasA; j++)
                {
                    sb.Append(resultado[i, j] + "\t");
                }
                sb.AppendLine();
            }
            sb.AppendLine();

            // Mostrar en el panel de resultados
            txtResultado.Text += sb.ToString();

            // Desplazar al final
            txtResultado.SelectionStart = txtResultado.Text.Length;
            txtResultado.ScrollToCaret();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            // Verificar si ambas matrices existen
            if (matrizA == null || matrizB == null)
            {
                MessageBox.Show("Ambas matrices deben ser creadas antes de realizar operaciones");
                return;
            }

            // Obtener valores actuales
            ObtenerValoresMatrizA();
            ObtenerValoresMatrizB();

            // Verificar si las matrices tienen las mismas dimensiones
            if (filasA != filasB || columnasA != columnasB)
            {
                MessageBox.Show("Para restar matrices, ambas deben tener las mismas dimensiones");
                return;
            }

            // Crear matriz resultado
            double[,] resultado = new double[filasA, columnasA];

            // Realizar la resta
            for (int i = 0; i < filasA; i++)
            {
                for (int j = 0; j < columnasA; j++)
                {
                    resultado[i, j] = matrizA[i, j] - matrizB[i, j];
                }
            }

            // Mostrar resultado
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Resultado de A - B:");

            for (int i = 0; i < filasA; i++)
            {
                for (int j = 0; j < columnasA; j++)
                {
                    sb.Append(resultado[i, j] + "\t");
                }
                sb.AppendLine();
            }
            sb.AppendLine();

            // Mostrar en el panel de resultados
            txtResultado.Text += sb.ToString();

            // Desplazar al final
            txtResultado.SelectionStart = txtResultado.Text.Length;
            txtResultado.ScrollToCaret();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            // Verificar si ambas matrices existen
            if (matrizA == null || matrizB == null)
            {
                MessageBox.Show("Ambas matrices deben ser creadas antes de realizar operaciones");
                return;
            }

            // Obtener valores actuales
            ObtenerValoresMatrizA();
            ObtenerValoresMatrizB();

            // Verificar si las matrices tienen dimensiones compatibles para multiplicación
            if (columnasA != filasB)
            {
                MessageBox.Show("Para multiplicar matrices, el número de columnas de A debe ser igual al número de filas de B");
                return;
            }

            // Crear matriz resultado
            double[,] resultado = new double[filasA, columnasB];

            // Realizar la multiplicación
            for (int i = 0; i < filasA; i++)
            {
                for (int j = 0; j < columnasB; j++)
                {
                    double suma = 0;
                    for (int k = 0; k < columnasA; k++)
                    {
                        suma += matrizA[i, k] * matrizB[k, j];
                    }
                    resultado[i, j] = suma;
                }
            }

            // Mostrar resultado
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Resultado de A * B:");

            for (int i = 0; i < filasA; i++)
            {
                for (int j = 0; j < columnasB; j++)
                {
                    sb.Append(resultado[i, j] + "\t");
                }
                sb.AppendLine();
            }
            sb.AppendLine();

            // Mostrar en el panel de resultados
            txtResultado.Text += sb.ToString();

            // Desplazar al final
            txtResultado.SelectionStart = txtResultado.Text.Length;
            txtResultado.ScrollToCaret();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            // Verificar si ambas matrices existen
            if (matrizA == null || matrizB == null)
            {
                MessageBox.Show("Ambas matrices deben ser creadas antes de realizar operaciones");
                return;
            }

            // Obtener valores actuales
            ObtenerValoresMatrizA();
            ObtenerValoresMatrizB();

            // Verificar si la matriz B es cuadrada
            if (filasB != columnasB)
            {
                MessageBox.Show("Para la división de matrices, B debe ser una matriz cuadrada");
                return;
            }

            try
            {
                // Calcular la inversa de B
                double[,] inversaB = CalcularInversa(matrizB, filasB);

                // Verificar si las matrices tienen dimensiones compatibles para multiplicación
                if (columnasA != filasB)
                {
                    MessageBox.Show("Para la división de matrices, el número de columnas de A debe ser igual al número de filas de B");
                    return;
                }

                // Crear matriz resultado
                double[,] resultado = new double[filasA, columnasB];

                // Realizar la multiplicación A * B^-1
                for (int i = 0; i < filasA; i++)
                {
                    for (int j = 0; j < columnasB; j++)
                    {
                        double suma = 0;
                        for (int k = 0; k < columnasA; k++)
                        {
                            suma += matrizA[i, k] * inversaB[k, j];
                        }
                        resultado[i, j] = suma;
                    }
                }

                // Mostrar resultado
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Resultado de A / B (A * B^-1):");

                for (int i = 0; i < filasA; i++)
                {
                    for (int j = 0; j < columnasB; j++)
                    {
                        sb.Append(Math.Round(resultado[i, j], 2) + "\t");
                    }
                    sb.AppendLine();
                }
                sb.AppendLine();

                // Mostrar en el panel de resultados
                txtResultado.Text += sb.ToString();

                // Desplazar al final
                txtResultado.SelectionStart = txtResultado.Text.Length;
                txtResultado.ScrollToCaret();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede realizar la división: " + ex.Message);
            }
        }

        // Botón para limpiar resultados
        private void btnClearResultado_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
        }


        // Método para validar que solo se ingresen números
        private void ValidarNumero(object sender, KeyPressEventArgs e)
        {
            // Solo permitir dígitos y tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Create and show the welcome form
            Form2 bienvenida = new Form2();
            bienvenida.Show();
        }

        private void ValidarNumeroDecimal(object sender, KeyPressEventArgs e)
        {
            // Permitir dígitos, punto decimal, signo negativo y tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-' && e.KeyChar != 8)
            {
                e.Handled = true;
                return;
            }
        }
        private double[,] CalcularInversa(double[,] matriz, int n)
        {
            // Crear la matriz aumentada [A|I]
            double[,] aumentada = new double[n, 2 * n];

            // Llenar la matriz aumentada
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    aumentada[i, j] = matriz[i, j];          // Matriz original
                    aumentada[i, j + n] = (i == j) ? 1 : 0;  // Matriz identidad
                }
            }

            // Algoritmo de eliminación Gaussiana para convertir [A|I] en [I|A^-1]
            for (int k = 0; k < n; k++)
            {
                // Verificar si el elemento de la diagonal es cero
                if (Math.Abs(aumentada[k, k]) < 1e-10)
                {
                    throw new InvalidOperationException("La matriz no tiene inversa (determinante cero)");
                }

                // Normalizar la fila k
                double pivot = aumentada[k, k];
                for (int j = 0; j < 2 * n; j++)
                {
                    aumentada[k, j] /= pivot;
                }

                // Restar múltiplos de la fila k de las otras filas
                for (int i = 0; i < n; i++)
                {
                    if (i != k)
                    {
                        double factor = aumentada[i, k];
                        for (int j = 0; j < 2 * n; j++)
                        {
                            aumentada[i, j] -= factor * aumentada[k, j];
                        }
                    }
                }
            }

            // Extraer la matriz inversa
            double[,] inversa = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    inversa[i, j] = aumentada[i, j + n];
                }
            }

            return inversa;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
