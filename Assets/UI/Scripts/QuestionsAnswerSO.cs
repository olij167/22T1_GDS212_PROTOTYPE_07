using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]

public class QuestionsAnswerSO : ScriptableObject
{
    [SerializeField]
    private float _value2;

    public float Value2
    {
        get { return _value2; }
        set { _value2 = value; }
    }

}
