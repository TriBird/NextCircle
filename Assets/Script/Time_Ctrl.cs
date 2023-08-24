using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Time_Ctrl : MonoBehaviour, IPointerClickHandler
{

    bool isClicked = false;

    public void OnPointerClick(PointerEventData eventData)
    {
        isClicked = !isClicked;
        if(isClicked){
            transform.Find("Image (4)").GetComponent<Image>().color = new Color32(0xC3, 0xEA, 0xC6, 0xFF);
        }else{
            transform.Find("Image (4)").GetComponent<Image>().color = new Color32(0xFF, 0xFF, 0xFF, 0xFF);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
