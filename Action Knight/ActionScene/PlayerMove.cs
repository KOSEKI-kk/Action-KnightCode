using UnityEngine;
//プレイヤー操作
public class PlayerMove : MonoBehaviour
{
    public float speed = 10F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    public CharacterController controller;
    private Vector3 moveDirection;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        //地面についている時
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
            //Transform.TransformDirectionはローカル空間からワールド空間へ方向Vectorを変換する
            moveDirection = transform.TransformDirection(moveDirection) * speed;
            //ジャンプ↓
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }
        //重力分変更する
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
