using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dry : MonoBehaviour
{
    public bool isCatch = false;

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("colidiu com "+ col.tag);
        if (col.tag == "Can" && !isCatch)
        {
            isCatch = true;
            col.GetComponent<Can>().score = col.GetComponent<Can>().score + 1;
            Destroy(this.gameObject);
        }
        else if (col.tag == "Floor" && !isCatch)
        {
            isCatch = true;
            Destroy(this.gameObject);
        }

    }
}
