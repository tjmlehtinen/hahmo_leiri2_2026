using UnityEngine;

public class PartSelector : MonoBehaviour
{
    public Sprite[] parts;
    private SpriteRenderer partRenderer;
    private int currentIndex = 0;

    void Awake()
    {
        partRenderer = GetComponent<SpriteRenderer>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        partRenderer.sprite = parts[currentIndex];
    }

    public void ChangePart()
    {
        currentIndex = (currentIndex + 1) % parts.Length;
        partRenderer.sprite = parts[currentIndex];
    }
}
