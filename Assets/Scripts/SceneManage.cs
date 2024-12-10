using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    public GameObject MenuButton;
    public void LoadGame()
    {
        SceneManager.LoadScene("Fight");
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
