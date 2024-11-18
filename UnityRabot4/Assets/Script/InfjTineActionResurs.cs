using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfjTineActionResurs : ScriptableObject
{
    public Resurs[] resurs;
    private void Awake()
    {
        resurs = new Resurs[]
        {
            new Resurs(){ timeDisintegration = 2, timeEnrichment = 2},
        
        
            new Resurs(){ timeDisintegration = 5, timeEnrichment = 5}
        };

    }

}
