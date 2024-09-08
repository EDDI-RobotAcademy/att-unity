using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeetingManager : MonoBehaviour
{
    public Text guidance;
    public Text meetingPlace;
    public Text meetingDay;

    public bool letsMeet = false;

    private LikabilityManager likabilityManager;
    private SceneController sceneController;

    void Start()
    {
        likabilityManager = GetComponent<LikabilityManager>();
        sceneController = GetComponent<SceneController>();
    }

    void Update()
    {
        if (letsMeet)
        {
            guidance.text = "��� ��ҿ� �ð��� ����\n���� �������� ���ư�������!";
            meetingPlace.gameObject.SetActive(true);
            meetingDay.gameObject.SetActive(true);
            letsMeet = false;
        }

        if (likabilityManager.GetNormalizedLikability() >= 0.5f && meetingPlace.text != "����" && meetingDay.text != "����")
        {
            sceneController.MoveToCafeScene();
        }
    }
}
