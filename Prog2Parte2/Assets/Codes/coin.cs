using UnityEngine;

public class coin : MonoBehaviour
{
    public int coinValue = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Comunicación dinámica: buscamos si el objeto tiene PlayerStats
        PlayerStats stats = collision.GetComponent<PlayerStats>();

        if (stats != null) // Si no es nulo, significa que es el jugador
        {
            stats.AddCoin(coinValue);
            Destroy(gameObject); // Destruimos la moneda tras recogerla
        }
    }
}
