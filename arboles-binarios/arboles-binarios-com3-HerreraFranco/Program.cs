/*
 
    Implemente una clase C# llamada ProfundidadDeArbolBinario que tiene como 
    variable de instancia un árbol binario de números enteros y un método de instancia 
    sumaElementosProfundidad (int p):int el cuál devuelve la suma de todos los nodos 
    del árbol que se encuentren a la profundidad pasada como argumento.
 
 */

namespace arboles_binarios_com3_HerreraFranco
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolBinario<int> raiz = new ArbolBinario<int>(10);

            ArbolBinario<int> nodo5 = new ArbolBinario<int>(5);
            ArbolBinario<int> nodo20 = new ArbolBinario<int>(20);

            ArbolBinario<int> nodo3 = new ArbolBinario<int>(3);
            ArbolBinario<int> nodo8 = new ArbolBinario<int>(8);
            ArbolBinario<int> nodo15 = new ArbolBinario<int>(15);
            ArbolBinario<int> nodo25 = new ArbolBinario<int>(25);

            ArbolBinario<int> nodo7 = new ArbolBinario<int>(7);

            raiz.agregarHijoIzquierdo(nodo5);
            raiz.agregarHijoDerecho(nodo20);

            nodo5.agregarHijoIzquierdo(nodo3);
            nodo5.agregarHijoDerecho(nodo8);

            nodo20.agregarHijoIzquierdo(nodo15);
            nodo20.agregarHijoDerecho(nodo25);

            nodo8.agregarHijoIzquierdo(nodo7);

            ProfundidadDeArbolBinario profundidaDeArbol = new ProfundidadDeArbolBinario(raiz);

            // Prueba 1
            int profundidad0 = 0;
            int suma0 = profundidaDeArbol.sumaElementosProfundidad(profundidad0);
            Console.WriteLine($"La suma en profundidad {profundidad0} es: {suma0}"); // Resultado: 10

            // Prueba 2
            int profundidad1 = 1;
            int suma1 = profundidaDeArbol.sumaElementosProfundidad(profundidad1);
            Console.WriteLine($"La suma en profundidad {profundidad1} es: {suma1}"); // Resultado: 25

            // Prueba 3
            int profundidad2 = 2;
            int suma2 = profundidaDeArbol.sumaElementosProfundidad(profundidad2);
            Console.WriteLine($"La suma en profundidad {profundidad2} es: {suma2}"); // Resultado: 51

            // Prueba 5
            int profundidad3 = 3;
            int suma3 = profundidaDeArbol.sumaElementosProfundidad(profundidad3);
            Console.WriteLine($"La suma en profundidad {profundidad3} es: {suma3}"); // Resultado: 7

            // Prueba 6
            int profundidad4 = 4;
            int suma4 = profundidaDeArbol.sumaElementosProfundidad(profundidad4);
            Console.WriteLine($"La suma en profundidad {profundidad4} es: {suma4}"); // Resultado: 0
        }
    }
}
