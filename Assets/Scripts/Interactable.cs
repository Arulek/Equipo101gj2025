using UnityEngine;

public class Interactable : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other && other.CompareTag("Player"))
        {
            EventManager.Instance.OnInteractRange(gameObject); // Notify the EventManager of the interaction
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other && other.CompareTag("Player"))
        {
            EventManager.Instance.OnInteractRange(null); // Notify the EventManager to hide the label
            EventManager.Instance.ChangeAnxiety(-10); // Example of decreasing anxiety when leaving the interaction range
        }
    }
}
