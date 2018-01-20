using GearListoon.Presenters.GearList;
using GearListoon.Services;
using UnityEngine;

namespace GearListoon.Managers {

	/// <summary>
	/// アプリ全体管理
	/// </summary>
	public class AppManager : MonoBehaviour {

		// サービスのインスタンス生成だけ先にする
		public void Awake()
			=> SpriteService.GetInstance();
		
		public void Start() 
			=> new GearListPresenter();
		
	}

}