using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour {
    
    // Animatorコンポーネント
	Animator animator;
	// キャラクターコントローラー
	CharacterController character;
	
	void Start () {
		// キャラクターコントローラーの取得
		character = GetComponent<CharacterController>();
		// Animatorコンポーネントの取得
		animator = GetComponent<Animator>();
	}
	public void go()
	{
		animator.SetTrigger ("go");
	}
	public void back()
	{
		animator.SetTrigger ("back");
	}
}