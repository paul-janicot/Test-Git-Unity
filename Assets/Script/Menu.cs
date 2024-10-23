using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public bool isStart;
    public bool isQuit;
    public bool isMenu;
    // Start is called before the first frame update
    void Start()
    {
        if(isStart)
        {
            GetComponent<Button>().onClick.AddListener(Game);
        }
        else if (isQuit)
        {
            GetComponent<Button>().onClick.AddListener(Quit);
        }
        else if (isMenu)
        {
            GetComponent<Button>().onClick.AddListener(MenuGame);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Game()
    {
        SceneManager.LoadScene(1);
    }
    void Quit()
    {
        Application.Quit();
    }
    void MenuGame()
    {
        SceneManager.LoadScene(0);
    }
}
