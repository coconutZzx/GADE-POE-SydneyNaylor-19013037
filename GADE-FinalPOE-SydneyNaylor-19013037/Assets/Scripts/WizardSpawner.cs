using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardSpawner : MonoBehaviour
{
    public GameObject unit;
    public int x;
    public int z;
    public int unitAmount;
    void Start()
    {
        StartCoroutine(UnitSpawner());
    }

    IEnumerator UnitSpawner()
    {
        while (unitAmount < 6)
        {
            x = Random.Range(-MapManager.width / 2, MapManager.width / 2);
            z = Random.Range(-MapManager.length / 2, MapManager.length / 2);
            Instantiate(unit, new Vector3(x, 1, z), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            unitAmount += 1;
        }
    }
}
