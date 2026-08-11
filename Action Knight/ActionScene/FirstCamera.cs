using Unity.Cinemachine;
using UnityEngine;
using System.Collections;
//最初にステージ全体を見せる(旧)
public class FirstCamera : MonoBehaviour
{
    public CinemachineCamera vcam;
    private CinemachinePositionComposer composer;

    IEnumerator Start()
    {
        yield return null;
        composer = vcam.GetComponent<CinemachinePositionComposer>();
        vcam.Follow = GameObject.Find("Player").transform;
        StartCoroutine(WaitCamera());
    }

    IEnumerator WaitCamera()
    {
        yield return null;

        composer.TargetOffset = new Vector3(60, 10, -70);

        yield return new WaitForSeconds(3f);

        composer.TargetOffset = new Vector3(0.5f, 1, 5);
    }
}
