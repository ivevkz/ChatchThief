using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : MonoBehaviour
{
    [SerializeField] private GameObject _leha;
    private Animator _animator;

    private void Start()
    {
        _animator = _leha.GetComponent<Animator>();        
    }
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            _animator.SetTrigger("isAlarm");
        }        
    }
}
