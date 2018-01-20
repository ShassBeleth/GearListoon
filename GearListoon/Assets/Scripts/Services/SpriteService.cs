using System.Collections.Generic;
using UnityEngine;

namespace GearListoon.Services {

	/// <summary>
	/// SpriteService
	/// </summary>
	public class SpriteService {

		#region Singletonパターン

		/// <summary>
		/// インスタンス
		/// </summary>
		private static SpriteService instance = null;

		/// <summary>
		/// インスタンス取得
		/// </summary>
		/// <returns></returns>
		public static SpriteService GetInstance() {
			if( instance == null )
				instance = new SpriteService();
			return instance;
		}

		#endregion

		/// <summary>
		/// ギアパワーSprites
		/// </summary>
		private Dictionary<string , Sprite> gearPowerSpritesDictionary;

		private Dictionary<string , Sprite> brandSpritesDictionary;

		private Sprite nothingSprite;

		private Sprite[] gearSprites;

		private Sprite[] brandSprites;

		private Sprite GetGearSprite( string name ) {
			foreach( Sprite sprite in this.gearSprites ) {
				if( name.Equals( sprite.name ) )
					return sprite;
			}
			return null;
		}

		private Sprite GetBrandSprite( string name ) {
			foreach( Sprite sprite in this.brandSprites ) {
				if( name.Equals( sprite.name ) )
					return sprite;
			}
			return null;
		}

