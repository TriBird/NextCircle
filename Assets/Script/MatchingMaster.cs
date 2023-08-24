using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MatchingMaster : MonoBehaviour
{

    public Transform Matching_Trans, Cell4_Trans, Cell5_Trans;
    public bool isMatching = false;

    // Start is called before the first frame update
    void Start()
    {
        if(isMatching){
            DOVirtual.DelayedCall(2f, ()=>{
                Cell4_Trans.gameObject.SetActive(true);
            });
            DOVirtual.DelayedCall(5f, ()=>{
                Cell5_Trans.gameObject.SetActive(true);
            });
            DOVirtual.DelayedCall(5f, ()=>{
                Matching_Trans.DOLocalMoveX(0f, 0.5f);
            });
            DOVirtual.DelayedCall(7f, ()=>{
                SceneManager.LoadScene("VideoKaigi");
            });
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Cancel(){
        SceneManager.LoadScene("SelectCategory");
    }

}
