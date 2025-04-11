namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panMatrizA = new System.Windows.Forms.Panel();
            this.panMatrizB = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFilasMatrizA = new System.Windows.Forms.TextBox();
            this.txtColumnasMatrizA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreateA = new System.Windows.Forms.Button();
            this.btnClearA = new System.Windows.Forms.Button();
            this.btnClearB = new System.Windows.Forms.Button();
            this.btnCreateB = new System.Windows.Forms.Button();
            this.txtColumnasMatrizB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFilasMatrizB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTranspuestaA = new System.Windows.Forms.Button();
            this.btnInversaA = new System.Windows.Forms.Button();
            this.btnShowMatrizA = new System.Windows.Forms.Button();
            this.btnRandomA = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnRandomB = new System.Windows.Forms.Button();
            this.btnShowMatrizB = new System.Windows.Forms.Button();
            this.btnInversaB = new System.Windows.Forms.Button();
            this.btnTranspuestaB = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnClearResultado = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULADORA DE MATRICES";
            // 
            // panMatrizA
            // 
            this.panMatrizA.AutoScroll = true;
            this.panMatrizA.BackColor = System.Drawing.Color.Silver;
            this.panMatrizA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panMatrizA.Location = new System.Drawing.Point(40, 134);
            this.panMatrizA.Name = "panMatrizA";
            this.panMatrizA.Size = new System.Drawing.Size(200, 116);
            this.panMatrizA.TabIndex = 1;
            // 
            // panMatrizB
            // 
            this.panMatrizB.AutoScroll = true;
            this.panMatrizB.BackColor = System.Drawing.Color.Silver;
            this.panMatrizB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panMatrizB.Location = new System.Drawing.Point(447, 134);
            this.panMatrizB.Name = "panMatrizB";
            this.panMatrizB.Size = new System.Drawing.Size(200, 116);
            this.panMatrizB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Matriz A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(444, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Matriz B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dimensiones:";
            // 
            // txtFilasMatrizA
            // 
            this.txtFilasMatrizA.Location = new System.Drawing.Point(79, 8);
            this.txtFilasMatrizA.Name = "txtFilasMatrizA";
            this.txtFilasMatrizA.Size = new System.Drawing.Size(40, 20);
            this.txtFilasMatrizA.TabIndex = 6;
            this.txtFilasMatrizA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarNumero);
            // 
            // txtColumnasMatrizA
            // 
            this.txtColumnasMatrizA.Location = new System.Drawing.Point(137, 9);
            this.txtColumnasMatrizA.Name = "txtColumnasMatrizA";
            this.txtColumnasMatrizA.Size = new System.Drawing.Size(40, 20);
            this.txtColumnasMatrizA.TabIndex = 8;
            this.txtColumnasMatrizA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarNumero);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "X";
            // 
            // btnCreateA
            // 
            this.btnCreateA.BackColor = System.Drawing.Color.DarkGray;
            this.btnCreateA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateA.Location = new System.Drawing.Point(183, 7);
            this.btnCreateA.Name = "btnCreateA";
            this.btnCreateA.Size = new System.Drawing.Size(47, 23);
            this.btnCreateA.TabIndex = 13;
            this.btnCreateA.Text = "Crear";
            this.btnCreateA.UseVisualStyleBackColor = false;
            this.btnCreateA.Click += new System.EventHandler(this.btnCreateA_Click);
            // 
            // btnClearA
            // 
            this.btnClearA.BackColor = System.Drawing.Color.DarkGray;
            this.btnClearA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearA.Location = new System.Drawing.Point(236, 7);
            this.btnClearA.Name = "btnClearA";
            this.btnClearA.Size = new System.Drawing.Size(55, 23);
            this.btnClearA.TabIndex = 14;
            this.btnClearA.Text = "Limpiar";
            this.btnClearA.UseVisualStyleBackColor = false;
            this.btnClearA.Click += new System.EventHandler(this.btnClearA_Click);
            // 
            // btnClearB
            // 
            this.btnClearB.BackColor = System.Drawing.Color.DarkGray;
            this.btnClearB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearB.Location = new System.Drawing.Point(236, 17);
            this.btnClearB.Name = "btnClearB";
            this.btnClearB.Size = new System.Drawing.Size(55, 23);
            this.btnClearB.TabIndex = 20;
            this.btnClearB.Text = "Limpiar";
            this.btnClearB.UseVisualStyleBackColor = false;
            this.btnClearB.Click += new System.EventHandler(this.btnClearB_Click);
            // 
            // btnCreateB
            // 
            this.btnCreateB.BackColor = System.Drawing.Color.DarkGray;
            this.btnCreateB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateB.Location = new System.Drawing.Point(183, 17);
            this.btnCreateB.Name = "btnCreateB";
            this.btnCreateB.Size = new System.Drawing.Size(47, 23);
            this.btnCreateB.TabIndex = 19;
            this.btnCreateB.Text = "Crear";
            this.btnCreateB.UseVisualStyleBackColor = false;
            this.btnCreateB.Click += new System.EventHandler(this.btnCreateB_Click);
            // 
            // txtColumnasMatrizB
            // 
            this.txtColumnasMatrizB.Location = new System.Drawing.Point(137, 19);
            this.txtColumnasMatrizB.Name = "txtColumnasMatrizB";
            this.txtColumnasMatrizB.Size = new System.Drawing.Size(40, 20);
            this.txtColumnasMatrizB.TabIndex = 18;
            this.txtColumnasMatrizB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarNumero);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "X";
            // 
            // txtFilasMatrizB
            // 
            this.txtFilasMatrizB.Location = new System.Drawing.Point(76, 19);
            this.txtFilasMatrizB.Name = "txtFilasMatrizB";
            this.txtFilasMatrizB.Size = new System.Drawing.Size(40, 20);
            this.txtFilasMatrizB.TabIndex = 16;
            this.txtFilasMatrizB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarNumero);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Dimensiones:";
            // 
            // btnTranspuestaA
            // 
            this.btnTranspuestaA.BackColor = System.Drawing.Color.LightBlue;
            this.btnTranspuestaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranspuestaA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTranspuestaA.Location = new System.Drawing.Point(8, 295);
            this.btnTranspuestaA.Name = "btnTranspuestaA";
            this.btnTranspuestaA.Size = new System.Drawing.Size(126, 23);
            this.btnTranspuestaA.TabIndex = 21;
            this.btnTranspuestaA.Text = "Matriz Transpuesta";
            this.btnTranspuestaA.UseVisualStyleBackColor = false;
            this.btnTranspuestaA.Click += new System.EventHandler(this.btnTranspuestaA_Click);
            // 
            // btnInversaA
            // 
            this.btnInversaA.BackColor = System.Drawing.Color.LightBlue;
            this.btnInversaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInversaA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInversaA.Location = new System.Drawing.Point(140, 295);
            this.btnInversaA.Name = "btnInversaA";
            this.btnInversaA.Size = new System.Drawing.Size(143, 23);
            this.btnInversaA.TabIndex = 22;
            this.btnInversaA.Text = "Matriz Inversa";
            this.btnInversaA.UseVisualStyleBackColor = false;
            this.btnInversaA.Click += new System.EventHandler(this.btnInversaA_Click);
            // 
            // btnShowMatrizA
            // 
            this.btnShowMatrizA.BackColor = System.Drawing.Color.LightBlue;
            this.btnShowMatrizA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowMatrizA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnShowMatrizA.Location = new System.Drawing.Point(8, 266);
            this.btnShowMatrizA.Name = "btnShowMatrizA";
            this.btnShowMatrizA.Size = new System.Drawing.Size(126, 23);
            this.btnShowMatrizA.TabIndex = 23;
            this.btnShowMatrizA.Text = "Mostrar Matriz";
            this.btnShowMatrizA.UseVisualStyleBackColor = false;
            this.btnShowMatrizA.Click += new System.EventHandler(this.btnShowMatrizA_Click);
            // 
            // btnRandomA
            // 
            this.btnRandomA.BackColor = System.Drawing.Color.LightBlue;
            this.btnRandomA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRandomA.Location = new System.Drawing.Point(140, 266);
            this.btnRandomA.Name = "btnRandomA";
            this.btnRandomA.Size = new System.Drawing.Size(143, 23);
            this.btnRandomA.TabIndex = 24;
            this.btnRandomA.Text = "Llenar Aleatoriamente";
            this.btnRandomA.UseVisualStyleBackColor = false;
            this.btnRandomA.Click += new System.EventHandler(this.btnRandomA_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSuma.Location = new System.Drawing.Point(305, 227);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 23);
            this.btnSuma.TabIndex = 25;
            this.btnSuma.Text = "A + B";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.BackColor = System.Drawing.Color.DarkBlue;
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnResta.Location = new System.Drawing.Point(305, 256);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(75, 23);
            this.btnResta.TabIndex = 26;
            this.btnResta.Text = "A -B";
            this.btnResta.UseVisualStyleBackColor = false;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnRandomB
            // 
            this.btnRandomB.BackColor = System.Drawing.Color.LightGreen;
            this.btnRandomB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRandomB.Location = new System.Drawing.Point(549, 266);
            this.btnRandomB.Name = "btnRandomB";
            this.btnRandomB.Size = new System.Drawing.Size(146, 23);
            this.btnRandomB.TabIndex = 30;
            this.btnRandomB.Text = "Llenar Aleatoriamente";
            this.btnRandomB.UseVisualStyleBackColor = false;
            this.btnRandomB.Click += new System.EventHandler(this.btnRandomB_Click);
            // 
            // btnShowMatrizB
            // 
            this.btnShowMatrizB.BackColor = System.Drawing.Color.LightGreen;
            this.btnShowMatrizB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowMatrizB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnShowMatrizB.Location = new System.Drawing.Point(417, 266);
            this.btnShowMatrizB.Name = "btnShowMatrizB";
            this.btnShowMatrizB.Size = new System.Drawing.Size(126, 23);
            this.btnShowMatrizB.TabIndex = 29;
            this.btnShowMatrizB.Text = "Mostrar Matriz";
            this.btnShowMatrizB.UseVisualStyleBackColor = false;
            this.btnShowMatrizB.Click += new System.EventHandler(this.btnShowMatrizB_Click);
            // 
            // btnInversaB
            // 
            this.btnInversaB.BackColor = System.Drawing.Color.LightGreen;
            this.btnInversaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInversaB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInversaB.Location = new System.Drawing.Point(549, 295);
            this.btnInversaB.Name = "btnInversaB";
            this.btnInversaB.Size = new System.Drawing.Size(146, 23);
            this.btnInversaB.TabIndex = 28;
            this.btnInversaB.Text = "Matriz Inversa";
            this.btnInversaB.UseVisualStyleBackColor = false;
            this.btnInversaB.Click += new System.EventHandler(this.btnInversaB_Click);
            // 
            // btnTranspuestaB
            // 
            this.btnTranspuestaB.BackColor = System.Drawing.Color.LightGreen;
            this.btnTranspuestaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranspuestaB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTranspuestaB.Location = new System.Drawing.Point(417, 295);
            this.btnTranspuestaB.Name = "btnTranspuestaB";
            this.btnTranspuestaB.Size = new System.Drawing.Size(126, 23);
            this.btnTranspuestaB.TabIndex = 27;
            this.btnTranspuestaB.Text = "Matriz Transpuesta";
            this.btnTranspuestaB.UseVisualStyleBackColor = false;
            this.btnTranspuestaB.Click += new System.EventHandler(this.btnTranspuestaB_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.BackColor = System.Drawing.Color.DarkBlue;
            this.btnMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacion.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnMultiplicacion.Location = new System.Drawing.Point(305, 285);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplicacion.TabIndex = 31;
            this.btnMultiplicacion.Text = "A * B";
            this.btnMultiplicacion.UseVisualStyleBackColor = false;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.DarkBlue;
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDivision.Location = new System.Drawing.Point(305, 314);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(75, 23);
            this.btnDivision.TabIndex = 32;
            this.btnDivision.Text = "A/B";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "Resultado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(79, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "(Filas) ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(122, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "(Columnas) ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(134, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "(Columnas) ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(79, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "(Filas) ";
            // 
            // btnClearResultado
            // 
            this.btnClearResultado.BackColor = System.Drawing.Color.Chartreuse;
            this.btnClearResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearResultado.Location = new System.Drawing.Point(631, 360);
            this.btnClearResultado.Name = "btnClearResultado";
            this.btnClearResultado.Size = new System.Drawing.Size(64, 23);
            this.btnClearResultado.TabIndex = 39;
            this.btnClearResultado.Text = "Limpiar";
            this.btnClearResultado.UseVisualStyleBackColor = false;
            this.btnClearResultado.Click += new System.EventHandler(this.btnClearResultado_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtResultado.Location = new System.Drawing.Point(15, 389);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResultado.Size = new System.Drawing.Size(661, 123);
            this.txtResultado.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtFilasMatrizA);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtColumnasMatrizA);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btnCreateA);
            this.panel1.Controls.Add(this.btnClearA);
            this.panel1.Location = new System.Drawing.Point(15, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 59);
            this.panel1.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGreen;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnClearB);
            this.panel2.Controls.Add(this.btnCreateB);
            this.panel2.Controls.Add(this.txtColumnasMatrizB);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtFilasMatrizB);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(395, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 67);
            this.panel2.TabIndex = 42;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Orange;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(611, 549);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 43;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(707, 584);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnClearResultado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnRandomB);
            this.Controls.Add(this.btnShowMatrizB);
            this.Controls.Add(this.btnInversaB);
            this.Controls.Add(this.btnTranspuestaB);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnRandomA);
            this.Controls.Add(this.btnShowMatrizA);
            this.Controls.Add(this.btnInversaA);
            this.Controls.Add(this.btnTranspuestaA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panMatrizB);
            this.Controls.Add(this.panMatrizA);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculadoraDeMatrices.Ape";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panMatrizA;
        private System.Windows.Forms.Panel panMatrizB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFilasMatrizA;
        private System.Windows.Forms.TextBox txtColumnasMatrizA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreateA;
        private System.Windows.Forms.Button btnClearA;
        private System.Windows.Forms.Button btnClearB;
        private System.Windows.Forms.Button btnCreateB;
        private System.Windows.Forms.TextBox txtColumnasMatrizB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFilasMatrizB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTranspuestaA;
        private System.Windows.Forms.Button btnInversaA;
        private System.Windows.Forms.Button btnShowMatrizA;
        private System.Windows.Forms.Button btnRandomA;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnRandomB;
        private System.Windows.Forms.Button btnShowMatrizB;
        private System.Windows.Forms.Button btnInversaB;
        private System.Windows.Forms.Button btnTranspuestaB;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnClearResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAtras;
    }
}

