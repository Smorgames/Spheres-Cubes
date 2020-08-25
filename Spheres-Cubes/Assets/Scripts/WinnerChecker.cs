using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnerChecker : MonoBehaviour
{
    List<GameObject> gameObjects = new List<GameObject>();

    public GameObject winImpactPS;
    public GameObject pointsEmpty;
    public GameObject turnDisplay1, turnDisplay2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cube" || other.gameObject.tag == "Sphere")
        {
            gameObjects.Add(other.gameObject);
        }

        if (gameObjects.Count == 4 && gameObjects[0].tag == "Cube" && gameObjects[1].tag == "Cube" && gameObjects[2].tag == "Cube" && gameObjects[3].tag == "Cube")
        {
            winImpactPS.SetActive(true);
            pointsEmpty.SetActive(false);
            turnDisplay1.SetActive(false);
            turnDisplay2.SetActive(false);
        }
        if (gameObjects.Count == 4 && gameObjects[0].tag == "Sphere" && gameObjects[1].tag == "Sphere" && gameObjects[2].tag == "Sphere" && gameObjects[3].tag == "Sphere")
        {
            winImpactPS.SetActive(true);
            pointsEmpty.SetActive(false);
            turnDisplay1.SetActive(false);
            turnDisplay2.SetActive(false);
        }
    }
}
