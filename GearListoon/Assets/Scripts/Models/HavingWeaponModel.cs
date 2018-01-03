namespace GearListoon.Models {

	/// <summary>
	/// 所持武器Model
	/// </summary>
	public class HavingWeaponModel {

		/// <summary>
		/// ユーザID
		/// </summary>
		public string userId;

		/// <summary>
		/// 武器ID
		/// </summary>
		public string weaponId;

		/// <summary>
		/// ユーザIDに紐づくユーザ
		/// </summary>
		public UserModel user;

		/// <summary>
		/// 武器IDに紐づく武器
		/// </summary>
		public WeaponModel weapon;

	}

}