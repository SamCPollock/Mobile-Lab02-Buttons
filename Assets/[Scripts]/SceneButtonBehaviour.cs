using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButtonBehaviour : MonoBehaviour
{
    [SerializeField]
    string sceneName;

    public void OnStartButtonPressed()
    {
        SceneManager.LoadScene(sceneName);
    }


    public void OnNextButtonPressed()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OnBackButtonPressed()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}
