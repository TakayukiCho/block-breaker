using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	private int maxHits;
	private int timesHit;
	private LevelManager levelManager;
	public Sprite[] hitSprites;
	static public int breakableCount = 0;
	
	// Use this for initialization
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		timesHit = 0;
		breakableCount++;
		maxHits = hitSprites.Length + 1; 
	}
	
	void OnCollisionEnter2D (Collision2D col) {
		timesHit++;
		if (maxHits <= timesHit) {
			breakableCount--;
			levelManager.BrickDestroyed();
			Destroy (gameObject);
		} else {
			LoadSprites();
		}
	}
	
	void LoadSprites () {
		int spriteIndex = timesHit - 1;
		this.GetComponent<SpriteRenderer>().sprite =  hitSprites[spriteIndex];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
