using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculador
{
    public partial class Index : Form
    {

        //Regex para operandos
        Regex operandos = new Regex(@"(-?[1-9]\d*)");
        //Regex para operadores
        Regex operadores = new Regex(@"[\+\-\/\*]");
        //Regex para identificar operaciones individuales
        Regex operacion_unitaria = new Regex(@"(\({1}[\d\+\-\/\*]+[\d+]*\){1})");
        //Lista donde se almacenan las distintas partes de una ecuación que se
        //encuentren encerradas en parentesis para ser resueltas y reemplazadas en la ecuación.
        List<String> partes_de_ecuacion = new List<String>();

        public Index()
        {
            InitializeComponent();
            
        }

        private void Screen_KeyDown(object sender, KeyEventArgs e)
        {
            screen.AppendText($"KeyDown code: {e.KeyCode}, value: {e.KeyValue}, modifiers: {e.Modifiers}" + "\r\n");
            
        }

        //Metodo para escribir numeros, en caso de tener un parentesis de cierre ")", no permite escribir un numero siguiente a este.
        private void AgregarNumero(object sender, EventArgs e)
        {
            var boton = ((System.Windows.Forms.Button)sender);
            if (screen.Text == "0")
                screen.Text = "";
            if (screen.Text.Equals(""))
            {
                screen.Text += boton.Text;
            }
            else
            {
                if (!screen.Text[screen.Text.Length - 1].Equals(')'))
                {
                    screen.Text += boton.Text;


                }
            }
        }
        //borra SOLAMENTE el valor de la pantalla inferior y lo setea en "0"
        private void Button_borrar_Click(object sender, EventArgs e)
        {
            screen.Text = "0";
        }
        //Metodo para escribir operadores, no permite escribir mas de un operador seguido, en caso de escribir uno, reemplaza el actual.
        private void Click_operador(object sender, EventArgs e)
        {
            var boton = ((System.Windows.Forms.Button)sender);
            String texto = boton.Tag.ToString();
            char caracter = screen.Text[screen.Text.Length - 1];
            if (screen.Text == "0")
            {
                screen.Text = "";
                screen.Text += boton.Tag.ToString();
            }
            else
            {
                if (!operadores.IsMatch("" + screen.Text[screen.Text.Length - 1]))
                {
                    screen.Text = screen.Text.TrimEnd();
                    screen.Text += boton.Tag.ToString();
                }
                else
                {
                    screen.Text = screen.Text.TrimEnd(caracter);
                    screen.Text += boton.Tag.ToString();

                }
            }
        }
        //Metodo para borrar
        private void Button_backspace_Click(object sender, EventArgs e)
        {
            if (screen.Text != "")
            {
                screen.Text = screen.Text.Substring(0, screen.Text.Length - 1);
            }
            if (screen.Text.Length == 0)
            {
                screen.Text = "0";
            }
        }
        //procedimiento para borrar TODOS LOS DATOS EN LA CALCULADORA
        private void ButtonC_Click(object sender, EventArgs e)
        {
            //devuelve TODOS los valores a sus originales respectivos
            txtRes.Text = "";
            screen.Text = "0";
        }
        //Metodo para checkear si el caracter es un digito un parentesis cerrado
        private bool Number_closeBracket(string car)
        {
            Regex regex = new Regex(@"^\d$");
            return regex.IsMatch(car) || car.Equals(")");
        }
        //Metodos para agregar parentesis izquierdo y derecho, con validacion para no permitir )(, es necesario un operador intermedio, ej: )+(
        private void Button_p_izq_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "";
            }
            if (screen.Text.Length > 0)
            {
                string n_anterior = "" + screen.Text[screen.Text.Length - 1];
                bool is_operator = operadores.IsMatch(n_anterior);

                if (is_operator || n_anterior.Equals("("))
                {
                    screen.Text += "(";
                }
            }
            else
            {
                screen.Text += "(";
            }
        }

        private void Button_p_der_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "";
            }
            if (screen.Text.Length > 0)
            {
                string n_anterior = "" + screen.Text[screen.Text.Length - 1];
                bool is_operator = Number_closeBracket(n_anterior);
                if (is_operator)
                {
                    screen.Text += ")";
                }
            }
        }
        /* Los Logs por consola, son meramente para ver el proceso logico
         */
        //Metodo para calcular el resultado
        private void Button_result_Click(object sender, EventArgs e)
        {
            Regex modNegativo = new Regex(@"(-[\d]+[\*\/][\d]+){1}");
            try
            {
                String cuenta = screen.Text;
                //Muestro cuenta ingresada por consola
                Console.WriteLine("La cuenta ingresada es: " + cuenta);
                //Instancio una calculadora
                Calc _calculator = new Calc();
                //Seteo el resultado en 0
                double resultado = 0;

                if (cuenta.Contains('(') || cuenta.Contains(')'))
                {
                    Console.WriteLine("CASO A: Ecuación con paretensís");
                    //Caso A: primero validamos que la cantidad de parentesis presente sea correcta, por ej: 2(( y 2)), y no 2(( y 3))
                    if (ValidarEcuacion(cuenta))
                    {
                        /* En caso de que existan parentesis internos, separamos estos como partes de la ecuacion
                         * Realizamos este proceso, las veces que sean necesarias (esto va ligado a la jerarquía de los parentesis)
                         */

                        while (cuenta.Contains("("))
                        {
                            Separar_en_partes(cuenta);
                            cuenta = CalcularResultado(cuenta, _calculator);
                            Console.WriteLine("Cuenta:" + cuenta);

                        }
                        // Una vez la ecuacion esta simplificada para ser resuelta por el algoritmo la resolvemos por completo
                        resultado = _calculator.Solve(Remover_parentesis(cuenta));
                        //LLamamos a la funcion para calcular el resultado
                        Console.WriteLine("Resultado: " + resultado);
                        //Muestro el valor en el formulario
                        txtRes.Text = Convert.ToString(resultado);
                    }
                    else
                    {
                        //Si no se cumple la validacion se muestra error de sintaxis
                        Console.WriteLine("Syntax error");
                        txtRes.Text = "Syntax error";
                    }
                }
                else
                {
                    /* El caso B es el mas sencillo simplemente aplicamos el algoritmo del arbol, sin necesidad de hacer reemplazos en la ecuacion
                     */
                    Console.WriteLine("CASO B: Ecuación sin paretensis");
                    //Calculo el resultado
                    resultado = _calculator.Solve(cuenta);
                    Console.WriteLine("Resultado: " + resultado);
                    //Muestro el valor en el formulario
                    txtRes.Text = Convert.ToString(resultado);
                }
            }
            catch (Exception)
            {
                //En caso de que haya un fallo, suelta error matematico. Esto podría expandirse y hacerse mas especifico
                txtRes.Text = "Math error";
            }
        }
        //Esta funcion, resuelve primero los parentesis, reemplaza los resultados, cuando obtiene la ecuacion simple, resuelve la misma.
        private String CalcularResultado(String cuenta, Calc _calculator)
        {
            Regex negativoComienzo = new Regex(@"^(-[\d]+)");
            // Para casos de -(+n) => -n o -(-n) => n
            Regex sRyRs = new Regex(@"(?<=[0-9])([+-]+)(?=[0-9]+)");
            Regex RR = new Regex(@"(?<=[0-9])([--]{2})(?=[0-9]+)");

            // Proceso de resolución y reemplazo de cada parentesis interno
            foreach (String parte in partes_de_ecuacion)
            {
                // Log por consola de la parte que se va a resolver
                Console.WriteLine("parte de ecuacion: " + parte);

                //Guardo los resultados para despues reemplazarlos
                Console.WriteLine("Reemplazo: " + parte + " " + Convert.ToString(_calculator.Solve(Remover_parentesis(parte))));
                cuenta = cuenta.Replace(parte, Convert.ToString(_calculator.Solve(Remover_parentesis(parte))));

                //Para casos de -(+n) => -n o -(-n) => n

                if (sRyRs.IsMatch(cuenta))
                {
                    /* Se ponen ambos replace en  base al funcionamiento del metodo Replace, ya que tenemos dos posibilidades
                     * en el primer caso, que matchee -+, pero le enviemos a replace +- como patron de coincidencia, si esto pasa
                     * no se efectuaran cambios, por ello realizamos un segundo replace con la alternativa correcta y viceversa.
                     */
                    cuenta = cuenta.Replace("+-", "-");
                    cuenta = cuenta.Replace("-+", "-");
                    Console.WriteLine("a: " + cuenta);
                }
                if (RR.IsMatch(cuenta))
                {
                    cuenta = cuenta.Replace("--", "+");
                    Console.WriteLine("a: " + cuenta);
                }

            }
            // Necesito retornar tanto la cuenta modificada, como el resultado por eso retorno un arraylist
            ArrayList retorno = new ArrayList();
            return cuenta;
        }
        //Valida la ecuacion contando si la cantidad de parentesis de apertura y cierre coinciden.
        private bool ValidarEcuacion(String cuenta)
        {
            char p_i = '(';
            char p_d = ')';
            int contador_pd = 0;
            int contador_pi = 0;
            foreach (char p in cuenta)
            {
                if (p.Equals(p_i))
                {
                    contador_pi++;
                }
                if (p.Equals(p_d))
                {
                    contador_pd++;
                }
            }
            Regex parentesis_innecesarios = new Regex(@"(\(\([\d]*\)\))");
            if (parentesis_innecesarios.IsMatch(cuenta))
            {
                cuenta = cuenta.Replace("(", "");
                cuenta = cuenta.Replace(")", "");
                Console.WriteLine(cuenta);

            }
            return contador_pd == contador_pi ? true : false;
        }
        //Separa las partes de la ecuacion que esten entre parentesis
        private List<String> Separar_en_partes(String cuenta)
        {
            // Limpio la lista por cada operacion nueva
            partes_de_ecuacion.Clear();
            foreach (Match m in operacion_unitaria.Matches(cuenta)) { partes_de_ecuacion.Add(Convert.ToString(m)); }
            return partes_de_ecuacion;
        }
        //Quita los parentesis de las partes de la ecuacion que esten entre parentesis
        private String Remover_parentesis(String cuenta)
        {
            if (cuenta.Contains("("))
            {
                cuenta = cuenta.Remove(cuenta.IndexOf("("), 1);
                cuenta = cuenta.Remove(cuenta.LastIndexOf(")"), 1);
            }
            return cuenta;

        }

        //procedimiento para agregar un punto en la expresion
        private void BtnPunto_Click(object sender, EventArgs e)
        {
            if (!screen.Text.Contains(",")) //solo si la expresion no contiene punto...
            {
                screen.Text += ",";         //agrega un punto
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
        }

    }
}
