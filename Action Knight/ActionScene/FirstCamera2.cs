using Unity.Cinemachine;
using UnityEngine;
using System.Collections;
using System;
//最初にステージ全体を見せる
public class FirstCamera2 : MonoBehaviour
{
    public CinemachineCamera vcam;
    private CinemachinePositionComposer composer;

    IEnumerator Start()
    {
        yield return null;
        composer = vcam.GetComponent<CinemachinePositionComposer>();
        vcam.Follow = GameObject.Find("Player").transform;
        composer.TargetOffset = new Vector3(60, 10, -70);
        StartCoroutine(WaitCamera());
    }

    IEnumerator WaitCamera()
    {
        yield return new WaitForSeconds(3f);

        composer.TargetOffset = new Vector3(0, 1, 5);
    }

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            composer.TargetOffset = new Vector3(0, 1, 5);
        }
    }
}
