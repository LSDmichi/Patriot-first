using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field_generator : MonoBehaviour {

	public int tile_max_count; // 最大タイル数
	private GameObject[] tile_list; // タイル
	private Vector3 gen_pos; // 生成場所

	// Use this for initialization
	void Start () {
		current_tile_count = 0;
		gen_pos = ;
		tile_max_count = 100; // after everthig has done, we create more unique maps
	}

	public void generate_field(Vector3 gen_pos, ) {

		for(int i = 0; i <= tile_max_count; i++) {
			GameObject tile = pick_tile_type(tile_list)
			Vector3 gen_pos = generate_position(gen_pos, i)
			Instantiate(tile, gen_pos)
		}

	}

	private GameObject pick_tile_type(tile_list){

	}

	private Vector3 generate_position(Vector3 gen_pos, int i) {

	}
	// // Update is called once per frame
	// void Update () {

	// }
}
