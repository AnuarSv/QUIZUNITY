using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenus : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;

    void Start()
    {
        ShowPanel1();
    }

    public void ShowPanel1()
    {
        panel1.SetActive(true);
        panel2.SetActive(false);
    }

    public void ShowPanel2()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
    }

    public void lvl1()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void lvl2()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void lvl3()
    {
        SceneManager.LoadSceneAsync(3);
    }
    public void exit()
    {
        Application.Quit();
    }
    public void back()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
