using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Sorular : MonoBehaviour
{

    public GameObject[] sorular;
    public GameObject soruc;
    public Animator karakter;
    public Text dogruText;
    public Text yanlisText;

    private int dogruSayisi = 0;
    private int yanlisSayisi = 0;

    // Use this for initialization
    void Start()
    {
        HepsiniGizle();
        Soru1Goster();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Soru1Goster()
    {
        HepsiniGizle();
        sorular[0].SetActive(true);
    }

    public void Soru2Goster()
    {
        HepsiniGizle();
        sorular[1].SetActive(true);
    }
    public void Soru3Goster()
    {
        HepsiniGizle();
        sorular[2].SetActive(true);
    }
    public void Soru4Goster()
    {
        HepsiniGizle();
        sorular[3].SetActive(true);
    }
    public void Soru5Goster()
    {
        HepsiniGizle();
        sorular[4].SetActive(true);
    }

    private void HepsiniGizle()
    {
        soruc.SetActive(false);
        for (int i = 0; i < sorular.Length; i++)
        {
            sorular[i].SetActive(false);
        }
    }

    public void SonuclariGoster()
    {

        HepsiniGizle();
        soruc.SetActive(true);

        dogruText.text = "Doğru Sayınız : "+dogruSayisi.ToString();
        yanlisText.text = "Yanlış Sayınız : "+yanlisSayisi.ToString();

        if (dogruSayisi == 5)
        {
            karakter.Play("Bboy Hip Hop Move", 0, 0f);
        }
        else if (dogruSayisi >= 3)
        {
            karakter.Play("Victory Idle (1)", 0, 0f);
        }
        else karakter.Play("Sad Idle", 0, 0f);
    }

    public void dogruArtir()
    {
        dogruSayisi++;
    }
    public void yanlisArtir()
    {
        yanlisSayisi++;
    }

}
