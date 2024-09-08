using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;
using System.Runtime.InteropServices;

public class SceneController : MonoBehaviour
{
    public Image fadePanel;
    public Text description;


    void Start()
    {
        fadePanel.DOFade(1, 0f);
        fadePanel.DOFade(0, 1.5f); // Fade In
    }

    public void MoveToChatScene()
    {
        StartCoroutine(MoveScene("ChatScene", ""));
    }

    public void MoveToCafeScene()
    {
        StartCoroutine(MoveScene("CafeScene", ""));
    }

    public void MoveToMenuScene()
    {
        StartCoroutine(MoveScene("MenuScene", ""));
    }


    IEnumerator MoveScene(string SceneName, string descriptionText)
    {
        fadePanel.DOFade(1, 1.5f); // Fade out
        description.DOFade(1, 1.5f);
        description.text = descriptionText;
        GameObject.Find("Main Camera").GetComponent<AudioSource>().DOFade(0f, 3f);
        yield return new WaitForSeconds(3f);  // ��ü�� �ð� (��)
        SceneManager.LoadScene(SceneName);
        yield break; // �ڷ�ƾ ���� 
    }
}
