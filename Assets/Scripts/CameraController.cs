using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private float smoothSpeed;
    private int zOffset = -20;
    public GameObject player;
    Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        smoothSpeed = 2f;
        cam = GetComponent<Camera>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = new Vector3(player.transform.position.x , player.transform.position.y, player.transform.position.z + zOffset);
        Vector3 smoothedPos = Vector3.Lerp(transform.position, target, smoothSpeed);
        transform.position = smoothedPos;
    }
}
