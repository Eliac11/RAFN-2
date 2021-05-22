using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandAudioPlay : MonoBehaviour
{

    private AudioSource audiosors;
    public AudioClip[] clips;

    public float t;
    public float mintimespawn;
    public float maxtimespawn;
    // Start is called before the first frame update
    void Start()
    {
        audiosors = GetComponent<AudioSource>();
        t = 1;
    }

    // Update is called once per frame
    void Update()
    {
	if (!audiosors.isPlaying){
        t -= Time.deltaTime;
        if (t<= 0){
            t = Random.Range(mintimespawn, maxtimespawn);;
            audiosors.clip = clips[Random.Range(0,clips.Length)];
            audiosors.Play();
        }
	}
    }
}
