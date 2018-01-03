using System;
using GearListoon.Models;
using GearListoon.Services;
using GearListoon.Views.GearList;
using GearListoon.Views.GearPowerSelector;
using UnityEngine;

namespace GearListoon.Presenters.GearList {

	/// <summary>
	/// ギア一覧Presenter
	/// </summary>
	public class GearListPresenter {

		/// <summary>
		/// Service
		/// </summary>
		private Service Service { set; get; }

		/// <summary>
		/// ギア一覧Viewer
		/// </summary>
		private GearListViewer GearListViewer { set; get; }

		/// <summary>
		/// ギア選択Viewer
		/// </summary>
		private GearPowerSelectorViewer GearPowerSelectorViewer { set; get; }

		/// <summary>
		/// ギアノード
		/// </summary>
		private GameObject GearNode { set; get; }

		/// <summary>
		/// ギアパワーノード
		/// </summary>
		private GearPowerSelectorNodeViewer GearPowerSelectorNodeViewer { set; get; }

		/// <summary>
		/// ギアパワー選択ダイアログから選んだギアパワー
		/// </summary>
		private PowerModel selectedGearPower;

		/// <summary>
		/// ギアパワー選択ダイアログでギアパワーを選んだ後のコールバック
		/// </summary>
		private Action SelectedGearPowerCallback { set; get; }

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public GearListPresenter() {

			this.Service = new Service();

			this.GearListViewer = GameObject.Find( "GearList" ).GetComponent<GearListViewer>();
			
			this.GearListViewer.OnClickedHeadButtonEventHandler = this.OnClickedHeadButtonEvent();
			this.GearListViewer.OnClickedClotheButtonEventHandler = this.OnClickedClotheButtonEvent();
			this.GearListViewer.OnClickedShoesButtonEventHandler = this.OnClickedShoesButtonEvent();
			
			this.GearNode = Resources.Load( "GearList/ScrollViewNode/GearNode" ) as GameObject;

			#region ギアパワー選択ダイアログ初期設定

			this.GearPowerSelectorViewer = GameObject.Find( "GearPowerSelector" ).GetComponent<GearPowerSelectorViewer>();
			GameObject resourceNode = Resources.Load( "GearList/ScrollViewNode/GearPowerNode" ) as GameObject;
			this.GearPowerSelectorNodeViewer = resourceNode.GetComponent<GearPowerSelectorNodeViewer>();

			foreach( PowerModel power in this.Service.GetPowers() ) {
				GameObject nodeObj = GameObject.Instantiate( this.GearPowerSelectorNodeViewer.gameObject );
				GearPowerSelectorNodeViewer nodeViewer = nodeObj.GetComponent<GearPowerSelectorNodeViewer>();
				this.GearPowerSelectorViewer.SetScrollNode( nodeViewer );
				nodeViewer.SetPower( power );
				nodeViewer.OnClickedNodeButtonEventHandler = () => {
					this.selectedGearPower = nodeViewer.PowerModel;
					this.GearPowerSelectorViewer.gameObject.SetActive( false );
					if( this.SelectedGearPowerCallback != null )
						this.SelectedGearPowerCallback.Invoke();
				};
			}
			this.GearPowerSelectorViewer.gameObject.SetActive( false );

			#endregion

		}

		/// <summary>
		/// 頭ボタン押下時イベント
		/// </summary>
		/// <returns>イベント</returns>
		private Action OnClickedHeadButtonEvent() {
			return () => {
				this.GearListViewer.ResetHeadScrollContent();
				foreach( GearModel node in this.Service.GetHeadGears() ) {
					GameObject obj = GameObject.Instantiate( this.GearNode );
					GearNodeViewer nodeViewer = obj.GetComponent<GearNodeViewer>();
					this.GearListViewer.SetHeadScrollViewNode( nodeViewer );
					nodeViewer.SetNode( node );
					nodeViewer.OnClickedMainGearButtonEventHandler = () => {
						this.ShowGearPowerSelectorViewer();
						this.SelectedGearPowerCallback = () => {
							node.mainPower = this.selectedGearPower;
							node.mainPowerId = this.selectedGearPower.id;
							nodeViewer.SetNode( node );
						};
					};
					nodeViewer.OnClickedSubGear1ButtonEventHandler = () => {
						this.ShowGearPowerSelectorViewer();
						this.SelectedGearPowerCallback = () => {
							node.sub1Power = this.selectedGearPower;
							node.sub1PowerId = this.selectedGearPower.id;
							nodeViewer.SetNode( node );
						};
					};
					nodeViewer.OnClickedSubGear2ButtonEventHandler = () => {
						this.ShowGearPowerSelectorViewer();
						this.SelectedGearPowerCallback = () => {
							node.sub2Power = this.selectedGearPower;
							node.sub2PowerId = this.selectedGearPower.id;
							nodeViewer.SetNode( node );
						};
					};
					nodeViewer.OnClickedSubGear3ButtonEventHandler = () => {
						this.ShowGearPowerSelectorViewer();
						this.SelectedGearPowerCallback = () => {
							node.sub3Power = this.selectedGearPower;
							node.sub3PowerId = this.selectedGearPower.id;
							nodeViewer.SetNode( node );
						};
					};
				}
				this.GearListViewer.ShowHeadScrollView();
			};
		}

		/// <summary>
		/// 服ボタン押下時イベント
		/// </summary>
		/// <returns>イベント</returns>
		private Action OnClickedClotheButtonEvent() {
			return () => {
				this.GearListViewer.ResetClotheScrollContent();
				foreach( GearModel node in this.Service.GetClotheGears() ) {
					GameObject obj = GameObject.Instantiate( this.GearNode );
					GearNodeViewer nodeViewer = obj.GetComponent<GearNodeViewer>();
					this.GearListViewer.SetClotheScrollViewNode( nodeViewer );
					nodeViewer.SetNode( node );
				}
				this.GearListViewer.ShowClotheScrollView();
			};
		}

		/// <summary>
		/// 靴ボタン押下時イベント
		/// </summary>
		/// <returns>イベント</returns>
		private Action OnClickedShoesButtonEvent() {
			return () => {
				this.GearListViewer.ResetShoesScrollContent();
				foreach( GearModel node in this.Service.GetShoesGears() ) {
					GameObject obj = GameObject.Instantiate( this.GearNode );
					GearNodeViewer nodeViewer = obj.GetComponent<GearNodeViewer>();
					this.GearListViewer.SetShoesScrollViewNode( nodeViewer );
					nodeViewer.SetNode( node );
					nodeViewer.OnClickedMainGearButtonEventHandler = () => {
					};
				}
				this.GearListViewer.ShowShoesScrollView();
			};
		}


		private void ShowGearPowerSelectorViewer() {
			this.GearPowerSelectorViewer.gameObject.SetActive( true );
		}
	}

}