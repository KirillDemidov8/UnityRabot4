using Navigate;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ServiceLoadTimeActiveRes : InfjTineActionResurs
{
    
    private static ServiceLoadTimeActiveRes instance;
    public static ServiceLoadTimeActiveRes Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new ServiceLoadTimeActiveRes();
            }

            return instance;
        }
    }
    
    public Resurs LoadTimeActiveRes(TypeResource tr )
    {
        int j  = 0;
        foreach (TypeResource e in Enum.GetValues(typeof(TypeResource)))
        {
            //Debug.Log(e + " = " + (int)e);
            if( e == tr )
            {
                j = (int)e; break;
            }
        }

        string s = "Uranium";
        //Debug.Log(resurs[0].timeDisintegration);
        return resurs[j];
    }
    

}
