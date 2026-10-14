using Dominio;
namespace Obligatorio1_P2

{
    internal class Program
    {
        private static Sistema miSistema;
        static void Main(string[] args)
        {
            miSistema = new Sistema();

            string opcion = "";
            while (opcion != "5")
            {
                menuPrincipal();
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Casos");
                        Console.ReadKey();
                        break;
                    case "2":
                        //Console.Clear();
                        Console.WriteLine("Ingrese el email del investigador");
                        string email = Console.ReadLine();
                        BuscarCasosInvestigador(email);
                        Console.ReadKey();
                        break;
                    case "3":
                        AltaSospechoso();
                        Console.ReadKey();
                        break;
                    case "4":
                        ListarSospechososConAntecedentes();
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Fin del programa");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Ingrese una opción correcta");
                        break;
                }
            }

            static void menuPrincipal()
            {
                Console.Clear();
                Console.WriteLine(" MENU");
                Console.WriteLine();
                Console.WriteLine("1-Listado de casos");
                Console.WriteLine("2-Buscar investigador");
                Console.WriteLine("3-Agregar sospechoso");
                Console.WriteLine("4-Listar sospechosos con antecedentes");
                Console.WriteLine("5-Salir");
                Console.WriteLine();
                Console.WriteLine("Seleccione una opción");
            }

            static void BuscarCasosInvestigador(string email)
            {
                Console.Clear();
                foreach(Caso c in miSistema.Casos)
                {
                    if (c.Detective.Email == email)
                    {
                        Console.WriteLine($"ID: {c.Id}");
                        Console.WriteLine($"Nombre del caso: {c.Nombre}" );
                        Console.WriteLine($"Nombre investigador: {c.Detective.Nombre}");
                    }
                }
            }

            static void ListarSospechososConAntecedentes()
            {
                foreach(Sospechoso s in miSistema.Sospechosos)
                {
                    if(s.Antecedentes)
                    {
                        Console.WriteLine($"Nombre: {s.Nombre}");
                        Console.WriteLine($"CI: {s.CI}");
                        Console.WriteLine($"Fecha de nacimiento: {s.FechaNac:dd/MM/yyyy}");
                        Console.WriteLine($"Tiene antecedentes: {s.Antecedentes}");
                        Console.WriteLine();
                    }
                }
            }

            static void AltaSospechoso()
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("Ingrese el nombre del sospechoso");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese la CI del sospechoso");
                    int ci = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la fecha de nacimiento del sospechoso");
                    DateTime fechaNac;
                    if (!DateTime.TryParse(Console.ReadLine(), out fechaNac) || fechaNac>DateTime.Today) throw new Exception("La fecha no respeta el formato");
                    bool antecedentes = false;
                    Console.WriteLine("Ingrese 1 si el sospechoso tiene antecedentes");   
                    string resp = Console.ReadLine();
                    if(resp=="1")antecedentes = true;
                    Sospechoso s = new Sospechoso(nombre, ci, antecedentes, fechaNac);
                    //miSistema.AgregarSospechoso(s);
                }
                catch(Exception ex) 
                {

                }

            }

        }
    }
}
