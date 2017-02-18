using UnityEngine;
using System.Collections;

public class ShopController : MonoBehaviour {

	public GameObject Panel;

	void OnCollisionEnter(Collision collision)
	{
		
			OpenShop ();

	}

	void OpenShop()
	{
		Panel.SetActive (true);
		Time.timeScale = 0;
	}

	public void CloseShop()
	{
		Panel.SetActive (false);
		Time.timeScale = 1;
	}
}
