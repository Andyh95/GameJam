using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextLoader : MonoBehaviour {
	public TextAsset beeText;
	public TextAsset batText;
	public TextAsset bedText;
	public TextAsset AirplaneText;
	public TextAsset birdText;
	public TextAsset ButterflyText;
	public TextAsset HighRiseText;
	public TextAsset LadderText;
	public TextAsset LotteryText;
	public TextAsset MirrorText;
	public TextAsset WitchesText;
	public Text content;
	 



	// Use this for initialization
	void Start () {

		int num = Random.Range (1, 11);

		if (num == 1) {
			content.text = beeText.text;
		} else if (num == 2) {
			content.text = batText.text;
		} else if (num == 3) {
			content.text = bedText.text;
		} else if (num == 4) {
			content.text = AirplaneText.text;
		} else if (num == 5) {
			content.text = birdText.text;
		} else if (num == 6) {
			content.text = ButterflyText.text;
		} else if (num == 7) {
			content.text = HighRiseText.text;
		} else if (num == 8) {
			content.text = LadderText.text;
		} else if (num == 9) {
			content.text = LotteryText.text;
		} else if (num == 10) {
			content.text = MirrorText.text;
		} else if (num == 11) {
			content.text = WitchesText.text;
		}


	}
	
	// Update is called once per frame
	void Update () {

	}
}