using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private string scene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StarGame()
    {
        SceneManager.LoadScene(scene);
    }

    public void ExitGame()
    {
        //Editor Unity
        UnityEditor.EditorApplication.isPlaying = false;

        //Jogo Compilado
        // Application.Quit();
    }
}
