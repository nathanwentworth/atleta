using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class sampletext : MonoBehaviour {
  private int splitNum;

  public Text ans1text;
  public Text ans2text;
  public Text ans3text;

  public Text dialogueText;

  public Button ans1;
  public Button ans2;
  public Button ans3;

  private string ans1string;
  private string ans2string;
  private string ans3string;

  private bool ans1interactable;
  private bool ans2interactable;
  private bool ans3interactable;

  void Start() {
    ans1 = (Button)ans1.GetComponent(typeof(Button));
    ans2 = (Button)ans2.GetComponent(typeof(Button));
    ans3 = (Button)ans3.GetComponent(typeof(Button));

    ans1text = (Text)ans1text.GetComponent(typeof(Text));
    ans2text = (Text)ans2text.GetComponent(typeof(Text));
    ans3text = (Text)ans3text.GetComponent(typeof(Text));

    dialogueText = (Text)dialogueText.GetComponent(typeof(Text));

    IntroScript();
  }

  void OnTriggerEnter(Collider target) {
    if(target.tag == "dialoguetrigger") {
      switch(splitNum) {
        case 1:
        break;
      }

    }
  }

  private void IntroScript() {

    ans1.interactable = ans2.interactable = ans3.interactable = false;
  
    dialogueText.text = "This is a sample block of text! If this is showing up, that means the script is working properly. I want to make this long enough so that it actually fills at least a few lines. Now to test how \nline breaks \nwork i'm just gonna throw some in. \nokay cool let's see how that looks!";

    ans1.onClick.AddListener(Script1A);
    ans2.onClick.AddListener(Script1B);
    ans3.onClick.AddListener(Script1A);

    ans1string = "Lorem1A";
    ans2string = "Lorem1B";
    ans3string = "Lorem3";

    ans1interactable = true;
    ans2interactable = true;
    ans3interactable = true;
  }

  private void Script1A() {

    ans1.interactable = ans2.interactable = ans3.interactable = false;

    dialogueText.text = "This is more sample text! if this shows up, then you clicked a button and it properly called the second dialogue bit. ";

    ans1.onClick.AddListener(Script2A);
    ans2.onClick.AddListener(Script2B);
    ans3.onClick.AddListener(Script1A);

    ans1string = "Lorem2A";
    ans2string = "Lorem2B";
    ans3string = " ";

    ans1interactable = ans2interactable = true;
  }

  private void Script1B() {

    ans1.interactable = ans2.interactable = ans3.interactable = false;

    dialogueText.text = "This is a second dialogue choice. it'll show you different dialogue than the first choice, which is A ";

    ans1.onClick.AddListener(Script1A);
    ans2.onClick.AddListener(Script1B);
    ans3.onClick.AddListener(Script1A);

    ans1string = "Lorem1A";
    ans2string = "Lorem1B";
    ans3string = "Lorem3";

    ans1interactable = ans2interactable = ans3interactable = true;  
  }
  private void Script2A() {

    ans1.interactable = ans2.interactable = ans3.interactable = false;

    dialogueText.text = "You entered the trigger and this is the first option of the first split";

    ans1.onClick.AddListener(Script1A);
    ans2.onClick.AddListener(Script1B);
    ans3.onClick.AddListener(Script1A);

    ans1string = "Lorem1A";
    ans2string = "Lorem1B";
    ans3string = "Lorem3";

    ans1interactable = ans2interactable = ans3interactable = true;  
  }
  private void Script2B() {

    ans1.interactable = ans2.interactable = ans3.interactable = false;

    dialogueText.text = "You entered the trigger and this is the second option of the first split";

    ans1.onClick.AddListener(Script1A);
    ans2.onClick.AddListener(Script1B);
    ans3.onClick.AddListener(Script1A);

    ans1string = "Lorem1A";
    ans2string = "Lorem1B";
    ans3string = "Lorem3";

    ans1interactable = ans2interactable = ans3interactable = true;  
  }

}