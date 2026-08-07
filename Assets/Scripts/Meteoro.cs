using UnityEngine;

public class Meteoro : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float tamanhoaleatorio = Random.Range(0.5f, 2.0f);

        transform.localScale = new Vector3(tamanhoaleatorio, tamanhoaleatorio, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
