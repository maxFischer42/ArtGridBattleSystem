using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public Vector3 loc;

    private bool loadScene = false;

    public int scene;
    [SerializeField]
    private Text loadingText;

    public void Start()
    {
        if(PlayerPrefs.GetInt("LvlID") == 0)
        {
            PlayerPrefs.SetInt("LvlID", 1);
            PlayerPrefs.SetFloat("LvlX",-16f);
            PlayerPrefs.SetFloat("LvlY",1.4f);
            PlayerPrefs.SetFloat("LvlZ",-11.7f);
        }

    }

    // Updates once per frame
    void Update()
    {
        // If the player has pressed the space bar and a new scene is not loading yet...
        if (loadScene == false)
        {
            scene = PlayerPrefs.GetInt("LvlID");
            DontDestroyOnLoad(gameObject);

            // ...set the loadScene boolean to true to prevent loading a new scene more than once...
            loadScene = true;

            // ...change the instruction text to read "Loading..."
            loadingText.text = "Loading...";

            // ...and start a coroutine that will load the desired scene.
            StartCoroutine(LoadNewScene());

        }

        // If the new scene has started loading...
        if (loadScene == true)
        {

            // ...then pulse the transparency of the loading text to let the player know that the computer is still working.
            loadingText.color = new Color(loadingText.color.r, loadingText.color.g, loadingText.color.b, Mathf.PingPong(Time.time, 1));

        }

    }


    // The coroutine runs on its own at the same time as Update() and takes an integer indicating which scene to load.
    IEnumerator LoadNewScene()
    {

        // This line waits for 3 seconds before executing the next line in the coroutine.
        // This line is only necessary for this demo. The scenes are so simple that they load too fast to read the "Loading..." text.
        yield return new WaitForSeconds(3);

        // Start an asynchronous operation to load the scene that was passed to the LoadNewScene coroutine.
        AsyncOperation async = Application.LoadLevelAsync(scene);

        // While the asynchronous operation to load the new scene is not yet complete, continue waiting until it's done.
        while (!async.isDone)
        {
            yield return null;
        }
        loc = new Vector3(PlayerPrefs.GetFloat("LvlX"), PlayerPrefs.GetFloat("LvlY"), PlayerPrefs.GetFloat("LvlZ"));
        GameObject.FindObjectOfType<PlayerController>().transform.SetPositionAndRotation(loc, Quaternion.identity);
        Destroy(gameObject);

    }

}