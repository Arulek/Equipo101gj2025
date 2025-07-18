using UnityEngine;
using UnityEngine.Rendering.Universal;

public class GameManager : MonoBehaviour
{

    public Light2D ambientLight;

    public int maxAnxiety = 100; // Maximum anxiety level
    public int currentAnxiety = 100; // Current anxiety level
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EventManager.OnChangeAnxiety += OnAnxietyChange; // Subscribe to the event
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    private void OnAnxietyChange(int amount)
    {
        currentAnxiety += amount; // Change the current anxiety level
        currentAnxiety = Mathf.Clamp(currentAnxiety, 0, maxAnxiety); // Ensure anxiety level does not exceed limits
        // Adjust the ambient light intensity based on anxiety level
        if (ambientLight != null)
        {
            ambientLight.intensity = Mathf.Clamp(1f -(currentAnxiety / (float)maxAnxiety), 0.0f, 1f);
        }
    }
}
