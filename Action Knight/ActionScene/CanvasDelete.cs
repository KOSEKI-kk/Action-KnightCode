using UnityEngine;
//‰æ–Êã‚Ì•¶š‚ğÁ‚·
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
