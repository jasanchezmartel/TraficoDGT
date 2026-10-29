using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {
    public void Gotoscene() {
        SceneManager.LoadScene("GameScene");
    }
}