using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapManager : MonoBehaviour
{
    public Slider sliderWidth;
    public Slider sliderLength;

    public static int width = 10;
    public static int length = 10;

    public static bool inMenu = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inMenu)
        {
            width = (int)sliderWidth.value;
            length = (int)sliderLength.value;
        }
    }
}
