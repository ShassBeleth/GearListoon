namespace GearListoon.Models {

	/// <summary>
	/// ブランド
	/// </summary>
	public class BrandModel {

		/// <summary>
		/// ID
		/// </summary>
		public string id;

		/// <summary>
		/// 名前
		/// </summary>
		public string name;

		/// <summary>
		/// つきやすいギアパワー
		/// </summary>
		public string easyToHoldPowerId;

		/// <summary>
		/// つきにくいギアパワー
		/// </summary>
		public string difficultToHoldPowerId;

		/// <summary>
		/// つきやすいギアパワー
		/// </summary>
		public PowerModel easyToHoldPower;

		/// <summary>
		/// つきにくいギアパワー
		/// </summary>
		public PowerModel difficultToHoldPower;

	}

}