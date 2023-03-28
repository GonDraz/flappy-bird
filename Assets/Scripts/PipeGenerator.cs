using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    public GameObject pipePrefab;

    public bool enableGeneratorPipe;
    public float timeDuration;
    private float countdown;

    private void Awake()
    {
        countdown = timeDuration;
        enableGeneratorPipe = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (enableGeneratorPipe == true)
        {
            countdown -= Time.deltaTime;

            if (countdown <= 0)
            {
                Instantiate(pipePrefab, new Vector3(4, Random.Range(-1.2f, 3f), 0), Quaternion.identity);

                countdown = timeDuration;
            }

        }

    }
}
