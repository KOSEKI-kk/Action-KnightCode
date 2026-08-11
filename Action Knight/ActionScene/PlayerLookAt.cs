using UnityEngine;
//プレイヤーの向きを計算
public class PlayerLookAt : MonoBehaviour
{
    float Move;

    void Update()
    {
        Move = Input.GetAxis("Horizontal");
        if (Move > 0)
            transform.forward = Vector3.right;
        else if (Move < 0)
            transform.forward = Vector3.left;

    }
}
