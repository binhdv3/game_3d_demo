using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 moveVector;

    private MeshCollider _meshCollider; //mat luoi cua coin

    private void Awake()
    {
        _meshCollider = GetComponent<MeshCollider>();
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Hanhdong()
    {
        transform.position = transform.position + new Vector3(2, 2);

        int i = 0;

        Destroy(gameObject, 2f);
    }
}