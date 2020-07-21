using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowThePlaceOfHacking : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;

    public void ShowHackingPlace()
    {
        _spriteRenderer.enabled = true;
    }

    public void HideHackingPlace()
    {
        _spriteRenderer.enabled = false;
    }
}
