using System.Collections;
using UnityEngine;

public class bomb_spawner : MonoBehaviour
{
    public GameObject itemPrefab;

    //public float r;

    public float rectXMin = -11;
    public float rectXMax = 11;
    public float rectYMin = 6;
    public float rectYMax = 7;
    public float createBombs;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        createBombs = 4f;
        StartCoroutine(spawnObject());
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.B))
        //{
        //    spawnObject();
        //}
    }

    IEnumerator spawnObject()
    {
        while (true)
        {
            //Vector3 randomPos = Random.insideUnitCircle * r;
            //Instantiate(itemPrefab, randomPos, Quaternion.identity);
            float randomX = Random.Range(rectXMin, rectXMax);
            float randomY = Random.Range(rectYMin, rectYMax);
            Vector2 spawnPosition = new Vector2(randomX, randomY);

            Instantiate(itemPrefab, spawnPosition, Quaternion.identity);
            if (createBombs > 1.0f)
            {
                createBombs -= 0.1f;
            }
            yield return new WaitForSeconds(createBombs);
        }
    }

}
