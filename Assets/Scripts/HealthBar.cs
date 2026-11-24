using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public UnitHealth unitHealth;
    public Transform bar;

    private Vector3 originalScale;
    private Vector3 originalPosition;

    void Start()
    {
        if (bar != null)
        {
            originalScale = bar.localScale;
            originalPosition = bar.localPosition;
        }
    }

    void Update()
    {
        if (unitHealth == null || bar == null)
            return;

        float healthPercent =
            unitHealth.GetCurrentHealth() / unitHealth.maxHealth;

        healthPercent = Mathf.Clamp01(healthPercent);

        // Shrink the bar from right to left.
        bar.localScale = new Vector3(
            originalScale.x * healthPercent,
            originalScale.y,
            originalScale.z
        );

        bar.localPosition = new Vector3(
            originalPosition.x -
            originalScale.x * (1f - healthPercent) / 2f,
            originalPosition.y,
            originalPosition.z
        );
    }
}