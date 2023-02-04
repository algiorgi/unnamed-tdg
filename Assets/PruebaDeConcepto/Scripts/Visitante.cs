using UnityEngine;

namespace UnnamedTowerDefense.PruebaDeConcepto.Scripts
{
    public enum Estado
    { 
        CAMINANDO,
        EN_TIENDA
    }

    public class Visitante : MonoBehaviour
    {
        private Nodo _destino;
        private Estado _estado;
        private float _tiempoEnConsumir = 0f;
        private float _tiempoDeArribo;

        [SerializeField]
        private float _velocidad = 2f;

        private void Start()
        {
            _estado = Estado.CAMINANDO;
        }

        public void SetNodo(Nodo nodoInicial)
        {
            _destino = nodoInicial;
        }

        public void EnTienda()
        {
            _tiempoEnConsumir = 5f;
            _tiempoDeArribo = Time.time;
            _estado = Estado.EN_TIENDA;
        }

        private void Update()
        {
            if (_destino == null) return;

            if (_estado.Equals(Estado.CAMINANDO))
            {
                Caminar();
            }
            else if (_estado.Equals(Estado.EN_TIENDA))
            {
                Consumir();
            }
        }

        private void Caminar()
        {
            if (LlegoADestino())
            {
                _destino.Visitar(this);
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, _destino.transform.position, _velocidad * Time.deltaTime);
            }
        }

        private bool LlegoADestino()
        {
            float distanciaAlNodo = Vector2.Distance(transform.position, _destino.transform.position);
            return Mathf.Approximately(distanciaAlNodo, 0f);
        }

        private void Consumir()
        {
            if ((Time.time - _tiempoDeArribo) >= _tiempoEnConsumir)
            {
                _estado = Estado.CAMINANDO;
            }
        }
    }
}

