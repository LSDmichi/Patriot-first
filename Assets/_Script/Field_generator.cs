using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field_generator : MonoBehaviour {

	public int tile_max_count; // 最大タイル数
	private int[] tile_list; // タイル
	private Vector3 gen_pos; // 生成場所

	// Use this for initialization
	void Start () {
		Vector3 gen_pos = new Vector3(1, 1, 1);
		int tile_max_count = 100; // after everthig has done, we create more unique maps
	}

	// public void generate_field(Vector3 gen_pos) {

	// 	for(int i = 0; i <= tile_max_count; i++) {
	// 		GameObject tile = pick_tile_type(tile_list);
	// 		Vector3 new_gen_pos = generate_position(gen_pos, i);
	// 		Instantiate(tile, new_gen_pos);
	// 	}

	// }

	// private GameObject pick_tile_type(int[] tile_list){
	// 	int rand_int = Random.Range(0, 100);
	// }

	// private Vector3 generate_position(Vector3 gen_pos, int i) {

	// }

}