using System.Collections;
using System.Collections.Generic;
using System.Net.WebSockets;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Coin : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<ColorChanger>().IsSameColor(gameObject))
        {
            Destroy(gameObject);
        }
        else
        {
            GoTransparent();
        }
    }

    private void GoTransparent()
    {
        var color = _spriteRenderer.color;
        color.a = 0.2f;
        _spriteRenderer.color = color;
    }
    private void GoOpaque()
    {
        var color = _spriteRenderer.color;
        color.a += 1 * Time.deltaTime;
        _spriteRenderer.color = color;
    }

    private void Update()
    {
        if (_spriteRenderer.color.a < 1)
        {
            GoOpaque();
        }
    }

}
