using UnityEngine;
//プレイヤーのアニメーション制御
public class PlayerAnimation : MonoBehaviour
{
    public PlayerMove PlayerMove;
    public Animator anim;
    float Move;

    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        if (PlayerMove.controller.isGrounded)
        {
            //走り
            if (Move != 0)
            {
                anim.SetBool("run", true);
            }
            else
            {
                anim.SetBool("run", false);
            }
        }
    }
}
