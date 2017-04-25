using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {
	
	public Text text;
	private enum States {Prison, Mirror, Key, LockedDoor, PrisKey, MirrKey, LockDoorKey, Freedom};
	private States myState;
	
	// Use this for initialization
	void Start () {
		myState = States.Prison;
		text.text = "You wake up cold, isolated, and filled with the sharp pangs of hunger. You are welcomed by encroaching darkness as your vision begins to adjust. You realize that " + 
					 "you are surrounded by bars from all sides. This must be a prison, but you do not remember what you were arrested for. Maybe there is a way to escape. You decide " +
					 "to take a look around. There is a shiny object on the ground, a gray silouette in front of you, and the chilling stare of your reflection.\n\n" + 
					 "Press M to view your reflection, press K to view the shiny object, and press D to meet the silouette.";
	}
	
	// Update is called once per frame
	void Update () {
		if (myState == States.Prison) {State_Prison();}
		else if (myState == States.Mirror) {State_Mirror();} 
		else if (myState == States.Key) {State_Key();}
		else if (myState == States.LockedDoor) {State_LockedDoor();}
		else if (myState == States.PrisKey) {State_PrisKey();}
		else if (myState == States.MirrKey) {State_MirrKey();}
		else if (myState == States.LockDoorKey) {State_LockDoorKey();}
		else if (myState == States.Freedom) {State_Freedom();}
	}
	
	void State_Prison() {
		text.text = "You wake up cold, isolated, and filled with the sharp pangs of hunger. You are welcomed by encroaching darkness as your vision begins to adjust. You realize that " + 
					"you are surrounded by bars from all sides. This must be a prison, but you do not remember what you were arrested for. Maybe there is a way to escape. You decide " +
					"to take a look around. There is a shiny object on the ground, a gray silouette in front of you, and the chilling stare of your reflection.\n\n" + 
					"Press M to view your reflection, press K to view the shiny object, or press D to meet the silhouette.";
		if (Input.GetKey(KeyCode.M)) {myState = States.Mirror;} 
		else if (Input.GetKey(KeyCode.K)) {myState = States.Key;}
		else if (Input.GetKey(KeyCode.D)) {myState = States.LockedDoor;}
	}
	
	void State_Mirror() {
		text.text = "You see what remains of your reflection gaze back at you. A tatterred shell with remnants of flesh strewn upon it. Amidst the darkness of your visage, each bone " +
					"of your rib somehow remains clearly pronounced. Your stomach as shriveled as a raisin in the Sahara. You look like you have not eaten in months. If you do not " +
					"escape this prison, you are sure that you will die soon.\n\nPress Enter to return.";
		if (Input.GetKey(KeyCode.Return)) {myState = States.Prison;}
	}
	
	void State_Key() {
		text.text = "The object has the engravings of a key. My god... it is! Maybe this is my chance to escape. But what does this key open? Is something locked somewhere? And who wants " +
					"me to escape? This key could be serendipity or I could be playing into someone else's plan.\n\nPress T to take the key or press Enter to return.";
		if (Input.GetKey(KeyCode.T)) {myState = States.PrisKey;}
		else if (Input.GetKey(KeyCode.Return)) {myState = States.Prison;}
	}
	
	void State_LockedDoor() {
		text.text = "The silhouette greets me with a non-existent gaze. Gray encroaches its stare from all sides. It seems almost mechanical, surely inhuman. I touch the dull glow " +
					"emanating from its source. What?! This is no human. It is a wall. Cold, hard, and impossible to break through. Yet I can feel a hole. Almost as if a key can fit " +
					"through. But how is that possible? This is just a wall. There is no door.\n\nPress Enter to return.";
		if (Input.GetKey(KeyCode.Return)) {myState = States.Prison;}
	}
	
	void State_PrisKey() {
		text.text = "I took the key. This may be my ticket out. I hear a voice echo from the abyss, I see that you have found my present. I have started the timer. I have rigged your cell" +
					" to blow up. If you can find my escape hatch, then your ingenuity has allowed you to survive. If not, then I will enjoy cleaning up what is left of you. Tick tock, " +
					"my friend. Four minutes left. \n\n Press M to view your reflection or press D to go back to that mysterious silhouette.";
		if (Input.GetKey(KeyCode.M)) {myState = States.MirrKey;}
		else if (Input.GetKey(KeyCode.D)) {myState = States.LockDoorKey;}
	}
	
	void State_MirrKey() {
		text.text = "I take a second to contemplate my impending death. There is no hope. My death is imminent. I have been reduced to a shell and will die with a flicker. My reflection " +
					"- a monstrosity of starvation and terror - will finally find peace. Oblivion awaits. I hear his voice one more time. Tick tock, my friend. 10, 9, 8 ... if only you " +
					"did not kill my family. Then, I might have let you live.\n\nGame Over\nPress R to start over.";
		if (Input.GetKey(KeyCode.R)) {myState = States.Prison;}
	}
	
	void State_LockDoorKey() {
		text.text = "I cannot waste any second. The silhouette has a key-shaped hole. Today is my lucky day. Time is ticking. I place the key in the hole. The ground shakes and the wall " +
					"rumbles. I see the wall begin to crumble. Light shines through to an almost blinding degree. As my vision clears, I realize that I am greeted by the outside. " +
					"I either escape and live or stay and die. My choice is clear. \n\nPress E to escape.";
		if (Input.GetKey(KeyCode.E)) {myState = States.Freedom;}
	}
	
	void State_Freedom() {
		text.text = "I hear the cell behind me explode as I run to meet the outside world. Why did this man want me dead? How did I wrong him so? I tried to think back but could not " +
					"remember my past. I did not even know my name. I hear a ring in my pocket. A cellphone? I answer the phone. Who is this?\n\nJames Rogers? Is that you? This is the " +
					"FBI. You are wanted for the murder of your family. You went off the grid, but we finally found you. Truth be told, we thought you killed yourself after the suicide " +
					"note that you left. You said that you would blow yourself up in a prison of your own design.\n\nPress R to play again.";
		if (Input.GetKey(KeyCode.R)) {myState = States.Prison;}
	}
}