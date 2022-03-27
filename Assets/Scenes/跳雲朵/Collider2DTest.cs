using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider2DTest : MonoBehaviour
{
    public GameObject cat;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "cloud")
        {
            col.GetComponent<Collider2D>().enabled = false;
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "cloud")
        {
            col.GetComponent<Collider2D>().enabled = true;
        }
    }
}
