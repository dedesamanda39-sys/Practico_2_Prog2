using UnityEngine;

public class PlayerHeath : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("¡Has resivido daño! Vida restante: " + currentHealth);

        if (currentHealth <= 0)
        {
            Debug.Log("¡Has muerto!");
        }

    }
}
