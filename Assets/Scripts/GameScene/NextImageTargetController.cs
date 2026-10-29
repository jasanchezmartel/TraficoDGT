using UnityEngine;
using TMPro;

public class NextImageTargetController : MonoBehaviour {
    [Header("Lista de ImageTargets")]
    public GameObject[] imageTargets;

    [Header("Descripciones de cada imagen")]
    public string[] targetNames;

    [Header("Referencia al Texto de la UI")]
    public TextMeshProUGUI infoText;

    private int currentIndex = 0;

    void Start() {
        UpdateTargets();
    }

    public void NextTarget() {
        if (imageTargets == null || imageTargets.Length == 0) return;
        currentIndex = (currentIndex + 1) % imageTargets.Length;
        UpdateTargets();
    }

    void UpdateTargets() {
        for (int i = 0; i < imageTargets.Length; i++) {
            if (imageTargets[i] != null) {
                imageTargets[i].SetActive(i == currentIndex);
            }
        }

        if (infoText != null && targetNames != null && targetNames.Length > currentIndex) {
            infoText.text = targetNames[currentIndex];
        }
    }
}