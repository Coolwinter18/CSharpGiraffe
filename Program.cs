using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TUTORIAL FROM https://www.youtube.com/watch?v=GhQdlIFylQ8
namespace Giraffe
{
    class Program
    {

        static void Main(string[] args)
        {
            video28();
        }
        static void video1()
        {
            //Video 1
            Console.WriteLine("Hello World!");
            Console.WriteLine("   /|");
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");
            Console.WriteLine("/___|");
        }
        static void video2()
        {
            // Video 2
            //string name = "John";
            int edad = 15;
            edad = 20;
            Console.WriteLine("Texto con una variable " + edad.ToString());
        }
        static void video3()
        {
            //Video 3
            //string unString = "Un Texto";
            //har unCaracter = 'a';
            //int unNumero = 1;
            //float, double, decimal
            //double unReal = 3.2;
            //bool unValor = true;
        }
        static void video4()
        {
            //Video 4 - Strings

            Console.WriteLine("Un String sin Salto de Linea");
            Console.WriteLine("Un String con Salto\n de Linea");
            Console.WriteLine("Un String con \"Comillas\" " + "mas una concatenacion de string");
            string unString = "Longitud de String";
            Console.WriteLine(unString.Length);
            string otroString = "a mayusculas";
            Console.WriteLine(otroString.ToUpper()); //mismo para lowercase
            Console.WriteLine(otroString.Contains('a')); //busca si el char o string esta incluido
            Console.WriteLine(otroString[0]);//accede a la posicion 0(primera) del string
            Console.WriteLine(otroString.IndexOf("hola"));//mismo que contains pero devuelve el indice donde empiece la coincidencia;-1 si no existe.
            Console.WriteLine(otroString.Substring(0, 3));//obtiene el substring del string principal en la pos 0 con long 3
        }
        static void video5()
        {
            //Video 5 - Numeros
            int unNumero = 5;
            Console.WriteLine(unNumero % 2);//modulo de 5 en 2
            Console.WriteLine(Math.Abs(-40));//averiguar tooodas las operaciones matematicas que se puede hacer con la clase Math
        }
        static void video6()
        {
            //Video 6 - Entrada de Usuario

            Console.WriteLine("Un Texto");
            string text = Console.ReadLine(); //siempre lee un tipo string
        }
        static void video7()
        {
            //Video 7 - Crear Calculadora - Convertir strings a numeros.
            int unNumero = Convert.ToInt32("45");
            Console.WriteLine("Ingrese un Número");
            unNumero = Convert.ToInt32(Console.ReadLine());
        }
        static void video8()
        {
            //Video 8 - Crear Mad Libs Game 

            string color, Pronombre, Celebridad;
            color = "Yellow";
            Pronombre = "El";
            Celebridad = "Will Smith";
            Console.WriteLine("Roses are red or " + color);
            Console.WriteLine("Violets or " + Pronombre + " are blue");
            Console.WriteLine("I love you or " + Celebridad);
        }
        static void video9()
        {
            //Video 9 - Arreglos
            int[] LuckyNumbers = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(LuckyNumbers[2]);
            LuckyNumbers[0] = 3; //reemplazo el valor del arreglo en la pos 0 por un 3
            string[] friends = new string[2];
            friends[0] = "Juan";
            friends[1] = "Maria";
        }
        //Video 10 - Metodos
        static void SayHi()
        {
            //Video 10 - Metodos

            Console.WriteLine("Hello User");
        }
        //Video 11 - Sentencia Return en Metodos -- salteo porque ya se sabe definicion de funcion(es lo mismo).
        //Video 12 - Sentencia If - 
        static void video12()
        {
            bool male = true;
            bool tall = true;
            if(male && tall)// '&&' es 'and' __ '||' es 'or' __ '!' es 'not' __ '>=' __ '<' __ '>' __ '<' 
            {

            }
            else if(male)
            {
                //you are female    
            }
        }
        static void video13()
        {
            //video 13 - calculadora mejorada.. mismo que calculadora pero  usando if y seleccionando suma resta division o multiplicacion
        }
        static void video14()
        {
            //video 14 - uso de switch . metodo que segun el numero del 0 al 6, devuelve un string con el dia de la semana
            string dia= "error";
            int num = 0;
            switch (num)
            {
                case 0:
                    dia = "Lunes";
                    break;
                //case 1 , 2 , 3...
                default:
                    dia = "Default, error al ingresar numero de dia";
                    break;
            }
            Console.WriteLine(dia);
        }
        static void video15()
        {
            //Video 15 - While Loop.
            int index = 1;
            while(index < 10)
            {
                Console.WriteLine(index);
                index++;
            }
            do
            {
                //ejecuta el while por lo menos 1 vez
            } while (index < 10);
        }
        static void video16()
        {
            //Video 16 - Integra conocimientos de videos anteriores.
        }
        static void video17()
        {
            int[] LuckyNumbers = { 1, 2, 3, 4, 5, 6 };
            //Video 17 - Bucle For
            for (int i = 0; i < LuckyNumbers.Length; i++)
            {
                Console.WriteLine(LuckyNumbers[i]);
            }
        }
        static void video18()
        {
            //Video 18 - Crear funcion potencia aplicando Bucle For--
        }
        static void video19()
        {
            //Video 19 - Arreglos en 2 dimensiones
            //definicion arreglo de enteros de 2 dimensiones
            //definicion con asignacion.
            int[,] arrayNumeros = { { 0, 1 }, { 2, 3 }, { 4, 5 } };
            //definicion sin asignacion (indicar tamaño de arreglo a reservar en memoria
            int[,] arrayNumeros2 = new int[2, 3]; //indico que la matriz tiene 2 filas y 3 columnas
            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(arrayNumeros[i, j]);
                }
            }            

        }
        static void video20()
        {
            //Video 20 - Uso de comentarios...
        }
        static void video21()
        {
            //Manejo de Excepciones
            /*
            --Codificar dentro de try el codigo suceptible a una excepcion
            --Colocar un sentencia catch para cada tipo de excepcion a manejar
            */
            try
            {
                Console.WriteLine("Enter a Number: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another Number: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException d)
            {
                Console.WriteLine(d.Message);
                //throw;
            }
            catch(FormatException f)
            {
                Console.WriteLine(f.Message);
                //throw;
            }
            finally
            {
                //aca se codifica lo que se ejecuta despues, indistintamente si ocurre o no, una excepcion
            }

        }
        static void video22()
        {
            //Video 22 - Clases y Objetos
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;
            Console.WriteLine(book1.pages);
        }
        static void video23()
        {
            //Video 23 - Constructores
            //Tomado de Video 22 - Clases y Objetos
            Book book1 = new Book("Harry Potter", "JK Rowling",400);
            Console.WriteLine(book1.title);

        }
        static void video24()
        {
            //Video 24 - Metodos de Objetos
            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);
            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
        }
        static void video25()
        {
            //Video 25 - Getters & Setters
            Movie avengers = new Movie("The Avengers", "Joss Wheon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            // G - PG - PG13 - R - NR
            Console.WriteLine(avengers.Rating);

        }
        static void video26()
        {
            //Video 26 - Static Class Atributes ... atributos estaticos o atributos de clase... acceden desde clase.atClase
            // atributos de instancia es objeto.atObjeto
            Song holyday = new Song("Holiday", "Grrenday", 200);
            Console.WriteLine(holyday.title);
            //acceder al atributo desde la clase
            Console.WriteLine(Song.songCount);
            //acceder al atributo desde cualquier objeto
            Console.WriteLine(holyday.getSongCount());
            Song kashmir = new Song("Kashmir", "Led Zepelin", 150);
            Console.WriteLine(kashmir.title);
            Console.WriteLine(Song.songCount);

        }
        static void video27()
        {
            //Video 27 - Static Methods and Classes ... Metodos de clase... llamados por objetos o la clase misma
            //se usa para crear una clase con metodos generales o funciones y no para metodos para un objeto en particular.
            Console.WriteLine(Math.Sqrt(144));
            UsefulTools.SayHi("Eduardo");
        }
        static void video28()
        {
            //Video 28 - Inheritance ... Herencia.
            Chef chef = new Chef();
            chef.MakeChicken();
            
            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChicken();

        }

    }
}
