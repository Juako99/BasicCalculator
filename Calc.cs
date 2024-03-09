using System;
using System.Text.RegularExpressions;

public class Calc
{
    //Regex para operandos
    //Regex for operands
    public Regex operandos = new Regex(@"(-?[1-9]\d*)");
    //Regex para identificar si hay un negativo posterior a otro operador
    //Regex to identify if there is a negative operator next to another operator
    public Regex hayNegativo = new Regex(@"[\+\-\/\*\^\%]{1}[\-]");
    //Regex para detectar negativos
    //Regex to identify negatives
    public Regex Resta = new Regex("[-]");
    public double Solve(string equation)
    {
        // Quitamos todos los espacios, en caso de que por algun motivo exista alguno
        equation = Regex.Replace(equation, @"\s+", "");

        Operacion operation = new Operacion();
        operation.Parse(equation);
        double result;

        // Este if es en caso de se le de a calcular ingresando un numero negativo
        if (operandos.Matches(equation).Count == 1)
        {
            //Si solo hay un operando lo devuelve, esto es para prevenir el fallo con los negativos
            result = Convert.ToDouble(equation);
        }
        else
        {

            result = operation.Resolver();
        }

        return result;


    }
}

public class Operacion
{
    //Regex para operadores
    public Regex operadores = new Regex(@"[\+\-\/\*\^\%]");
    //Regex para identificar si hay un negativo posterior a otro operador (* /)
    public Regex hayNegativo = new Regex(@"[\*\/]{1}[\-]");
    //Regex para detectar negativos
    public Regex Resta = new Regex("[-]");

    /*
     * El arbol funciona a partir un nodo principal y que se bifurca en un numero izquiero y un nodo en 
     * caso de que exista mas de un operador, en caso contrario es simplemente un numero derecho
     */
    public Operacion NumeroIzquierdo { get; set; }
    public string Operador { get; set; }
    public Operacion NumeroDerecho { get; set; }

    /* Ambos Regex son para identificar los operadores y establecer los nodos del arbol, funcionan de derecha a izquierda, para que 
     * a la hora de resolver el arbol , este respete la regla de resolucion de los calculos combinados, es decir, de izquierda a derecha.
     * Esto se debe a que el ultimo operador encontrado es el primero en ser resuelto, por lo cual, el ultimo a ser encontrado debe ser,
     * el mas proximo a la izquierda.
     */
    private Regex sumaResta = new Regex("(?<=[0-9])([+-]+)(?=[0-9]+)", RegexOptions.RightToLeft);
    private Regex multiplicacionDivision = new Regex("[*/]", RegexOptions.RightToLeft);

    public void Parse(string equation)

    {

        // Busca el operador usando el regex, priorizando suma y resta
        var operatorLocation = sumaResta.Match(equation).Groups[1];

        // Si no encuentra, busca multiplicación y división
        if (!operatorLocation.Success)
        {
            operatorLocation = multiplicacionDivision.Match(equation);
        }
        // Este condicional se fija si hay casos de *(-numero o  /(-numero
        bool hayDosOperadores = hayNegativo.IsMatch(equation);
        if (hayDosOperadores)
        {
            // Si encuentra, tira el mensaje por consola
            Console.WriteLine("Entre caso [ *(-n || /(-n  ] : " + equation.Remove(Resta.Match(equation).Index, 1));
            // Borra la parte negativa para evitar que el proceso logico se rompa, esto se contempla igualmente, EL NEGATIVO NO SE PIERDE
            operatorLocation = sumaResta.Match(equation);
            if (!operatorLocation.Success)
            {
                operatorLocation = multiplicacionDivision.Match(equation);
            }
        }
        // Si encuentra un operador
        if (operatorLocation.Success)
        {
            // Le setea el valor de la posicion a Operador
            Operador = operatorLocation.Value;
            // Y crea las ramas de NI Y ND
            NumeroIzquierdo = new Operacion();
            NumeroIzquierdo.Parse(equation.Substring(0, operatorLocation.Index));

            NumeroDerecho = new Operacion();
            NumeroDerecho.Parse(equation.Substring(operatorLocation.Index + 1));
        }
        else
        {
            // En caso de que no encuentre un operador, setea operador como "v" y parsea el valor de la equacion, ya que es solo un numero
            Operador = "v";
            result = double.Parse(equation);
        }
    }

    private double result;
    // Resuelve la equacion, resolviendo cada calculo, de forma recursiva
    public double Resolver()
    {
        switch (Operador)
        {
            case "v":
                break;
            case "+":

                result = NumeroIzquierdo.Resolver() + NumeroDerecho.Resolver();
                Console.WriteLine("suma: " + result);
                break;
            case "-":
                result = NumeroIzquierdo.Resolver() - NumeroDerecho.Resolver();
                Console.WriteLine("resta: " + result);
                break;
            case "*":
                result = NumeroIzquierdo.Resolver() * NumeroDerecho.Resolver();
                Console.WriteLine("multiplicacion: " + result);
                break;
            case "/":
                result = NumeroIzquierdo.Resolver() / NumeroDerecho.Resolver();
                Console.WriteLine("division: " + result);
                break;
            default:
                throw new Exception("Call Parse first.");
        }
        Console.WriteLine("retorno resultado: " + result);
        return result;
    }
}