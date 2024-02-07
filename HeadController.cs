using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadController : MonoBehaviour
{
    public GameObject PressE;
    public Indicators BarsScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, 50f))
        {
            
            if(hit.transform.tag == "Bush"){
                PressE.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if(hit.transform.GetComponent<BushController>().count  > 0) {
                        hit.transform.GetComponent<BushController>().count -= 5;
                        BarsScript.foodAmount += 5;
                    }else {
                        hit.transform.gameObject.SetActive(false);
                    }
                    
                }

            }else{
                PressE.SetActive(false);
            }
            if(hit.transform.tag == "Barrel"){
                PressE.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    BarsScript.waterAmount += 5;
                }

            }
            
            
        }
        
        
    }
}
