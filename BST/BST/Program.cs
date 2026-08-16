namespace BST 
{
  public class Nodo
  {
    public int valor;
    public Nodo izq;
    public Nodo der;

    public Nodo(int valor){
        Valor = valor;
        izq = null;
        der = null;
    }
  }

  public class Arbol{
    public Nodo Raiz;

    public BST(){
        Raiz=null;
    }

    public bool Insertar(int valor){
        if (Buscar(Raiz, valor)) return false;
            Raiz = InsertarRec(Raiz, valor);
        return true;
    }

    private Nodo InsertarRec(Nodo actual, int valor){
        if (actual == null) return new Nodo(valor);

        if (valor < actual.Valor)
        actual.Izq = InsertarRec(actual.Izq, valor);
        else
        {
            actual.Der = InsertarRec.Der, valor
        }
        return actual;
    }

    public bool Nodo(Nodo actual, int valor){
        if (actual == null) return false;
        if(actual.Valor == valor) return true;
        if(valor < actual.Valor) return Buscar(actual.Izq, valor);
        else
         return Buscar(actual.Der, valor)
    }

    public void Inorden(Nodo actual){
        if (actual != null){
            Inorden(actual.Izq);
            Console.Write($"{actual.Valor}");
            Inorden(actual.Der);
        }
    }

    public void Preorden(Nodo actual){
        if (actual != null){
            Console.Write($"{actual.Valor}");
            Inorden(actual.Izq);
            Inorden(actual.Der);
        }
    }

    public void Postorden(Nodo actual){
        if (actual != null){
            Inorden(actual.Der);
            Inorden(actual.Izq);
            Console.Write($"{actual.Valor}");
        }
    }
  }

  class Program{
    static void Main(string[] args){
        Arbol  arbol = new Arbol();
        bool salir = false;
        while (!salir){
            Console.Write("Seleccione una opcion:")
            Console.Write("1. Insertar nodo")
            Console.Write("2. Buscar Nodo")
            Console.Write("3. Recorrido Inorden")
            Console.Write("4. Recorrido Preorden")
            Console.Write("5. Recorrido Postorden")
            Console.Write("\n Seleccione una opcion:")
            int opcion = Console.ReadLine();

            switch(opcion){
                case 1:
                    Console.Write("Ingrese el valor del nodo")
                    opcion2 = Console.ReadLine();
                    opcion2 = int valInsertar
                    if (arbol.Insertar(valInsertar)){
                        Console.Write("Valor insertardo")
                    }
                    else{
                        Console.Write("Valor no insertado")
                    }
                break;

                case 2:
                    Console.Write("Ingrese el nodo a buscar:")
                    opcion3 = Console.ReadLine();
                    opcion3 = int valBuscar;
                    if(arbol.Buscar(arbol.Raiz, valBuscar)){
                        Console.Write("Valor encontrado")
                    }
                    else{
                        Console.Write("Valor no encontrado")
                    }
                break;

                case 3:
                    Console.Write("Recorrido Inorden");
                    if(arbol.Raiz == null){
                        Console.Write("No existe");
                    }
                    else{
                        arbol.Inorden(arbol.Raiz);
                    }
                break;

                case 4:
                    Console.Write("Recorrido Preorden");
                    if(arbol.Raiz == null){
                        Console.Write("No existe");
                    }
                    else{
                        arbol.Preorden(arbol.Raiz);
                    }
                break;

                case 5:
                    Console.Write("Recorrido Postorden");
                    if(arbol.Raiz == null){
                        Console.Write("No existe");
                    }
                    else{
                        arbol.Postorden(arbol.Raiz);
                    }
                break;

                case 6:
                    salir = true;
                break;
            }
        }
    }
  }
}