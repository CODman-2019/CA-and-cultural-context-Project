using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioSource speaker;
    public AudioClip dialogue;

    private void OnTriggerStay(Collider other)
    {

        if ((Input.GetKeyDown(KeyCode.Mouse0)) && (other.tag == "Player"))
        {
            if (speaker.isPlaying)
            {
                speaker.Stop();
            }
                speaker.clip = dialogue;
                speaker.Play();
            Debug.Log(this.name);
        }

    }
}
