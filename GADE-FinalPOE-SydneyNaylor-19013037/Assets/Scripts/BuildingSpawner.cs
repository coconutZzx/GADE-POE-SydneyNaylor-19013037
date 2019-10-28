using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSpawner : MonoBehaviour
{
    public GameObject building;
    public int x;
    public int z;
    public int buildingAmount;
    void Start()
    {
        StartCoroutine(BuildingsSpawner());
        StopCoroutine(BuildingsSpawner());
    }

    IEnumerator BuildingsSpawner()
    {
        while (buildingAmount < MapManager.width * MapManager.length / 100)
        {
            x = Random.Range((-MapManager.width / 2 + 1), (MapManager.width / 2) - 1);
            z = Random.Range((-MapManager.length / 2 + 1), (MapManager.length / 2) - 1);
            Instantiate(building, new Vector3(x, 1, z), Quaternion.identity);
            yield return new WaitForSeconds(0.0f);
            buildingAmount += 1;
        }
    }
}
