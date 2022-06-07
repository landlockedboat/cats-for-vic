using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meower : MonoBehaviour
{
    [SerializeField] private AudioClip[] _meus;
    [SerializeField] private float _meowRate = 20;
    [SerializeField] private float _pitchVariability = 1;

    private AudioSource _as;
    private float _basePitch;


    private void Awake()
    {
        // _as = gameObject.AddComponent<AudioSource>();
        _as = GetComponent<AudioSource>();
        _basePitch = _as.pitch;
    }

    void Start()
    {
        Meow();
        // Invoke("Meow", _meowRate/2 * Random.value + _meowRate / 2);
    }

    private void Meow()
    {

        _as.pitch = _basePitch + Random.value * _pitchVariability;
        _as.clip = _meus[Random.Range(0, _meus.Length)];
        _as.Play();
        Invoke("Meow", _meowRate / 2 * Random.value + _meowRate / 2);
    }
}
