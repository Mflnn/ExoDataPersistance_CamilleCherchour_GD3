using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    private int sceneNumber;

    private void OnTriggerEnter(Collider other)
    {
        sceneNumber = SceneManager.GetActiveScene().buildIndex;
        if (sceneNumber == 1)
        {
            SceneManager.LoadScene(2);
            Debug.Log(SceneManager.GetActiveScene().buildIndex);
        } else
        {
            SceneManager.LoadScene(1);
            Debug.Log(SceneManager.GetActiveScene().buildIndex);
        }
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);

        
    }



}
