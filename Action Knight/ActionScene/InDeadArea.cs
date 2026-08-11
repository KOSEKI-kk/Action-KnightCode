using UnityEngine;
using UnityEngine.SceneManagement;
//ゲームオーバーまたはステージクリア判定
public class InDeadArea : MonoBehaviour
{
    public string scene = "";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // プレイヤーだけ反応させる
        {
            SceneManager.LoadScene(scene);
        }
    }
}
