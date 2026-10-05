using UnityEngine;

public class Shooting : MonoBehaviour
{
    public int damage;
    public float timeBetweenShooting, range;
    public int bulletsPerTap;
    int bulletsShot;

    bool shooting, readyToShoot;

    public Camera fpsCam;
    public Transform attackPoint;
    public RaycastHit rayHit;
    public LayerMask whatIsEnemy;
    public bool allowInvoke = true;


    private void Update()
    {
        MyInput();
    }
    private void MyInput()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }

        if (readyToShoot && shooting && allowInvoke)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out rayHit, range, whatIsEnemy))
        {
            Debug.Log(rayHit.collider.name);
            if (rayHit.collider.CompareTag("Grid"))
            {
                rayHit.collider.GetComponent<Damage>().TakeDamage(damage);
            }
        }
    }
}
