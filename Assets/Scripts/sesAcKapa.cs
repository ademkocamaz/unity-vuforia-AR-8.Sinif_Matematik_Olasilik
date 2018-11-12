using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class sesAcKapa : MonoBehaviour
{
    public AudioSource audioSource;
    public Button acikButton;
    public Button kapaliButton;

    // Use this for initialization
    void Start()
    {
        acikButton.gameObject.SetActive(true);
        kapaliButton.gameObject.SetActive(false);
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void sesAcKapat()
    {
        if (audioSource.isPlaying)
        {
            acikButton.gameObject.SetActive(false);
            kapaliButton.gameObject.SetActive(true);      
            audioSource.Stop();
        }
        else
        {
            acikButton.gameObject.SetActive(true);
            kapaliButton.gameObject.SetActive(false);
            audioSource.Play();
        }
        
    }
    

}
