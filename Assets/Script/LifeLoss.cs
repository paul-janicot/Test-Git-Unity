using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lifeloss : MonoBehaviour

{
    public List<GameObject> hearts = new List<GameObject>();
    public int life = 5;
    // Start is called before the first frame update
    void Start()
    {
        UpdateLife();
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
    public void lifeloss(int perte)
    {
        life -= perte;
        UpdateLife();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Attack2"))
        {
            lifeloss(1);
        }
    }

}
