using UnityEngine;

public class Proyectil : MonoBehaviour
{
    [SerializeField] private int damage = 10;
    [SerializeField] private float lifeTime = 3f;  // segundos antes de autodestruirse
    public string tipoProyectil = "Player";

    void Start()
    {
        // Red de seguridad: se destruye solo si no impacta nada antes
        Destroy(gameObject, lifeTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (tipoProyectil == "Enemy" && collision.CompareTag("Player"))
        {
            PlayerHeath playerheath = collision.GetComponent<PlayerHeath>();
            if (playerheath != null)
            {
                playerheath.TakeDamage(damage);
            }
            Destroy(gameObject);// Aquí delegamos el daño al script de vida del enemigo
        }
        else if (collision.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}