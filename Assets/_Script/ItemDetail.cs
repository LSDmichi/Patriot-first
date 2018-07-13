using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct ItemDetail
{
    string item_name; //アイテムの名前
    string item_description; //アイテムの詳細
    int item_effect; //アイテムの効果
    uint item_value; //アイテムの効果値
    int type; //カードのタイプ(資源だったり、効果カード、判例カード)
    Texture item_image; //アイテムの画像

    public ItemDetail Food()
    {
        this.item_name = "food";
        this.item_description = "食料カード";
        this.item_effect = 0;
        this.item_value = 0;
        this.type = 0;
        this.item_image = Resources.Load("card/texture/food") as Texture;
        return this;
    }

}