using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    // Aquí podrías tener tu referencia real al Animator:
    [SerializeField] private Animator anim;

        public void SetRunning(bool isWalking)
{
        // anim.SetBool("isWalking", isWalking);
        Debug.Log("Corriendo: " + isWalking);
}

// --- Funciones para la Misión 4 (Opcional) ---

// Opción A: Por Acción
public void TriggerJump()
{
    // anim.SetTrigger("jump");
    Debug.Log("¡Animación de salto disparada!");
}

// Opción B: Por Estado
public void SetInAir(bool inAir)
{
    // anim.SetBool("inAir", inAir);
}
    }
