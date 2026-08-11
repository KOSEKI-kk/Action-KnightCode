using UnityEngine;
using UnityEngine.SceneManagement;
//繧ｲ繝ｼ繝邨ゆｺ・
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
