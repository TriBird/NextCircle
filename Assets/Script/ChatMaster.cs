using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using DG.Tweening;

public class ChatMaster : MonoBehaviour
{

    public Transform NewMessage_Trans, Tatsumi_Trans;
    public InputField Message_IF;

    // Start is called before the first frame update
    void Start()
    {
        DOVirtual.DelayedCall(3f, ()=>{
            Tatsumi_Trans.gameObject.SetActive(true);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Tatsumi_Click(){
        SceneManager.LoadScene("TatsumiPage");
    }

    public void InputMessage(){
        NewMessage_Trans.Find("Image (1)/Text (Legacy)").GetComponent<Text>().text = Message_IF.text;
        Message_IF.text = "";
        NewMessage_Trans.gameObject.SetActive(true);
    }

}
