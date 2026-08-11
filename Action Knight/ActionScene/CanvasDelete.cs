using UnityEngine;
//画面上の文字を消す
public class CanvasDelete : MonoBehaviour
{
    //GameObject Canvas;

    void Start()
    {
        //Canvas = GameObject.Find("Canvas");
    }

    void Update()
    {
        //bool C = Canvas.activeSelf;

        if (Input.GetKeyDown(KeyCode.W))
        {
            var canvas = KeepUI.Instance.canvas;
            canvas.SetActive(!canvas.activeSelf);
            //Canvas.SetActive(!C);
        }
    }
}
