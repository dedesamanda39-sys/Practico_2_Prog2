using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int coins = 0;

    // Función pública para que otros scripts puedan modificar las monedas
    public void AddCoin(int amount)
    {
        coins += amount;
        Debug.Log("Monedas actuales: " + coins);
    }
}
