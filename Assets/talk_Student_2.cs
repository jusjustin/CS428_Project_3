using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talk_Student_2 : MonoBehaviour
{
    // retrieve the player GO
    void Start() {}
    void Update() { 
        if ((!audio.isPlaying) && ((player.transform.position-this.transform.position).sqrMagnitude<2)) {
            // the player is within a radius of 3 units to this game object
            Debug.Log("Test");
            audio.PlayOneShot(audio.clip);
        }
    }
    public GameObject player;
    public AudioSource audio;

}
