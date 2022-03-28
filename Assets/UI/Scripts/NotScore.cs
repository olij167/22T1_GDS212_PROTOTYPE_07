using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class NotScore : ScriptableObject
{
    [SerializeField]
    private float _value1;

    public float Value1
    {
        get { return _value1; }
        set { _value1 = value; }
    }

}
