using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Importe, lai lietotu pointer darbibu interfeisu
using UnityEngine.EventSystems;

//Piesaista interfeisu

public class ObjektuParvietosana : MonoBehaviour, IPointerDownHandler,
	IBeginDragHandler, IDragHandler, IEndDragHandler {
	private RectTransform transformKomponente;
	public Canvas kanva;
	// Use this for initialization
	void Start () {
		//Startejot automatiski pieklust
		//attela transform komponentei un
		//piefikse kadas koordinatas attels atrodas
	 transformKomponente = GetComponent<RectTransform>();

}
	public void OnPointerDown (PointerEventData notikums) {
		Debug.Log("Izdarits peles klikskis uz objekta");
	}

	public void OnBeginDrag(PointerEventData notikums)
	{
        Debug.Log("Uzsakta objekta vilksana");

    }

	public void OnDrag(PointerEventData notikums)
	{
        Debug.Log("Notiek objekta parvietosana");
		transformKomponente.anchoredPosition +=
			notikums.delta / kanva.scaleFactor;
    }
	

	public void OnEndDrag(PointerEventData notikums)
	{
        Debug.Log("Pabeigta objekta vilksana");
    }
}
