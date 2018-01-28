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
	
	void FixedUpdate () {
		// Get player, and following objects position
		Vector3 sub_pos = GameObject.FindGameObjectWithTag("Subumarine").transform.position;
		Vector3 mine_pos = this.transform.position;

		// Calculate this objects direction to player
		//var angle = Mathf.Atan2(mine_pos.x - sub_pos.x, mine_pos.y - sub_pos.y);
		//mine_pos.x += -1 * Mathf.Sin(angle) * speed * Time.deltaTime;
		//mine_pos.y -= Mathf.Cos(angle) * speed * Time.deltaTime;

		// Places movement values to this
        this.transform.position = Vector3.MoveTowards(mine_pos, sub_pos, speed * Time.deltaTime);

		//this.transform.position = new Vector3 (mine_pos.x, mine_pos.y, 0f);
		//Debug.Log("Following: " + this.transform.position.x + " " + this.transform.position.y);
	}
}

