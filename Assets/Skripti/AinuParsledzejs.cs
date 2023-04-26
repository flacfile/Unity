using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AinuParsledzejs : MonoBehaviour {

public void uzSakumu()
    {
        SceneManager.LoadScene("Sakums", LoadSceneMode.Single);
    }


    public void uzSpeli()
    {
        SceneManager.LoadScene("aina1", LoadSceneMode.Single);
    }

    public void Apturet()
    {
        Application.Quit();
    }

}
