using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field_generator : MonoBehaviour {

	public int tile_max_count; // 最大タイル数
	private List<Object> tile_object_list; // タイル
	private Vector3 gen_pos; // 生成場所
	private Vector3 new_gen_pos;

	// Use this for initialization
	void Start () {
		Vector3 gen_pos = new Vector3(-45, 1, 45);
		int tile_max_count = 100; // after everthig has done, we create more unique maps
		Weight_List name_list = new Weight_List();
		List<Object> tile_object_list = name_list.InitList();
	}

	public void generate_field(Vector3 gen_pos) {

		for(int i = 0; i <= tile_max_count; i++) {
			Object tile = pick_tile_type(tile_object_list);
			new_gen_pos = generate_position(gen_pos, i);
			Instantiate(tile, new_gen_pos, Quaternion.identity);
		}

	}

	private Object pick_tile_type(List<Object> tile_object_list){
		int rand_int = Random.Range(0, 100);
		Object tile = tile_object_list[rand_int];
    	return tile;
	}

	private Vector3 generate_position(Vector3 gen_pos, int i) {
		if (i <= 10) {
			float x = i * 10 + gen_pos.x;
			new_gen_pos = new Vector3(x, gen_pos.y, gen_pos.z);
		} else if (i > 10) {
			float x = gen_pos.x + (i * 10);
			float y = gen_pos.y + ((i / 10) * 10);
			new_gen_pos = new Vector3(x, y, gen_pos.z);
		}

		return new_gen_pos;
	}

}