using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    
   public void Restart()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
