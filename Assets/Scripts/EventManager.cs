using UnityEngine;

public delegate void OnInteractRangeAction(GameObject interactable); // Delegate for interaction actions
public delegate void ChangeAnxietyAction(int amount); // Delegate for decreasing anxiety
public class EventManager : MonoBehaviour
{
    public static event OnInteractRangeAction OnInteract;
    public static event ChangeAnxietyAction OnChangeAnxiety;


    //singleton
    public static EventManager Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this; // Set the singleton instance
        }
        else
        {
            Destroy(gameObject); // Ensure only one instance exists
        }
    }


    public void OnInteractRange(GameObject interactable)
    {
        if (OnInteract != null)
        {
            OnInteract(interactable); // Invoke the interaction event
        }
    }

    public void ChangeAnxiety(int amount)
    {
        if (OnChangeAnxiety != null)
        {
            OnChangeAnxiety(amount); // Invoke the change anxiety event
        }
    }

}
