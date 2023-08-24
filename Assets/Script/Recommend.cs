using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class Recommend : MonoBehaviour
{

    public Transform RecommendRun_Trans, AI_Trans, Effect_Trans;

    public void Recommend_On(){
        RecommendRun_Trans.gameObject.SetActive(false);
        Sequence seq = DOTween.Sequence();
        seq.Append(AI_Trans.transform.DOLocalRotate(new Vector3(0,0,20), 0.3f).SetEase(Ease.Linear));
        seq.Append(AI_Trans.transform.DOLocalRotate(new Vector3(0,0,-20), 0.6f).SetEase(Ease.Linear));
        seq.Append(AI_Trans.transform.DOLocalRotate(new Vector3(0,0,20), 0.6f).SetEase(Ease.Linear));
        seq.Append(AI_Trans.transform.DOLocalRotate(new Vector3(0,0,0), 0.3f).SetEase(Ease.Linear));
        seq.OnComplete(()=>{
            int i = 0;
            foreach(Transform trans in Effect_Trans){
                trans.gameObject.SetActive(true);
                trans.DOLocalMoveY(trans.localPosition.y + 50f, 0.3f).SetDelay(i*0.1f);
                trans.GetComponent<CanvasGroup>().DOFade(1, 0.5f).SetDelay(i*0.1f);
                i++;
            }
        });
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
