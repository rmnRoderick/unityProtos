using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class BulletTime : MonoBehaviour
{

    [SerializeField] private GameObject _pointLight;

    private void Awake()
    {
        _pointLight.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("Enemy"))
        {
            _pointLight.SetActive(true);
            Time.timeScale = .2f;
            StartCoroutine("StopBulletTime");
        }
    }

    private IEnumerator StopBulletTime()
    {
        yield return new WaitForSeconds(.8f);

        Time.timeScale = 1f;

        _pointLight.SetActive(false);

    }
}
