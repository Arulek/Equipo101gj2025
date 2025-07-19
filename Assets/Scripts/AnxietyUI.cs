using UnityEngine;
using UnityEngine.UI;

public class AnxietyUI : MonoBehaviour
{
    public Image fillImage; // Asignar el objeto "Fill" en el inspector
    public int maxAnxiety = 100; // Se puede sincronizar con GameManager si querés

    void Start()
    {
        EventManager.OnChangeAnxiety += UpdateBar; // Suscribirse al evento
    }

    void UpdateBar(int delta)
    {
        // Buscar el valor actual desde GameManager
        int current = GameManager.Instance.currentAnxiety;

        // Calcular el porcentaje
        float percent = Mathf.Clamp01(current / (float)maxAnxiety);

        // Asignar al fill
        fillImage.fillAmount = percent;
    }
}
