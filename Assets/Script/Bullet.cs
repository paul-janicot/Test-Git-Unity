using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public bool player2;
    public GameObject impactEffect;
    GameObject effect;
    // Start is called before the first frame update
    void Start()
    {
        if (player2 == false)
        rb.velocity = transform.right * speed;
        else if(player2)
            rb.velocity = transform.right * -speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player 2"))
        {
            Lifeloss lifeloss = collision.GetComponent<Lifeloss>();
            if (lifeloss != null )
            {
                lifeloss.lifeloss(1);
            }

            
            
            
            
            StartCoroutine(impact());
            
        }
        else if(collision.gameObject.CompareTag("Player 1"))
        {
            Lifeloss lifeloss = collision.GetComponent<Lifeloss>();
            if (lifeloss != null)
            {
                lifeloss.lifeloss(1);
            }
            
            
           
            StartCoroutine(impact());
            
            
        }
        else if(collision.gameObject.CompareTag("wall"))
        {
            Destroy(gameObject);
        }
        
    }
    private IEnumerator impact()
    {
        
        effect = Instantiate(impactEffect, transform.position, transform.rotation);
        GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(0.05f);
        Destroy(effect);
        Destroy(gameObject);

        
        
    }
    
}
