using UnityEngine;

public class Wire : MonoBehaviour
{
    public Transform correctTarget;
    public LineRenderer line;

    private Camera cam;
    private bool connected;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = Camera.main;

        line.positionCount = 2;
        line.useWorldSpace = true;
        line.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (connected) return;

        line.enabled = true;
        line.SetPosition(0, transform.position);
        line.SetPosition(1, transform.position);
    }

    void OnMouseDrag()
    {
        if (connected) return;

        // Get mouse position at SAME depth as the wire
        Vector3 mouse = Input.mousePosition;
        mouse.z = cam.WorldToScreenPoint(transform.position).z;

        Vector3 world = cam.ScreenToWorldPoint(mouse);

        line.SetPosition(1, world);
    }


    void OnMouseUp()
    {
        if (connected) return;

        Vector3 mouse = Input.mousePosition;
        mouse.z = cam.WorldToScreenPoint(transform.position).z;
        Vector2 worldPoint = cam.ScreenToWorldPoint(mouse);

        Collider2D hit = Physics2D.OverlapPoint(worldPoint);

        if (hit != null && hit.transform == correctTarget)
        {
            connected = true;
            line.SetPosition(1, correctTarget.position);
        }
        else
        {
            line.enabled = false;
        }
    }


    void OnConnected()
    {
        Debug.Log($"{name} connected!");
        // Notify manager here
    }
}
