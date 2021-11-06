using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Text username_field;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void QuitGame()
    {
        // check if the game is running in the editor or in a compiled Version
#if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();
#else
            Application.Quit();
#endif
    }

    public void StartGame()
    {
        if (username_field.text != "")
        {
            MainManager.name = username_field.text;
            SceneManager.LoadScene("main");

            // turn the text of username_field into json, and save it to a file
            string json = JsonUtility.ToJson(username_field.text);
            //File.WriteAllText(Application.dataPath + "/username.json", json);

        }
    }


}
