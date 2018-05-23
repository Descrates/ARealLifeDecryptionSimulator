using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    private string num;

    [SerializeField]
    private InputField input;

    [SerializeField]
    private Text text;

    void Awake() {
        num = "test34";
    }

    public void GetInput(string guess) {
        CompareGuesses (guess);
        input.text = "";
    }

    void CompareGuesses(string guess)
    {
        if (guess == num)
        {
            text.text = "True";
            Debug.Log("True");
        } else if (guess != num) {
            text.text = "False";
            Debug.Log("False");
        }
    }
}
