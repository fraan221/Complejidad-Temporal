public class Estrategia
{
    private List<NodoArbol> mejorEstrategiaGlobal;
    private double mejorTiempoGlobal;

    public List<NodoArbol> mejorEstrategia(NodoArbol raiz)
    {
        this.mejorEstrategiaGlobal = new List<NodoArbol>();
        this.mejorTiempoGlobal = double.MaxValue;

        foreach (var nodoHijo in raiz.getHijos())
        {
            List<NodoArbol> rutaActual = new List<NodoArbol>();

            buscarEstrategiaRecursivo(nodoHijo, rutaActual, 0);
        }

        return this.mejorEstrategiaGlobal;
    }

    private void buscarEstrategiaRecursivo(NodoArbol nodoActual, List<NodoArbol> rutaAnterior, double tiempoAnterior)
    {
        List<NodoArbol> nuevaRuta = new List<NodoArbol>(rutaAnterior);
        nuevaRuta.Add(nodoActual);

        double tiempoActual = tiempoAnterior + calcularTiempoNodo(nodoActual);
        if (nuevaRuta.Count > 1)
        {
            tiempoActual = tiempoActual + 10;
        }

        if (nodoActual.getHijos().Count == 0)
        {
            if (tiempoActual < this.mejorTiempoGlobal)
            {
                this.mejorTiempoGlobal = tiempoActual;
                this.mejorEstrategiaGlobal = nuevaRuta;
            }
        }
        else
        {
            foreach (var nodoHijo in nodoActual.getHijos())
            {
                buscarEstrategiaRecursivo(nodoHijo, nuevaRuta, tiempoActual);
            }
        }
    }

    private double calcularTiempoNodo(NodoArbol nodo)
    {
        switch (nodo.getTipo())
        {
            case "Soft":
                return nodo.getCantDeVueltas() * 0.0;
            case "Med":
                return nodo.getCantDeVueltas() * 0.4;
            case "Hard":
                return nodo.getCantDeVueltas() * 0.7;
            default:
                return 0.0;
        }
    }
}