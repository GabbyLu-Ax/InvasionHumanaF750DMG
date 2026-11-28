using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    [SerializeField] private Vector2 currOfffset;

    [SerializeField] private Vector2 speed;


    private Renderer spriteRenderer;


    void Awake()
    {
        spriteRenderer = GetComponent<Renderer>();
    }
    void Update()
    {
        currOfffset += speed * Time.deltaTime;

        spriteRenderer.material.mainTextureOffset = currOfffset;

    }
}
