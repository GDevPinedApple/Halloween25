using UnityEngine.SceneManagement;

namespace Persistent
{
    public class SceneLoader : MonoBehaviourSingleton<SceneLoader>
    {
        public void LoadScene(SceneId scene)
        {
            SceneManager.LoadScene((int)scene);
        }

        public void LoadMainMenu() => LoadScene(SceneId.MainMenu);
        public void LoadIndoorsScene() => LoadScene(SceneId.IndoorsScene);
        public void LoadOutdoorsScene() => LoadScene(SceneId.OutdoorsScene);
        public void LoadFieldScene() => LoadScene(SceneId.FieldScene);
        public void LoadLabyrinthScene() => LoadScene(SceneId.LabyrinthScene);
        public void LoadGraveyardScene() => LoadScene(SceneId.GraveyardScene);
        public void LoadAlleyScene() => LoadScene(SceneId.AlleyScene);
        public void LoadFairScene() => LoadScene(SceneId.FairScene);
    }

    public enum SceneId
    {
        MainMenu,
        IndoorsScene,
        OutdoorsScene,
        FieldScene,
        LabyrinthScene,
        GraveyardScene,
        AlleyScene,
        FairScene
    }
}