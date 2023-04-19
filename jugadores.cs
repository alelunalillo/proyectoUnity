using UnityEngine;
using UnityEngine.UI;

public class jugadores : MonoBehaviour
{
    public InputField player1Input;
    public InputField player2Input;
    public Button continueButton;

    private string player1Name;
    private string player2Name;

    private void Start()
    {
        continueButton.interactable = false;
    }

    public void OnPlayer1NameChanged()
    {
        player1Name = player1Input.text;
        CheckIfCanContinue();
    }

    public void OnPlayer2NameChanged()
    {
        player2Name = player2Input.text;
        CheckIfCanContinue();
    }

    public void OnContinueButtonClicked()
    {
        // Accede al siguiente panel
    }

    private void CheckIfCanContinue()
    {
        if (!string.IsNullOrEmpty(player1Name) && !string.IsNullOrEmpty(player2Name))
        {
            continueButton.interactable = true;
        }
        else
        {
            continueButton.interactable = false;
        }
    }
}
