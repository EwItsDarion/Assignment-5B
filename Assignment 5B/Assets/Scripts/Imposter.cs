/*
		 * Darion Jeffries
		 * Imposter.cs
		 * Assignment 6
		 * Overridded Imposter, when the imposter is found and eliminated, you win and move onto next level.
		 */
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Imposter : Target
{
    public Text text;
    public override void Die()
    {

        UnityEngine.Debug.Log("You win!");
        base.Die();
        text.text = "You Win!";

    }
}