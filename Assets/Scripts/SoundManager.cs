using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip[] sounds;
    public AudioSource a;
    public void sound()
    {
        a.clip = sounds[0];
        a.Play();
    }
}
