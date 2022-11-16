using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_script : MonoBehaviour
{
    [SerializeField]
    float[] unityZahl1 = new float[10];
    [SerializeField]
    Color[] unityColor2 = new Color[10];
    [SerializeField]
    float[] systemZahl1 = new float[10];

    // Start is called before the first frame update
    void Start()
    {
        Random.seed = 42;

        for (int i = 0; i < systemZahl1.Length; i++)
        {
            systemZahl1[i] = Random.value;
        }

        for (int i = 0; i < unityZahl1.Length; i++)
        {
            unityZahl1[i] = Random.Range(-10.5f, 10.5f);
        }

        for (int i = 0; i < unityColor2.Length; i++)
        {
            unityColor2[i] = Random.ColorHSV();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
