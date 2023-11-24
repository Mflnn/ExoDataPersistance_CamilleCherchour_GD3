using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    private int sceneNumber;
    public UIQuest uiQuest;
    public int scoreValueBronze;
    public int scoreValueIron;
    public int scoreValueGold;
    public Objective[] objectives;

    private void OnTriggerEnter(Collider other)
    {
        sceneNumber = SceneManager.GetActiveScene().buildIndex;
        scoreValueBronze = objectives[0].ActualValue;
        scoreValueIron = objectives[1].ActualValue;
        scoreValueGold = objectives[2].ActualValue;

        if (sceneNumber == 1)
        {
            SceneManager.LoadScene(2);
            Debug.Log(SceneManager.GetActiveScene().buildIndex);
        } else
        {
            SceneManager.LoadScene(1);
            Debug.Log(SceneManager.GetActiveScene().buildIndex);

            uiQuest.UpdateObjectiveUI(scoreValueBronze);
            uiQuest.UpdateObjectiveUI(scoreValueIron);
            uiQuest.UpdateObjectiveUI(scoreValueGold);
        }
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);

        
    }



}
