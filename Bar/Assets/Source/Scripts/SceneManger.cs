using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManger : MonoBehaviour
{
   public void StratPressed()
   {

        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

}
