using UnityEngine;
using System.Collections;

public class Animasyon_sf1 : MonoBehaviour
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
    public void konuAnlat(int numara)

    {
        audioSource[numara].Play();
    }

    public void karakterAnimasyon(string animasyonAdi)
    {
        karakter.Play(animasyonAdi, 0, 0f);
    }

    public void karakterWaving()
    {
        karakter.Play("Waving", 0, 0f);
    }

    public void karakterWalking()
    {
        karakter.Play("Walking", 0, 0f);
    }

    public void karakterTalking0()
    {
        karakter.Play("Talking0", 0, 0f);
    }

    public void karakterTalking1()
    {
        karakter.Play("Talking1", 0, 0f);
    }

    public void karakterTalking2()
    {
        karakter.Play("Talking2", 0, 0f);
    }

    public void karakterCounting()
    {
        karakter.Play("Counting", 0, 0f);
    }

    public void karakterLookAround()
    {
        karakter.Play("LookAround", 0, 0f);
    }
}
