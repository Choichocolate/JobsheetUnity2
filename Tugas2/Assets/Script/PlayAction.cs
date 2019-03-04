using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAction : MonoBehaviour
{
   public void PLAY_ACTION_GotoPage(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
