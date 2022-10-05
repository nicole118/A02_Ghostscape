using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip foleyA;
    public static AudioClip foleyB;
    static AudioSource audiosrc;

    // Start is called before the first frame update
    void Start()
    {
        foleyA = Resources.Load<AudioClip>("Foley_A");
        foleyB = Resources.Load<AudioClip>("Foley_B");

        audiosrc = GetComponent<AudioSource>();

    }

    public static void PlaySound()
    {
        audiosrc.PlayOneShot(foleyA);
    }

}
