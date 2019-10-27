using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject unit;
    public int x;
    public int z;
    public int unitAmount = 3;
    public LayerMask nonPlaceableMask;
    void Start()
    {
        UnitSpawn();
        // StartCoroutine(UnitSpawner());
        // StopCoroutine(UnitSpawner()); ??
    }
    
    void UnitSpawn()
    {
        for (int i = 0; i < unitAmount; i++)
        {
            x = Random.Range((-MapManager.width / 2 + 1), (MapManager.width / 2) - 1);
            z = Random.Range((-MapManager.length / 2 + 1), (MapManager.length / 2) - 1);
            
            bool isPlaceable = !(Physics.CheckSphere(new Vector3(x, 1, z), 1f, nonPlaceableMask));

            while (isPlaceable == false)
            {
                x = Random.Range((-MapManager.width / 2 + 1), (MapManager.width / 2) - 1);
                z = Random.Range((-MapManager.length / 2 + 1), (MapManager.length / 2) - 1);
            }
            Instantiate(unit, new Vector3(x, 1, z), Quaternion.identity);
        }
    }

    IEnumerator UnitSpawner()
    {

        while (unitAmount < 3)
        {
            x = Random.Range((-MapManager.width/2 + 1), (MapManager.width/2) - 1);
            z = Random.Range((-MapManager.length/2 + 1), (MapManager.length/2) - 1);
            Instantiate(unit, new Vector3(x, 1, z), Quaternion.identity);
            yield return new WaitForSeconds(0.0f);
            unitAmount += 1;
        }
    }
}
