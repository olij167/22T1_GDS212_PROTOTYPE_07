using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]

public class Questions : ScriptableObject
{
    [SerializeField]
    private int _value2;

    public int Value2
    {
        get { return _value2; }
        set { _value2 = value; }
    }
}
