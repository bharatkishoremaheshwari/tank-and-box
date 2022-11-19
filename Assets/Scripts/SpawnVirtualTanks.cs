using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnVirtualTanks : MonoBehaviour
{
    //

    [SerializeField]
    private List<GameObject> Tanks = new List<GameObject>();
    [SerializeField]
    private float startTime = 4f;
    [SerializeField]
    private float repeatRate = 5f;
    [SerializeField]
    private Transform tankParentGO;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnVTanks", startTime,repeatRate);
    }
    // TODO: Improve using Object Pooling
    public void SpawnVTanks()
    {
        int tankNum = Random.Range(0, Tanks.Count);
        Vector3 position = new Vector3(Random.Range(-1.5f, 1.5f) , 0.001f  , Random.Range(-1.5f, 1.5f) );
        GameObject tankInit = Instantiate(Tanks[tankNum], position, Quaternion.identity, tankParentGO);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
