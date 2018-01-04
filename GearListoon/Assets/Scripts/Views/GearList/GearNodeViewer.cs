using System;
using GearListoon.Models;
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
		private Text Name;

		/// <summary>
		/// ブランドアイコン
		/// </summary>
		private Text Brand;

		/// <summary>
		/// ブランド名
		/// </summary>
		private Text BrandName;

		/// <summary>
		/// つきやすいギアパワー
		/// </summary>
		private Text EasyPower;

		/// <summary>
		/// つきにくいギアパワー
		/// </summary>
		private Text HardPower;
		
		/// <summary>
		/// メインギアパワー
		/// </summary>
		private Text MainGearPower;

		/// <summary>
		/// サブ1ギアパワー
		/// </summary>
		private Text Sub1GearPower;

		/// <summary>
		/// サブ2ギアパワー
		/// </summary>
		private Text Sub2GearPower;

		/// <summary>
		/// サブ3ギアパワー
		/// </summary>
		private Text Sub3GearPower;

		#endregion

		public void Awake() {

			#region 各部品の参照取得

			this.Name = this.gameObject.transform.Find( "Name" ).transform.Find( "Text" ).GetComponent<Text>();

			this.Brand = this.gameObject.transform.Find( "BrandButton" ).transform.Find( "Text" ).GetComponent<Text>();
			this.BrandName = this.gameObject.transform.Find( "BrandName" ).GetComponent<Text>();
			this.EasyPower = this.gameObject.transform.Find( "EasyPower" ).transform.Find( "Text" ).GetComponent<Text>();
			this.HardPower = this.gameObject.transform.Find( "HardPower" ).transform.Find( "Text" ).GetComponent<Text>();

			this.MainGearPower = this.gameObject.transform.Find( "Main" ).transform.Find( "Text" ).GetComponent<Text>();
			this.Sub1GearPower = this.gameObject.transform.Find( "Sub1" ).transform.Find( "Text" ).GetComponent<Text>();
			this.Sub2GearPower = this.gameObject.transform.Find( "Sub2" ).transform.Find( "Text" ).GetComponent<Text>();
			this.Sub3GearPower = this.gameObject.transform.Find( "Sub3" ).transform.Find( "Text" ).GetComponent<Text>();

			#endregion

		}
		
		/// <summary>
		/// ノードの設定
		/// </summary>
		/// <param name="gear"></param>
		public void SetNode( GearModel gear ) {
			
			if( gear != null ) {

				if( gear.brand != null ) {

					this.Brand.text = gear.brand.id;
					this.BrandName.text = gear.brand.name;

					if( gear.brand.easyToHoldPower != null )
						this.EasyPower.text = gear.brand.easyToHoldPower.name;

					if( gear.brand.difficultToHoldPower != null )
						this.HardPower.text = gear.brand.difficultToHoldPower.name;

				}

				if( gear.mainPower != null )
					this.MainGearPower.text = gear.mainPower.name;

				if( gear.sub1Power != null )
					this.Sub1GearPower.text = gear.sub1Power.name;

				if( gear.sub2Power != null )
					this.Sub2GearPower.text = gear.sub2Power.name;

				if( gear.sub3Power != null )
					this.Sub3GearPower.text = gear.sub3Power.name;

				this.Name.text = gear.name;

			}
		}
		
	}

}