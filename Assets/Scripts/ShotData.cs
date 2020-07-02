using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Shot Data", menuName = "Shot Data", order = 51)]
public class ShotData : ScriptableObject
{
    [SerializeField]
    private int force;

    public int Forse
    {
        get
        {
            return force;
        }
    }
}
