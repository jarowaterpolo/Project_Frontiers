using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueSystem : MonoBehaviour
{
    [Header("Dialogue")]
    [TextArea(3, 10)]
    public List<string> dialogueLines;

    [Header("UI")]
    public GameObject dialoguePanel;
    public TMP_Text dialogueText;

    [Header("Typewriter")]
    public float typingSpeed = 0.05f;

    private int currentLine = 0;
    private Coroutine typingCoroutine;
    private bool isTyping = false;

    void Start()
    {
        dialoguePanel.SetActive(false);
        StartDialogue();
    }

    void Update()
    {
        if (dialoguePanel.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            if (isTyping)
            {
                // Instantly finish the current line
                StopCoroutine(typingCoroutine);
                dialogueText.text = dialogueLines[currentLine];
                isTyping = false;
            }
            else
            {
                NextLine();
            }
        }
    }

    public void StartDialogue()
    {
        currentLine = 0;
        dialoguePanel.SetActive(true);
        StartTyping(dialogueLines[currentLine]);
    }

    void NextLine()
    {
        currentLine++;

        if (currentLine < dialogueLines.Count)
        {
            StartTyping(dialogueLines[currentLine]);
        }
        else
        {
            dialoguePanel.SetActive(false);
        }
    }

    void StartTyping(string line)
    {
        if (typingCoroutine != null)
            StopCoroutine(typingCoroutine);

        typingCoroutine = StartCoroutine(TypeLine(line));
    }

    IEnumerator TypeLine(string line)
    {
        isTyping = true;
        dialogueText.text = "";

        foreach (char letter in line)
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }

        isTyping = false;
    }
}