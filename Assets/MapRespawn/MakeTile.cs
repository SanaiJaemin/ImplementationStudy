using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeTile : MonoBehaviour
{
    [SerializeField]
    GameObject[] tilePrefabs = new GameObject[3];
    [SerializeField]
    GameObject tilePrefab;
    enum ETile
    {
        Grass,
        River,
        Wall
    }

    bool Destruction;




    // Update is called once per frame

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            tilePrefab = null;
            Destruction = true;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Destruction = false;
            tilePrefab = tilePrefabs[(int)ETile.Grass];


        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Destruction = false;
            tilePrefab = tilePrefabs[(int)ETile.River];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Destruction = false;
            tilePrefab = tilePrefabs[(int)ETile.Wall];
        }



        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (Destruction)
                {
                    if (hit.transform.position.y >= 1f) //1이 아니면 삭제안됨 타일없애는거 방지
                    {
                        Destroy(hit.transform.gameObject);
                    }
                }
                Vector3 SpawnTilePos = new Vector3(hit.transform.position.x, 1, hit.transform.position.z);
                if (tilePrefab != null)
                {
                    Instantiate(tilePrefab, SpawnTilePos, Quaternion.identity);

                }



            }
        }
    }
}

