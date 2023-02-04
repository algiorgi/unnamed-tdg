using System.Collections.Generic;
using UnityEngine;

namespace UnnamedTowerDefense.PruebaDeConcepto.Scripts
{
    public class TestController : MonoBehaviour
    {
        [SerializeField]
        private GameObject _visitantePrefab;
        [SerializeField]
        private Nodo _nodoInicio;

        private Queue<GameObject> _visitantes;

        private void Awake()
        {
            _visitantes = new Queue<GameObject>();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                Instanciar();
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                Eliminar();
            }
        }

        private void Instanciar()
        { 
            GameObject go = Instantiate(_visitantePrefab, _nodoInicio.transform.position + Vector3.left * 2f, Quaternion.identity);
            go.GetComponent<Visitante>().SetNodo(_nodoInicio);
            _visitantes.Enqueue(go);
        }

        private void Eliminar()
        {
            if (_visitantes.Count > 0)
            {
                GameObject visitante = _visitantes.Dequeue();
                Destroy(visitante.gameObject);
            }
            else
            {
                Debug.Log("No existen instancias para eliminar");
            }
        }
    }
}

