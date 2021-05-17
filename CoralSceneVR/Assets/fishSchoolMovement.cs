using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishSchoolMovement : MonoBehaviour
{
    public GameObject fish;
    float timer;
    bool alt = true;

    void Update()
    {
        timer += Time.deltaTime;
        fish.transform.Translate(new Vector3(0.1f, 0.0f, 0.0f));

        if (timer >= 3 && alt)
        {
            timer = 0;
            alt = !alt;
            fish.transform.Rotate(0, 25, 0, Space.Self);
        }
        if (timer >= 3 && !alt)
        {
            timer = 0;
            alt = !alt;
            fish.transform.Rotate(0, 75, 0, Space.Self);
        }

    }
}
