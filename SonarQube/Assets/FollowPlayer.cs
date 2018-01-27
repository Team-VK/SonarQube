using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	public GameObject obj;
	public float speed;

	// Use this for initialization
	void Start () {
		// nada
	}
	
	// Update is called once per frame
	void Update () {
		// Get player, and following objects position
		var sub_pos = GameObject.FindGameObjectWithTag("Player").transform.position;
		var mine_pos = this.transform.position;

		// Calculate this objects direction to player
		var angle = Mathf.Atan2(mine_pos.x - sub_pos.x, mine_pos.y - sub_pos.y);
		mine_pos.x += -1 * Mathf.Sin(angle) * speed * Time.deltaTime;
		mine_pos.y -= Mathf.Cos(angle) * speed * Time.deltaTime;

		// Places movement values to this
		this.transform.position = mine_pos;
	}
}
