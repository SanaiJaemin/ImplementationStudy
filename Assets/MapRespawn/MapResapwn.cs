using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapResapwn : MonoBehaviour
{
    int horizontal = 20;
    int vertical = 20;
   [SerializeField]
   private  GameObject MapTile;
    [SerializeField]
    private GameObject Player;


    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < vertical; i++)
        {
            for(int j = 0; j < horizontal; j++)
            {
                Vector3 TilePos = new Vector3(j, 0, i);
               GameObject tile =Instantiate(MapTile, TilePos, Quaternion.identity);
                string Tilepos = "X : " + j + " Z : " + i;
                tile.name = Tilepos;
                tile.transform.parent = gameObject.transform;

            }
        }


    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            Instantiate(Player, new Vector3(10, 1, 10), Quaternion.identity);
        }
    }




}
