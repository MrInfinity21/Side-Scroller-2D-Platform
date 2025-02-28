using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    [SerializeField] private string _sceneToLoad;
    private bool bLoadingScene = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (bLoadingScene) return;
        bLoadingScene = true;
        SceneManager.LoadScene(_sceneToLoad);
    }
}