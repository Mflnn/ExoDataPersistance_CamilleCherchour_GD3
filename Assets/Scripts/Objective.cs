using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Objectives")]
public class Objective : ScriptableObject
{
    [SerializeField] string Name;
    [SerializeField] int MaxValue;
    [SerializeField] int StartValue;
    [SerializeField] int ActualValue;
    [SerializeField] bool IsFinished;
    [SerializeField] string CollectibleType;
}
