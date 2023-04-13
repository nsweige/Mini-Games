using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wet : MonoBehaviour
{
    public bool isCatch = false;

    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "Can" && !isCatch)
        {
            isCatch = true;
            if (col.GetComponent<Can>().canGetHit)
            {
                col.GetComponent<Can>().canGetHit = false;
                col.GetComponent<Can>().startBlink = true;
                col.GetComponent<Can>().lastHit = col.GetComponent<Can>().timer;
                col.GetComponent<Can>().life = col.GetComponent<Can>().life - 1;
            }
            Destroy(this.gameObject);
        }
        else if (col.tag == "Floor" && !isCatch)
        {
            isCatch = true;
            Destroy(this.gameObject);
        }

    }
}
