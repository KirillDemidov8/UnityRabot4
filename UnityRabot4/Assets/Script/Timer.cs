using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    int time = 0;   

   
    void Start()
    {
        
    }

   public IEnumerator StartTimer()
    {
       

        for (; ; )
        {
            yield return new WaitForSeconds(1);
            time++;
            timerText.text = time.ToString();

        }


    }
    
}
