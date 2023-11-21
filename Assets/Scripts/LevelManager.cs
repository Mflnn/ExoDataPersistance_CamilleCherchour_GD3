using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private ScoreDatas _ScoreData;
    [SerializeField] private Quest _quete;

    private void Start()
    {
        _ScoreData.InitScoreValue(0);
        _quete.IsStarted = false;
        _quete.IsFinished = false;
    }
}
