using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class win : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {    
        Debug.Log("win!");
    }

}
