using UnityEngine;



public class CanvasManager : MonoBehaviour
{

    public GameObject label;

    void Start()
    {
        EventManager.OnInteract += ShowLabel; // Subscribe to the interaction event
    }

    private void ShowLabel(GameObject obj)
    {
        if (obj == null)
        {
            label.SetActive(false); // Hide the label if no object is interacted with
            return;
        }
        label.SetActive(true);
        label.transform.position = obj.transform.position + new Vector3(0, 1, 0);

    }
}
