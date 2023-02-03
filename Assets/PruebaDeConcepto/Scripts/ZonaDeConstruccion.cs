using UnityEngine;
using UnityEngine.EventSystems;

namespace UnnamedTowerDefense.PruebaDeConcepto.Scripts
{
    public class ZonaDeConstruccion : MonoBehaviour, IPointerDownHandler
    {
        [SerializeField]
        private GameObject _tiendaPrefab;

        public void OnPointerDown(PointerEventData eventData)
        {
            ConstruirTienda();
        }

        private void ConstruirTienda()
        {
            Instantiate(_tiendaPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}

