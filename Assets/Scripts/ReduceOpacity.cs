using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReduceOpacity : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            spriteRenderer.color = new Color(1f, 1f, 1f, 0f);
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            spriteRenderer.color = new Color(1f, 1f, 1f, 1f);
        }

    }
}
