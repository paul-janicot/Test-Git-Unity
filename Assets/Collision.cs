using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour

{
    public List<GameObject> hearts = new List<GameObject>();
    public int life = 6;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void UpdateLife()
    {

        for (int i = 0; i < life; i++)
        {
            hearts[i].SetActive(true);
        }
        for (int i = life; i < 5; i++)
        {
            hearts[i].SetActive(false);
        }
        if (life <= 0)
        {
            //pipou
        }
    }
}
