using UnityEngine;
using UnityEngine.SceneManagement;

public class StartCC : MonoBehaviour
{

    public void mainScene()
    {
        Debug.Log("Hi");
        SceneManager.LoadSceneAsync(1);
    }
}
