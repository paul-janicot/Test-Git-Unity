using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class mouvment : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpforce = 2;
    Rigidbody2D rigidbody;
    Animator animator;
    SpriteRenderer sprite;
    public GameObject attackzone;
    private bool facingRight = true;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            if (!facingRight)
            {
                transform.Rotate(0, 180f, 0);
                facingRight = true ;
            }
                
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            //attackzone.GetComponent<Collider2D>().offset = new Vector3(0, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            
            if(facingRight) 
            {

                transform.Rotate(0, 180f, 0);
                facingRight = false;
            }
             
            //attackzone.GetComponent<Collider2D>().offset = new Vector3(-1.6f, 0, 0);
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (rigidbody.velocity.y < 0.001 && rigidbody.velocity.y > -0.001   )
             rigidbody.velocity += new Vector2(0, jumpforce);
        }
        if (Input.GetKey(KeyCode.E))
        {
            animator.SetTrigger("Attack");
        }




    }
}
