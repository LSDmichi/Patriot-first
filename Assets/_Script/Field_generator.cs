using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field_generator : MonoBehaviour {

	public int tile_max_count; // 最大タイル数
	private Vector3 new_gen_pos;

	public void generate_field(){
        Vector3 gen_pos = new Vector3(-45, 1, 45);
        Weight_List name_list = new Weight_List();
		List<Object> tile_object_list = name_list.InitList();

		for(int i = 0; i <= tile_max_count; i++) {
			Object tile = pick_tile_type(tile_object_list);
			new_gen_pos = GeneratePosition(gen_pos, i);
            GameObject obj = (GameObject)Instantiate(tile, new_gen_pos, Quaternion.identity);
            GameObject parent_obj = GameObject.Find("field");
            obj.transform.parent = parent_obj.transform;
        }
	}

	private Object pick_tile_type(List<Object> tile_object_list){
		int rand_int = Random.Range(0, 50);
		Object tile = tile_object_list[rand_int];
    	return tile;
	}

	private Vector3 GeneratePosition(Vector3 gen_pos, int i) {
        
        float x = (i % 10) * 10 + gen_pos.x;
        float z = gen_pos.z - (i / 10) * 10;
        new_gen_pos = new Vector3(x, gen_pos.y, z);

        return new_gen_pos;
	}
}