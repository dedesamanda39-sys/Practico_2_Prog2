using UnityEngine;

public class TurretShooting : MonoBehaviour
{
    [SerializeField] private GameObject ProyectilPrefeb;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float bullettSpreed = 6f;

    [SerializeField] private float fireRate = 5f;
    private float nextFireTime = 0f;

    void Update()
    {
        if (Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate;
        }
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(ProyectilPrefeb, firePoint.position, firePoint.rotation);

        Proyectil proj = bullet.GetComponent<Proyectil>();
        if (proj != null)
        {
            proj.tipoProyectil = "Enemy";
        }

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(-bullettSpreed, 0f);
    }

}
