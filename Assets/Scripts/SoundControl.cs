using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    [SerializeField] private float _durationVolume;

    private AudioSource _source;
    private bool _isPlaySound, _isStopSound;
    private float _runningTime;

    void Start()
    {
        _source = GetComponent<AudioSource>();
    }

    public void PlaySound()
    {
        _isPlaySound = true;
    }

    public void StopSound()
    {
        _isStopSound = true;
    }

    private void Update()
    {
        if (_isPlaySound)
        {
            if (_source.volume != 1)
            {
                _runningTime += Time.deltaTime;
                _source.volume = Mathf.Lerp(0, 1, (_runningTime / _durationVolume));
            }
            else
            {
                _isPlaySound = false;
                _runningTime = 0;
            }                
        }
        else 
        if (_isStopSound)
        {
            if (_source.volume != 0)
            {
                _runningTime += Time.deltaTime;
                _source.volume = Mathf.Lerp(1, 0, (_runningTime / _durationVolume));
            }
            else
            {
                _isStopSound = false;
                _runningTime = 0;
            }                
        }
        else
        {
            return;
        }
            
    }
}
