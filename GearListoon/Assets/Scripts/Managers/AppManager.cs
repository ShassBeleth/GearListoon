using GearListoon.Presentations.GearList;
using UnityEngine;

namespace GearListoon.Managers {

	/// <summary>
	/// アプリ全体管理
	/// </summary>
	public class AppManager : MonoBehaviour {
		
		public void Start() {

			new GearListPresenter();

		}
		
	}

}