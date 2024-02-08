using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Flag : MonoBehaviour
{

    [SerializeField] private Transform _winPanel;
    private Coin[] allCoins;

    private void Awake()
    {
        _winPanel.gameObject.SetActive(false);
    }

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
                _winPanel.gameObject.SetActive(true);
                Time.timeScale = 0f;
                Debug.Log("win");
            }
        }
    }

}
