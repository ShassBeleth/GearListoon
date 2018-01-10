﻿using System;
using System.Collections.Generic;
using GearListoon.Models;
using UnityEngine;
using UnityEngine.UI;

namespace GearListoon.Views.GearList {

	/// <summary>
	/// ギア一覧View
	/// </summary>
	public class GearListViewer : MonoBehaviour {

		#region イベントとイベントハンドラ

		/// <summary>
		/// 頭ボタン押下時イベントハンドラ
		/// </summary>
		public Action OnClickedHeadButtonEventHandler { set; get; }

		/// <summary>
		/// 頭ボタン押下時イベント
		/// </summary>
		public void OnClickedHeadButton() {
			if( this.OnClickedHeadButtonEventHandler != null )
				this.OnClickedHeadButtonEventHandler.Invoke();
		}

		/// <summary>
		/// 服ボタン押下時イベントハンドラ
		/// </summary>
		public Action OnClickedClotheButtonEventHandler { set; get; }

		/// <summary>
		/// 服ボタン押下時イベント
		/// </summary>
		public void OnClickedClotheButton() {
			if( this.OnClickedClotheButtonEventHandler != null )
				this.OnClickedClotheButtonEventHandler.Invoke();
		}

		/// <summary>
		/// 靴ボタン押下時イベントハンドラ
		/// </summary>
		public Action OnClickedShoesButtonEventHandler { set; get; }
		
		/// <summary>
		/// 靴ボタン押下時イベント
		/// </summary>
		public void OnClickedShoesButton() {
			if( this.OnClickedShoesButtonEventHandler != null )
				this.OnClickedShoesButtonEventHandler.Invoke();
		}

		/// <summary>
		/// ギア追加ボタン押下時イベントハンドラ
		/// </summary>
		public Action OnClickedAddGearButtonEventHandler { set; get; }

		/// <summary>
		/// ギア追加ボタン押下時イベント
		/// </summary>
		public void OnClickedAddGearButton() {
			if( this.OnClickedAddGearButtonEventHandler != null )
				this.OnClickedAddGearButtonEventHandler.Invoke();
		}

		#endregion

		#region 画面部品

		/// <summary>
		/// 頭スクロールビュー
		/// </summary>
		private ScrollRect HeadScrollView { set; get; }

		/// <summary>
		/// 服スクロールビュー
		/// </summary>
		private ScrollRect ClotheScrollView { set; get; }

		/// <summary>
		/// 靴スクロールビュー
		/// </summary>
		private ScrollRect ShoesScrollView { set; get; }

		/// <summary>
		/// 頭スクロールコンテント
		/// </summary>
		private GameObject HeadScrollContent { set; get; }

		/// <summary>
		/// 服スクロールコンテント
		/// </summary>
		private GameObject ClotheScrollContent { set; get; }

		/// <summary>
		/// 靴スクロールコンテント
		/// </summary>
		private GameObject ShoesScrollContent { set; get; }

		/// <summary>
		/// ギアノード
		/// </summary>
		private GameObject GearNode { set; get; }

		#endregion 

		public void Start() {

			#region 画面部品参照取得
			this.HeadScrollView = GameObject.Find( "HeadScrollView" ).GetComponent<ScrollRect>();
			this.ClotheScrollView = GameObject.Find( "ClotheScrollView" ).GetComponent<ScrollRect>();
			this.ShoesScrollView = GameObject.Find( "ShoesScrollView" ).GetComponent<ScrollRect>();
			this.HeadScrollContent = GameObject.Find( "HeadScrollContent" );
			this.ClotheScrollContent = GameObject.Find( "ClotheScrollContent" );
			this.ShoesScrollContent = GameObject.Find( "ShoesScrollContent" );
			#endregion

		}

		#region 各スクロールコンテントの初期化

		/// <summary>
		/// スクロールコンテント初期化
		/// </summary>
		/// <param name="gearPosition">0:頭,1:服,2:靴</param>
		public void ResetScrollContent( int gearPosition ) {
			switch( gearPosition ) {
				case 0:
					this.ResetHeadScrollContent();
					break;
				case 1:
					this.ResetClotheScrollContent();
					break;
				case 2:
					this.ResetShoesScrollContent();
					break;
			}
		}

		/// <summary>
		/// 頭リスト初期化
		/// </summary>
		public void ResetHeadScrollContent() {
			foreach( Transform child in this.HeadScrollContent.transform ) {
				GameObject.Destroy( child.gameObject );
			}
		}

		/// <summary>
		/// 服リスト初期化
		/// </summary>
		public void ResetClotheScrollContent() {
			foreach( Transform child in this.ClotheScrollContent.transform ) {
				GameObject.Destroy( child.gameObject );
			}
		}

