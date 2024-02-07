using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class win : MonoBehaviour
{

    [SerializeField] private GameObject _winPanel;

    private void Awake()
    {
        _winPanel.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0;
        _winPanel.SetActive(true);
        Debug.Log("win!");
    }

}
