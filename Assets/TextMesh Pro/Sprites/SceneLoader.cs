using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{

    public Image prgrssbar;

    private static SceneLoader sceneload;
    private AsyncOperation loadingScene;
    private Animator animtr;
    private static bool sceneStart = false;

    public static void StartScene(string name)
    {
        sceneload.animtr.SetTrigger("SceneLoad");

        sceneload.loadingScene = SceneManager.LoadSceneAsync(name);
        sceneload.loadingScene.allowSceneActivation = false;


    }


    void Start()
    {
        sceneload = this;
        animtr = GetComponent<Animator>();

        if (sceneStart)
        {
            animtr.SetTrigger("SceneStart");
        }
    }

    void Update()
    {
        if (loadingScene != null) { 

            prgrssbar.fillAmount = loadingScene.progress;
        }
    }
    void onAnimOver()
    {
        sceneStart = true;
        loadingScene.allowSceneActivation = true;
    }
}
