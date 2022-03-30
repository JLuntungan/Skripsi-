using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoBehavior : MonoBehaviour
{
    const float SPEED = 6f;
    public AudioSource suara;

    [SerializeField]
    Transform SectionInfo;

    Vector3 desiredScale = Vector3.zero;

    

    // Update is called once per frame
    void Update()
    {
        SectionInfo.localScale = Vector3.Lerp(SectionInfo.localScale, desiredScale, Time.deltaTime * SPEED);
    }

    public void BukaInfo()
    {
       
        desiredScale = Vector3.one;
        suara.Play();
    }

    public void Tutupinfo()
    {
        desiredScale = Vector3.zero;
        suara.Stop();
    }

    void Awake()
    {
        suara = GetComponent<AudioSource>();
    }
}
