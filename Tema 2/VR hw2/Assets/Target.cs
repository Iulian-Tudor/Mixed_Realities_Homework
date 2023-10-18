using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Target : MonoBehaviour
{
    public ScoreManager scoreManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Throwable")) // Make sure your thrown objects have this tag
        {

            scoreManager.IncreaseScore();

            Debug.Log("obj thrown");
        }
    }

}
