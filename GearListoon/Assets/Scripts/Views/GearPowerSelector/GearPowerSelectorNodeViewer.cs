using System;
using GearListoon.Models;
using GearListoon.Services;
using UnityEngine;
using UnityEngine.UI;

namespace GearListoon.Views.GearPowerSelector {

	/// <summary>
	/// ギア選択ノードViewer
	/// </summary>
	public class GearPowerSelectorNodeViewer : MonoBehaviour {

		#region イベントとイベントハンドラ

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

		#endregion

		#region 部品

		/// <summary>
		/// ギア名
		/// </summary>
		private Text Name { set; get; }

		/// <summary>
		/// アイコン画像
		/// </summary>
		private Image Icon { set; get; }

		#endregion

		/// <summary>
		/// パワーモデル
		/// </summary>
		public PowerModel PowerModel { private set; get; }

		public void Awake() {
			this.Name = this.transform.Find( "Button" ).Find( "Text" ).GetComponent<Text>();
			this.Icon = this.transform.Find( "Button" ).Find( "IconImage" ).GetComponent<Image>();
		}

		/// <summary>
		/// パワー設定
		/// </summary>
		/// <param name="power">パワー</param>
		public void SetPower( PowerModel power ) {
			this.Name.text = power.name;
			this.Icon.sprite = SpriteService.GetInstance().GetGearPowerSpriteFromDictionary( power.id );
			this.PowerModel = power;

		}
		
	}

}