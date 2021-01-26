//
//
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    
    public Image LoadingProgressBar;

    private static SceneLoader instance;
    private static bool shouldPlayOpeningAnimation = false;

    private Animator componentAnimator;
    //private AsyncOperation loadingSceneOperation;
    private string sname;
    public static void StartScene(string sceneName)
    {
        instance.componentAnimator.SetTrigger("SceneLoad");
        //SceneManager.LoadSceneAsync(sceneName);

        // Чтобы сцена не начала переключаться пока играет анимация closing:
        //instance.loadingSceneOperation.allowSceneActivation = false;

        instance.sname = sceneName;
        instance.LoadingProgressBar.fillAmount = 0;
    }

    private void Start()
    {
        instance = this;

        componentAnimator = GetComponent<Animator>();

        if (shouldPlayOpeningAnimation)
        {
            componentAnimator.SetTrigger("SceneStart");
            instance.LoadingProgressBar.fillAmount = 1;

            // Чтобы если следующий переход будет обычным SceneManager.LoadScene, не проигрывать анимацию opening:
            shouldPlayOpeningAnimation = false;
            LoadingProgressBar.enabled = false;
        }
    }

    private void Update()
    {
        //if (loadingSceneOperation != null)
        //{

            // Просто присвоить прогресс:
            //LoadingProgressBar.fillAmount = loadingSceneOperation.progress; 

            // Присвоить прогресс с быстрой анимацией, чтобы ощущалось плавнее:
            //LoadingProgressBar.fillAmount = Mathf.Lerp(LoadingProgressBar.fillAmount, loadingSceneOperation.progress,
            //Time.deltaTime * 5);
        //}
    }

    public void onAnimOver()
    {
        // Чтобы при открытии сцены, куда мы переключаемся, проигралась анимация opening:
        shouldPlayOpeningAnimation = true;
        SceneManager.LoadScene(sname);
        //loadingSceneOperation.allowSceneActivation = true;
    }
}