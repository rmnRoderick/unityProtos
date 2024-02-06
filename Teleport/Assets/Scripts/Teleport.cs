using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// GameDev.tv Challenge Club. Got questions or want to share your nifty solution?
// Head over to - http://community.gamedev.tv

public class Teleport : MonoBehaviour
{
    [SerializeField] Transform[] teleportsTarget;
    [SerializeField] GameObject player;
    [SerializeField] Light areaLight;
    [SerializeField] Light mainWorldLight;

    private bool _used = false;

    void Start()
    {
        // CHALLENGE TIP: Make sure all relevant lights are turned off until you need them on
        // because, you know, that would look cool.
        areaLight.gameObject.SetActive(false);
        StartCoroutine("BlinkWorldLight");
    }

    void OnTriggerEnter(Collider other) 
    {
        // Challenge 2:
        TeleportPlayer();
        // Challenge 3:
        DeactivateObject();
        // Challenge 4:
        IlluminateArea();
        // Challenge 5:
        StartCoroutine ("BlinkWorldLight");
        // Challenge 6:
        //TeleportPlayerRandom();
    }

    void TeleportPlayer()
    {
        if(_used) return;

        var teleportTarget = GetRandomTeleport();
        var newPosition = teleportTarget.position;
        newPosition.y += 1f;

        player.transform.position = newPosition;
    }

    private Transform GetRandomTeleport()
    {
        var teleportIndex = Random.Range(0, teleportsTarget.Length);

        return teleportsTarget[teleportIndex];
    }

    void DeactivateObject()
    {
       // code goes here
       _used = true;
    }

    void IlluminateArea()
    {
       // code goes here 
       areaLight.gameObject.SetActive(true);
    }

    IEnumerator BlinkWorldLight()
    {
        //code goes here
        mainWorldLight.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        mainWorldLight.gameObject.SetActive(false);
     }

    //void TeleportPlayerRandom()
    //{
    //    // code goes here... or you could modify one of your other methods to do the job.
    //}

}
