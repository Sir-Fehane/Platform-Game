using UnityEngine;
using UnityEngine.SceneManagement;

public class TituloClass : MonoBehaviour
{
    public void buttonNewGame()
    {
            PlayerPrefs.SetInt("current_progress",0);
            SceneManager.LoadScene(1);
    }
    public void buttonContinue()
    {
        if (!PlayerPrefs.HasKey("current_progress"))
        {
            PlayerPrefs.SetInt("current_progress",0);
        }
        SceneManager.LoadScene(1);
    }
}
