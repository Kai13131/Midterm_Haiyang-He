using UnityEngine;

public class ChangeSword : MonoBehaviour
{
    public Sprite newSwordSprite;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = newSwordSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
