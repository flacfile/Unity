using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtulisSkripts : MonoBehaviour {
	public float laikaIntervals =  1f;
	public GameObject[] virtuluSagataves;
	float minX, maxX;
	private Transform krasnsTransform;

	// Use this for initialization
	void Start () {
		krasnsTransform= GetComponent<Transform>();
	}
	
	// Update is called once per frame
	public void SagatavotVirtulus(bool stavoklis)
	{
		if (stavoklis)
			StartCoroutine(Generet());

		else
			StopAllCoroutines();
	}

	IEnumerator Generet()
	{
		while (true)
		{
			minX = krasnsTransform.position.x - 15;
            maxX = krasnsTransform.position.x + 15;
			var cipars = Random.Range(minX, maxX);
			var pozicija = new Vector2(cipars , transform.position.y);
			GameObject virtulis = Instantiate(virtuluSagataves[
				Random.Range(0, virtuluSagataves.Length)],
				pozicija, Quaternion.identity, krasnsTransform);

            yield return new WaitForSeconds(laikaIntervals);

		}
	}
}
