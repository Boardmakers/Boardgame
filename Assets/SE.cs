using System.Collections;
using UnityEngine;

public class SE : MonoBehaviour {
	public AudioClip test;
	void OnMouseEnter() {
		GetComponent<AudioSource>().PlayOneShot(test);
		}
	}
