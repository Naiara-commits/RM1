using System.Collections;
using UnityEngine;

public class Cubos : MonoBehaviour
{
    [SerializeField] public GameObject cuboPrefab;
    [SerializeField] private Transform player;
    [SerializeField] public float dist = 10f;
    [SerializeField] private float Angle = 90f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(spawnCubo), 0f, 4f);

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void spawnCubo()
    {

        Camera cam = Camera.main;

        Vector3 playerForward = player.forward;
        playerForward.y = 0f;
        playerForward.Normalize();

        float randAngle = Random.Range(Angle / 2f, -Angle / 2f);
        Quaternion rot = Quaternion.AngleAxis(randAngle, Vector3.up);
        Vector3 direction = rot * playerForward;

        Vector3 pos = player.position + direction * dist;
        pos.y = cam.transform.position.y;

        Instantiate(cuboPrefab, pos, Quaternion.identity);
    }

}
