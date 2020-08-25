using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointController : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;
    private GameObject gameControllerGO;
    private GameController gameController;

    public GameObject nextAppearPoint;

    private void Start()
    {
        gameControllerGO = GameObject.FindWithTag("GameController");
        gameController = gameControllerGO.GetComponent<GameController>();
    }

    private void OnMouseDown()
    {
        if (gameController.ReturnTurnValue() == true)
        {
            Instantiate(cube, transform.position, Quaternion.identity);
            gameController.SwitchTurn();
        }
        if (gameController.ReturnTurnValue() == false)
        {
            Instantiate(sphere, transform.position, Quaternion.identity);
            gameController.SwitchTurn();
        }
        nextAppearPoint.SetActive(true);
        Destroy(gameObject);
    }

    private void OnMouseOver()
    {
        gameObject.transform.localScale = new Vector3(1, 1, 1);
    }

    private void OnMouseExit()
    {
        gameObject.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
    }
}
