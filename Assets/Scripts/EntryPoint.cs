using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EntryPoint : MonoBehaviour
{
    [SerializeField] private UnityEvent _showHacked, _hideHacked;

    public event UnityAction ShowHacked
    {
        add => _showHacked.AddListener(value);
        remove => _showHacked.RemoveListener(value);
    }
    public event UnityAction HideHacked
    {
        add => _hideHacked.AddListener(value);
        remove => _hideHacked.RemoveListener(value);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            _showHacked?.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            _hideHacked?.Invoke();
        }
    }
}
