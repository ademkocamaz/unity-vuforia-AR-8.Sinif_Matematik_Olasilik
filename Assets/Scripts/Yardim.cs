using UnityEngine;
using System.Collections;

public class Yardim : MonoBehaviour
{
    public AudioSource[] audioSource;
    public Animator karakter;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void konus(int numara)
    {
        audioSource[numara].Play();
    }

    public void karakterAnimasyon(string animasyonAdi)
    {
        karakter.Play(animasyonAdi, 0, 0f);
    }

    public void Cikis()
    {
        LoadingScreenManager.LoadScene(0);
    }
}
