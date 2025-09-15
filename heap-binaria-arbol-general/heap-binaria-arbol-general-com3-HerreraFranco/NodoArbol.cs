using System.Collections.Generic;

public class NodoArbol
{
    private int cantDeVueltas;
    private string tipo;
    private List<NodoArbol> hijos;

    public NodoArbol(int cant, string t)
    {
        this.cantDeVueltas = cant;
        this.tipo = t;
        this.hijos = new List<NodoArbol>();
    }

    public NodoArbol()
    {
        this.cantDeVueltas = 0;
        this.tipo = "";
        this.hijos = new List<NodoArbol>();
    }

    public int getCantDeVueltas()
    {
        return this.cantDeVueltas;
    }

    public string getTipo()
    {
        return this.tipo;
    }

    public List<NodoArbol> getHijos()
    {
        return this.hijos;
    }

    public void agregarHijo(NodoArbol hijo)
    {
        this.hijos.Add(hijo);
    }
}