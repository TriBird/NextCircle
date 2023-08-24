using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class archivementCtrl : MonoBehaviour
{

    bool isOpen = false;

    public void achivement_click(){
        isOpen = !isOpen;
        if(isOpen){
            transform.DOLocalMoveY(-688.19f, 0.5f);
        }else{
            transform.DOLocalMoveY(-898.7f, 0.5f);
        }
    }

    public void GotoHome(){
        SceneManager.LoadScene("Home");
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
