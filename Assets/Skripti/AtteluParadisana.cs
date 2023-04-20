using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {
    public GameObject binsImg;
    public GameObject lacisImg;
    public GameObject omeImg;
    public GameObject masinaImg;
    public GameObject pakreisiPoga;
    public GameObject palabiPoga;
    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;
    public void binaAttelosana(bool vertiba)
    {
        binsImg.SetActive(vertiba);
        pakreisiPoga.GetComponent<Toggle>().interactable = vertiba;
        palabiPoga.GetComponent<Toggle>().interactable = vertiba;
    }

    
    public void lacisAttelosana(bool vertiba)
    {
        lacisImg.SetActive(vertiba);
    }

    public void omeAttelosana(bool vertiba)
    {
        omeImg.SetActive(vertiba);
    }

    public void masinaAttelosana(bool vertiba)
    {
        masinaImg.SetActive(vertiba);
    }

    public void paLabiBins()
    {
        binsImg.transform.localScale = new Vector2(-1, 1);
    }

    public void paKreisiBins()
    {
        binsImg.transform.localScale = new Vector2(1, 1);
    }

    public void izkritosais(int skaitlis) {
        if (skaitlis == 0)
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];
        else if (skaitlis == 1)
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];
        else if (skaitlis == 2)
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[2];
        else
            Debug.Log("Nav piesaistits attels");
    }

}
