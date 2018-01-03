using System;
using UnityEngine;

namespace GearListoon.Views.GearPowerSelector {

	/// <summary>
	/// ギア選択Viewer
	/// </summary>
	public class GearPowerSelectorViewer : MonoBehaviour {

		/// <summary>
		/// スクロールコンテント
		/// </summary>
		private GameObject ScrollContent;

		public void Awake() {
			this.ScrollContent = this.transform.Find( "Panel" ).Find( "Scroll View" ).Find( "Viewport" ).Find( "Content" ).gameObject;
		}

		/// <summary>
		/// キャンセルボタン押下時イベント
		/// </summary>
		public Action OnClickedCancelButtonEventHandler { set; get; }

		/// <summary>
		/// キャンセルボタン押下時イベント
		/// </summary>
		public void OnClickedCancelButton() {
			if( this.OnClickedCancelButtonEventHandler != null )
				this.OnClickedCancelButtonEventHandler.Invoke();
		}

		/// <summary>
		/// 一覧初期化
		/// </summary>
		public void ResetScrollContent() {
			foreach( Transform child in this.ScrollContent.transform ) {
				GameObject.Destroy( child.gameObject );
			}
		}

		/// <summary>
		/// ノードを設定
		/// </summary>
		/// <param name="node">ノード</param>
		public void SetScrollNode( GearPowerSelectorNodeViewer node ) {
			node.gameObject.transform.SetParent( this.ScrollContent.transform );
		}

	}

}