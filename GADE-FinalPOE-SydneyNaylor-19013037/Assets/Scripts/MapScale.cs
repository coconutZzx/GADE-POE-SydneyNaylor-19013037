using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapScale : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(MapManager.width, 1 ,MapManager.length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
