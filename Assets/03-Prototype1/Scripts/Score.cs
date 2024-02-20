using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using System;
using System.Threading;
using UnityEngine.SceneManagement;


public class Score : MonoBehaviour
{
    static public bool goalMet = false;

    async void OnTriggerEnter(Collider other)
    {
        // when the trigger is hit by something
        // check to see if it's a Projectile 
        if (other.gameObject.tag == "Projectile")
        {
            // if so, set goalMet = true
            Goal.goalMet = true;

            // also set the alpha of the color of higher opacity
            Material mat = GetComponent<Renderer>().material;
            Color c = mat.color;
            c.a = 1;
            mat.color = c;
            StartCoroutine(LoadSceneAfterDelay("Main-Prototype 1"));
        }
        
    }
    private IEnumerator LoadSceneAfterDelay(string sceneName)
    {
        
        yield return new WaitForSeconds(2f);

        
        SceneManager.LoadScene(sceneName);
    }
}