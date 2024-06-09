using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float delay = 2.0f;
    [SerializeField] ParticleSystem FinishEffect;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            FinishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", delay);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}