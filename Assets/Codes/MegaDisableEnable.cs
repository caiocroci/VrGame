using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MegaDisableEnable : MonoBehaviour
{
	public AudioSource sound;
	public GameObject toDisable;


	private void OnTriggerEnter(Collider other)
	{
		if (sound)
		{
			sound.Play();
		}

		if (toDisable)
		{
			toDisable.SetActive(false);
		}


	
	}
}
