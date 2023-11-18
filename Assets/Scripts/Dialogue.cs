using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Dialogue")]
public class Dialogue : ScriptableObject
{
    public int SentenceIndex;
    public string LongSentence;
    public string ShortSentence;
    public string NomPersoActif;
    public bool IsEndingSentence;
    public int answer1;
    public int answer2;
}
