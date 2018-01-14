using System;
using UnityEngine;
using UnityEngine.UI;

namespace GearListoon.Views.NameInputer {

	public class NameInputerViewer : MonoBehaviour {

		#region イベントとイベントハンドラ

		public Action OnClickedOkButtonEventHandler { set; get; }

		public void OnClickedOkButton() {
			if( this.OnClickedOkButtonEventHandler != null )
				this.OnClickedOkButtonEventHandler.Invoke();
		}

		public Action OnClickedCancelButtonEventHandler { set; get; }

		public void OnClickedCancelButton() {
			if( this.OnClickedCancelButtonEventHandler != null )
				this.OnClickedCancelButtonEventHandler.Invoke();
		}

		#endregion
		
		#region 画面部品

		private InputField InputField { set; get; }
		
		#endregion

		public void Awake() {

			this.InputField = this.transform.Find( "Panel" ).transform.Find( "InputField" ).GetComponent<InputField>();
			
		}

		public string GetInputField() {
			return this.InputField.text;
		}
		
	}

}