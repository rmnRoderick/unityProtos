using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Gem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            var myColor = gameObject.GetComponent<ColorChanger>().GetCurrentColor();
            collision.GetComponent<ColorChanger>().SetColor(myColor);
        }
    }

    
}
