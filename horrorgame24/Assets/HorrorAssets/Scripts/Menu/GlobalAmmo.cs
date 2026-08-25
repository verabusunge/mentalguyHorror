using UnityEngine;
using TMPro;

public class GlobalAmmo : MonoBehaviour
{
	public static int ammoCount;
	public GameObject ammoText;
	public int internalAmmo;
	void Update()
	{
		internalAmmo = ammoCount;
		ammoText.GetComponent<TextMeshProUGUI>().text = "" +ammoCount;
	}
}
