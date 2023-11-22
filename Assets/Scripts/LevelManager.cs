using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private UIQuest _uiQuest;
    [SerializeField] private Quest _questData;


    private void Start()
    {
     if (_questData.IsStarted == true)
        {
            _uiQuest.ShowQuestUI();
        }
    }
}
