using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float panSpeed = 10f;
    public float panBorderThickness = 10f;
    public Vector2 panLimit;

    public float scrollSpeed = 20f;
    public float minY = 20f;
    public float maxY = 120f;

    // Update is called once per frame
    void Update()
    {
        // storing current position in temp var called pos
        // x,y,z stored in pos
        Vector3 pos = transform.position;

        if (Input.GetKey("W") || Input.mousePosition.y >= Screen.height - panBorderThickness)  // || Input.mousePosition.y >= Screen.height - panBorderThickness
        {
            //increases z value
            pos.z += panSpeed * Time.deltaTime; 
        }
        if (Input.GetKey("S") || Input.mousePosition.y <= Screen.height - panBorderThickness)  // || Input.mousePosition.y <= Screen.height - panBorderThickness
        {
            //increases z value
            pos.z -= panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("D") || Input.mousePosition.x >= Screen.height - panBorderThickness)  // || Input.mousePosition.x >= Screen.height - panBorderThickness
        {
            //increases z value
            pos.x += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("A") || Input.mousePosition.x <= Screen.height - panBorderThickness)  // || Input.mousePosition.x <= Screen.height - panBorderThickness
        {
            //increases z value
            pos.x -= panSpeed * Time.deltaTime;
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.y -= scroll * scrollSpeed * 100f * Time.deltaTime;

        pos.x = Mathf.Clamp(pos.x, -panLimit.x, panLimit.x);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        pos.z = Mathf.Clamp(pos.z, -panLimit.y, panLimit.y);

        //makes current position equal to new position
        transform.position = pos;
    }
}
