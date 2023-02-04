using UnityEngine;

namespace UnnamedTowerDefense.PruebaDeConcepto.Scripts
{
    public class Tienda : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log($"Llego a la tienda: {collision.tag}");
            Visitante visitante = collision.GetComponent<Visitante>();
            visitante.EnTienda();
        }
    }
}

