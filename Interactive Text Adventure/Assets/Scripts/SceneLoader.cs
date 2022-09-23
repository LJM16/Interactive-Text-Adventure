using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadTownScene()
    {
        SceneManager.LoadScene(4);
    }


    public void LoadforestScene()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadContinueInCave()
    {
        SceneManager.LoadScene(5);
    }

    public void LoadGameOverForest1()
    {
        SceneManager.LoadScene(6);
    }

    public void LoadCaveExit()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadGameOverTown()
    {
        SceneManager.LoadScene(7);
    }

    public void LoadTownContinuation()
    {
        SceneManager.LoadScene(8);
    }

    public void LoadYouDie()
    {
        SceneManager.LoadScene(9);
    }

    public void LoadGreenWater()
    {
        SceneManager.LoadScene(10);
    }

    public void LoadClearWater()
    {
        SceneManager.LoadScene(11);
    }

    public void LoadYouWin()
    {
        SceneManager.LoadScene(12);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
