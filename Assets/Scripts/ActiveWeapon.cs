using UnityEngine;
using StarterAssets;

public class ActiveWeapon : MonoBehaviour
{
    [SerializeField] WeaponSO weaponSO;
    
    Animator animator;
    StarterAssetsInputs starterAssetsInputs;
    Weapon currentWeapon;

    const string SHOOT_STRING = "Shoot";
    float shootTimer = 0f;

    void Awake()
    {
        starterAssetsInputs = GetComponentInParent<StarterAssetsInputs>();
        animator = GetComponent<Animator>();
    }

    void Start()
    {
        currentWeapon = GetComponentInChildren<Weapon>();
    }

    void Update()
    {
        shootTimer = shootTimer + Time.deltaTime;
        if (starterAssetsInputs.shoot && shootTimer >= weaponSO.FireRate)
        {
            HandleShoot();
        }
        
    }

    void HandleShoot()
    {
        currentWeapon.Shoot(weaponSO);

        animator.Play(SHOOT_STRING, 0, 0f);
        starterAssetsInputs.ShootImput(false);
        shootTimer = 0f;
    }
}
