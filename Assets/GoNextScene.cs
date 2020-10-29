using UnityEngine;
using UnityEngine.SceneManagement;

public class GoNextScene : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("Darijumi");
    }

}
