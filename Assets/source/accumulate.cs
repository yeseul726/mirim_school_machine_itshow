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

	public static bool accu_reset = true; //Can see

	public static int[] accu_tmp = new int[8];

	// Use this for initialization
	void Start () {
		top1.SetActive (false); top2.SetActive (false); top3.SetActive (false); top4.SetActive (false);
		bottom1.SetActive (false); bottom2.SetActive (false); bottom3.SetActive (false); bottom4.SetActive (false);
		stocking1.SetActive (false); stocking2.SetActive (false); stocking3.SetActive (false); stocking4.SetActive (false);
		socks1.SetActive (false); socks2.SetActive (false); socks3.SetActive (false); socks4.SetActive (false);
		hair_tie1.SetActive (false); hair_tie2.SetActive (false); hair_tie3.SetActive (false); hair_tie4.SetActive (false);
		hair1.SetActive (false); hair2.SetActive (false); hair3.SetActive (false); hair4.SetActive (false);
		outer1.SetActive (false); outer2.SetActive (false); outer3.SetActive (false); outer4.SetActive (false);
		backpack1.SetActive (false); backpack2.SetActive (false); backpack3.SetActive (false); backpack4.SetActive (false);
		for (int i = 0; i < 8; i++) {
			accumulate.accu_tmp[i] = 0;
		}
	}

	// Update is called once per frame
	void Update () {
		show_result ();
	}

	public void show_result() {
		Debug.Log ("aaaaaaaaa");
		Debug.Log ("accu_reset == " + accu_reset);
		int i;
		if (accu_reset) {
			for (i = 0; i < 8; i++) {
				Debug.Log ("accu_tmp : " + accu_tmp [i]);
				if (i == 0) {
					if (accu_tmp [i] == 1) {
						top1.SetActive (true);
					} else if (accu_tmp [i] == 2) {
						top2.SetActive (true);
					} else if (accu_tmp [i] == 3) {
						top3.SetActive (true);
					} else if (accu_tmp [i] == 4) {
						top4.SetActive (true);
					}
				} else if (i == 1) {
					if (accu_tmp [i] == 1) {
						bottom1.SetActive (true);
					} else if (accu_tmp [i] == 2) {
						bottom2.SetActive (true);
					} else if (accu_tmp [i] == 3) {
						bottom3.SetActive (true);
					} else if (accu_tmp [i] == 4) {
						bottom4.SetActive (true);
					}
				} else if (i == 2) {
					if (accu_tmp [i] == 1) {
						stocking1.SetActive (true);
					} else if (accu_tmp [i] == 2) {
						stocking2.SetActive (true);
					} else if (accu_tmp [i] == 3) {
						stocking3.SetActive (true);
					} else if (accu_tmp [i] == 4) {
						stocking4.SetActive (true);
					}
				} else if (i == 3) {
					if (accu_tmp [i] == 1) {
						socks1.SetActive (true);
					} else if (accu_tmp [i] == 2) {
						socks2.SetActive (true);
					} else if (accu_tmp [i] == 3) {
						socks3.SetActive (true);
					} else if (accu_tmp [i] == 4) {
						socks4.SetActive (true);
					}
				} else if (i == 4) {
					if (accu_tmp [i] == 1) {
						hair_tie4.SetActive (true);
					} else if (accu_tmp [i] == 2) {
						hair_tie2.SetActive (true);
					} else if (accu_tmp [i] == 3) {
						hair_tie3.SetActive (true);
					} else if (accu_tmp [i] == 4) {
						hair_tie1.SetActive (true);
					}
				} else if (i == 5) {
					if (accu_tmp [i] == 1) {
						hair2.SetActive (true);
					} else if (accu_tmp [i] == 2) {
						hair1.SetActive (true);
					} else if (accu_tmp [i] == 3) {
						hair3.SetActive (true);
					} else if (accu_tmp [i] == 4) {
						hair4.SetActive (true);
					}
				} else if (i == 6) {
					if (accu_tmp [i] == 1) {
						outer1.SetActive (true);
					} else if (accu_tmp [i] == 2) {
						outer2.SetActive (true);
					} else if (accu_tmp [i] == 3) {
						outer3.SetActive (true);
					} else if (accu_tmp [i] == 4) {
						outer4.SetActive (true);
					}
				} else if (i == 7) {
					if (accu_tmp [i] == 1) {
						backpack1.SetActive (true);
					} else if (accu_tmp [i] == 2) {
						backpack2.SetActive (true);
					} else if (accu_tmp [i] == 3) {
						backpack3.SetActive (true);
					} else if (accu_tmp [i] == 4) {
						backpack4.SetActive (true);
					}
				} else {
					top1.SetActive (false); top2.SetActive (false); top3.SetActive (false); top4.SetActive (false);
					bottom1.SetActive (false); bottom2.SetActive (false); bottom3.SetActive (false); bottom4.SetActive (false);
					stocking1.SetActive (false); stocking2.SetActive (false); stocking3.SetActive (false); stocking4.SetActive (false);
					socks1.SetActive (false); socks2.SetActive (false); socks3.SetActive (false); socks4.SetActive (false);
					hair_tie1.SetActive (false); hair_tie2.SetActive (false); hair_tie3.SetActive (false); hair_tie4.SetActive (false);
					hair1.SetActive (false); hair2.SetActive (false); hair3.SetActive (false); hair4.SetActive (false);
					outer1.SetActive (false); outer2.SetActive (false); outer3.SetActive (false); outer4.SetActive (false);
					backpack1.SetActive (false); backpack2.SetActive (false); backpack3.SetActive (false); backpack4.SetActive (false);
				}
			}
		} else {
			top1.SetActive (false); top2.SetActive (false); top3.SetActive (false); top4.SetActive (false);
			bottom1.SetActive (false); bottom2.SetActive (false); bottom3.SetActive (false); bottom4.SetActive (false);
			stocking1.SetActive (false); stocking2.SetActive (false); stocking3.SetActive (false); stocking4.SetActive (false);
			socks1.SetActive (false); socks2.SetActive (false); socks3.SetActive (false); socks4.SetActive (false);
			hair_tie1.SetActive (false); hair_tie2.SetActive (false); hair_tie3.SetActive (false); hair_tie4.SetActive (false);
			hair1.SetActive (false); hair2.SetActive (false); hair3.SetActive (false); hair4.SetActive (false);
			outer1.SetActive (false); outer2.SetActive (false); outer3.SetActive (false); outer4.SetActive (false);
			backpack1.SetActive (false); backpack2.SetActive (false); backpack3.SetActive (false); backpack4.SetActive (false);
		}
	}
}
