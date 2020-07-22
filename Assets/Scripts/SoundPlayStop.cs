using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayStop : MonoBehaviour
{
    [SerializeField] private float _durationVolume;

    private AudioSource _source;
    private bool _isWork;
    private float _runningTime, _initialValue, _lastValue;

    void Start()
    {
        _source = GetComponent<AudioSource>();
    }

    public void PlaySound()
    {
        _isWork = true;
        _initialValue = 0;
        _lastValue = 1;
    }

    public void StopSound()
    {
        _isWork = true;
        _initialValue = 1;
        _lastValue = 0;
    }

    private void Update()
    {
        if (_isWork)
        {
            if (_source.volume != _lastValue)
            {
                _runningTime += Time.deltaTime;
                _source.volume = Mathf.Lerp(_initialValue, _lastValue, (_runningTime / _durationVolume));
            }
            else
            {
                _isWork = false;
                _runningTime = 0;
            }                
        }
        else
        {
            return;
        }            
    }
}
