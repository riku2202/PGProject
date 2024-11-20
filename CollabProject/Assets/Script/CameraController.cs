using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] float muoseSensitvity = 100f;
    [SerializeField] Transform playerBody;

    private float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * muoseSensitvity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * muoseSensitvity * Time.deltaTime;
        //
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        //カメラのx回転を適用
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        //プレイヤー本体の左右回転(Y軸)
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
