using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;

    [Header("Conexi�n con otros Scripts")]
    [SerializeField] private PlayerAnimation myAnimations;
    [SerializeField] private PlayerJump myJump;

    private float moveInput;

    void Update()
    {
        //Leer Inputs
        moveInput = Input.GetAxisRaw("Horizontal");

        //Mover el Rigidbody2D (manteniendo la velocidad Y intacta)
        rb.linearVelocity = new Vector2(moveInput * speed, rb.linearVelocity.y);

        //Reto de Rotaci�n (Voltear el personaje)
        if (moveInput > 0)
        {
            transform.localScale = new Vector3(1, 1, 1); // Mira a la derecha
        }
        else if (moveInput < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1); // Mira a la izquierda
        }

        //Controlar la animaci�n de correr
        bool isWalking = moveInput != 0; // Verdadero si nos estamos moviendo
        if (myAnimations != null)
        {
            myAnimations.SetRunning(isWalking);
        }

        //Llamar al salto desde el cerebro
        if (Input.GetKeyDown(KeyCode.Space) && myJump != null)
        {
            myJump.TryJump();
        }
    }
}