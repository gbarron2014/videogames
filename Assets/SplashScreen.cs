using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreenAnimation : MonoBehaviour
{
    public static int sceneNumber;
    private int tiempo = 3;
    // Start is called before the first frame update
    void Start()
    {   
        Debug.Log("NUmero  " + sceneNumber.ToString());
        if (sceneNumber == 0) {
            StartCoroutine(SplashOne());
        }

        if (sceneNumber == 1) {
            StartCoroutine(SplashTwo());
        }
        if (sceneNumber == 2) {
            StartCoroutine(SplashMain());
        }
    }

    IEnumerator SplashOne() {
        yield return new WaitForSeconds(tiempo);
        sceneNumber = 1;
        SceneManager.LoadScene(0);
    }

    IEnumerator SplashTwo() {
        yield return new WaitForSeconds(tiempo);
        sceneNumber = 2;
        SceneManager.LoadScene(1);
    }

    IEnumerator SplashMain() {
        yield return new WaitForSeconds(tiempo);
        //sceneNumber = 0;
        SceneManager.LoadScene(2);
    }

}
