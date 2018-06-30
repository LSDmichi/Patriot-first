using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field_generator : MonoBehaviour {

	public int tile_max_count; // 最大タイル数
	private List<GameObject> tile_object_list; // タイル
	private Vector3 gen_pos; // 生成場所

	// Use this for initialization
	void Start () {
		Vector3 gen_pos = new Vector3(0, 0, 0);
		int tile_max_count = 100; // after everthig has done, we create more unique maps
		Weight_List name_list = new Weight_List();
		List<GameObject> tile_object_list = name_list.InitList();
	}

	public void generate_field(Vector3 gen_pos) {

		for(int i = 0; i <= tile_max_count; i++) {
			GameObject tile = pick_tile_type(tile_object_list);
			Vector3 new_gen_pos = generate_position(gen_pos, i);
			Instantiate(tile, new_gen_pos, Quaternion.identity);
		}

	}

	private GameObject pick_tile_type(List<GameObject> tile_object_list){
		int rand_int = Random.Range(0, 100);
    	return tile_object_list[rand_int];
	}

	private Vector3 generate_position(Vector3 gen_pos, int i) {
		return gen_pos;
	}

}