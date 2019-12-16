using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera_Action : MonoBehaviour
{
    public GameObject player; //2D이기 때문에 Z축 값만 변화시킴
    public float offsetX = 0f;
    public float offsetY = 0f;
    public float offsetZ = -5f;

    Vector3 cameraPosition;

    void LateUpdate() //캐릭터가 움직이는 곳으로 카메라가 따라서 움직이므로 LateUpdate 사용
    {
        cameraPosition.x = player.transform.position.x + offsetX;
        cameraPosition.y = player.transform.position.y + offsetY;
        cameraPosition.z = player.transform.position.z + offsetZ;

        transform.position = cameraPosition;
    }
}
