using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public PlayerController playerPos;
    private Vector3 cameraOffset;
    
	private void LateUpdate()
	{
        cameraOffset = playerPos.playerPos;
        cameraOffset.x = cameraOffset.x - 0.5f;
        cameraOffset.y = cameraOffset.y + 5.133333f;
        cameraOffset.z = cameraOffset.z - 5.1f;

        transform.position = cameraOffset;
    }

}
