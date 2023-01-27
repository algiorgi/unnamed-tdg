using UnityEditor;
using UnityEngine;

namespace UnnamedTowerDefense.PruebaDeConcepto.Scripts
{
    public class AdministradorDeNodos : MonoBehaviour
    {
        [SerializeField]
        private Nodo[] nodos;

        private void OnDrawGizmos()
        {
            DibujarNodos(nodos[0]);
        }

        private void DibujarNodos(Nodo nodo) {

            Gizmos.color = Color.green;
            Vector2 posicion = nodo.transform.position;
            Gizmos.DrawWireSphere(posicion, 0.5f);

            Vector2 offset = Vector2.up * 0.75f + Vector2.left * 0.75f;
            Handles.Label(posicion + offset, nodo.Tipo.ToString());

            Nodo siguiente = nodo.Siguiente;
            if (siguiente == null) return;

            Gizmos.DrawLine(posicion, siguiente.transform.position);
            DibujarNodos(siguiente);
        }
    }
}
