using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GotoHackerthon(){
        SceneManager.LoadScene("Hackerson");
    }

    public void GotoPortal(){
        SceneManager.LoadScene("Recommend");
    }
}
