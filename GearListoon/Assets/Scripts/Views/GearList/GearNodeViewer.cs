using System;
using GearListoon.Models;
using GearListoon.Services;
using UnityEngine;
using UnityEngine.UI;

namespace GearListoon.Views.GearList {

	/// <summary>
	/// ギアノードViewer
	/// </summary>
	public class GearNodeViewer : MonoBehaviour {

		#region イベントとイベントハンドラ

		/// <summary>
		/// ギア名ボタン押下時イベントハンドラ
		/// </summary>
		public Action OnClickedGearNameButtonHandler { set; get; }

		/// <summary>
		/// ギア名ボタン押下時イベント
		/// </summary>
		public void OnClickedGearNameButton() {
			if( this.OnClickedGearNameButtonHandler != null )
				this.OnClickedGearNameButtonHandler.Invoke();
		}

		/// <summary>
		/// ブランドボタン押下時イベントハンドラ
		/// </summary>
		public Action OnClickedBrandButtonHandler { set; get; }

		/// <summary>
		/// ブランドボタン押下時イベント
		/// </summary>
		public void OnClickedBrandButton() {
			if( this.OnClickedBrandButtonHandler != null )
				this.OnClickedBrandButtonHandler.Invoke();
		}

		/// <summary>
		/// メインギアボタン押下時イベントハンドラ
		/// </summary>
		public Action OnClickedMainGearButtonEventHandler { set; get; }

		/// <summary>
		/// メインギアボタン押下時イベント
		/// </summary>
		public void OnClickedMainGearButton() {
			if( this.OnClickedMainGearButtonEventHandler != null )
				this.OnClickedMainGearButtonEventHandler.Invoke();
		}

		/// <summary>
		/// サブ1ギアボタン押下時イベントハンドラ
		/// </summary>
		public Action OnClickedSubGear1ButtonEventHandler { set; get; }

		/// <summary>
		/// サブ1ギアボタン押下時イベント
		/// </summary>
		public void OnClickedSubGear1Button() {
			if( this.OnClickedSubGear1ButtonEventHandler != null )
				this.OnClickedSubGear1ButtonEventHandler.Invoke();
		}

		/// <summary>
		/// サブ2ギアボタン押下時イベントハンドラ
		/// </summary>
		public Action OnClickedSubGear2ButtonEventHandler { set; get; }

		/// <summary>
		/// サブ2ギアボタン押下時イベント
		/// </summary>
		public void OnClickedSubGear2Button() {
			if( this.OnClickedSubGear2ButtonEventHandler != null )
				this.OnClickedSubGear2ButtonEventHandler.Invoke();
		}

		/// <summary>
		/// サブ3ギアボタン押下時イベントハンドラ
		/// </summary>
		public Action OnClickedSubGear3ButtonEventHandler { set; get; }

		/// <summary>
		/// サブ3ギアボタン押下時イベント
		/// </summary>
		public void OnClickedSubGear3Button() {
			if( this.OnClickedSubGear3ButtonEventHandler != null )
				this.OnClickedSubGear3ButtonEventHandler.Invoke();
		}

		/// <summary>
		/// 削除ボタン押下時イベントハンドラ
		/// </summary>
		public Action OnClickedDeleteButtonEventHandler { set; get; }

		/// <summary>
		/// 削除ボタン押下時イベント
		/// </summary>
		public void OnClickedDeleteButton() {
			if( this.OnClickedDeleteButtonEventHandler != null )
				this.OnClickedDeleteButtonEventHandler.Invoke();
		}

		#endregion

		#region 部品

		/// <summary>
		/// ギア名
		/// </summary>
		private Button Name;

		/// <summary>
		/// ブランドアイコン
		/// </summary>
		private Image Brand;

		/// <summary>
		/// ブランド名
		/// </summary>
		private Text BrandName;

		/// <summary>
		/// つきやすいギアパワー
		/// </summary>
		private Image EasyPower;

		/// <summary>
		/// つきにくいギアパワー
		/// </summary>
		private Image HardPower;
		
		/// <summary>
		/// メインギアパワー
		/// </summary>
		private Image MainGearPower;

		/// <summary>
		/// サブ1ギアパワー
		/// </summary>
		private Image Sub1GearPower;

		/// <summary>
		/// サブ2ギアパワー
		/// </summary>
		private Image Sub2GearPower;

		/// <summary>
		/// サブ3ギアパワー
		/// </summary>
		private Image Sub3GearPower;

		#endregion

		private SpriteService spriteService;

		public void Awake() {

			this.spriteService = SpriteService.GetInstance();

			#region 各部品の参照取得

			this.Name = this.gameObject.transform.Find( "Name" ).GetComponent<Button>();

			this.Brand = this.gameObject.transform.Find( "BrandButton" ).GetComponent<Image>();
			this.BrandName = this.gameObject.transform.Find( "BrandName" ).GetComponent<Text>();
			this.EasyPower = this.gameObject.transform.Find( "EasyPower" ).GetComponent<Image>();
			this.HardPower = this.gameObject.transform.Find( "HardPower" ).GetComponent<Image>();

			this.MainGearPower = this.gameObject.transform.Find( "Main" ).GetComponent<Image>();
			this.Sub1GearPower = this.gameObject.transform.Find( "Sub1" ).GetComponent<Image>();
			this.Sub2GearPower = this.gameObject.transform.Find( "Sub2" ).GetComponent<Image>();
			this.Sub3GearPower = this.gameObject.transform.Find( "Sub3" ).GetComponent<Image>();

			#endregion

		}

		/// <summary>
		/// ギア
		/// </summary>
		public GearModel Gear { private set; get; }
		
		/// <summary>
		/// ノードの設定
		/// </summary>
		/// <param name="gear"></param>
		public void SetNode( GearModel gear ) {

			this.Gear = gear;
						
			if( gear != null ) {

				if( gear.brand != null ) {

					this.BrandName.text = gear.brand.name;
					this.Brand.sprite = this.spriteService.GetBrandSpriteFromDictionary( gear.brandId );
					this.EasyPower.sprite = this.spriteService.GetGearPowerSpriteFromDictionary( gear.brand.easyToHoldPowerId );
					this.HardPower.sprite = this.spriteService.GetGearPowerSpriteFromDictionary( gear.brand.difficultToHoldPowerId );

				}

				if( gear.mainPower != null ) {
					this.MainGearPower.sprite = this.spriteService.GetGearPowerSpriteFromDictionary( gear.mainPowerId );
				}

				if( gear.sub1Power != null ) {
					this.Sub1GearPower.sprite = this.spriteService.GetGearPowerSpriteFromDictionary( gear.sub1PowerId );
				}

				if( gear.sub2Power != null ) {
					this.Sub2GearPower.sprite = this.spriteService.GetGearPowerSpriteFromDictionary( gear.sub2PowerId );
				}

				if( gear.sub3Power != null ) {
					this.Sub3GearPower.sprite = this.spriteService.GetGearPowerSpriteFromDictionary( gear.sub3PowerId );
				}

				this.Name.transform.Find( "Text" ).GetComponent<Text>().text = gear.name;

			}
		}
		
	}

}