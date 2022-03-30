using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBR : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject About;
    public GameObject Help;

    // Start is called before the first frame update
    void Start()
    {
        MainMenu.SetActive(true);
        About.SetActive(false);
    }

    public void LoadScene (string namascene)
    {
        SceneManager.LoadScene(namascene);
    }

   public void aboutClick()
    {
        MainMenu.SetActive(false);
        About.SetActive(true);
    }

    public void HelpClick()
    {
        MainMenu.SetActive(false);
        Help.SetActive(true);
    }


    public void backClick()
    {
        MainMenu.SetActive(true);
        About.SetActive(false);
    }

    public void back1Click()
    {
        MainMenu.SetActive(true);
        Help.SetActive(false);
    }
  
    public void exit()
    {
        Application.Quit();
    }
}
