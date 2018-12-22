using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelWarp : MonoBehaviour
{

    public Vector3 Location;
    public int load;

    private void OnTriggerEnter(Collider other)
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("LevelLoader");
        PlayerPrefs.SetInt("LvlID", load);
        PlayerPrefs.SetFloat("LvlX", Location.x);
        PlayerPrefs.SetFloat("LvlY", Location.y);
        PlayerPrefs.SetFloat("LvlZ", Location.z);
        Destroy(gameObject);
    }
}
