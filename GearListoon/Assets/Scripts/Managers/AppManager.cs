using GearListoon.Presenters.GearList;
using GearListoon.Services;
using UnityEngine;

namespace GearListoon.Managers {

	/// <summary>
	/// アプリ全体管理
	/// </summary>
	public class AppManager : MonoBehaviour {

		public void Awake() {

			// サービスのインスタンス生成だけ先にする
			SpriteService.GetInstance();

		}

		public void Start() {
			
			new GearListPresenter();

		}
		
	}

}