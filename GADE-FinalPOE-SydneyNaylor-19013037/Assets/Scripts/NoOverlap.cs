using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoOverlap : MonoBehaviour
{
    public GameObject[] items;
    public float raycastDistance = 100f;
    public float overlapSize = 1f;
    public LayerMask spawns;
    
    void Start()
    {
        PositionRaycast();
    }

    void PositionRaycast()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, Vector3.down, out hit, raycastDistance))
        {
            Quaternion spawnRotation = Quaternion.FromToRotation(Vector3.up, hit.normal);

            Vector3 overlapScale = new Vector3(overlapSize, overlapSize, overlapSize);

            Collider[] colliders = new Collider[2];

            int numColliders = Physics.OverlapBoxNonAlloc(hit.point, overlapScale, colliders, spawnRotation, spawns);

            Debug.Log("Number of colliders found " + numColliders);

            if (numColliders == 0)
            {
                Debug.Log("Spawned!");
                Pick(hit.point, spawnRotation);
            }
            else
            {
                Debug.Log("name of collider 0 found " + colliders[0].name);
            }
        }
    }

    void Pick(Vector3 positionToSpawn, Quaternion rotationToSpawn)
    {
        int randomIndex = Random.Range(0, items.Length);
        GameObject clone = Instantiate(items[randomIndex], positionToSpawn, rotationToSpawn);
    }
}
