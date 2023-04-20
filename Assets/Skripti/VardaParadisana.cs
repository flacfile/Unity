using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour{
	public string teksts;
	public GameObject ievadLauks;
	public GameObject tekstaAttelosana;
	private string[] fragmenti = {"Svekiks", "Jauku dienu", "Prieks Tevi redzet", "Wasap maaaan"};
	int indekss;
	public void UzglabatTekstu()
	{
		indekss = Random.Range(0, fragmenti.Length);
		teksts = ievadLauks.GetComponent<InputField>().text;
		tekstaAttelosana.GetComponent<Text>().text = fragmenti[indekss]+teksts.ToUpper()+"!";

	}

}
