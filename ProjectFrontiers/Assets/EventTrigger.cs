using UnityEngine;
using UnityEngine.Events;

public class EventTrigger : MonoBehaviour
{
    private bool PlayerInTrigger = false;

    public UnityEvent TriggerEvent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        TriggerEvent.Invoke();
    }
}
