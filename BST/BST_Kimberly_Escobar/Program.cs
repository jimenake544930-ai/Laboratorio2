namespace BST
{
    public class Nodo
    {
        public int Valor;
        public Nodo Izq;
        public Nodo Der;

        public Nodo(int valor)
        {
            Valor = valor;
            Izq = null;
            Der = null;
        }
    }

    public class Arbol
    {
        public Nodo Raiz;

        public Arbol()
        {
            Raiz = null;
        }

        public bool Insertar(int valor)
        {
            if (Buscar(Raiz, valor))
                return false;

            Raiz = InsertarRec(Raiz, valor);
            return true;
        }

        private Nodo InsertarRec(Nodo actual, int valor)
        {
            if (actual == null)
                return new Nodo(valor);

            if (valor < actual.Valor)
            {
                actual.Izq = InsertarRec(actual.Izq, valor);
            }
            else
            {
                actual.Der = InsertarRec(actual.Der, valor);
            }

            return actual;
        }

        public bool Buscar(Nodo actual, int valor)
        {
            if (actual == null)
                return false;

            if (actual.Valor == valor)
                return true;

            if (valor < actual.Valor)
                return Buscar(actual.Izq, valor);
            else
                return Buscar(actual.Der, valor);
        }

        public void Inorden(Nodo actual)
        {
            if (actual != null)
            {
                Inorden(actual.Izq);
                Console.Write($"{actual.Valor} ");
                Inorden(actual.Der);
            }
        }

        public void Preorden(Nodo actual)
        {
            if (actual != null)
            {
                Console.Write($"{actual.Valor} ");
                Preorden(actual.Izq);
                Preorden(actual.Der);
            }
        }

        public void Postorden(Nodo actual)
        {
            if (actual != null)
            {
                Postorden(actual.Izq);
                Postorden(actual.Der);
                Console.Write($"{actual.Valor} ");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Arbol arbol = new Arbol();
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\nSeleccione una opcion:");
                Console.WriteLine("1. Insertar nodo");
                Console.WriteLine("2. Buscar Nodo");
                Console.WriteLine("3. Recorrido Inorden");
                Console.WriteLine("4. Recorrido Preorden");
                Console.WriteLine("5. Recorrido Postorden");
                Console.WriteLine("6. Salir");

                Console.Write("Seleccione una opcion: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el valor del nodo: ");
                        int valInsertar = Convert.ToInt32(Console.ReadLine());

                        if (arbol.Insertar(valInsertar))
                        {
                            Console.WriteLine("Valor insertado");
                        }
                        else
                        {
                            Console.WriteLine("Valor no insertado");
                        }
                        break;

                    case 2:
                        Console.Write("Ingrese el nodo a buscar: ");
                        int valBuscar = Convert.ToInt32(Console.ReadLine());

                        if (arbol.Buscar(arbol.Raiz, valBuscar))
                        {
                            Console.WriteLine("Valor encontrado");
                        }
                        else
                        {
                            Console.WriteLine("Valor no encontrado");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Recorrido Inorden:");

                        if (arbol.Raiz == null)
                        {
                            Console.WriteLine("No existe");
                        }
                        else
                        {
                            arbol.Inorden(arbol.Raiz);
                        }
                        break;

                    case 4:
                        Console.WriteLine("Recorrido Preorden:");

                        if (arbol.Raiz == null)
                        {
                            Console.WriteLine("No existe");
                        }
                        else
                        {
                            arbol.Preorden(arbol.Raiz);
                        }
                        break;

                    case 5:
                        Console.WriteLine("Recorrido Postorden:");

                        if (arbol.Raiz == null)
                        {
                            Console.WriteLine("No existe");
                        }
                        else
                        {
                            arbol.Postorden(arbol.Raiz);
                        }
                        break;

                    case 6:
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
        }
    }
}