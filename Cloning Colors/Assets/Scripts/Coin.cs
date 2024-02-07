using System.Collections;
using System.Collections.Generic;
using System.Net.WebSockets;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Coin : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<ColorChanger>().IsSameColor(gameObject))
        {
            Destroy(gameObject);
        }
    }

    

}
