using UnityEngine;

namespace UnnamedTowerDefense.PruebaDeConcepto.Scripts
{
    public enum TipoDeNodo
    { 
        SALIDA,
        CAMINO,
        LLEGADA
    }

    public class Nodo : MonoBehaviour
    {
        [SerializeField]
        private Nodo _siguiente;
        public Nodo Siguiente => _siguiente;

        [SerializeField]
        private TipoDeNodo _tipoDeNodo;
        public TipoDeNodo Tipo => _tipoDeNodo;

        public void Visitar(Visitante visitador)
        {
            if (Tipo == TipoDeNodo.LLEGADA)
            {
                Destroy(visitador.gameObject);
            }
            else
            {
                visitador.SetNodo(_siguiente);
            }
        }
    }
}

