/*
		 * Darion Jeffries
		 * ShootWithRaycasts.cs
		 * Assignment 5B
		 * Creates a raycast that shoots a target and makes it take damage.
		 */

using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using UnityEngine;
using UnityEngine.UI;

public class ShootWithRaycasts : MonoBehaviour
{
    public Camera cam;
    public float damage = 10f;
    public float range = 100f;
    public ParticleSystem muzzleFlash;
    public float hitForce = 10f;
    public Text text;
    private int imposterCount;

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

        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo, range))
        {
            Debug.Log(hitInfo.transform.gameObject.name);

            //Get the target script off the hit object

            Target target = hitInfo.transform.gameObject.GetComponent<Target> ();
            if(hitInfo.transform.CompareTag("Target"))
            {
                target.TakeDamage(damage);
            }

            if (hitInfo.transform.CompareTag("Imposter"))
            {
                target.TakeDamage(damage);
                text.text = "You win!";
            }
        }
    }
}
