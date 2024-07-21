using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour {
    public void levelMain()
    {
        SceneManager.LoadScene("levelmain");
    }
    public void level2()
    {
        SceneManager.LoadScene("levelmain 1");
    }
    public void level3()
    {
        SceneManager.LoadScene("levelmain 2");
    }
    public void level4()
    {
        SceneManager.LoadScene("levelmain 3");
    }


    public void Menus()
    {
        SceneManager.LoadScene("Menus");
    }
    public void Menus2()
    {
        SceneManager.LoadScene("Menus 1");
    }
    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }
    public void Menus3()
    {
        SceneManager.LoadScene("Menus 2");
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("finish");
    }
}
