using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weight_List : MonoBehaviour {

	public string tile_name;
	public int weight;

	public List<Weight_List> InitList(){
		List<Weight_List> tiles = new List<Weight_List>{
			// 抽選割合、
			new Weight_List{ tile_name = "desert",		weight = 2	},
			new Weight_List{ tile_name = "wood",		weight = 10	},
			new Weight_List{ tile_name = "oil", 		weight = 10	},
			new Weight_List{ tile_name = "iron", 		weight = 10	},
			new Weight_List{ tile_name = "food", 		weight = 15	},
			new Weight_List{ tile_name = "gold", 		weight = 3	}
		};

		return tiles;
	}
}
