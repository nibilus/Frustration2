using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    public AudioSource Bump;
    void OnTriggerEnter()
    {
        Bump.Play();
    }
}
