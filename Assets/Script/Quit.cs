using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
   public void GameOver()
    {
        Application.Quit();
        Debug.Log("작동오나료");
    }
}
