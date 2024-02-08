using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scorer : MonoBehaviour
{
    [SerializeField] ParticleSystem celebration;
    bool hasChildren = true;

    void Update()
    {
        if (!hasChildren)
        {
            return;
        }

        if (transform.childCount == 0)
        {
            celebration.Play();
            hasChildren = false;

            StartCoroutine("ResetGame");
        }
    }

    private IEnumerator ResetGame()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Main Game");

    }

}
