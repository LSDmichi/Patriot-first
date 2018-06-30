using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weight_List {

	public GameObject tile_object;
	public int weight;

	public List<GameObject> InitList(){
		List<Weight_List> tiles = new List<Weight_List>{
			// 抽選割合、
			new Weight_List{tile_object = Resources.Load("/_Prefab/desert"), 	weight = 2	},
			new Weight_List{tile_object = Resources.Load("/_Prefab/wood"),		weight = 10	},
			new Weight_List{tile_object = Resources.Load("/_Prefab/oil"), 		weight = 10	},
			new Weight_List{tile_object = Resources.Load("/_Prefab/iron"), 		weight = 10	},
			new Weight_List{tile_object = Resources.Load("/_Prefab/food"), 		weight = 15	},
			new Weight_List{tile_object = Resources.Load("/_Prefab/gold"), 		weight = 3	}
		};

		List<GameObject> tile_object_list = new List<GameObject>();
    	foreach(Weight_List tile in tiles){
       		for(int i = 1; i <= tile.weight; i++){
       			tile_object_list.Add(tile.tile_object);
    		}
    	}

		return tile_object_list;
	}
}
