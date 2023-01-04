using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
   private Sprite[] Object = new Sprite[4];
    [SerializeField]
    private GameObject UI;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            UI.GetComponent<Image>().sprite = Object[0];
           
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            UI.GetComponent<Image>().sprite = Object[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            UI.GetComponent<Image>().sprite = Object[2];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            UI.GetComponent<Image>().sprite = Object[3];
        }
    }
}
