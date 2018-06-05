using UnityEngine;
using System.Collections;

public class accumulate : MonoBehaviour {
	
	public GameObject top1, top2, top3, top4;
	public GameObject bottom1, bottom2, bottom3, bottom4;
	public GameObject stocking1, stocking2, stocking3, stocking4;
	public GameObject socks1, socks2, socks3, socks4;
	public GameObject hair_tie1, hair_tie2, hair_tie3, hair_tie4;
	public GameObject hair1, hair2, hair3, hair4;
	public GameObject outer1, outer2, outer3, outer4;
	public GameObject backpack1, backpack2, backpack3, backpack4;


	void Start () {
		//show_play_result.reset = true;
		top1.SetActive (false); top2.SetActive (false); top3.SetActive (false); top4.SetActive (false);
		bottom1.SetActive (false); bottom2.SetActive (false); bottom3.SetActive (false); bottom4.SetActive (false);
		stocking1.SetActive (false); stocking2.SetActive (false); stocking3.SetActive (false); stocking4.SetActive (false);
		socks1.SetActive (false); socks2.SetActive (false); socks3.SetActive (false); socks4.SetActive (false);
		hair_tie1.SetActive (false); hair_tie2.SetActive (false); hair_tie3.SetActive (false); hair_tie4.SetActive (false);
		hair1.SetActive (false); hair2.SetActive (false); hair3.SetActive (false); hair4.SetActive (false);
		outer1.SetActive (false); outer2.SetActive (false); outer3.SetActive (false); outer4.SetActive (false);
		backpack1.SetActive (false); backpack2.SetActive (false); backpack3.SetActive (false); backpack4.SetActive (false);
	}

	void Update () {
		
	}

}