		private SpriteService() {

			this.gearPowerSpritesDictionary = new Dictionary<string , Sprite>();
			this.brandSpritesDictionary = new Dictionary<string , Sprite>();

			#region nothingSprite取得

			Sprite[] nothingSprites = Resources.LoadAll<Sprite>( "Icon/Nothing" );
			foreach( Sprite sprite in nothingSprites ) {
				if( "Nothing".Equals( sprite.name ) )
					this.nothingSprite = sprite;
			}

			#endregion
			
			this.gearSprites = Resources.LoadAll<Sprite>( "Icon/Gear" );
			this.brandSprites = Resources.LoadAll<Sprite>( "Icon/Brand" );

			#region ギアパワー一覧
			this.gearPowerSpritesDictionary.Add( "none" , this.nothingSprite );
			this.gearPowerSpritesDictionary.Add(
				"9a28baa7-520a-4e1a-9348-391d5ed05a99" ,
				this.GetGearSprite( "SubPerformanceUp" )
			);
			this.gearPowerSpritesDictionary.Add(
				"b71c74a0-f4a7-425a-b01f-455c90e952b6" ,
				this.GetGearSprite( "SubEfficiencyIncrease" )
			);
			this.gearPowerSpritesDictionary.Add(
				"dac60773-5fad-4b1f-b780-3aeab732d5b7" ,
				this.GetGearSprite( "IncreaseSpecialUp" )
			);
			this.gearPowerSpritesDictionary.Add(
				"4d04c4dd-15e6-4a50-81d2-27aa0eeb52ae" ,
				this.GetGearSprite( "SpecialDecreaseDown" )
			);
			this.gearPowerSpritesDictionary.Add(
				"9eb9ee16-299e-44f6-a4b3-b952835bb940" ,
				this.GetGearSprite( "SpecialPerformanceUp" )
			);
			this.gearPowerSpritesDictionary.Add(
				"e2b0c798-994d-474b-b19b-8874286f63a6" ,
				this.GetGearSprite( "SquidSpeed" )
			);
			this.gearPowerSpritesDictionary.Add(
				"76e88d20-30ae-416a-990b-df6e6cd75538" ,
				this.GetGearSprite( "PersonSpeed" )
			);
			this.gearPowerSpritesDictionary.Add(
				"4e518beb-de42-4f48-a069-63a508bc500a" ,
				this.GetGearSprite( "Ninja" )
			);
			this.gearPowerSpritesDictionary.Add(
				"d4e7221c-cf73-4919-9021-ff1d872b0bba" ,
				this.GetGearSprite( "SafetyShoes" )
			);
			this.gearPowerSpritesDictionary.Add(
				"949ac24c-896a-418e-95f7-d40664b87fd6" ,
				this.GetGearSprite( "MainEfficiencyIncrease" )
			);
			this.gearPowerSpritesDictionary.Add(
				"816e1f6e-371a-4983-9ef6-b7465ee1315d" ,
				this.GetGearSprite( "IncreaseInkRecoverySpeed" )
			);
			this.gearPowerSpritesDictionary.Add(
				"21d286c9-ff1d-47eb-9af0-0018173b2976" ,
				this.GetGearSprite( "StealthJump" )
			);
			this.gearPowerSpritesDictionary.Add(
				"f099676a-ee43-433f-a131-eddbc7818e6c" ,
				this.GetGearSprite( "ShorterSuperJumpTime" )
			);
			this.gearPowerSpritesDictionary.Add(
				"5e88bb43-8b7c-4c04-ba23-4f4658d03f02" ,
				this.GetGearSprite( "ReducedResurrection" )
			);
			this.gearPowerSpritesDictionary.Add(
				"2a0fa9f2-e643-4ce2-b99a-57887e09cc74" ,
				this.GetGearSprite( "StartDash" )
			);
			this.gearPowerSpritesDictionary.Add(
				"340a8c1e-3874-433d-ad27-d832ea8b76ce" ,
				this.GetGearSprite( "Comeback" )
			);
			this.gearPowerSpritesDictionary.Add(
				"cce89d3b-baea-432e-b445-e59ced55116a" ,
				this.GetGearSprite( "Adversity" )
			);
			this.gearPowerSpritesDictionary.Add(
				"3ca6e386-cf70-46d0-ad56-2c06e227e296" ,
				this.GetGearSprite( "BlastReduction" )
			);
			this.gearPowerSpritesDictionary.Add(
				"b99b9725-ae09-4d13-bf0a-7940a13c02f6" ,
				this.GetGearSprite( "MarkingGuard" )
			);
			this.gearPowerSpritesDictionary.Add(
				"e8808ea9-636e-46c4-974e-28da6d8eda21" ,
				this.GetGearSprite( "ThermalInk" )
			);
			this.gearPowerSpritesDictionary.Add(
				"b7800add-aa15-4973-a051-fe18d06bd5bc" ,
				this.GetGearSprite( "PhysicalPowerUp" )
			);
			this.gearPowerSpritesDictionary.Add(
				"04e060f7-33c8-45fb-9f54-b05c29c98f08" ,
				this.GetGearSprite( "Passive" )
			);
			this.gearPowerSpritesDictionary.Add(
				"00337511-ffe5-460a-bb82-977c7b0866be" ,
				this.GetGearSprite( "Penalty" )
			);
			this.gearPowerSpritesDictionary.Add(
				"f830c85c-97df-4005-944b-c2ed532c3237" ,
				this.GetGearSprite( "Revenge" )
			);
			this.gearPowerSpritesDictionary.Add(
				"91d11d15-9764-4b78-a52f-0afa7b5ee1a9" ,
				this.GetGearSprite( "LastSports" )
			);
			#endregion

			#region ブランド一覧
			this.brandSpritesDictionary.Add(
					"a888c3ed-10eb-445b-9814-b6d1df650ce8" ,
					this.GetBrandSprite( "Aironikku" )
			);
			this.brandSpritesDictionary.Add(
					"87832f5f-2bb5-4cf6-a2b5-c6e733d0b8ed" ,
					this.GetBrandSprite( "Anaaki" )
			);
			this.brandSpritesDictionary.Add(
				"4c274bfb-cfcd-4853-abea-3d0f97cee6eb" ,
				this.GetBrandSprite( "Arome" )
			);
			this.brandSpritesDictionary.Add(
				"3573cd5e-fabe-4bf5-95b5-f49282a2c820" ,
				this.GetBrandSprite( "Ezokko" )
			);
			this.brandSpritesDictionary.Add(
				"9c7bbe9e-0a8a-4e97-b807-61f460f3c28d" ,
				this.GetBrandSprite( "Emperi" )
			);
			this.brandSpritesDictionary.Add(
				"eab2c5f2-a740-4b96-8d52-07913a909cf2" ,
				this.GetBrandSprite( "Kuragesu" )
			);
			this.brandSpritesDictionary.Add(
				"d06fd0a0-fc19-4793-9367-1ab1402391f9" ,
				this.GetBrandSprite( "Shigureni" )
			);
			this.brandSpritesDictionary.Add(
				"13e88049-c176-4391-9391-63d34dc53c93" ,
				this.GetBrandSprite( "Jimon" )
			);
			this.brandSpritesDictionary.Add(
				"4fa28b14-cb83-47f8-b69e-d7dc01e6847b" ,
				this.GetBrandSprite( "Tatakikensaki" )
			);
			this.brandSpritesDictionary.Add(
				"5017fd40-1e57-4341-9d28-1aa6cbc340a8" ,
				this.GetBrandSprite( "Batoroika" )
			);
			this.brandSpritesDictionary.Add(
				"850a760b-304e-419d-a520-cd8182eaeab7" ,
				this.GetBrandSprite( "Forima" )
			);
			this.brandSpritesDictionary.Add(
				"38b66388-9073-4e6a-aa8c-e7f658a116ee" ,
				this.GetBrandSprite( "Hotakkusu" )
			);
			this.brandSpritesDictionary.Add(
				"e2d1cd74-c840-4d2a-af8c-04e59ec49fbc" ,
				this.GetBrandSprite( "Hokkori" )
			);
			this.brandSpritesDictionary.Add(
				"98f46caf-7604-4fa8-8ea3-4b14c98ab240" ,
				this.GetBrandSprite( "Rokkenberuku" )
			);
			this.brandSpritesDictionary.Add(
				"bd5663d4-6f2c-470a-a540-2e729ccecba1" ,
				this.GetBrandSprite( "Yako" )
			);
			this.brandSpritesDictionary.Add(
				"b1bb35a2-25ec-4245-afeb-0163d371be7b" ,
				this.GetBrandSprite( "Atarimeido" )
			);
			this.brandSpritesDictionary.Add(
				"9fc0df89-a7e5-4ec2-884a-67fbca0fb6b1" ,
				this.GetBrandSprite( "Amibo" )
			);
			this.brandSpritesDictionary.Add(
				"ea9041d1-82ba-48a0-a05a-f46e325cf3a3" ,
				this.GetBrandSprite( "KumasanShokai" )
			);
			#endregion

		}

		/// <summary>
		/// ギアパワーSprite取得
		/// </summary>
		/// <param name="id">ギアパワーID</param>
		public Sprite GetGearPowerSpriteFromDictionary( string id ) {
			try {
				return this.gearPowerSpritesDictionary[ id ];
			}
			catch( KeyNotFoundException ) {
				return this.nothingSprite;
			}
		}

		/// <summary>
		/// ブランドSprite取得
		/// </summary>
		/// <param name="id">ブランドID</param>
		public Sprite GetBrandSpriteFromDictionary( string id ) {
			try {
				return this.brandSpritesDictionary[ id ];
			}
			catch( KeyNotFoundException ) {
				return this.nothingSprite;
			}
		}
		
	}

}