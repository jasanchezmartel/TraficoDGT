using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMainMenu : MonoBehaviour {
    public void Gotoscene() {
        SceneManager.LoadScene("MainMenu");
    }
}