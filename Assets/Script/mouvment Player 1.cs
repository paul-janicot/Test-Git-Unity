using System.Collections;
using System.Collections.Generic;
//using TreeEditor;
using UnityEngine;

public class mouvment : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpforce = 2;
    Rigidbody2D rb;
    Animator animator;
    SpriteRenderer sprite;
    public GameObject attackzone;
    public bool facingRight = true;

    public KeyCode moveRightKey;
    public KeyCode moveLeftKey;
    public KeyCode JumpKey;
    public KeyCode AttackKey;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(moveRightKey))
        {
            if (!facingRight)
            {
                transform.Rotate(0, 180f, 0);
                facingRight = true ;
            }
                
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            //attackzone.GetComponent<Collider2D>().offset = new Vector3(0, 0, 0);
        }
        else if (Input.GetKey(moveLeftKey))
        {
            
            if(facingRight) 
            {

                transform.Rotate(0, 180f, 0);
                facingRight = false;
            }
             
            //attackzone.GetComponent<Collider2D>().offset = new Vector3(-1.6f, 0, 0);
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKeyDown(JumpKey))
        {
            if (rb.velocity.y < 0.001 && rb.velocity.y > -0.001   )
             rb.velocity += new Vector2(0, jumpforce);
        }
        if (Input.GetKeyDown(AttackKey))
        {
            animator.SetTrigger("Attack");
        }




    }
}
