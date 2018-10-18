using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioExample : MonoBehaviour {

    public GameObject MusicGameObject;

    public AudioClip Bap;
    public AudioClip Pew;

    AudioSource source;
    AudioSource musicSource;

    // Use this for initialization
    void Start () {
        source = gameObject.AddComponent<AudioSource>();
        musicSource = MusicGameObject.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        // Play One Shot Sound
        if (Input.GetMouseButtonDown(0))
        { 
            source.PlayOneShot(Bap);
            Debug.Log("Bap");
        }

        // Play One Shot Sound
        if (Input.GetMouseButtonDown(1))
        {
            source.PlayOneShot(Pew);
            Debug.Log("Pew");
        }

        // Toggle Spacial Blend
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ToggleSpacialBlend(); 
        }

        
    }

    public void ToggleSpacialBlend()
    {
        if (musicSource.spatialBlend == 1 )
        {
            musicSource.spatialBlend = 0;
            Debug.Log("Spatical Blend = 0 (2d)"); 
        } else
        {
            musicSource.spatialBlend = 1;
            Debug.Log("Spatical Blend = 1 (3d)");
        }
    }
}
