﻿using System;
using System.Collections.Generic;
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

		#region Viewer

		/// <summary>
		/// ギア一覧Viewer
		/// </summary>
		private GearListViewer GearListViewer { set; get; }

		/// <summary>
		/// ギア選択Viewer
		/// </summary>
		private GearPowerSelectorViewer GearPowerSelectorViewer { set; get; }

		#endregion

		#region Prefabs

		/// <summary>
		/// ギアノード
		/// </summary>
		private GameObject GearNode { set; get; }

		/// <summary>
		/// ギアパワーノード
		/// </summary>
		private GameObject GearPowerSelectorNode { set; get; }

		#endregion
		
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

			#region Viewerの取得

			this.GearListViewer = GameObject.Find( "GearList" ).GetComponent<GearListViewer>();
			this.GearPowerSelectorViewer = GameObject.Find( "GearPowerSelector" ).GetComponent<GearPowerSelectorViewer>();

			#endregion

			#region イベントハンドラの設定

			this.GearListViewer.OnClickedHeadButtonEventHandler = this.OnClickedHeadButtonEvent();
			this.GearListViewer.OnClickedClotheButtonEventHandler = this.OnClickedClotheButtonEvent();
			this.GearListViewer.OnClickedShoesButtonEventHandler = this.OnClickedShoesButtonEvent();

			#endregion

			#region Resources.Load

			this.GearNode = Resources.Load( "GearList/ScrollViewNode/GearNode" ) as GameObject;
			this.GearPowerSelectorNode = Resources.Load( "GearList/ScrollViewNode/GearPowerNode" ) as GameObject;

			#endregion

			#region ギアパワー選択ダイアログ初期設定
			
			foreach( PowerModel power in this.Service.GetPowers() ) {

				// ノードのインスタンス作成
				GameObject nodeObj = GameObject.Instantiate( this.GearPowerSelectorNode );
				GearPowerSelectorNodeViewer nodeViewer = nodeObj.GetComponent<GearPowerSelectorNodeViewer>();
				this.GearPowerSelectorViewer.SetScrollNode( nodeViewer );
				nodeViewer.SetPower( power );
				nodeViewer.OnClickedNodeButtonEventHandler = () => {
					this.OnClickedGearPowerNodeButton( nodeViewer );
				};
			}
			this.GearPowerSelectorViewer.gameObject.SetActive( false );

			#endregion

		}

		/// <summary>
		/// ギアパワーノードクリック時イベント
		/// </summary>
		/// <param name="nodeViewer">ノード</param>
		private void OnClickedGearPowerNodeButton( GearPowerSelectorNodeViewer nodeViewer ) {
			this.selectedGearPower = nodeViewer.PowerModel;
			this.GearPowerSelectorViewer.gameObject.SetActive( false );
			if( this.SelectedGearPowerCallback != null )
				this.SelectedGearPowerCallback.Invoke();
		}

		#region ギアパワー押下時イベント

		/// <summary>
		/// メインギアパワー押下時イベント
		/// </summary>
		/// <param name="model">モデル</param>
		/// <param name="viewer">押したノードのスクリプト</param>
		private void OnClickedMainPowerButton( GearModel model , GearNodeViewer viewer ) {
			this.ShowGearPowerSelectorViewer();
			this.SelectedGearPowerCallback = () => {
				model.mainPower = this.selectedGearPower;
				model.mainPowerId = this.selectedGearPower.id;
				viewer.SetNode( model );
			};
		}

		/// <summary>
		/// サブ１ギアパワー押下時イベント
		/// </summary>
		/// <param name="model">モデル</param>
		/// <param name="viewer">押したノードのスクリプト</param>
		private void OnClickedSub1PowerButton( GearModel model , GearNodeViewer viewer ) {
			this.ShowGearPowerSelectorViewer();
			this.SelectedGearPowerCallback = () => {
				model.sub1Power = this.selectedGearPower;
				model.sub1PowerId = this.selectedGearPower.id;
				viewer.SetNode( model );
			};
		}

		/// <summary>
		/// サブ２ギアパワー押下時イベント
		/// </summary>
		/// <param name="model">モデル</param>
		/// <param name="viewer">押したノードのスクリプト</param>
		private void OnClickedSub2PowerButton( GearModel model , GearNodeViewer viewer ) {
			this.ShowGearPowerSelectorViewer();
			this.SelectedGearPowerCallback = () => {
				model.sub2Power = this.selectedGearPower;
				model.sub2PowerId = this.selectedGearPower.id;
				viewer.SetNode( model );
			};
		}

		/// <summary>
		/// サブ３ギアパワー押下時イベント
		/// </summary>
		/// <param name="model">モデル</param>
		/// <param name="viewer">押したノードのスクリプト</param>
		private void OnClickedSub3PowerButton( GearModel model , GearNodeViewer viewer ) {
			this.ShowGearPowerSelectorViewer();
			this.SelectedGearPowerCallback = () => {
				model.sub3Power = this.selectedGearPower;
				model.sub3PowerId = this.selectedGearPower.id;
				viewer.SetNode( model );
			};
		}

		#endregion

		#region ヘッダ部の各ボタン押下時イベント

		/// <summary>
		/// 頭ボタン押下時イベント
		/// </summary>
		/// <returns>イベント</returns>
		private Action OnClickedHeadButtonEvent() {
			return this.OnClickedHeaderGearButtonEvent( this.Service.GetHeadGears() , 0 );
		}

		/// <summary>
		/// 服ボタン押下時イベント
		/// </summary>
		/// <returns>イベント</returns>
		private Action OnClickedClotheButtonEvent() {
			return this.OnClickedHeaderGearButtonEvent( this.Service.GetClotheGears() , 1 );
		}

		/// <summary>
		/// 靴ボタン押下時イベント
		/// </summary>
		/// <returns>イベント</returns>
		private Action OnClickedShoesButtonEvent() {
			return this.OnClickedHeaderGearButtonEvent( this.Service.GetShoesGears() , 2 );
		}
		
		/// <summary>
		/// ヘッダの各ボタン押下時イベント
		/// </summary>
		/// <param name="gears"></param>
		/// <param name="gearPosition">0:頭,1:服,2:靴</param>
		/// <returns></returns>
		private Action OnClickedHeaderGearButtonEvent( List<GearModel> gears , int gearPosition ) {
			return () => {
				this.GearListViewer.ResetScrollContent( gearPosition );
				foreach( GearModel model in gears ) {

					// インスタンス生成
					GameObject obj = GameObject.Instantiate( this.GearNode );
					GearNodeViewer nodeViewer = obj.GetComponent<GearNodeViewer>();
					this.GearListViewer.SetScrollViewNode( gearPosition , nodeViewer );
					nodeViewer.SetNode( model );
					nodeViewer.OnClickedMainGearButtonEventHandler = () => {
						this.OnClickedMainPowerButton( model , nodeViewer );
					};
					nodeViewer.OnClickedSubGear1ButtonEventHandler = () => {
						this.OnClickedSub1PowerButton( model , nodeViewer );
					};
					nodeViewer.OnClickedSubGear2ButtonEventHandler = () => {
						this.OnClickedSub2PowerButton( model , nodeViewer );
					};
					nodeViewer.OnClickedSubGear3ButtonEventHandler = () => {
						this.OnClickedSub3PowerButton( model , nodeViewer );
					};
				}
				this.GearListViewer.ShowScrollView( gearPosition );
			};
		}

		#endregion

		/// <summary>
		/// ギアパワー選択ダイアログ表示
		/// </summary>
		private void ShowGearPowerSelectorViewer() {
			this.GearPowerSelectorViewer.gameObject.SetActive( true );
		}

	}

}