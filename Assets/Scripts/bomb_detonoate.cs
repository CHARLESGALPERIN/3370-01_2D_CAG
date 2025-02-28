using System.Collections;
using UnityEngine;

public class bomb_detonoate : MonoBehaviour
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
        yield return new WaitForSeconds(3.3f);
        Destroy(this.gameObject);
    }
}
