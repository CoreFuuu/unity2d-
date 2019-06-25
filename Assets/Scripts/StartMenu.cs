using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class StartMenu : MonoBehaviour {

    public Text runningText;
    public GameObject SettingMenu;
    Vector3 decrease = new Vector3(5, 0, 0);
    string[] NewsList = RunningNewsValues.News;
    Vector3 OriginPosition;
    int i;
    public void StartNewGame()
    {
        //SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("loadSceneAsync(right) ");
    }

    public void DisplaySettingMenu()
    {
        gameObject.SetActive(false);
        SettingMenu.SetActive(true);
    }

    private void Awake()
    {
        this.enabled = true;
    }
    private void Start()
    {
        OriginPosition = runningText.transform.position;
        i = Random.Range(0, NewsList.Length);
        runningText.text = NewsList[i];
    }

    private void FixedUpdate()
    {
        if (runningText.transform.position.x >= -1500)
        {
            runningText.transform.position -= decrease;
        }
        else
        {
            runningText.transform.position = OriginPosition;
            i = Random.Range(0, NewsList.Length);
            runningText.text = NewsList[i];
        }
    }
}
