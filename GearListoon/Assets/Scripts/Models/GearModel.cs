namespace GearListoon.Models {

	/// <summary>
	/// ギアModel
	/// </summary>
	public class GearModel {

		/// <summary>
		/// ギアID
		/// </summary>
		public string id;

		/// <summary>
		/// ギア名
		/// </summary>
		public string name;

		/// <summary>
		/// ブランドID
		/// </summary>
		public string brandId;

		/// <summary>
		/// メインギアパワーID
		/// </summary>
		public string mainPowerId = "none";

		/// <summary>
		/// サブ1ギアパワーID
		/// </summary>
		public string sub1PowerId = "none";

		/// <summary>
		/// サブ2ギアパワーID
		/// </summary>
		public string sub2PowerId = "none";

		/// <summary>
		/// サブ3ギアパワーID
		/// </summary>
		public string sub3PowerId = "none";

		/// <summary>
		/// ブランド
		/// </summary>
		public BrandModel brand;

		/// <summary>
		/// メインギアパワー
		/// </summary>
		public PowerModel mainPower;

		/// <summary>
		/// サブ1ギアパワー
		/// </summary>
		public PowerModel sub1Power;

		/// <summary>
		/// サブ2ギアパワー
		/// </summary>
		public PowerModel sub2Power;

		/// <summary>
		/// サブ3ギアパワー
		/// </summary>
		public PowerModel sub3Power;

	}
	
}