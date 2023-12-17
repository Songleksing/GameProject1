using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("ชนแบบ OnTriggerEnter2D : ") + collision.gameObject.name);
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("ชน Enemy : ") + collision.gameObject.name);
        }
        if(collision.gameObject.tag == "Coin")
        {
            Debug.Log("ชน Coin : " + collision.gameObject.name);
        }
    }
}
