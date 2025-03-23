using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Gun : MonoBehaviour
{
    public int damage;
    public int mag,bulletsLeft;
    public float range, ReloadTime;
    public bool HoldBotton;
    public bool readyToShoot;
    public bool reloading;
     public GameObject projectilePrefab; 
    public Transform shootPoint;         
    public float shootForce = 20f;


    public Camera camera;
    public attackPoint point;
    public LayerMask whatIsEnemy;

    //input system 
    private void Awake()
    {
        bulletsLeft = mag;
        readyToShoot = true;
    }
    void Update()
    {
        MyInput();
    }
    private void MyInput()
    {

        if(HoldBotton) shooting = input.GetKey(KeyCode.Mouse0);
        else shooting = input.GetKey(KeyCode.Mouse0);

        // defining reload
        if(Input.GetKeyDown(KeyCode.R) && bulletsLeft < mag && !reloading) reload();

        if(readyToShoot && shooting && !reloading) 
        {
            Debug.Log($"shooting and bullets left are {bulletsLeft}");
            shoot();
        }
    


    }
    
    private void reload()
    {
        // find a way to wait a few seconds 
       bulletsLeft = mag;
       Invoke("reload finished", ReloadTime);

    }
    private void shoot()
    {
        GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, shootPoint.rotation);
        
        
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(shootPoint.forward * shootForce, ForceMode.Impulse);
        }
    }

    // Update is called once per frame
    
}
