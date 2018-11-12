using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class menuSahneGecis : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    public void yardimSahneAc()
    {
        LoadingScreenManager.LoadScene(6);
    }

    public void degerlendirmeSahneAc()
    {
        LoadingScreenManager.LoadScene(7);
    }

    public void konuAnlatimSahneAc()
    {
        LoadingScreenManager.LoadScene(1);
        //SceneManager.LoadScene ("konuKarakter");
    }

    public void anaSahneAc()
    {
        LoadingScreenManager.LoadScene(0);
        //SceneManager.LoadScene ("mainScene");
    }

    public void arSahneAc()
    {
        LoadingScreenManager.LoadScene(3);
        //SceneManager.LoadScene ("ornekler");
    }

    //public void sf82SahneAc(){
    //	SceneManager.LoadScene ("konuAnlatim");
    //}

    //   public void kameraTestSahneAc()
    //   {
    //       SceneManager.LoadScene("kameraTest");
    //   }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            LoadingScreenManager.LoadScene(8);
        }
    }
}
