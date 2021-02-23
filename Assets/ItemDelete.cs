using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDelete : MonoBehaviour
{
    private GameObject MainCamera;
    private float difference;
    public GameObject carPrefab;
    public GameObject coinPrefab;
    public GameObject conePrefab;
    // Start is called before the first frame update
    void Start()
    {
        this.MainCamera = GameObject.Find("Main Camera");
        this.difference = MainCamera.transform.position.z - this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.z < MainCamera.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}
