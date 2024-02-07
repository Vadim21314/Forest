using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WoodController : MonoBehaviour
{
    public int k = 0;
    public TextMeshProUGUI Tool_text;
    public TextMeshProUGUI Tub_text;
    public bool isHouse = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision obj){
        if(obj.gameObject.tag == "Tool"){         
            obj.gameObject.transform.SetParent(gameObject.transform.GetChild(0).GetChild(k).transform);
            obj.gameObject.transform.localPosition = new Vector3(0,0,0);
            obj.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            k++;
            Tool_text.text = k.ToString();
            transform.Find("Light").gameObject.SetActive(false);
            //x += 2f;
            //obj.gameObject.GetComponent<Collider>().isTrigger = true; 
        }
    }
}
