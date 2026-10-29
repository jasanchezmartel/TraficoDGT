using UnityEngine;
using UnityEngine.SceneManagement;

public class ToCredits : MonoBehaviour {
    public void Gotoscene() {
        SceneManager.LoadScene("Credits");
    }
}