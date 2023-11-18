using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour,ICollectible
{
    public int _value;
    [SerializeField] ScoreDatas _scoreData;
    public string collectibleType;

    public void Collect()
    {
        _scoreData.UpdateScoreValue(_value);
        Destroy(gameObject);
    }
}
