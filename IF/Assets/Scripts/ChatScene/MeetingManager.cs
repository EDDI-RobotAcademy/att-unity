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

    void Update()
    {
        if (letsMeet)
        {
            guidance.text = "��� ��ҿ� �ð��� ����\n���� �������� ���ư�������!";
            meetingPlace.gameObject.SetActive(true);
            meetingDay.gameObject.SetActive(true);
            letsMeet = false;
        }
    }


    private Dictionary<string, string> keywordMeetingPlace = new Dictionary<string, string>()
    {
        // ��� ��� ���� Ű����
        {"���� ���� �� ���?", "��ȭ��"},
        {"���� ������", "��ȭ��"},
    };
    
    private Dictionary<string, string> keywordMeetingDay = new Dictionary<string, string>()
    {
        // ��� ��¥ ���� Ű����
        {"������ ���ؿ�", "�����"},
        {"���� ��", "�����"},
        {"���� �", "�����"},
        {"���Ͽ� ����", "�����"},
    };

    public void UpdateMeetingPlace(string message)
    {
        foreach (var keyword in keywordMeetingPlace.Keys)
        {
            if (message.Contains(keyword))
            {
                meetingPlace.text = keywordMeetingPlace[keyword];
                break; // ù ��° ��ġ�ϴ� Ű���忡 ���ؼ��� ��� ��� �ݿ�
            }
        }
    }
    
    public void UpdateMeetingDay(string message)
    {
        foreach (var keyword in keywordMeetingDay.Keys)
        {
            if (message.Contains(keyword))
            {
                meetingDay.text = keywordMeetingDay[keyword];
                break; // ù ��° ��ġ�ϴ� Ű���忡 ���ؼ��� ��� ��¥ �ݿ�
            }
        }
    }
}
