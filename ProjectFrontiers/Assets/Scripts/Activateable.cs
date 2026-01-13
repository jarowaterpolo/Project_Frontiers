using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Activateable : MonoBehaviour
{
    private Collider _collider;
    private bool PlayerInTrigger;

    public UnityEvent TriggerEvent;

    public char ActivateKey = 'e';

    private void Start()
    {
        _collider = GetComponent<Collider>();
    }

    private void Update()
    {
        if (PlayerInTrigger == true && Input.GetKeyDown((KeyCode)ActivateKey))
        {
            //Debug.Log("activation key " + ActivateKey + " was pressed");
            TriggerEvent.Invoke();
        }
    }
    private void OnTriggerStay(Collider other)
    {
        //Debug.Log(other.name + " is in the collider");
        if (other.transform.parent.CompareTag("Player"))
        {
            //Debug.Log("Player is in the collider");
            PlayerInTrigger = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        PlayerInTrigger = false;
    }

    public void Activate_Reactor()
    {
        Debug.Log("Activate Reactor");
    }
}
