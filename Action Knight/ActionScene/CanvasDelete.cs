using UnityEngine;
//逕ｻ髱｢荳翫・譁・ｭ励ｒ豸医☆
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
