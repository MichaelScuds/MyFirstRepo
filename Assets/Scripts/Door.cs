using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "KeyItem")
        {
            //Destroy(GetComponent<Rigidbody>());
            Object.Destroy(this.gameObject);
            Object.Destroy(other.gameObject);
        }
    }
}
