using UnityEngine;
using TMPro;

public class DialogueSystem : MonoBehaviour
{
    [Header("Dialogue")]
    public string[] dialogueLines;

    [Header("UI")]
    public GameObject dialoguePanel;
    public TMP_Text dialogueText;

    private int currentLine = 0;

    void Start()
    {
        dialoguePanel.SetActive(false);
        StartDialogue();
    }

    void Update()
    {
        if (dialoguePanel.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            NextLine();
        }
    }

    public void StartDialogue()
    {
        currentLine = 0;
        dialoguePanel.SetActive(true);
        dialogueText.text = dialogueLines[currentLine];
    }

    void NextLine()
    {
        currentLine++;

        if (currentLine < dialogueLines.Length)
        {
            dialogueText.text = dialogueLines[currentLine];
        }
        else
        {
            dialoguePanel.SetActive(false);
        }
    }
}
