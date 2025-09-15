public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Iniciando cálculo de la mejor estrategia de neumáticos...");

        NodoArbol raiz = construirArbolDeEjemplo();

        Estrategia motorEstrategia = new Estrategia();
        List<NodoArbol> estrategiaGanadora = motorEstrategia.mejorEstrategia(raiz);

        imprimirEstrategia(estrategiaGanadora);
    }

    public static NodoArbol construirArbolDeEjemplo()
    {
        NodoArbol raiz = new NodoArbol();

        NodoArbol n10s = new NodoArbol(10, "Soft");
        NodoArbol n20h = new NodoArbol(20, "Hard");
        NodoArbol n35h = new NodoArbol(35, "Hard");

        raiz.agregarHijo(n10s);
        raiz.agregarHijo(n20h);
        raiz.agregarHijo(n35h);

        NodoArbol n10s_hijo = new NodoArbol(10, "Soft");
        NodoArbol n30h_hijo = new NodoArbol(30, "Hard");
        NodoArbol n15m_hijo = new NodoArbol(15, "Med");
        NodoArbol n15s_hijo = new NodoArbol(15, "Soft");

        n10s.agregarHijo(n10s_hijo);
        n20h.agregarHijo(n30h_hijo);
        n20h.agregarHijo(n15m_hijo);
        n35h.agregarHijo(n15s_hijo);

        NodoArbol n30h_nieto = new NodoArbol(30, "Hard");
        NodoArbol n15m_nieto = new NodoArbol(15, "Med");

        n10s_hijo.agregarHijo(n30h_nieto);
        n15m_hijo.agregarHijo(n15m_nieto);

        return raiz;
    }

    public static void imprimirEstrategia(List<NodoArbol> estrategia)
    {
        Console.WriteLine("\n--- Estrategia Óptima Encontrada ---");

        if (estrategia.Count == 0)
        {
            Console.WriteLine("No se encontró ninguna estrategia válida.");
            return;
        }

        double tiempoTotal = 0;
        for (int i = 0; i < estrategia.Count; i++)
        {
            NodoArbol parada = estrategia[i];
            Console.WriteLine("Parada " + (i + 1) + ": " + parada.getCantDeVueltas() + " vueltas con compuesto " + parada.getTipo());

            switch (parada.getTipo())
            {
                case "Soft":
                    tiempoTotal += parada.getCantDeVueltas() * 0.0;
                    break;
                case "Med":
                    tiempoTotal += parada.getCantDeVueltas() * 0.4;
                    break;
                case "Hard":
                    tiempoTotal += parada.getCantDeVueltas() * 0.7;
                    break;
            }

            if (i > 0)
            {
                tiempoTotal += 10;
            }
        }

        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Tiempo total de la estrategia: " + tiempoTotal);
    }
}