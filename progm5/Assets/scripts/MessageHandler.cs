using System.Collections;
using TMPro;
using UnityEngine;

public class MessageHandler : MonoBehaviour
{
    public TMP_Text messageField;
    public float defaultDuration = 3f;

    public IEnumerator ShowMessage(string message, float duration = -1f)
    {
        messageField.enabled = true;
        messageField.text = message;
        yield return new WaitForSeconds(duration > 0 ? duration : defaultDuration);
        messageField.enabled = false;
    }
}
