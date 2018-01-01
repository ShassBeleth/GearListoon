using System;
using System.Collections.Generic;
using GearListoon.Views.GearList;
using UnityEngine;

namespace GearListoon.Presentations.GearList {

	/// <summary>
	/// ギア一覧Presenter
	/// </summary>
	public class GearListPresenter {

		/// <summary>
		/// ギア一覧Viewer
		/// </summary>
		private GearListViewer GearListViewer { set; get; }
		
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public GearListPresenter() {

			this.GearListViewer = GameObject.Find( "GearList" ).GetComponent<GearListViewer>();
			
			this.GearListViewer.onClickedHeadButtonEventHandler = this.OnClickedHeadButtonEvent();
			this.GearListViewer.onClickedClotheButtonEventHandler = this.OnClickedClotheButtonEvent();
			this.GearListViewer.onClickedShoesButtonEventHandler = this.OnClickedShoesButtonEvent();
			
		}

		/// <summary>
		/// 頭ボタン押下時イベント
		/// </summary>
		/// <returns>イベント</returns>
		private Action OnClickedHeadButtonEvent() {
			return () => {
				this.GearListViewer.SetHeadScrollViewNode( 
					new List<string>() {
						"a" ,
						"b" ,
						"c" ,
						"d" ,
						"a" ,
						"b" ,
						"c" ,
						"d" ,
						"a" ,
						"b" ,
						"c" ,
						"d" ,
						"a" ,
						"b" ,
						"c" ,
						"d" ,
						"a" ,
						"b" ,
						"c" ,
						"d" ,
						"a" ,
						"b" ,
						"c" ,
						"d" ,
						"a" ,
						"b" ,
						"c" ,
						"d" ,
						"a" ,
						"b" ,
						"c" ,
						"d" ,
						"a" ,
						"b" ,
						"c" ,
						"d" 
					} 
				);
				this.GearListViewer.ShowHeadScrollView();
			};
		}

		/// <summary>
		/// 服ボタン押下時イベント
		/// </summary>
		/// <returns>イベント</returns>
		private Action OnClickedClotheButtonEvent() {
			return () => {
				this.GearListViewer.SetClotheScrollViewNode(
					new List<string>() {
						"111" ,
						"222" ,
						"333" ,
						"444"
					} 
				);
				this.GearListViewer.ShowClotheScrollView();
			};
		}

		/// <summary>
		/// 靴ボタン押下時イベント
		/// </summary>
		/// <returns>イベント</returns>
		private Action OnClickedShoesButtonEvent() {
			return () => {
				this.GearListViewer.SetShoesScrollViewNode(
					new List<string>() {
						"あああ" ,
						"いいい" ,
						"ううう" ,
						"えええ"
					}
				);
				this.GearListViewer.ShowShoesScrollView();
			};
		}



	}

}