using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private bool isCubeTurn = true;

    public bool ReturnTurnValue()
    {
        return isCubeTurn;
    }

    public void SwitchTurn()
    {
        StartCoroutine(SwitchTurnCoroutine());
    }

    IEnumerator SwitchTurnCoroutine()
    {
        yield return new WaitForSeconds(0.1f);
        isCubeTurn = !isCubeTurn;
    }
}
