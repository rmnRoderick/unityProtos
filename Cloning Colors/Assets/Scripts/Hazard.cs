// GameDev.tv ChallengeClub.Got questionsor wantto shareyour niftysolution?
// Head over to - http://community.gamedev.tv

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    private GameHandler gameHandler;

    void Start()
    {
        gameHandler = FindObjectOfType<GameHandler>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {

            if (IsSameColor(collision.gameObject))
            {
                return;
            }

            if (collision.gameObject.GetComponent<BlockMovement>().isActiveBool)
            {
                Destroy(collision.gameObject);
                gameHandler.AllPlayerBlocksArrayUpdate();
                gameHandler.DestroyedBlockUpdate();
            }
            else
            {
                Destroy(collision.gameObject);
            }
        }
    }

    private bool IsSameColor(GameObject block)
    {
        var blockColor = block.GetComponent<ColorChanger>().GetCurrentColor();

        return blockColor == gameObject.GetComponent<ColorChanger>().GetCurrentColor();
    }
}
