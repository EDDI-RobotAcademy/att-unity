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
    private LikabilityManager likabilityManager;
    private MeetingManager meetingManager;


    void Start()
    {
        likabilityManager = GetComponent<LikabilityManager>();
        meetingManager = GetComponent<MeetingManager>();
    }

    void Update()
    {
        if (likabilityManager.GetNormalizedLikability() >= 0.7f && meetingManager.meetingPlace.text != "???" && meetingManager.meetingDay.text != "?����")
        {
            MoveToFirstDate();
        }
    }

    public void MoveToFirstDate()
    {
        StartCoroutine(MoveScene("CafeScene"));
    }


    IEnumerator MoveScene(string SceneName)
    {
        fadePanel.DOFade(1, 3f); // Fade out
        description.DOFade(1, 3f);
        GameObject.Find("Main Camera").GetComponent<AudioSource>().DOFade(0f, 3f);
        yield return new WaitForSeconds(3f);  // ��ü�� �ð� (��)
        SceneManager.LoadScene(SceneName);
        yield break; // �ڷ�ƾ ���� 
    }
}
