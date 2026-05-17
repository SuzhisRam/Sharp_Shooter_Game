using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] GameObject ExplosionVFX;
    [SerializeField] int startingHealth = 300;
    int currentHealth;

    GameManager gameManager;

    void Awake()
    {
        currentHealth = startingHealth;
    }

    void Start()
    {
        #pragma warning disable CS0618
        gameManager = FindFirstObjectByType<GameManager>();
        #pragma warning restore CS0618
        gameManager.AdjustEnemiesLeft(1);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            SelfDestruct();
        }
    }

    public void SelfDestruct()
    {
        Instantiate(ExplosionVFX, transform.position, Quaternion.identity);
        gameManager.AdjustEnemiesLeft(-1);
        Destroy(gameObject);
    }  
}
