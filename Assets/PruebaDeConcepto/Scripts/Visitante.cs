using UnityEngine;

namespace UnnamedTowerDefense.PruebaDeConcepto.Scripts
{
    public class Visitante : MonoBehaviour
    {
        private Nodo _nodo;

        [SerializeField]
        private float _velocidad = 2f;

        public void SetNodo(Nodo nodoInicial)
        {
            _nodo = nodoInicial;
        }

        private void Update()
        {
            if (_nodo == null) return;

            if (EnNodo())
            {
                _nodo.Visitar(this);
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, _nodo.transform.position, _velocidad * Time.deltaTime);
            }

        }

        private bool EnNodo()
        {
            float distanciaAlNodo = Vector2.Distance(transform.position, _nodo.transform.position);
            return Mathf.Approximately(distanciaAlNodo, 0f);
        }
    }
}

