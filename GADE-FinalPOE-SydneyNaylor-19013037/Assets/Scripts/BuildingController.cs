using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingController : MonoBehaviour
{
    public GameObject redSpawner;
    public GameObject blueSpawner;
    public GameObject greenSpawner;
    private void Start()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "BuildingR"|| 
            collision.collider.gameObject.tag == "BuildingB"|| 
            collision.collider.gameObject.tag == "BuildingG"||
            collision.collider.gameObject.tag == "FactoryBuildingR"||
            collision.collider.gameObject.tag == "FactoryBuildingB"||
            collision.collider.gameObject.tag == "FactoryBuildingG")
        {
            GameObject factory = GameObject.FindGameObjectWithTag("FactoryBuildingR");
        }
    }
}
