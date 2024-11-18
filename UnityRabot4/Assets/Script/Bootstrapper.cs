using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace Navigate
{
    public enum TypeResource { Uranium, Plutonium }

    public class Bootstrapper : MonoBehaviour
    {
        public GameObject[] button;
        //public enum typeResource { Uranium, Plutonium }
        private TypeResource typeResource;
        public TypeResource GetTypeResource { get { return typeResource; } }

        private static Bootstrapper instance;
        public static Bootstrapper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Bootstrapper();
                }

                return instance;
            }
        }
        private void Start()
        {
            

            button[0].GetComponent<ButtonResurs>().GetInfoType();
           // ServiceLoadTimeActiveRes.Instance.LoadTimeActiveRes();
        }
        private void CheckNumber()
        {

        }


    }
}