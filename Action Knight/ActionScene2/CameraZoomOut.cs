using Unity.Cinemachine;
using UnityEngine;
//カメラのズームアウト
public class CameraZoomOut : MonoBehaviour
{
    public CinemachineCamera vcam;
    private CinemachinePositionComposer composer;

    void Start()
    {
        composer = vcam.GetComponent<CinemachinePositionComposer>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Debug.Log("Enter");
            composer.TargetOffset = new Vector3(0, -5, 0);
        }
    }

    /*void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            composer.TargetOffset = new Vector3(0, -5, 0);
        }
    }*/

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Debug.Log("Exit");
            composer.TargetOffset = new Vector3(0, 1, 5);
        }
    }
}
