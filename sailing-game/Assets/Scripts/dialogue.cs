using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class dialogue : MonoBehaviour {
  private int splitNum;

	public GameObject book;

	public Text ans1text;
	public Text ans2text;
	public Text ans3text;

	public Text dialogueText;

	public Button ans1;
	public Button ans2;
	public Button ans3;

	public GameObject ans1obj;
	public GameObject ans2obj;
	public GameObject ans3obj;


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

    S1();
  }

  void OnTriggerEnter(Collider target) {
    if(target.tag == "dialoguetrigger") {
      switch(splitNum) {
        case 1:
        break;
      }

    }
  }

  public void S1() {  
    dialogueText.text = "On the morning of her 16th birthday, Atleta woke to the familiar sounds of her village, An Tara, and the sea that it belonged to. Her mother beamed with pride and her father watched Atleta drive the last nails into the hull of her very own boat. The village gathered on the coarse shore and listened to her father’s booming voice:\n\n“Atleta, my beautiful daughter, you are on this day 16 summers on land; from this moment henceforth you are of the sea. To become one of us, you must visit our neighbors to the WEST, NORTH, and EAST, and complete the rituals their leaders give you, then fly the flag of their island on your boat.”";
	
		ans1obj.SetActive (true);
		ans2obj.SetActive (false);
		ans3obj.SetActive (false);

    ans1.onClick.AddListener(S2);
    // ans2.onClick.AddListener(Script1B);
    // ans3.onClick.AddListener(Script1A);

    ans1text.text = "Atleta was given...";
    // ans2text.text = "Lorem1B";
    // ans3text.text = "Lorem3";
  }

  private void S2() {
    dialogueText.text = "Atleta was given a Pāua shell, beautiful beyond compare, a giant red-gray fish with sharp scales, and ten loaves of soda bread, as well as supplies for the journey.";

		ans1obj.SetActive (true);
		ans2obj.SetActive (false);
		ans3obj.SetActive (false);

		// ans1.onClick close dialogue

    // ans1.onClick.AddListener(Script2A);
    // ans2.onClick.AddListener(Script2B);
    // ans3.onClick.AddListener(Script1A);

    ans1text.text = "Set sail!";
    // ans2text.text = " ";
    // ans3text.text = " ";
  }

  public void K1() {
		dialogueText.text = "The wind was warmer and the sand finer on KIRKJA; as Atleta ran her boat ashore, a woman in fine silks emerged from her home and greeted Atleta with open arms, and with the flag of the island.\n\n“You must be Atleta of An Tara, out on the water at last! How has your journey been thus far?”";

		ans1obj.SetActive (true);
		ans2obj.SetActive (true);
		ans3obj.SetActive (true);

    ans1.onClick.AddListener(K1A);
    ans2.onClick.AddListener(K1B);
    ans3.onClick.AddListener(K1C);

    ans1text.text = "“The sea’s been kind, thank goodness.”";
    ans2text.text = "“I may or may not have gotten lost a couple times.”";
    ans3text.text = "“Who are you?”";
  }
  public void K1A() {
    dialogueText.text = "“Glad to hear it. It smiles on us more often here, but I know that where you’re coming from, as well as where you’re going, it’s not necessarily that way.” the woman said. “Do you have in your possession a shell of incomparable beauty?”\n\nAtleta showed the woman the Pāua shell. It gleamed in the sunlight, luminously green, blue, and purple. It was perfectly smooth and soft to the touch -- Atleta had never seen something like it in her life, and wondered where it had come from.";

		ans1obj.SetActive (true);
		ans2obj.SetActive (false);
		ans3obj.SetActive (false);

    ans1.onClick.AddListener(K2);
    // ans2.onClick.AddListener(Script1B);
    // ans3.onClick.AddListener(Script1A);

    ans1text.text = "“Such a beautiful gift…”";
    // ans2text.text = "Lorem1B";
    // ans3text.text = "Lorem3";
  }
  public void K1B() {
    dialogueText.text = "“It happens to us all, child. I once sailed into a fog bank and went in circles around this very island for nearly a day,” the woman said. “Do you have in your possession a shell of incomparable beauty?”\n\nAtleta showed the woman the Pāua shell. It gleamed in the sunlight, luminously green, blue, and purple. It was perfectly smooth and soft to the touch -- Atleta had never seen something like it in her life, and wondered where it had come from.";

		ans1obj.SetActive (true);
		ans2obj.SetActive (false);
		ans3obj.SetActive (false);

    ans1.onClick.AddListener(K2);
    // ans2.onClick.AddListener(Script1B);
    // ans3.onClick.AddListener(Script1A);

    ans1text.text = "“Such a beautiful gift…”";
    // ans2text.text = "Lorem1B";
    // ans3text.text = "Lorem3";
  }

  public void K1C() {
    dialogueText.text = "“I am Una, mother of Kirkja and, though your father failed to mention it, your aunt! I never had the thick skin for anywhere that far north, and left to build this place with my own hands,” the woman said. “Do you have in your possession a shell of incomparable beauty?”\n\nAtleta showed the woman the Pāua shell. It gleamed in the sunlight, luminously green, blue, and purple. It was perfectly smooth and soft to the touch -- Atleta had never seen something like it in her life, and wondered where it had come from.";

		ans1obj.SetActive (true);
		ans2obj.SetActive (false);
		ans3obj.SetActive (false);

    ans1.onClick.AddListener(K2);
    // ans2.onClick.AddListener(Script1B);
    // ans3.onClick.AddListener(Script1A);

    ans1text.text = "“Such a beautiful gift…”";
    // ans2text.text = "Lorem1B";
    // ans3text.text = "Lorem3";
  }

  public void K2() {
    dialogueText.text = "“Such a beautiful gift from the sea”, the woman said as she held it in her hands.\n“However, these great gifts the sea tempts us with, we cannot keep. These shells are only found in our world under the tongue of sacred sea-beasts who wash ashore or are killed in the shallows. Even as you and I stare at its beauty, we are slowly being cursed.\n“You must throw this shell into the sea, and never think of it again.”\nAtleta looked down at the jewel of the sea in her hand and felt its allure reach out to her.";

		ans1obj.SetActive (true);
		ans2obj.SetActive (true);
		ans3obj.SetActive (false);

    ans1.onClick.AddListener(K2A);
    ans2.onClick.AddListener(K2B);
    // ans3.onClick.AddListener(Script1A);

    ans1text.text = "She walked to the wake’s edge and threw it into the waves.";
    ans2text.text = "She didn’t believe the myth and…";
    // ans3text.text = "Lorem3";
  }

  public void K2A() {
    dialogueText.text = "She walked to the wake’s edge and threw it into the waves. Una, mother of Kirkja, smiled warmly and bade her welcome to a feast they were having that evening, regaling her with embarrassing stories of Atleta’s father and the customs of Kirkja.\n\nThat night Atleta tossed and turned with dreams of the shell, but when the sun rose the next day, she could not remember what colors it bore, and she felt lighter.";

		ans1obj.SetActive (true);
		ans2obj.SetActive (false);
		ans3obj.SetActive (false);

    ans1.onClick.AddListener(K2);
    // ans2.onClick.AddListener(Script1B);
    // ans3.onClick.AddListener(Script1A);

// ans1.onClick close dialogue

    // ans1text.text = "Set Sail!";
    // ans2text.text = "Lorem1B";
    // ans3text.text = "Lorem3";
  }

  public void K2B() {
    dialogueText.text = "Atleta didn’t the myth and pocketed the shell. Una, mother of Kirkja, frowned and curtly returned to her duties.”\n\nAtleta returned to her boat and shoved off. She pulled the shell out to look at it once more and the sea churned underneath her, the shell growing hot in her hands until it threatened to burn her -- she dropped it as it turned to dust that ate through her hull, the boat taking on water quickly.\n\nAtleta hastily patched the breach and breathed deeply. Her palm now bore a scar in the shape of the shell.";

		ans1obj.SetActive (true);
		ans2obj.SetActive (false);
		ans3obj.SetActive (false);

		// ans1.onClick close dialogue

    // ans1.onClick.AddListener(K2);
    // ans2.onClick.AddListener(Script1B);
    // ans3.onClick.AddListener(Script1A);

    ans1text.text = "Set Sail.";
    // ans2text.text = "Lorem1B";
    // ans3text.text = "Lorem3";
  }

}
