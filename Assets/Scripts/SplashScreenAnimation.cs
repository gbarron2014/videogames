using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    public int sceneNumber;
    // Start is called before the first frame update
    void Start()
    {
        if (sceneNumber == 0) {
            StartCoroutine(SplashTwo());
        }

        if (sceneNumber ==1) {
            StartCoroutine(SplashMain());
        }
    }

    IEnumerator SplashTwo() {
        yield return new WaitForSeconds(5);
        sceneNumber = 1;
        SceneManager.LoadScene(1);
    }

    IEnumerator SplashMain() {
        yield return new WaitForSeconds(5);
        sceneNumber = 2;
        SceneManager.LoadScene(1);
    }

}
