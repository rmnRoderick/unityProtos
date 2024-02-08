using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exploder : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystem;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            print("Aww, you got me");
            _particleSystem.transform.parent = null;
            _particleSystem.Play();
            Destroy(gameObject);
        }
    }


}
