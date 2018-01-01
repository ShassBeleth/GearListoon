using System;
using System.Collections.Generic;
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
		public Action onClickedHeadButtonEventHandler;

		/// <summary>
		/// 頭ボタン押下時イベント
		/// </summary>
		public void OnClickedHeadButton() {
			if( this.onClickedHeadButtonEventHandler != null )
				this.onClickedHeadButtonEventHandler.Invoke();
		}

		/// <summary>
		/// 服ボタン押下時イベントハンドラ
		/// </summary>
		public Action onClickedClotheButtonEventHandler;

		/// <summary>
		/// 服ボタン押下時イベント
		/// </summary>
		public void OnClickedClotheButton() {
			if( this.onClickedClotheButtonEventHandler != null )
				this.onClickedClotheButtonEventHandler.Invoke();
		}

		/// <summary>
		/// 靴ボタン押下時イベントハンドラ
		/// </summary>
		public Action onClickedShoesButtonEventHandler;
		
		/// <summary>
		/// 靴ボタン押下時イベント
		/// </summary>
		public void OnClickedShoesButton() {
			if( this.onClickedShoesButtonEventHandler != null )
				this.onClickedShoesButtonEventHandler.Invoke();
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

			this.HeadScrollView = GameObject.Find( "HeadScrollView" ).GetComponent<ScrollRect>();
			this.ClotheScrollView = GameObject.Find( "ClotheScrollView" ).GetComponent<ScrollRect>();
			this.ShoesScrollView = GameObject.Find( "ShoesScrollView" ).GetComponent<ScrollRect>();
			this.HeadScrollContent = GameObject.Find( "HeadScrollContent" );
			this.ClotheScrollContent = GameObject.Find( "ClotheScrollContent" );
			this.ShoesScrollContent = GameObject.Find( "ShoesScrollContent" );

			this.GearNode = Resources.Load( "GearList/ScrollViewNode/GearNode" ) as GameObject;

		}

		/// <summary>
		/// 頭ノードを設定
		/// </summary>
		/// <param name="nodes">ノード一覧</param>
		public void SetHeadScrollViewNode( List<string> nodes ) {
			foreach( Transform child in this.HeadScrollContent.transform ) {
				GameObject.Destroy( child.gameObject );
			}
			for( int i = 0 ; i < nodes.Count ; i++ ) { 
				GameObject obj = Instantiate( this.GearNode );
				obj.name = nodes[ i ];
				obj.GetComponent<Image>().color = new Color( ( 0.1f * i ) , 0 , 0 );
				obj.transform.SetParent( this.HeadScrollContent.transform );
			}
		}

		/// <summary>
		/// 服ノードを設定
		/// </summary>
		/// <param name="nodes">ノード一覧</param>
		public void SetClotheScrollViewNode( List<string> nodes ) {
			foreach( Transform child in this.ClotheScrollContent.transform ) {
				GameObject.Destroy( child.gameObject );
			}
			for( int i = 0 ; i < nodes.Count ; i++ ) {
				GameObject obj = Instantiate( this.GearNode );
				obj.name = nodes[ i ];
				obj.GetComponent<Image>().color = new Color( ( 0.1f * i ) , 0 , 0 );
				obj.transform.SetParent( this.ClotheScrollContent.transform );
			}
		}

		/// <summary>
		/// 靴ノードを設定
		/// </summary>
		/// <param name="nodes">ノード一覧</param>
		public void SetShoesScrollViewNode( List<string> nodes ) {
			foreach( Transform child in this.ShoesScrollContent.transform ) {
				GameObject.Destroy( child.gameObject );
			}
			for( int i = 0 ; i < nodes.Count ; i++ ) {
				GameObject obj = Instantiate( this.GearNode );
				obj.name = nodes[ i ];
				obj.GetComponent<Image>().color = new Color( ( 0.1f * i ) , 0 , 0 );
				obj.transform.SetParent( this.ShoesScrollContent.transform );
			}
		}

		/// <summary>
		/// 頭のスクロールビューを表示
		/// </summary>
		public void ShowHeadScrollView() {
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
			if( this.HeadScrollView != null )
				this.HeadScrollView.gameObject.SetActive( false );
			if( this.ClotheScrollView != null )
				this.ClotheScrollView.gameObject.SetActive( false );
			if( this.ShoesScrollView != null )
				this.ShoesScrollView.gameObject.SetActive( true );
		}

	}

}