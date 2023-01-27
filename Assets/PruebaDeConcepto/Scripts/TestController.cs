using UnityEngine;

namespace UnnamedTowerDefense.PruebaDeConcepto.Scripts
{
    public class TestController : MonoBehaviour
    {
        [SerializeField]
        private GameObject _visitantePrefab;
        [SerializeField]
        private Nodo _nodoInicio;

        private GameObject _visitanteInstancia;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.T) && _visitanteInstancia == null)
            {
                _visitanteInstancia = Instanciar();
            }

            if (Input.GetKeyDown(KeyCode.E) && _visitanteInstancia != null)
            {
                Destroy(_visitanteInstancia.gameObject);
                _visitanteInstancia = null;
            }
        }

        private GameObject Instanciar()
        { 
            GameObject go = Instantiate(_visitantePrefab, _nodoInicio.transform.position + Vector3.left * 2f, Quaternion.identity);
            go.GetComponent<Visitante>().SetNodo(_nodoInicio);
            return go;
        }
    }
}

