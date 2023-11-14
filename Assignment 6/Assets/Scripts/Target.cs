/*
		 * Darion Jeffries
		 * Target.cs
		 * Assignment 6
		 * Adds health to the target. When health reaches 0, the target is destroyed.
		 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IDestructable
{
    void TakeDamage(float amount);
    void Die();
}

public class Target : MonoBehaviour, IDestructable
{
    public float health = 100f;
    public bool imposter = false;
    public virtual void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

    public virtual void Die()
    {
        Destroy(gameObject);
    }
    // Start is called before the first frame update
}
