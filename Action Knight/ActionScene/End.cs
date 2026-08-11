using UnityEngine;
using UnityEngine.SceneManagement;
//ゲームスタート
public class End : MonoBehaviour
{
    public string scene = "";

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene(scene);
        }
    }
}
