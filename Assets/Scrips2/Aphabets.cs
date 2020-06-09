using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aphabets : MonoBehaviour
{

    public GameObject[] alphaPrefabs;
    private Transform playerTransform;
    private float spawnz = -6.0f;
    private float spawny = 1.0f;
    private float alphalength = 10.0f;
    private int amnalphaOnScreen = 80;
    private int lastPrefabIndex = 0;

    private float safezone = 15.0f;

    private List<GameObject> activealpha;

    // Start is called before the first frame update
    private void Start()
    {
        activealpha = new List<GameObject>();
        playerTransform = GameObject.FindGameObjectWithTag("Score").transform;

        for (int i = 0; i < amnalphaOnScreen; i++)
        {
            if (i < 2)
                Spawnalpha(0);
            else
                Spawnalpha();

        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (playerTransform.position.z > (spawnz - amnalphaOnScreen * alphalength))
        {
            Spawnalpha();
        }
    }
    private void Spawnalpha(int prefabIndex = -1)
    {
        GameObject go;
        if (prefabIndex == -1)
            go = Instantiate(alphaPrefabs[RandomPrefabIndex()]) as GameObject;
        else
            go = Instantiate(alphaPrefabs[RandomPrefabIndex()]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnz + Vector3.up* spawny;
        spawnz += (alphalength + 10.0f);
        activealpha.Add(go);
    }
  

    private int RandomPrefabIndex()
    {
        if (alphaPrefabs.Length <= 1)
            return 0;
        int randomIndex = lastPrefabIndex;
        while (randomIndex == lastPrefabIndex)
        {
            randomIndex = Random.Range(0, alphaPrefabs.Length);
        }
        lastPrefabIndex = randomIndex;
        return randomIndex;
    }
}
