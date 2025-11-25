using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegementGenerator : MonoBehaviour
{
    public GameObject[] segment;
    [SerializeField] int zPos = 170;
    [SerializeField] bool creatingSegment = false;
    [SerializeField] int segmentNum;

    public int distanceBetweenSegments;


    void Update()
    {
        if (creatingSegment == false)
        {
            creatingSegment = true;
            StartCoroutine(SegmentGen());
        }

    }

    IEnumerator SegmentGen()
    {
        segmentNum = Random.Range(0, 4);
        Instantiate(segment[segmentNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += distanceBetweenSegments;
        yield return new WaitForSeconds(10);
        creatingSegment = false;
    }

}