		/// <summary>
		/// 靴リスト初期化
		/// </summary>
		public void ResetShoesScrollContent() {
			foreach( Transform child in this.ShoesScrollContent.transform ) {
				GameObject.Destroy( child.gameObject );
			}
		}

		#endregion

		#region 各ノードの親を設定

		/// <summary>
		/// ノードを設定
		/// </summary>
		/// <param name="gearPosition">0:頭,1:服,2:靴</param>
		/// <param name="node">ノード</param>
		public void SetScrollViewNode( int gearPosition , GearNodeViewer node ) {
			switch( gearPosition ) {
				case 0:
					this.SetHeadScrollViewNode( node );
					break;
				case 1:
					this.SetClotheScrollViewNode( node );
					break;
				case 2:
					this.SetShoesScrollViewNode( node );
					break;
			}
		}

		/// <summary>
		/// 頭ノードを設定
		/// </summary>
		/// <param name="nodes">ノード</param>
		public void SetHeadScrollViewNode( GearNodeViewer node ) {
			node.transform.SetParent( this.HeadScrollContent.transform );
		}

		/// <summary>
		/// 服ノードを設定
		/// </summary>
		/// <param name="nodes">ノード</param>
		public void SetClotheScrollViewNode( GearNodeViewer node ) {
			node.transform.SetParent( this.ClotheScrollContent.transform );
		}

		/// <summary>
		/// 靴ノードを設定
		/// </summary>
		/// <param name="nodes">ノード</param>
		public void SetShoesScrollViewNode( GearNodeViewer node ) {
			node.transform.SetParent( this.ShoesScrollContent.transform );
		}

		#endregion

		/// <summary>
		/// 選択中のギア
		/// </summary>
		public int GearPosition { private set; get; }

		#region 各スクロールビューを表示

		/// <summary>
		/// スクロールビューを表示
		/// </summary>
		/// <param name="gearPosition"></param>
		public void ShowScrollView( int gearPosition ) {
			switch( gearPosition ) {
				case 0:
					this.ShowHeadScrollView();
					break;
				case 1:
					this.ShowClotheScrollView();
					break;
				case 2:
					this.ShowShoesScrollView();
					break;
			}
		}

		/// <summary>
		/// 頭のスクロールビューを表示
		/// </summary>
		public void ShowHeadScrollView() {
			this.GearPosition = 0;
			if( this.HeadScrollView != null )
				this.HeadScrollView.gameObject.SetActive( true );
			if( this.ClotheScrollView != null )
				this.ClotheScrollView.gameObject.SetActive( false );
			if( this.ShoesScrollView != null )
				this.ShoesScrollView.gameObject.SetActive( false );
		}

		/// <summary>
		/// 服のスクロールビューを表示
		/// </summary>
		public void ShowClotheScrollView() {
			this.GearPosition = 1;
			if( this.HeadScrollView != null )
				this.HeadScrollView.gameObject.SetActive( false );
			if( this.ClotheScrollView != null )
				this.ClotheScrollView.gameObject.SetActive( true );
			if( this.ShoesScrollView != null )
				this.ShoesScrollView.gameObject.SetActive( false );
		}

		/// <summary>
		/// 靴のスクロールビューを表示
		/// </summary>
		public void ShowShoesScrollView() {
			this.GearPosition = 2;
			if( this.HeadScrollView != null )
				this.HeadScrollView.gameObject.SetActive( false );
			if( this.ClotheScrollView != null )
				this.ClotheScrollView.gameObject.SetActive( false );
			if( this.ShoesScrollView != null )
				this.ShoesScrollView.gameObject.SetActive( true );
		}

		#endregion
		
		/// <summary>
		/// 頭ギア一覧取得
		/// </summary>
		/// <returns></returns>
		public List<GearModel> GetHeadGears() {
			List<GearModel> gears = new List<GearModel>();
			foreach( Transform child in this.HeadScrollContent.transform ) {
				gears.Add( child.GetComponent<GearNodeViewer>().Gear );
			}
			return gears;
		}

		/// <summary>
		/// 服ギア一覧取得
		/// </summary>
		/// <returns></returns>
		public List<GearModel> GetClotheGears() {
			List<GearModel> gears = new List<GearModel>();
			foreach( Transform child in this.ClotheScrollContent.transform ) {
				gears.Add( child.GetComponent<GearNodeViewer>().Gear );
			}
			return gears;
		}

		/// <summary>
		/// 靴ギア一覧取得
		/// </summary>
		/// <returns></returns>
		public List<GearModel> GetShoesGears() {
			List<GearModel> gears = new List<GearModel>();
			foreach( Transform child in this.ShoesScrollContent.transform ) {
				gears.Add( child.GetComponent<GearNodeViewer>().Gear );
			}
			return gears;
		}

	}

}