using UnityEngine;

public class MovimientoCubo : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private Transform player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        Destroy(gameObject, 3f);

    }

    // Update is called once per frame
    void Update()
    {
        if (player == null) return;

        Vector3 objetivo = player.position;
        objetivo.y = Camera.main.transform.position.y;

        transform.position = Vector3.MoveTowards(transform.position, objetivo, speed * Time.deltaTime);

        transform.LookAt(player);

    }
}
