using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Objectives")]
public class Objective : ScriptableObject
{
    [SerializeField] string Name;
    public int MaxValue;
    public int StartValue;
    public int ActualValue;
    public bool IsFinished;
    public string CollectibleType;
}
