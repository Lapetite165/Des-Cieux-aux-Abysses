using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public int SceneBuildIndex = 1;
    //While clicking the button
    public void OnPlay()
    {
        PlayerManager.ChangeScene(SceneBuildIndex);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
