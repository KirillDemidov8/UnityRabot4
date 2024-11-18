using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ServiceLoadIcon : MonoBehaviour
{
    private static ServiceLoadIcon instance;
    public static ServiceLoadIcon Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new ServiceLoadIcon();
            }

            return instance;
        }
    }
    public void LoadIconActive(Image image)
    {
        image.color = Color.red;
    }
    public void LoadIconNotActive(Image image)
    {
        image.color = Color.green;
    }

}
