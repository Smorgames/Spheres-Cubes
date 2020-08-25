using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed;

    private GameObject gameControllerGO;
    private GameController gameController;

    private MeshFilter meshFilter;
    public Mesh cube;
    public Mesh sphere;

    private void Start()
    {
        gameControllerGO = GameObject.FindWithTag("GameController");
        gameController = gameControllerGO.GetComponent<GameController>();
        meshFilter = GetComponent<MeshFilter>();
    }

    void Update()
    {
        transform.Rotate(speed * Time.deltaTime, speed * Time.deltaTime, speed * Time.deltaTime);

        if (gameController.ReturnTurnValue() == true)
        {
            transform.localScale = new Vector3(5, 5, 5);
            meshFilter.mesh = cube;
        }
        else
        {
            transform.localScale = new Vector3(7, 7, 7);
            meshFilter.mesh = sphere;
        }
    }
}
