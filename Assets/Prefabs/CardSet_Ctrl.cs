using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardSet_Ctrl : MonoBehaviour
{

    public List<string> AppName = new List<string>();
    public List<Sprite> AppImg = new List<Sprite>();

    public GameObject Card_prefab;
    public Text text;

    public int SelectID = 0;

    // Start is called before the first frame updat e
    void Start()
    {
        Placement(-1);
    }

    public void Placement(int select){
        SelectID = select;

        foreach(Transform trans in transform){
            Destroy(trans.gameObject);
        }

        for(int i=0; i<12; i++){
            GameObject pref = Instantiate(Card_prefab, transform);
            pref.transform.Find("Masked/Icon").GetComponent<Image>().sprite = AppImg[i];
            pref.GetComponentInChildren<Text>().text = AppName[i];
            pref.GetComponent<Card_Ctrl>().cs = this;
            pref.GetComponent<Card_Ctrl>().number = i;

            if(SelectID == i){
                pref.GetComponent<Image>().color = new Color32(0xC3, 0xEA, 0xC6, 0xFF);
                text.text = AppName[i] + "を頑張る";
            }else{
                pref.GetComponent<Image>().color = new Color32(0xFF, 0xFF, 0xFF, 0xFF);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
