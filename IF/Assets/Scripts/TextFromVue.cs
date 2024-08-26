using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;

public class TextFromVue : MonoBehaviour
{
    ChatManager ChatManager;
    string chatMessage;

    public void Start()
    {
        ChatManager = GetComponent<ChatManager>();
    }

    // JavaScript에서 호출할 수 있는 Unity 메서드
    public void VueEvent(string message)
    {
        Debug.Log("Message received from JavaScript: " + message);
        chatMessage = message;
        ChatManager.Chat(false, chatMessage, "이상형", Resources.Load<Texture2D>("aiGirl"));
        chatMessage = "";
    }
}
