using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Activateable : MonoBehaviour
{
    private bool PlayerInTrigger = false;

    public UnityEvent TriggerEvent;

    public char ActivateKey = 'e';

    public GameObject E_Canvas;

    public bool TaskComplete = false;

    private void Start()
    {

    }

    private void Update()
    {
        //Debug.Log("Player is in collider = " + PlayerInTrigger);

        if (PlayerInTrigger == true && (Input.GetKeyDown((KeyCode)ActivateKey) || Input.GetMouseButtonDown(0)))
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

    public void OnTriggerEnter(Collider other)
    {
        if (TaskComplete == true) return;
        //Debug.Log(other.name + " is in the collider");
        if (other.transform.parent.CompareTag("Player"))
        {
            E_Canvas.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PlayerInTrigger = false;
        E_Canvas.SetActive(false);
    }

    public void Activate_Reactor()
    {
        Debug.Log("Activate Reactor");
    }

    public void GetRemote()
    {
        PlanetStateSwitching.HasRemote = true;
    }

    public void SetTaskToDone()
    {
        TaskComplete = true;
    }
}
