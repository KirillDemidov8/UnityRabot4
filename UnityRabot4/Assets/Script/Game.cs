using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private GameObject panelGameOver;
    [SerializeField] private Timer timer;
    private void Start()
    {
       StartCoroutine(timer.StartTimer());  
        //panelGameOver.SetActive(true);
       
    }


    public static Game Instance
    {
        get
        {
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }
    static private Game _instance;

    public void GameOver()
    {
       
       panelGameOver.SetActive(true);
    }
}
