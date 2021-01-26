using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControls : MonoBehaviour
{
    public void StartPressed()
    {
        SceneLoader.StartScene("Level1");
    }

    public void ExitPressed()
    {
	Application.Quit();
	Debug.Log("Exit pressed!");
    }
}
