using UnityEngine;
using UnityEngine.SceneManagement;
//ゲームスタート
public class Start : MonoBehaviour
{
    public string scene = "";

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            SceneManager.LoadScene(scene);
        }
    }
}
