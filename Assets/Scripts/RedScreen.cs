using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedScreen : MonoBehaviour
{
    public GameObject TheRedScreen;
    public AudioSource FallSound;

    void OnTriggerEnter()
    {
        TheRedScreen.SetActive(true);
        FallSound.Play();
        TheRedScreen.GetComponent<Animation>().Play("RedScreen_Anim");
    }
}