using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private float panSpeed;
    [SerializeField]
    private float panBorderThickness;
    [SerializeField]
    private Vector2 panLimit;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (Input.GetKey("d"))
        {
            pos.x += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("w"))
        {
            Debug.Log("W pressed");
            pos.z += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            Debug.Log("S pressed");
            pos.z -= panSpeed * Time.deltaTime;
        }
        pos.x = Mathf.Clamp(pos.x, -panLimit.x, panLimit.x);
        pos.x = Mathf.Clamp(pos.z, -panLimit.y, panLimit.y);

        transform.position = pos;
    }
}
