using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public int SceneBuildIndex = 2;
    AudioSource audioSource;
    [SerializeField] ParticleSystem particlesSyst;
    public static void ChangeScene(int sceneBuildIndex = 2)
    {
        LoadSceneMode mode = LoadSceneMode.Single;
        AsyncOperation loadScene;
        loadScene = SceneManager.LoadSceneAsync(sceneBuildIndex, mode);
        if (!loadScene.isDone)
        {
            Debug.Log(null);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        if (Time.timeSinceLevelLoad >= particlesSyst.startDelay + 3f)
        {
            ChangeScene(SceneBuildIndex);
        }
    }
}
