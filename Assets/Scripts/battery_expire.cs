using System.Collections;
using UnityEngine;

public class battery_expire : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(fuse_time());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator fuse_time()
    {
        yield return new WaitForSeconds(4f);
        Destroy(this.gameObject);
    }
}
