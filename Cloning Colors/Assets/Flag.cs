using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Flag : MonoBehaviour
{

    private Coin[] allCoins;

    private void Start()
    {
        AllCoinsArrayUpdate();
    }
    private void Update()
    {
        AllCoinsArrayUpdate();
    }

    private void AllCoinsArrayUpdate()
    {
        allCoins = FindObjectsOfType<Coin>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            if(!collision.GetComponent<ColorChanger>().IsSameColor(gameObject)) {
                return;
            }

            if (allCoins.Length == 0)
            {
                Debug.Log("win");
            }
        }
    }

}
