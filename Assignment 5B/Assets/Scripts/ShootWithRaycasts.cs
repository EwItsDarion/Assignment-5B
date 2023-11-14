/*
		 * Darion Jeffries
		 * ShootWithRaycasts.cs
		 * Assignment 6
		 * Creates a raycast that shoots a target and makes it take damage.
		 */

using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using UnityEngine;
using UnityEngine.UI;

public class ShootWithRaycasts : Target
{
    public Camera cam;
    public float damage = 10f;
    public float range = 100f;
    public ParticleSystem muzzleFlash;
    public float hitForce = 10f;
    public Text text;
    private int imposterCount;
    public AudioSource soundFx;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {

        muzzleFlash.Play();
        RaycastHit hitInfo;

        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo, range))
        {
            Debug.Log(hitInfo.transform.gameObject.name);



            Target target = hitInfo.transform.gameObject.GetComponent<Target>();
            if (hitInfo.transform.CompareTag("Target") || hitInfo.transform.CompareTag("Imposter"))
            {

                Character character = hitInfo.transform.gameObject.GetComponent<Character>();


                if (character != null)
                {

                    Player player = GetComponent<Player>();
                    if (hitInfo.transform.CompareTag("Target"))
                    {
                        print("test");
                        this.TakeDamage(damage);
                    }
                }


                target.TakeDamage(damage);


                if (hitInfo.transform.CompareTag("Imposter"))
                {
                    
                    soundFx.Play();

                }
            }
        }
    }
}

