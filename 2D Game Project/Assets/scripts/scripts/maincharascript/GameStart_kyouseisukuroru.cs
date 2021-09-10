using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart_kyouseisukuroru: MonoBehaviour
{
    public string ObjectName1;
    public string ObjectName2;
    public string ObjectName3;
    public string ObjectName4;
    public string objectname;
	public string objectname1;
	public string objectname2;

	GameObject gameObject1;
	GameObject gameObject2;
	GameObject gameObject3;
	GameObject showObject1;
	GameObject showObject2;
	GameObject showObject3;
	GameObject showObject4
		;
	// Start is called before the first frame update
	void Start()
    {
	gameObject1 = GameObject.Find(objectname);
        gameObject1.GetComponent<OnKeyPress_MoveGravityPlus>().enabled = false;
		gameObject2 = GameObject.Find(objectname1);
		gameObject2.GetComponent<Forever_MoveH>().enabled = false;
		gameObject3 = GameObject.Find(objectname2);
		gameObject3.GetComponent<Forever_MoveH>().enabled = false;
		showObject1 = GameObject.Find(ObjectName1);
		showObject1.SetActive(false);
		showObject2 = GameObject.Find(ObjectName2);
		showObject2.SetActive(false);
		showObject3 = GameObject.Find(ObjectName3);
		showObject3.SetActive(false);
		showObject4 = GameObject.Find(ObjectName4);
		showObject4.SetActive(false);
		StartCoroutine("StartMotion");
    }

	// Update is called once per frame
	IEnumerator StartMotion()
	{
		showObject1.SetActive(true);

		yield return new WaitForSeconds(1.00f);
		showObject1.SetActive(false);
		showObject2.SetActive(true);

		yield return new WaitForSeconds(1.00f);
		showObject2.SetActive(false);
		showObject3.SetActive(true);

		yield return new WaitForSeconds(1.00f);
		showObject3.SetActive(false);
		showObject4.SetActive(true);

		yield return new WaitForSeconds(1.00f);
		showObject4.SetActive(false);

		gameObject1.GetComponent<OnKeyPress_MoveGravityPlus>().enabled = true;
		gameObject2.GetComponent<Forever_MoveH>().enabled = true;
		gameObject3.GetComponent<Forever_MoveH>().enabled = true;
	}
}
