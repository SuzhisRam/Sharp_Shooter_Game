using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    int initialHealth = 300;
    int currentHealth;

    void Start()
    {
        currentHealth = initialHealth;
    }

    void Update()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }
}
