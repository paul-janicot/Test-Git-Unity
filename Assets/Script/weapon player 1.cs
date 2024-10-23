using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bullet;

    public KeyCode fireKey;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(fireKey))
        {
            Shoot();
        }
    }
    private void Shoot()
    {
        Debug.Log("coucou");
        Instantiate(bullet, firepoint.position, firepoint.rotation);
    }
}
