using System;
using GearListoon.Models;
using UnityEngine;
using UnityEngine.UI;

namespace GearListoon.Views.GearPowerSelector {

	/// <summary>
	/// ギア選択ノードViewer
	/// </summary>
	public class GearPowerSelectorNodeViewer : MonoBehaviour {

		/// <summary>
		/// ギア名
		/// </summary>
		private Text Name { set; get; }

		public PowerModel PowerModel { private set; get; }

		public void Awake() {
			this.Name = this.transform.Find( "Button" ).Find( "Text" ).GetComponent<Text>();
		}

		/// <summary>
		/// ノードクリック時イベントハンドラ
		/// </summary>
		public Action OnClickedNodeButtonEventHandler { set; get; }

		/// <summary>
		/// ノードクリック時イベント
		/// </summary>
		public void OnClickedNodeButton() {
			if( this.OnClickedNodeButtonEventHandler != null )
				this.OnClickedNodeButtonEventHandler.Invoke();
		}

		/// <summary>
		/// パワー設定
		/// </summary>
		/// <param name="power">パワー</param>
		public void SetPower( PowerModel power ) {
			this.Name.text = power.name;
			this.PowerModel = power;
		}
		
	}

}