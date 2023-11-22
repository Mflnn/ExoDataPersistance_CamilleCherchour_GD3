using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ScoreDatas;

public class Collectible : MonoBehaviour,ICollectible
{
    public int _value;
    [SerializeField] ScoreDatas _scoreData;
    public string collectibleType;
    [SerializeField] Quest _questData;



    public void Collect()
    {
        _questData.UpdateObjective(this);
       

        Destroy(gameObject);
    }
}
