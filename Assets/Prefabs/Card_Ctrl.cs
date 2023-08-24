using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Card_Ctrl : MonoBehaviour, IPointerClickHandler
{

    public CardSet_Ctrl cs;
    public int number = 0;
    bool isClicked = false;

    public void OnPointerClick(PointerEventData eventData)
    {
        cs.Placement(number);
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
