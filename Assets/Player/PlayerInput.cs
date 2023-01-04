using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInput : MonoBehaviour
{
    float _speed = 3f;
    [SerializeField]
    Material Invmaterial;  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * _speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * _speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * _speed);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<MeshRenderer>().material.color == Color.green)
        {
            //gameObject.GetComponent<MeshRenderer>().material.color = new Color(255, 0, 0, 123); // 이거 질문있음 색깔이 이상함
            gameObject.GetComponent<MeshRenderer>().material = Invmaterial;
        }
        else if(other.gameObject.GetComponent<MeshRenderer>().material.color == Color.blue)
        {
            _speed /= 2;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<MeshRenderer>().material.color == Color.green)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        else if (other.gameObject.GetComponent<MeshRenderer>().material.color == Color.blue)
        {
            _speed = 5;
        }
    }
}
