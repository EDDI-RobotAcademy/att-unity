using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiningManager : MonoBehaviour
{
    public Text guidance;
    public Text foodMenu;

    public bool letsEat = false;

    private LikabilityManager2 likabilityManager;
    private SceneController sceneController;

    void Start()
    {
        likabilityManager = GetComponent<LikabilityManager2>();
        sceneController = GetComponent<SceneController>();
    }

    void Update()
    {
        if (letsEat)
        {
            guidance.text = "�Ļ� �޴��� ����\n���� ��ҷ� �̵��ϼ���!";
            foodMenu.gameObject.SetActive(true);
            letsEat = false;
        }

        if (likabilityManager.GetNormalizedLikability() >= 0.7f && foodMenu.text != "����")
        {
            if (GetComponent<SendMessageToVue2>().endChat)
            {
                sceneController.MoveToDiningScene();
            }
        }
    }
}
