using UnityEngine;
using StarterAssets;
using Unity.Cinemachine;
using TMPro;

public class ActiveWeapon : MonoBehaviour
{
    [SerializeField] WeaponSO startingWeaponSO;
    #pragma warning disable CS0618  
    [SerializeField] CinemachineVirtualCamera playerFollowCamera;
    #pragma warning restore CS0618
    [SerializeField] Camera weaponCamera;
    [SerializeField] GameObject zoomVignette;
    [SerializeField] TMP_Text ammoText;
    
    WeaponSO currentWeaponSO;
    Animator animator;
    StarterAssetsInputs starterAssetsInputs;
    FirstPersonController firstPersonController;
    Weapon currentWeapon;

    const string SHOOT_STRING = "Shoot";
    float shootTimer = 0f;
    float defaultZoom;
    float defaultRotationSpeed;
    int currentAmmo;

    void Awake()
    {
        starterAssetsInputs = GetComponentInParent<StarterAssetsInputs>();
        firstPersonController = GetComponentInParent<FirstPersonController>();
        animator = GetComponent<Animator>();
        
        defaultZoom = playerFollowCamera.m_Lens.FieldOfView;
        defaultRotationSpeed = firstPersonController.RotationSpeed;
    }

    void Start()
    {
        SwitchWeapon(startingWeaponSO);
        AdjustAmmo(currentWeaponSO.MagazineSize);
    }

    void Update()
    {
        HandleShoot();
        HandleZoom();
    }

    public void AdjustAmmo(int amount)
    {
        currentAmmo += amount;

        if (currentAmmo > currentWeaponSO.MagazineSize)
        {
            currentAmmo = currentWeaponSO.MagazineSize;
        } 

        ammoText.text = currentAmmo.ToString("D2");
    }

    public void SwitchWeapon(WeaponSO weaponSO)
    {
        if(currentWeapon)
        {
            Destroy(currentWeapon.gameObject);
        }

        Weapon newWeapon = Instantiate(weaponSO.WeaponPrefab, transform).GetComponent<Weapon>();
        currentWeapon = newWeapon;
        this.currentWeaponSO = weaponSO;
        AdjustAmmo(currentWeaponSO.MagazineSize);
    }

    void HandleShoot()
    {
        shootTimer = shootTimer + Time.deltaTime;
        if (!starterAssetsInputs.shoot) return;

        if  (shootTimer >= currentWeaponSO.FireRate && currentAmmo > 0)
        {
            currentWeapon.Shoot(currentWeaponSO);
            animator.Play(SHOOT_STRING, 0, 0f);
            shootTimer = 0f;
            AdjustAmmo(-1);
        }
        

        if (!currentWeaponSO.IsAutomatic)
        {
            starterAssetsInputs.ShootImput(false);
        }
    }

    void HandleZoom()
    {
        if (!currentWeaponSO.CanZoom) return;

        if (starterAssetsInputs.zoom)
        {
            playerFollowCamera.m_Lens.FieldOfView = currentWeaponSO.ZoomAmount;
            weaponCamera.fieldOfView = currentWeaponSO.ZoomAmount;
            firstPersonController.ChangeRotationSpeed(currentWeaponSO.ZoomRotationSpeed);
            zoomVignette.SetActive(true);
        } else
        {
            playerFollowCamera.m_Lens.FieldOfView = defaultZoom;
            weaponCamera.fieldOfView = defaultZoom;
            firstPersonController.ChangeRotationSpeed(defaultRotationSpeed);
            zoomVignette.SetActive(false);
        }
    }
}
