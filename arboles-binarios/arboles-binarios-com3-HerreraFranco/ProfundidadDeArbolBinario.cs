namespace arboles_binarios_com3_HerreraFranco
{
    internal class ProfundidadDeArbolBinario
    {
        private ArbolBinario<int> arbol;

        public ProfundidadDeArbolBinario(ArbolBinario<int> arbol)
        {
            this.arbol = arbol;
        }

        public int sumaElementosProfundidad(int p)
        {
            return sumaElementosProfundidad(this.arbol, p, 0);
        }

        private int sumaElementosProfundidad(ArbolBinario<int> nodo, int p, int profundidadActual)
        {
            if (nodo == null)
            {
                return 0;
            }

            if (profundidadActual == p)
            {
                return nodo.getDatoRaiz();
            }

            int sumaIzquierda = sumaElementosProfundidad(nodo.getHijoIzquierdo(), p, profundidadActual + 1);
            int sumaDerecha = sumaElementosProfundidad(nodo.getHijoDerecho(), p, profundidadActual + 1);

            return sumaIzquierda + sumaDerecha;
        }
    }
}