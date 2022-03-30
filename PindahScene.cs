using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PindahScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene(string namascene)
    {
        SceneManager.LoadScene(namascene);
    }
}
