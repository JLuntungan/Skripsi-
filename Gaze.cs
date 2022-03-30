using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Gaze : MonoBehaviour
{

    List<InfoBehavior> infos = new List<InfoBehavior>();

    void Start()
    {
        infos = FindObjectsOfType<InfoBehavior>().ToList();
    }

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
        {
            GameObject go = hit.collider.gameObject;
            if (go.CompareTag("hasInfo"))
            {
                BukaInfo(go.GetComponent<InfoBehavior>());
            }

        }
        else
        {
            CloseAll();
        }
    }

    void BukaInfo(InfoBehavior desiredInfo)
    {
        foreach (InfoBehavior info in infos)
        {
            if (info == desiredInfo)
            {
                info.BukaInfo();
            }
            else
            {
                info.Tutupinfo();
            }
           
        }
    }

    void CloseAll()
    {
        foreach (InfoBehavior info in infos)
        {
            info.Tutupinfo();
        }
    }


   

}
