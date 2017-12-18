using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class AppLoader : MonoBehaviour {
    
    bool requireLogin = false;
    int updateCounter = 0;

	// Use this for initialization
	void Start () {

        //SceneManager.LoadScene("MainScene");
        StartCoroutine(Load());
	}
	


    IEnumerator Load()
    {
        if (requireLogin)
        {
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene("LoginScene");
        }
        else
        {
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene("MainScene");
        }
    }
}
