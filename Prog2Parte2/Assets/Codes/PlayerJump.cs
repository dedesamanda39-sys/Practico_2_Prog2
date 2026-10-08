using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 10f;
    public Rigidbody2D rb;

    [Header("Deteccion de Suelo")]
    public Transform groundCheck;
    public LayerMask groundLayer;
    public float groundCheckRadius = 0.2f;

    [Header("Conexion de Animaciones")]
    [SerializeField] private PlayerAnimation myAnimations;

    private bool isGrounded;

    void Update()
    {
        // Chequear todo el tiempo si estamos tocando el suelo
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        // Misi�n 4 (Opci�n B): Avisarle al animador si estamos cayendo/en el aire
        if (myAnimations != null)
        {
            myAnimations.SetInAir(!isGrounded);
        }
    }

    // Esta funci�n es llamada desde el PlayerController
    public void TryJump()
    {
        if (isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);

            // Misi�n 4 (Opci�n A): Avisarle al animador que saltamos
            if (myAnimations != null)
            {
                myAnimations.TriggerJump();
            }
        }
    }
}