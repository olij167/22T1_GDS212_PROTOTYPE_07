using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class NotScoreSO : ScriptableObject
{
    [SerializeField]
    private int _value1;

    public int Value1
    {
        get { return _value1; }
        set { _value1 = value; }
    }

}
