using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weight_List {

	public Object tile_object;
    public string path;
	public int weight;

	public List<Object> InitList(){
		List<Weight_List> tiles = new List<Weight_List>{
			// 抽選割合、
			new Weight_List{path = "_Prefab/desert", 	weight = 2	},
			new Weight_List{path = "_Prefab/wood",		weight = 10	},
			new Weight_List{path = "_Prefab/oil", 		weight = 10	},
			new Weight_List{path = "_Prefab/iron",     weight = 10	},
			new Weight_List{path = "_Prefab/food", 	weight = 15	},
			new Weight_List{path = "_Prefab/gold", 	weight = 3	}
		};

		List<Object> tile_object_list = new List<Object>();
    	foreach(Weight_List tile in tiles){
            for(int i = 1; i <= tile.weight; i++){
                Debug.Log(tile.path);
                tile_object = gen_object(tile.path);
       			tile_object_list.Add(tile_object);
    		}
    	}
		return tile_object_list;
	}

    public Object gen_object(string path){
        Object tile_object = new Object();
        tile_object = Resources.Load(path);
        return tile_object;
    }
}
