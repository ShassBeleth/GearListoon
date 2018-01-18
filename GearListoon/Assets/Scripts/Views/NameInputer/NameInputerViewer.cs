using System;
using UnityEngine;
using UnityEngine.UI;

namespace GearListoon.Views.NameInputer {

	/// <summary>
	/// 名前入力Viewer
	/// </summary>
	public class NameInputerViewer : MonoBehaviour {

		#region イベントとイベントハンドラ

		/// <summary>
		/// OKボタン押下時イベントハンドラ
		/// </summary>
		public Action OnClickedOkButtonEventHandler { set; get; }

		/// <summary>
		/// OKボタン押下時イベント
		/// </summary>
		public void OnClickedOkButton() {
			if( this.OnClickedOkButtonEventHandler != null )
				this.OnClickedOkButtonEventHandler.Invoke();
		}

		/// <summary>
		/// キャンセルボタン押下時イベントハンドラ
		/// </summary>
		public Action OnClickedCancelButtonEventHandler { set; get; }

		/// <summary>
		/// キャンセルボタン押下時イベント
		/// </summary>
		public void OnClickedCancelButton() {
			if( this.OnClickedCancelButtonEventHandler != null )
				this.OnClickedCancelButtonEventHandler.Invoke();
		}

		#endregion
		
		#region 画面部品

		/// <summary>
		/// 名前入力InputField
		/// </summary>
		private InputField InputField { set; get; }
		
		#endregion

		public void Awake() {

			this.InputField = this.transform.Find( "Panel" ).transform.Find( "InputField" ).GetComponent<InputField>();
			
		}

		/// <summary>
		/// 名前取得
		/// </summary>
		/// <returns></returns>
		public string GetInputFieldText() {
			return this.InputField.text;
		}

		/// <summary>
		/// アクティブ設定
		/// </summary>
		/// <param name="active"></param>
		public void SetActive( bool active ) {

			if( active )
				this.InputField.text = "";

			this.gameObject.SetActive( active );


		}
		
	}

}