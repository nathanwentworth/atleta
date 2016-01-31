using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class dialogue : MonoBehaviour {

	public GameObject book;

	public Text ans1text;
	public Text ans2text;
	public Text ans3text;

	public Text dialogueText;

	public bool textDisp;

	public trigger trigger;

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
		
  public void S1() {  
    dialogueText.text = "On the morning of her 16th birthday, Atleta woke to the familiar sounds of her village, An Tara, and the sea that it belonged to. Her mother beamed with pride and her father watched Atleta drive the last nails into the hull of her very own boat. The village gathered on the coarse shore and listened to her father’s booming voice: \n\n“Atleta, my beautiful daughter, you are on this day 16 summers on land; from this moment henceforth you are of the sea. To become one of us, you must visit our neighbors to the WEST, NORTH, and EAST, and complete the rituals their leaders give you, then fly the flag of their island on your boat.”";
	
		ans1obj.SetActive (true);
		ans2obj.SetActive (false);
		ans3obj.SetActive (false);

		EventSystem.current.SetSelectedGameObject(ans1obj, null);

    ans1.onClick.RemoveAllListeners();
    ans2.onClick.RemoveAllListeners();
    ans3.onClick.RemoveAllListeners();

    ans1.onClick.AddListener(S2);
    // ans2.onClick.AddListener(Script1B);
    // ans3.onClick.AddListener(Script1A);

    ans1text.text = "Atleta was given...";
    // ans2text.text = "Lorem1B";
    // ans3text.text = "Lorem3";
  }

  void S2() {
    dialogueText.text = "Atleta was given a Pāua shell, beautiful beyond compare, a giant red-gray fish with sharp scales, and ten loaves of soda bread, as well as supplies for the journey.";

		ans1obj.SetActive (true);
		ans2obj.SetActive (false);
		ans3obj.SetActive (false);

    ans1.onClick.RemoveAllListeners();
    ans2.onClick.RemoveAllListeners();
    ans3.onClick.RemoveAllListeners();

		ans1.onClick.AddListener(trigger.ClosePanel);

    // ans1.onClick.AddListener(Script2A);
    // ans2.onClick.AddListener(Script2B);
    // ans3.onClick.AddListener(Script1A);

    ans1text.text = "Set sail!";
    // ans2text.text = " ";
    // ans3text.text = " ";
  }

  public void K1() {
		dialogueText.text = "The wind was warmer and the sand finer on KIRKJA; as Atleta ran her boat ashore, a woman in fine silks emerged from her home and greeted Atleta with open arms, and with the flag of the island. \n\n“You must be Atleta of An Tara, out on the water at last! How has your journey been thus far?”";

		ans1obj.SetActive (true);
		ans2obj.SetActive (true);
		ans3obj.SetActive (true);

    ans1.onClick.RemoveAllListeners();
    ans2.onClick.RemoveAllListeners();
    ans3.onClick.RemoveAllListeners();

    ans1.onClick.AddListener(K1A);
    ans2.onClick.AddListener(K1B);
    ans3.onClick.AddListener(K1C);

    ans1text.text = "“The sea’s been kind, thank goodness.”";
    ans2text.text = "“I may or may not have gotten lost a couple times.”";
    ans3text.text = "“Who are you?”";
  }
  public void K1A() {
    dialogueText.text = "“Glad to hear it. It smiles on us more often here, but I know that where you’re coming from, as well as where you’re going, it’s not necessarily that way.” the woman said. “Do you have in your possession a shell of incomparable beauty?”\n\nAtleta showed the woman the Pāua shell. It gleamed in the sunlight, luminously green, blue, and purple. It was perfectly smooth and soft to the touch -- Atleta had never seen something like it in her life, and wondered where it had come from. ";

		ans1obj.SetActive (true);
		ans2obj.SetActive (false);
		ans3obj.SetActive (false);

    ans1.onClick.RemoveAllListeners();
    ans2.onClick.RemoveAllListeners();
    ans3.onClick.RemoveAllListeners();

    ans1.onClick.AddListener(K2);
    // ans2.onClick.AddListener(Script1B);
    // ans3.onClick.AddListener(Script1A);

    ans1text.text = "“Such a beautiful gift…”";
    // ans2text.text = "Lorem1B";
    // ans3text.text = "Lorem3";
  }
  public void K1B() {
    dialogueText.text = "“It happens to us all, child. I once sailed into a fog bank and went in circles around this very island for nearly a day,” the woman said. “Do you have in your possession a shell of incomparable beauty?”\n\nAtleta showed the woman the Pāua shell. It gleamed in the sunlight, luminously green, blue, and purple. It was perfectly smooth and soft to the touch -- Atleta had never seen something like it in her life, and wondered where it had come from. ";

		ans1obj.SetActive (true);
		ans2obj.SetActive (false);
		ans3obj.SetActive (false);

    ans1.onClick.RemoveAllListeners();
    ans2.onClick.RemoveAllListeners();
    ans3.onClick.RemoveAllListeners();

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

    ans1.onClick.RemoveAllListeners();
    ans2.onClick.RemoveAllListeners();
    ans3.onClick.RemoveAllListeners();

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

    ans1.onClick.RemoveAllListeners();
    ans2.onClick.RemoveAllListeners();
    ans3.onClick.RemoveAllListeners();

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

    ans1.onClick.RemoveAllListeners();
    ans2.onClick.RemoveAllListeners();
    ans3.onClick.RemoveAllListeners();

    // ans1.onClick.AddListener(K2);
    // ans2.onClick.AddListener(Script1B);
    // ans3.onClick.AddListener(Script1A);

		ans1.onClick.AddListener(trigger.ClosePanel);

    ans1text.text = "Set Sail!";
    // ans2text.text = "Lorem1B";
    // ans3text.text = "Lorem3";
  }

  public void K2B() {
    dialogueText.text = "Atleta didn’t the myth and pocketed the shell. Una, mother of Kirkja, frowned and curtly returned to her duties.”\n\nAtleta returned to her boat and shoved off. She pulled the shell out to look at it once more and the sea churned underneath her, the shell growing hot in her hands until it threatened to burn her -- she dropped it as it turned to dust that ate through her hull, the boat taking on water quickly.\n\nAtleta hastily patched the breach and breathed deeply. Her palm now bore a scar in the shape of the shell.";

		ans1obj.SetActive (true);
		ans2obj.SetActive (false);
		ans3obj.SetActive (false);

    ans1.onClick.RemoveAllListeners();
    ans2.onClick.RemoveAllListeners();
    ans3.onClick.RemoveAllListeners();

		ans1.onClick.AddListener(trigger.ClosePanel);

    // ans1.onClick.AddListener(K2);
    // ans2.onClick.AddListener(Script1B);
    // ans3.onClick.AddListener(Script1A);

    ans1text.text = "Set Sail.";
    // ans2text.text = "Lorem1B";
    // ans3text.text = "Lorem3";
  }
  public void V1() {
    dialogueText.text = "Snow flurried as Atleta reached VANWAR, a mountainous, cragged isle. The dock was bustling as she tied her boat up, and she found herself amongst burly men and hardy women bringing in the day’s catch, steeled against the cold and wrapped in furs. A particularly burly man wrapped in many furs awaited Atleta at doors to a great hall, with his island’s flag in hand:\n\n“Hello, sweet child. I haven’t seen you since you were a babe, maybe,” - he made a barely perceptible gap between his index finger and thumb - “this big. Probably smaller.” He then burst into raucous laughter. “I am Skarsen, chief of Vanwar and the greatest chef of all the isles. Have you brought me a kingly gift?”";

		ans1obj.SetActive (true);
		ans2obj.SetActive (false);
		ans3obj.SetActive (false);

    ans1.onClick.RemoveAllListeners();
    ans2.onClick.RemoveAllListeners();
    ans3.onClick.RemoveAllListeners();

		ans1.onClick.AddListener(V2);
    // ans2.onClick.AddListener(Script1B);
    // ans3.onClick.AddListener(Script1A);

    ans1text.text = "She showed him the red-gray fish…";
    // ans2text.text = "Lorem1B";
    // ans3text.text = "Lorem3";
  }
  public void V2() {
    dialogueText.text = "She showed him the red-gray fish with sharp scales -- it was an ugly beast, with a long jaw laden with sharp teeth and abyss-like eyes. Over the voyage it had grown a stench, but it didn’t seem to bother Skarsen as he took it from her with glee.\n\n“There are spices that only exist on Vanmar, yet this fish only swims near An Tara -- when we combine North and South, we get a once-in-a-lifetime experience. There shall be a feast!”";

		ans1obj.SetActive (true);
		ans2obj.SetActive (false);
		ans3obj.SetActive (false);

    ans1.onClick.RemoveAllListeners();
    ans2.onClick.RemoveAllListeners();
    ans3.onClick.RemoveAllListeners();

		ans1.onClick.AddListener(V3);

    // ans1.onClick.AddListener(K2);
    // ans2.onClick.AddListener(Script1B);
    // ans3.onClick.AddListener(Script1A);

    ans1text.text = "That night at the great hall…";
    // ans2text.text = "Lorem1B";
    // ans3text.text = "Lorem3";
  }
  public void V3() {
    dialogueText.text = "That night at the great hall, the room was packed with the men and women of Vanmar laughing, drinking, and awaiting this fabled meal. When Skarsen emerged from the kitchen, the ugly red-gray fish looked barely any different, yet was steaming. He set it in front of Atleta: \n\n“The sea gives everything we need, and for this we are eternally grateful. To survive we must take whatever we can get, no matter if it is, perhaps, less palatable than we’d like. Eat this beast of the sea, Atleta, and become one of us.”";

		ans1obj.SetActive (true);
		ans2obj.SetActive (false);
		ans3obj.SetActive (false);

    ans1.onClick.RemoveAllListeners();
    ans2.onClick.RemoveAllListeners();
    ans3.onClick.RemoveAllListeners();

		ans1.onClick.AddListener(V4);

    // ans1.onClick.AddListener(K2);
    // ans2.onClick.AddListener(Script1B);
    // ans3.onClick.AddListener(Script1A);

    ans1text.text = "Atleta took a bite of the fish…";
    // ans2text.text = "Lorem1B";
    // ans3text.text = "Lorem3";
  }
  public void V4() {
    dialogueText.text = "Atleta took a bite of the fish, and was met with a burning sensation and searing pain in the roof of her mouth. The fish’s sharp scales cut her cheeks, and the meat was stringy and tough. All in the room watched.";

		ans1obj.SetActive (true);
		ans2obj.SetActive (true);
		ans3obj.SetActive (false);

    ans1.onClick.RemoveAllListeners();
    ans2.onClick.RemoveAllListeners();
    ans3.onClick.RemoveAllListeners();

    ans1.onClick.AddListener(V4A);
    ans2.onClick.AddListener(V4B);
    // ans3.onClick.AddListener(Script1A);

		ans1text.text = "Atleta kept eating… ";
		ans2text.text = "Atleta stopped eating… ";
    // ans3text.text = "Lorem3";
  }
  public void V4A() {
    dialogueText.text = "Atleta kept eating the fish, feeling Skarsen’s eyes on her, feeling the horrible meat slide down into her stomach, where it was making her insides churn in protest. Her mouth was numb except for the iron taste of her own blood. Skarsen patted her on the back  and circled, handing her water to wash it down.\n\nWhen it was finished, the entire thing, Skarsen gently picked Atleta up and brought her to a feather bed, where she promptly passed out and slept for a full day and night. When she awoke, miraculously, she felt nothing out of the ordinary. When she saw Skarsen out on the dock, he laughed jovially.\n\n“The beast is full of toxins, but the trick is if you eat all of it, you give your body what it needs to fight it. If you braved only part of it, the toll would’ve been much worse. You have to embrace the sea and all that it gives in its entirety. Remember that and you’ll never feel that pain again.”";

		ans1obj.SetActive (true);
		ans2obj.SetActive (false);
		ans3obj.SetActive (false);

    ans1.onClick.RemoveAllListeners();
    ans2.onClick.RemoveAllListeners();
    ans3.onClick.RemoveAllListeners();

		ans1.onClick.AddListener(trigger.ClosePanel);

    // ans1.onClick.AddListener(K2);
    // ans2.onClick.AddListener(Script1B);
    // ans3.onClick.AddListener(Script1A);

    ans1text.text = "Set Sail!";
    // ans2text.text = "Lorem1B";
    // ans3text.text = "Lorem3";
  }
  public void V4B() {
    dialogueText.text = "Atleta stopped eating the fish and pushed the plate away. Silence fell over the hall and Skarsen stared her dead in the eyes, then laughed. “Aye, Atleta of An Tara; if that’s your choice, can’t say I don’t blame you.”\n\nAtleta was bedridden for eight days, unable to move, sweating though freezing. All the while Skarsen coming to her door every couple of hours to laugh at her. “The beast is full of toxins, but the trick is if you eat all of it, you give your body what it needs to fight it. You have to embrace the sea and all that it gives in its entirety. Remember that and you’ll never feel this pain again.”";

		ans1obj.SetActive (true);
		ans2obj.SetActive (false);
		ans3obj.SetActive (false);

    ans1.onClick.RemoveAllListeners();
    ans2.onClick.RemoveAllListeners();
    ans3.onClick.RemoveAllListeners();

		ans1.onClick.AddListener(trigger.ClosePanel);

    // ans1.onClick.AddListener(K2);
    // ans2.onClick.AddListener(Script1B);
    // ans3.onClick.AddListener(Script1A);

    ans1text.text = "Set Sail.";
    // ans2text.text = "Lorem1B";
    // ans3text.text = "Lorem3";
  }
  public void B1() {
    dialogueText.text = "Upon the shore of BORNAIS there was only a dock and a path winding up the mountain. Atleta shouldered the sac full of loaves of soda bread and journeyed upwards, into fog. After many hours she came to a home built upon the crags and rocks, and an elderly woman came out of the hovel, using an ornate spear as a walking stick.\n\n“Come, come child, come in from the cold of this wicked place. It’s unkind to strangers.”\n\nAtleta entered the hovel and found it to be warm and pleasant, well-lit by many whale-oil candles. The old woman took the sac of soda bread and inhaled its sweet scent:\n\n“Ahh…  my daughter always did know how to make the best bread; I’ll make it last the winter, easy. Then the next journeyer will bring me my daughter’s soda bread, and the next, and the next, and the next, and I will be incredibly happy about it! Come, come! Be warm, I have a story to tell, lessons to impart, such is my task.”";

		ans1obj.SetActive (true);
		ans2obj.SetActive (false);
		ans3obj.SetActive (false);

    ans1.onClick.RemoveAllListeners();
    ans2.onClick.RemoveAllListeners();
    ans3.onClick.RemoveAllListeners();

    ans1.onClick.AddListener(B2);
    // ans2.onClick.AddListener(Script1B);
    // ans3.onClick.AddListener(Script1A);

    ans1text.text = "Atleta sat by the fire…";
    // ans2text.text = "Lorem1B";
    // ans3text.text = "Lorem3";
  }

  public void B2() {
    dialogueText.text = "Atleta sat by the fire -- she hadn’t noticed how cold she was, or how far from home she had journeyed already. She took the single sweet cake her mother, this old woman’s daughter, made for her, and decided now was the time for it.\n\n“Now to be arrogant, but did you know you were named after me?” the old woman said. “I too am Atleta, but I did it first. Time will tell if I do more with the name, but you look like you could do something interesting with it. Now, time for your first lesson, a story: \n\n“When I was a lady only a bit older than you, I met the love of my life. A few years later the gods delivered us a baby, washed ashore on piece of wreckage and crying endlessly. And so the sea delivered for me everything I ever wanted. But a few years later, as our baby boy found his legs and my love found her courage, they sailed out to catch an anniversary dinner and a terrible beast took them. And so the sea took from me everything that I wanted. What do you think I did next?”";

		ans1obj.SetActive (true);
		ans2obj.SetActive (true);
		ans3obj.SetActive (true);

    ans1.onClick.RemoveAllListeners();
    ans2.onClick.RemoveAllListeners();
    ans3.onClick.RemoveAllListeners();

    ans1.onClick.AddListener(B2A);
    ans2.onClick.AddListener(B2B);
    ans3.onClick.AddListener(B2C);

    ans1text.text = "“You cried.”";
    ans2text.text = "“You cried.”";
    ans3text.text = "“You hunted.”";
  }

  public void B2A() {
    dialogueText.text = "Atleta the Senior laughed haughtily. “Yes, yes I did. A lot. But that’s not the important part, that’s just something we all must do from time to time.” She reached over to the ornate spear, covered in carved symbols; she held it as if it was a natural extension of her arm. \n\n“I hunted. I scoured the waters around this island ‘till I found the beast and fought it for three days and three nights, only to awake bleeding on this very shore. Two years later, with a new ship and this very spear, I found it again. Who knows how many days and nights that was. But it ended this time with the beast bleeding on the beach, not I. I took its bones and used them to build this house, and now here I am.” The old woman leaned in:\n\n“If the sea takes from you, take from it.”";

		ans1obj.SetActive (true);
		ans2obj.SetActive (false);
		ans3obj.SetActive (false);

    ans1.onClick.RemoveAllListeners();
    ans2.onClick.RemoveAllListeners();
    ans3.onClick.RemoveAllListeners();

    ans1.onClick.AddListener(B3);
    // ans2.onClick.AddListener(Script1B);
    // ans3.onClick.AddListener(Script1A);

    ans1text.text = "Atleta nodded...";
    // ans2text.text = "Lorem1B";
    // ans3text.text = "Lorem3";
  }

  public void B2B() {
    dialogueText.text = "Atleta the Senior shook her head. “There is no such thing as starting over -- once you are marked the way you are by love or loss, you cannot simply begin anew. There is only soldiering on, taking the next step.\n\n“I hunted. I scoured the waters around this island ‘till I found the beast and fought it for three days and three nights, only to awake bleeding on this very shore. Two years later, with a new ship and this very spear, I found it again. Who knows how many days and nights that was. But it ended this time with the beast bleeding on the beach, not I. I took its bones and used them to build this house, and now here I am.” The old woman leaned in:\n\n“If the sea takes from you, take from it.”";

		ans1obj.SetActive (true);
		ans2obj.SetActive (false);
		ans3obj.SetActive (false);

    ans1.onClick.RemoveAllListeners();
    ans2.onClick.RemoveAllListeners();
    ans3.onClick.RemoveAllListeners();

    ans1.onClick.AddListener(B3);
    // ans2.onClick.AddListener(Script1B);
    // ans3.onClick.AddListener(Script1A);

    ans1text.text = "Atleta nodded...";
    // ans2text.text = "Lorem1B";
    // ans3text.text = "Lorem3";
  }

  public void B2C() {
    dialogueText.text = "Atleta the Senior nodded. “Yes, that is what I did.” She reached over to the ornate spear, covered in carved symbols; she held it as if it was a natural extension of her arm. \n\n“I hunted. I scoured the waters around this island ‘till I found the beast and fought it for three days and three nights, only to awake bleeding on this very shore. Two years later, with a new ship and this very spear, I found it again. Who knows how many days and nights that was. But it ended this time with the beast bleeding on the beach, not I. I took its bones and used them to build this house, and now here I am.” The old woman leaned in:\n\n“If the sea takes from you, take from it.”";

		ans1obj.SetActive (true);
		ans2obj.SetActive (false);
		ans3obj.SetActive (false);

    ans1.onClick.RemoveAllListeners();
    ans2.onClick.RemoveAllListeners();
    ans3.onClick.RemoveAllListeners();

    ans1.onClick.AddListener(B3);
    // ans2.onClick.AddListener(Script1B);
    // ans3.onClick.AddListener(Script1A);

    ans1text.text = "Atleta nodded...";
    // ans2text.text = "Lorem1B";
    // ans3text.text = "Lorem3";
  }

  public void B3() {
    dialogueText.text = "Atleta nodded, but could think of nothing to say. The candles flickered and cast strange shadows on the walls. Atleta the Senior yawned. “It’s quite a tale, living. Stay here tonight, child, and leave tomorrow when the birds begin to make a racket -- that’s when the wind is most favorable.\n\n“And this is most important: when you get home, tell your family you love them. That is very important; that is my second lesson to impart. Don’t let the sea take from you at all, if it can be helped.” She nodded, satisfied, then fetched a blanket for Atleta. \n\nThe next morning the birds began to make noise not soon after dawn; Atleta the Senior was nowhere to be seen.";

		ans1obj.SetActive (true);
		ans2obj.SetActive (false);
		ans3obj.SetActive (false);

    ans1.onClick.RemoveAllListeners();
    ans2.onClick.RemoveAllListeners();
    ans3.onClick.RemoveAllListeners();

    ans1.onClick.AddListener(trigger.ClosePanel);
    // ans2.onClick.AddListener(Script1B);
    // ans3.onClick.AddListener(Script1A);

    ans1text.text = "Set Sail!";
    // ans2text.text = "Lorem1B";
    // ans3text.text = "Lorem3";
  }

}