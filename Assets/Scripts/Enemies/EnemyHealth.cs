using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] GameObject ExplosionVFX;
    [SerializeField] int startingHealth = 300;
    int currentHealth;

    void Awake()
    {
        currentHealth = startingHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }

    public void SelfDestruct()
    {
        Instantiate(ExplosionVFX, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    void Update()
    {
        if (currentHealth <= 0)
        {
            SelfDestruct();
        }
    }

    
}
