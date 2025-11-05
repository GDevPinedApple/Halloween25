using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviourSingleton<SceneLoader>
{
    public void LoadScene(SceneId scene)
    {
        SceneManager.LoadScene((int)scene);
    }

    public void LoadMainMenu() => LoadScene(SceneId.MainMenu);

    public void LoadGameScene() => LoadScene(SceneId.GameScene);
}

public enum SceneId
{
    MainMenu,
    GameScene
}