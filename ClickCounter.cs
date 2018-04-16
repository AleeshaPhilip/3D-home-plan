
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClickCounter : MonoBehaviour 
{
	int cost=1000000;
	public Text DisplayText;

	public void button()
	{
		DisplayText.text = "Cost:" + cost;
	}
}
