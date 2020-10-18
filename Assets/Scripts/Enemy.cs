using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f;
    public float bound_x = -11f;

    private Transform _transform;
    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 temp = _transform.position;
        temp.x -= speed * Time.deltaTime;
        transform.position = temp;

        if (temp.x < bound_x)
            Destroy(gameObject);
    }
}
