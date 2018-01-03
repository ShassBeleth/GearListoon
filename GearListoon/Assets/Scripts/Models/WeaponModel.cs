namespace GearListoon.Models {

	/// <summary>
	/// 武器Model
	/// </summary>
	public class WeaponModel {

		/// <summary>
		/// ID
		/// </summary>
		public string id;

		/// <summary>
		/// 名前
		/// </summary>
		public string name;

		/// <summary>
		/// サブID
		/// </summary>
		public string subId;

		/// <summary>
		/// スペシャルID
		/// </summary>
		public string specialId;

		/// <summary>
		/// サブIDに紐づくサブ武器
		/// </summary>
		public SubWeaponModel subWeapon;

		/// <summary>
		/// スペシャルIDに紐づくスペシャル武器
		/// </summary>
		public SpecialWeaponModel specialWeapon;

	}

}