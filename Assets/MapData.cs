using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapData : MonoBehaviour
{
    //private static MapData instance = null;

    //private void Awake()
    //{
    //    if(null == instance)
    //    {
    //        instance = this;
           
    //    }
    //}
    //public static MapData Instance
    //{
    //    get
    //    {
    //        if (null == instance)
    //        {
    //            return null;
    //        }
    //        return instance;
    //    }
    //}

    public List<Transform> ObjectPos;

    public List<GameObject> Structure;
    Vector3 sencerpos;
    // Start is called before the first frame update
    void Start()
    {
        sencerpos = gameObject.transform.position + new Vector3(0, 1, 0);
    }



    public void MapDataSave()
    {
        ObjectPos.Clear();
        Structure.Clear();
        Collider[] Maps = Physics.OverlapBox(sencerpos, gameObject.transform.localScale); // 콜라이더에 닿은 객체들의 위치랑 오브젝트 정보를 받아서 저장
        foreach (Collider box in Maps)
        {
            if (box.tag == "Tile")
            {
                continue;
            }
            if (box.tag == "Structure")
            {
                ObjectPos.Add(box.gameObject.transform);
                Structure.Add(box.gameObject);
                
            }
            
        }
        
    }

 

    
    
}
