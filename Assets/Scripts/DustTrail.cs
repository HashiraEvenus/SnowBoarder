using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] ParticleSystem DustEffect;
    
    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Ground") {
            DustEffect.Play();
        }
    }
    void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.tag == "Ground") {
            DustEffect.Stop();
        }
    }
}
