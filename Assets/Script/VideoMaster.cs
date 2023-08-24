using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using DG.Tweening;

public class VideoMaster : MonoBehaviour
{

    public RawImage raw_img;
    public Transform VideoContainer, Sengen_Trans, End_trans, Mentor_Trans, Confirm_Trans;
    public Text timer_Text;

    private WebCamTexture webcam;

    private int min = 30;
    private int sec = 0;

    private void WebCam_On() {
        print("make");

        webcam = new WebCamTexture();
        raw_img.texture = webcam;

        // webcam.requestedWidth = 340;
        // webcam.requestedHeight = 340;

        webcam.Play();
    }

    public IEnumerator Timer(){
        while(true){
            yield return new WaitForSeconds(1f);

            if(min == 0 && sec == 0){
                TheEnd();
                yield break;
            }

            if(sec == 0){
                min -= 1;
                sec = 59;
            }else{
                sec -= 1;
            }

            timer_Text.text = min.ToString("00") + ":" + sec.ToString("00");
        }
    }

    public void GotoChat(){
        SceneManager.LoadScene("Home");
    }

    public void Sengen(){
        Sengen_Trans.gameObject.SetActive(false);

        foreach(Transform trans in VideoContainer){
            if(trans.GetComponent<VideoPlayer>() == null) continue;
            trans.GetComponent<VideoPlayer>().Play();
        }

        WebCam_On();

        StartCoroutine(Timer());
    }

    public void TheEnd(){
        VideoContainer.GetComponent<CanvasGroup>().DOFade(0, 0.5f);

        End_trans.DOLocalMoveY(0, 0.5f);
    }

    public void Skip(){
        min = 0;
        sec = 3;
    }

    public void Coach_Calling(){
        Confirm_Trans.GetComponent<CanvasGroup>().alpha = 0;
        Confirm_Trans.gameObject.SetActive(true);
        Confirm_Trans.GetComponent<CanvasGroup>().DOFade(1, 0.5f);
    }

    public void Coach_yappaiiya(){
        Confirm_Trans.GetComponent<CanvasGroup>().DOFade(0, 0.3f).OnComplete(()=>{
            Confirm_Trans.gameObject.SetActive(false);
        });
    }

    public void VideoContainerMoving(){
        Confirm_Trans.gameObject.SetActive(false);

        VideoContainer.DOLocalMoveY(-570.15f, 0.5f).OnComplete(()=>{
            Mentor_Trans.GetComponent<CanvasGroup>().DOFade(1, 0.5f);
            Mentor_Trans.gameObject.SetActive(true);
        });

        DOVirtual.DelayedCall(10f, ()=>{
            Mentor_Trans.GetComponent<CanvasGroup>().DOFade(0, 0.5f).OnComplete(()=>{
                Mentor_Trans.gameObject.SetActive(false);
            });
            VideoContainer.DOLocalMoveY(-85.47f, 0.5f);
        });
    }
}
