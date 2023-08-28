using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;
    [SerializeField] private GameObject blueObj;
    
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        GameObject redPrefab = Instantiate(redObj, new Vector3(2f, 0f, 0f), Quaternion.identity);
        GameObject bluePrefab = Instantiate(blueObj, new Vector3(-2f, 0f, 0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
