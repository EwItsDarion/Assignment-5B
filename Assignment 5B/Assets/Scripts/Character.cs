/*
		 * Darion Jeffries
		 * Character.cs
		 * Assignment 6
		 * Overrided Character from Target class. When character dies, reload scene
		 */
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Character : Target
{
    public override void TakeDamage(float amount)
    {
        health -= amount;

        if (health <= 0)
        {
            Die();
        }
    }

    public override void Die()
    {
        print("test");
        Destroy(gameObject);
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
}
