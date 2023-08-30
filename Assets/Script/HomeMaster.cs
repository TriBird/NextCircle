using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HomeMaster : MonoBehaviour
{

    public int time_index = 0;
    public Transform TimeBox_Trans;


    public void Time_Select(int index){
        time_index = index;

        foreach(Transform trans in TimeBox_Trans){
            trans.GetComponent<Image>().color = new Color32(0xCC, 0xCC, 0xCC, 0xFF);
        }
        TimeBox_Trans.GetChild(time_index).GetComponent<Image>().color = new Color32(0x5A, 0xC4, 0x63, 0xFF);
    }

    public void StartMTG(){
        // SceneManager.LoadScene("VideoKaigi");
        SceneManager.LoadScene("Matching");
    }

    public void GotoPortal(){
        SceneManager.LoadScene("Portal");
    }

}
