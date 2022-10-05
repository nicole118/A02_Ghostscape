using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public AudioClip shoot;
    private GameObject OrbPrefab;

    protected virtual void Start()
    {
        OrbPrefab = Resources.Load("weapon") as GameObject;
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            ShootOrb();
        }
    }

    private void ShootOrb()
    {
        Instantiate(OrbPrefab, firePoint.position, firePoint.rotation);
        SoundManagerScript.PlaySound();
    }
}
