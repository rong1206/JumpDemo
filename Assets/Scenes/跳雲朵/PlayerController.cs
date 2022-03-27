using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Collider2D coll2D;


    //¸õÅD
    float jumpForce = 680.0f;
    //¥ª¥k²¾°Ê
    //float moveForce = 30.0f;

    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }
        //IgnoreLayer();
    }

    //private void OnTriggerEnter2D(Collider2D col)
    //{
    //    if (col.gameObject.tag == "cloud")
    //    {
    //        col.GetComponent<Collider>().enabled = false;
    //    }
    //}

    //private void OnTriggerExit2D(Collider2D col)
    //{
    //    if (col.gameObject.tag == "cloud")
    //    {
    //        col.GetComponent<Collider>().enabled = true;
    //    }
    //}

    //private void IgnoreLayer()
    //{
    // Physics2D.GetIgnoreLayerCollision(10, 10);
    //}
}
