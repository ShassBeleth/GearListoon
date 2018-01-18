using System;
using GearListoon.Models;
using GearListoon.Services;
using UnityEngine;
using UnityEngine.UI;

namespace GearListoon.Views.BrandSelector {

	/// <summary>
	/// ブランド選択ノードViewer
	/// </summary>
	public class BrandSelectorNodeViewer : MonoBehaviour {

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
		/// ブランド名
		/// </summary>
		private Text Name { set; get; }

		/// <summary>
		/// つきやすいギアパワー名
		/// </summary>
		private Text EasyToHoldPowerName { set; get; }

		/// <summary>
		/// つきにくいギアパワー名
		/// </summary>
		private Text HardToHoldPowerName { set; get; }

		/// <summary>
		/// ブランドアイコン
		/// </summary>
		private Image BrandIcon { set; get; }

		/// <summary>
		/// つきやすいギアパワーアイコン
		/// </summary>
		private Image EasyToHoldPowerIcon { set; get; }

		/// <summary>
		/// つきにくいギアパワーアイコン
		/// </summary>
		private Image HardToHoldPowerIcon { set; get; }

		#endregion

		/// <summary>
		/// ブランドモデル
		/// </summary>
		public BrandModel BrandModel { private set; get; }

		public void Awake() {

			Transform buttonTransform = this.transform.Find( "Button" );
			this.Name = buttonTransform.Find( "Name" ).GetComponent<Text>();
			this.EasyToHoldPowerName = buttonTransform.Find( "EasyToHoldPowerName" ).GetComponent<Text>();
			this.HardToHoldPowerName = buttonTransform.Find( "HardToHoldPowerName" ).GetComponent<Text>();
			this.BrandIcon = buttonTransform.Find( "Icon" ).GetComponent<Image>();
			this.EasyToHoldPowerIcon = buttonTransform.Find( "EasyToHoldPowerIcon" ).GetComponent<Image>();
			this.HardToHoldPowerIcon = buttonTransform.Find( "HardToHoldPowerIcon" ).GetComponent<Image>();
		}

		/// <summary>
		/// ブランド設定
		/// </summary>
		/// <param name="power">ブランド</param>
		public void SetPower( BrandModel brand ) {
			this.Name.text = brand.name;
			this.EasyToHoldPowerName.text = brand.easyToHoldPower != null ? brand.easyToHoldPower.name : "無し";
			this.HardToHoldPowerName.text = brand.difficultToHoldPower != null ? brand.difficultToHoldPower.name : "無し";
			this.BrandModel = brand;
			this.BrandIcon.sprite = SpriteService.GetInstance().GetBrandSpriteFromDictionary( brand.id );
			this.EasyToHoldPowerIcon.sprite = SpriteService.GetInstance().GetGearPowerSpriteFromDictionary(
				brand.easyToHoldPower != null ? brand.easyToHoldPower.id : "無し"
			);
			this.HardToHoldPowerIcon.sprite = SpriteService.GetInstance().GetGearPowerSpriteFromDictionary(
			  brand.difficultToHoldPower != null ? brand.difficultToHoldPower.id : "無し"
		  );
		}

	}

}