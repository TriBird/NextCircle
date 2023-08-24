using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using DG.Tweening;

public class FlickHundler : MonoBehaviour
{
    Vector3 _clickStartPosition = Vector2.zero;

    [SerializeField] float _threshold = 30;

    public int CardIndex = 0;

    public enum FlickDirection
    {
        Left,
        Right,
        Up,
        Down,
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _clickStartPosition = Input.mousePosition;

        }
        else if (Input.GetMouseButtonUp(0))
        {
            // if(_clickStartPosition.y < 950 && _clickStartPosition.y > 660){
                Vector3 dif = Input.mousePosition - _clickStartPosition;

                float abs_x = Mathf.Abs(dif.x);
                float abs_y = Mathf.Abs(dif.y);

                if (abs_x >= _threshold || abs_y >= _threshold)
                {
                    // 横方向
                    if (abs_x > abs_y)
                    {
                        Flick(dif.x > 0 ? FlickDirection.Right : FlickDirection.Left);
                    }
                    // 縦方向
                    else
                    {
                        Flick(dif.y > 0 ? FlickDirection.Up : FlickDirection.Down);
                    }
                }
            // }
        }
    }

    public void CardMove(){
        transform.DOLocalMoveX(-780f*CardIndex, 0.3f);
    }

    public void Flick(FlickDirection dir)
    {
        // ここでフリックされた方向に応じて色々して！
        if(dir == FlickDirection.Left){
            CardIndex++;
            if(CardIndex > 3) CardIndex = 3;
            CardMove();
        }
        if(dir == FlickDirection.Right){
            CardIndex--;
            if(CardIndex < 0) CardIndex = 0;
            CardMove();
        }
    }
}
