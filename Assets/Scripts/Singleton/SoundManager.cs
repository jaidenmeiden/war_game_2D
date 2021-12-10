using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    private AudioSource audioSource;
    public AudioClip shoot;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        
        // Get component with AudioSource
        audioSource = GetComponent<AudioSource>();
        
        // Do not destroy the target Object when loading a new Scene.
        // https://docs.unity3d.com/ScriptReference/Object.DontDestroyOnLoad.html
        DontDestroyOnLoad(gameObject);
    }

    public void PlayShoot()
    {
        audioSource.PlayOneShot(shoot);
    }
}
