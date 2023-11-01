using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour
{

    public Text text;

    private enum States
    {
        start, master_bedroom_0, breast_pump, bathroom, sleep_jeffrey,
        nursery_0, polaroid_0, picture_frame_0, burp_cloth_0, crib_0,
		nursery_1, sooth_baby, picture_frame_1, polaroid_1, crib_1, diaper,
        breastfeed, left_breast_0, right_breast_0, crib_left_0, right_breast_1,
        crib_right_0, left_breast_1, crib_right_1, burp_cloth_right, crib_left_1,
        burp_cloth_left, crib_2, jeffrey_nursery, master_bedroom_1
    };

    private States myState;

    // Use this for initialization
    void Start()
    {
        myState = States.start;
    }

    // Update is called once per frame
    void Update()
    {
		print(myState);
       	if      (myState == States.start)               { start(); }
       	else if (myState == States.master_bedroom_0)    { master_bedroom_0 (); }
       	else if (myState == States.breast_pump)         { breast_pump (); }
      	else if (myState == States.bathroom) 			{ bathroom (); }
		else if (myState == States.sleep_jeffrey) 		{ sleep_jeffrey (); }
		else if (myState == States.nursery_0) 			{ nursery_0 (); }
		else if (myState == States.polaroid_0) 			{ polaroid_0 (); }
		else if (myState == States.picture_frame_0) 	{ picture_frame_0 (); }
		else if (myState == States.burp_cloth_0) 		{ burp_cloth_0 (); }
		else if (myState == States.crib_0) 				{ crib_0 (); }
		else if (myState == States.nursery_1) 			{ nursery_1 (); }
		else if (myState == States.sooth_baby) 			{ sooth_baby (); }
		else if (myState == States.picture_frame_1) 	{ picture_frame_1 (); }
		else if (myState == States.polaroid_1) 			{ polaroid_1 (); }
		else if (myState == States.crib_1) 				{ crib_1 (); }
		else if (myState == States.diaper) 				{ diaper (); }
		else if (myState == States.breastfeed) 			{ breastfeed (); }
		else if (myState == States.left_breast_0) 		{ left_breast_0 (); }
		else if (myState == States.right_breast_0) 		{ right_breast_0 (); }
		else if (myState == States.crib_left_0) 		{ crib_left_0 (); }
		else if (myState == States.right_breast_1) 		{ right_breast_1 (); }
		else if (myState == States.crib_right_0) 		{ crib_right_0 (); }
		else if (myState == States.left_breast_1) 		{ left_breast_1 (); }
		else if (myState == States.crib_right_1) 		{ crib_right_1 (); }
		else if (myState == States.burp_cloth_right) 	{ burp_cloth_right (); }
		else if (myState == States.crib_left_1) 		{ crib_left_1 (); }
		else if (myState == States.burp_cloth_left) 	{ burp_cloth_left (); }
		else if (myState == States.crib_2) 				{ crib_2 (); }
		else if (myState == States.jeffrey_nursery) 	{ jeffrey_nursery (); }
		else if (myState == States.master_bedroom_1) 	{ master_bedroom_1 (); }
		else if (Input.GetKeyDown(KeyCode.Escape)) 		{ Application.Quit(); }
    }

    void start()
    {
        text.text = "You wake up in the middle of the night to the sound of your baby daughter Sage crying in " + 
                    "the next room. Jeffrey, your husband, is next to you, and it looks like he is starting to " + 
                    "wake up because of the cries as well.\n\n" + 
                    "Press Space to get out of bed";
        if (Input.GetKeyDown(KeyCode.Space))        { myState = States.master_bedroom_0; }
    }

    #region States methods

    void master_bedroom_0()
    {
        text.text = "You are in the master bedroom. Jeffrey is in bed slowly waking up from his deep sleep. " +
                    "You can hear Sage is crying in the nursery. You can see the breast " +
                    "pump sitting on a table on one side of the bedroom. The entrance to the bathroom is on " +
                    "another side of the bedroom.\n\n" +
                    "Press P to look at the breast pump\n" +
                    "Press B to go to the bathroom\n" +
                    "Press J to look at Jeffrey\n" +
                    "Press N to go to the nursery";
        if      (Input.GetKeyDown(KeyCode.P))       { myState = States.breast_pump; }
        else if (Input.GetKeyDown(KeyCode.B))       { myState = States.bathroom; }
        else if (Input.GetKeyDown(KeyCode.J))       { myState = States.sleep_jeffrey; }
        else if (Input.GetKeyDown(KeyCode.N))       { myState = States.nursery_0; }
    }

    void breast_pump()
    {
        text.text = "You look at the breast pump. You were using it right before bed earlier. Seems like Sage " +
                    "will need a more immediate solution. You will just need to use the breast pump later.\n\n" +
                    "Press R to return to the bedroom";
        if      (Input.GetKeyDown(KeyCode.R))       { myState = States.master_bedroom_0; }
    }

    void bathroom()
    {
        text.text = "You go into the bathroom. You can hear the sound of water running inside the toilet. Need to " +
                    "remind Jeffrey to get it fixed. It looks like he's starting to rely too much on his temporary " +
                    "string \"solution\".\n\n" +
                    "Press R to return to the bedroom";
        if      (Input.GetKeyDown(KeyCode.R))       { myState = States.master_bedroom_0; }
    }

    void sleep_jeffrey()
    {
        text.text = "You look at Jeffrey as he tries to roll out of bed. He accidentally rolled a little too much " +
                    "and fell off the bed. Oops!\n\n" +
                    "Press R to return to the bedroom";
        if      (Input.GetKeyDown(KeyCode.R))       { myState = States.master_bedroom_0; }
    }

    void nursery_0()
    {
        text.text = "You are in the nursey. Sage is in the crib crying. You can see a polaroid hanging on the wall next " +
                    "to the window. There is a burp cloth hanging on the side of the crib. At the entrance of the " +
                    "nursery is a picture frame with several photos. Jeffrey looks like he is half asleep and stumbling " +
                    "everywhere.\n\n" +
                    "Press C to look inside the crib\n" +
                    "Press P to look at the polaroid\n" +
                    "Press F to look at the picture frame\n" +
                    "Press B to look at the burp cloth";
        if      (Input.GetKeyDown(KeyCode.C))       { myState = States.crib_0; }
        else if (Input.GetKeyDown(KeyCode.P))       { myState = States.polaroid_0; }
        else if (Input.GetKeyDown(KeyCode.F))       { myState = States.picture_frame_0; }
        else if (Input.GetKeyDown(KeyCode.B))       { myState = States.burp_cloth_0; }
    }

	void polaroid_0()
    {
		text.text = "You look at the polaroid next to the window. It's a photo of the three of us when Sage became 8 days " +
					"old. So precious, but too bad Sage's eyes were closed. Maybe next time!\n\n" +
                    "Press R to return to the nursery";
		if      (Input.GetKeyDown(KeyCode.R))       { myState = States.nursery_0; }
    }

	void picture_frame_0()
    {
		text.text = "You look at the picture frame next to the entrance of the room. You see that there are a bunch of " +
					"portraits of... another baby? You look at Jeffrey, and you see him smile with a guilty look on his " +
					"face. \"I'll get right on that,\" he said. Mmhmm!\n\n" +
					"Press R to return to the nursery";
		if      (Input.GetKeyDown(KeyCode.R))       { myState = States.nursery_0; }
    }

	void burp_cloth_0()
    {
		text.text = "You look at the burp cloth. There are some light saliva stains from when you used it to burp Sage " +
					"earlier in the night. It's still a little bit moist. Jeffrey quickly takes it from you and sniffs " +
					"it... Why does he always have to sniff things?\n\n" +
					"Press R to return to the nursery";
		if      (Input.GetKeyDown(KeyCode.R))       { myState = States.nursery_0; }
    }

	void crib_0()
    {
		text.text = "You go to the crib and look at Sage. Her crying makes her look so delicate and helpless. Seems like " +
					"she really needs something.\n\n" +
					"Press R to return to the nursery\n" +
                    "Press P to pick up Sage";
		if      (Input.GetKeyDown(KeyCode.R))       { myState = States.nursery_0; }
		else if (Input.GetKeyDown(KeyCode.P))       { myState = States.nursery_1; }
	}

	void nursery_1()
    {
		text.text = "Sage is in your arms. She is crying. Oh what a surprise, looks like Jeffrey is scretching. " + 
					"What should I do now?\n\n" +
					"Press S to try to sooth Sage\n" +
					"Press F to show Sage the picture frame\n" +
					"Press P to show sage the Polaroid\n" +
					"Press C to put Sage back in the crib\n" +
					"Press D to change Sage's diaper\n" +
                    "Press B to breastfeed Sage";
		if      (Input.GetKeyDown(KeyCode.S))       { myState = States.sooth_baby; }
		else if (Input.GetKeyDown(KeyCode.F))       { myState = States.picture_frame_1; }
		else if (Input.GetKeyDown(KeyCode.P))       { myState = States.polaroid_1; }
		else if (Input.GetKeyDown(KeyCode.C))       { myState = States.crib_1; }
		else if (Input.GetKeyDown(KeyCode.D))       { myState = States.diaper; }
		else if (Input.GetKeyDown(KeyCode.B))       { myState = States.breastfeed; }
	}

	void sooth_baby()
    {
		text.text = "You say a few things to Sage. You try to sing her a song to let her know everything is ok, " +
					"but she is still crying.\n\n" +
					"Press R to return to the nursery";
		if      (Input.GetKeyDown(KeyCode.R))       { myState = States.nursery_1; }
    }

	void picture_frame_1()
    {
		text.text = "You show Sage the picture frame with photos of a model baby. She seems briefly puzzled by the " +
					"look of the baby. Perhaps the blue eyes seem strange to her? It seems to distract and calm her " +
					"down for a small moment, and then she starts crying again.\n\n" +
					"Press R to return to the nursery";
		if      (Input.GetKeyDown(KeyCode.R))       { myState = States.nursery_1; }
    }

	void polaroid_1()
    {
		text.text = "You show Sage the polaroid we had taken of us. She stops crying to observe the photo. I wonder " +
					"if she realizes who the people in the polaroid are. She momentarily smiles, and then she starts " +
					"crying again.\n\n" +
					"Press R to return to the nursery";
		if      (Input.GetKeyDown(KeyCode.R))       { myState = States.nursery_1; }
    }

	void crib_1()
    {
		text.text = "You bring Sage back to her crib. She's still crying. What am I doing? I just picked her up! \n\n" +
					"Press R to return to the nursery with Sage";
		if      (Input.GetKeyDown(KeyCode.R))       { myState = States.nursery_1; }
    }

	void diaper()
    {
		text.text = "Maybe Sage has a dirty diaper? You check her diaper, and it looks clean.\n\n" +
					"Press R to return to the nursery";
		if      (Input.GetKeyDown(KeyCode.R))       { myState = States.nursery_1; }
    }

	void breastfeed()
    {
		text.text = "You notice that Sage is smacking her lips while she is crying. Maybe she's hungry?\n\n" +
					"Press L to feed Sage using your left breast\n" +
					"Press R to feed Sage using your right breast\n" +
					"Press N to return to the nursery";
		if      (Input.GetKeyDown(KeyCode.N))       { myState = States.nursery_1; }
		else if (Input.GetKeyDown(KeyCode.L))       { myState = States.left_breast_0; }
		else if (Input.GetKeyDown(KeyCode.R))       { myState = States.right_breast_0; }
    }

	void left_breast_0()
    {
		text.text = "Sage stops crying and immediately latches on. Looks like she was hungry. After a few " + 
					"minutes of feeding, it looks like she might be satisfied.\n\n" +
					"Press C to return Sage to her crib\n" +
					"Press R to continue feeding Sage with your right breast";
		if      (Input.GetKeyDown(KeyCode.C))       { myState = States.crib_left_0; }
		else if (Input.GetKeyDown(KeyCode.R))       { myState = States.right_breast_1; }
    }

	void right_breast_0()
    {
		text.text = "Sage stops crying and immediately latches on. Looks like she was hungry. After a few " + 
					"minutes of feeding, it looks like she might be satisfied.\n\n" +
					"Press C to return Sage to her crib\n" +
					"Press L to continue feeding Sage with your left breast";
		if      (Input.GetKeyDown(KeyCode.C))       { myState = States.crib_right_0; }
		else if (Input.GetKeyDown(KeyCode.L))       { myState = States.left_breast_1; }
    }

	void crib_left_0()
    {
		text.text = "You decide to put Sage back in the crib. Right before you leave the room, she starts " +
					"crying again. What now?\n\n" +
					"Press R to try feeding Sage with your right breast";
		if      (Input.GetKeyDown(KeyCode.R))       { myState = States.right_breast_1; }
    }

	void crib_right_0()
    {
		text.text = "You decide to put Sage back in the crib. Right before you leave the room, she starts " +
					"crying again. What now?\n\n" +
					"Press L to try feeding Sage with your left breast";
		if      (Input.GetKeyDown(KeyCode.L))       { myState = States.left_breast_1; }
    }

	void right_breast_1()
    {
		text.text = "You try feeding her again with the other breast, and she immediately latches on. I " +
					"guess she wasn't done! After another round of feeding, Sage looks like she " +
					"might be finally satisfied.\n\n" +
					"Press C to return Sage to her crib\n" +
					"Press B to grab the burp cloth and try to burp Sage";
		if      (Input.GetKeyDown(KeyCode.C))       { myState = States.crib_right_1; }
		else if (Input.GetKeyDown(KeyCode.B))       { myState = States.burp_cloth_right; }
    }

	void left_breast_1()
    {
		text.text = "You try feeding her again with the other breast, and she immediately latches on. I " +
					"guess she wasn't done! After another round of feeding, Sage looks like she " +
					"might be finally satisfied.\n\n" +
					"Press C to return Sage to her crib\n" +
					"Press B to grab the burp cloth and try to burp Sage";
		if      (Input.GetKeyDown(KeyCode.C))       { myState = States.crib_left_1; }
		else if (Input.GetKeyDown(KeyCode.B))       { myState = States.burp_cloth_left; }
    }

	void crib_right_1()
    {
		text.text = "You decide to put Sage back in the crib. Right before you leave the room, she starts " +
					"crying again. What now?\n\n" +
					"Press B to grab the burp cloth and try to burp Sage";
		if      (Input.GetKeyDown(KeyCode.B))       { myState = States.burp_cloth_right; }
    }

	void crib_left_1()
    {
		text.text = "You decide to put Sage back in the crib. Right before you leave the room, she starts " +
					"crying again. What now?\n\n" +
					"Press B to grab the burp cloth and try to burp Sage";
		if      (Input.GetKeyDown(KeyCode.B))       { myState = States.burp_cloth_left; }
    }

	void burp_cloth_right()
    {
		text.text = "You grab the burp cloth that's hanging on the side of the crib. You drape it over your " + 
					"shoulder, and then you carry Sage up over the burp cloth. You try patting her on the back, " +
					"and after a few minutes of patting, she lets out the loudest burp she's ever burped. You see " +
					"Jeffrey is in shock, and you hear him say, \"WHOA!\". I guess she had some gas!\n\n" +
					"Press C to return Sage to her crib";
		if      (Input.GetKeyDown(KeyCode.C))       { myState = States.crib_2; }
    }

	void burp_cloth_left()
    {
		text.text = "You grab the burp cloth that's hanging on the side of the crib. You drape it over your " + 
					"shoulder, and then you carry Sage up over the burp cloth. You try patting her on the back, " +
					"and after a few minutes of patting, she lets out the loudest burp she's ever burped. You see " +
					"Jeffrey is in shock, and you hear him say, \"WHOA!\". I guess she had some gas!\n\n" +
					"Press C to return Sage to her crib";
		if      (Input.GetKeyDown(KeyCode.C))       { myState = States.crib_2; }
    }

	void crib_2()
    {
		text.text = "Sage is back in her crib. Looks like she fell back asleep. She should be sleeping for " +
					"another few hours before she wakes up again. I'll need to try to get some sleep before she " +
					"wakes back up again.\n\n" +
					"Press J to look at Jeffrey\n" +
					"Press B to go back to your bedroom";
		if      (Input.GetKeyDown(KeyCode.J))       { myState = States.jeffrey_nursery; }
		else if (Input.GetKeyDown(KeyCode.B))       { myState = States.master_bedroom_1; }
    }

	void jeffrey_nursery()
    {
		text.text = "Jeffrey is looking at Sage and touching her double chin. Like father like daughter.\n\n" +
					"Press S to look back at Sage";
		if      (Input.GetKeyDown(KeyCode.S))       { myState = States.crib_2; }
    }

	void master_bedroom_1()
    {
		text.text = "You go back to the bedroom with Jeffrey, and you both immediately fall back asleep.\n\n" +
					"Press Space to wake Sage back up";
		if      (Input.GetKeyDown(KeyCode.Space))       { myState = States.start; }
    }
}

#endregion