using System.Collections.Generic;
using System.IO;
using GearListoon.Models;
using UnityEngine;

namespace GearListoon.Services {

	/// <summary>
	/// CSVService
	/// </summary>
	public class CSVService {

		#region 読み込み

		/// <summary>
		/// 頭ギア読み込み
		/// </summary>
		/// <returns></returns>
		public List<GearModel> ReadHeadGearCsv() {
			return this.ReadGearCsv( 0 );
		}

		/// <summary>
		/// 服ギア読み込み
		/// </summary>
		/// <returns></returns>
		public List<GearModel> ReadClotheGearCsv() {
			return this.ReadGearCsv( 1 );
		}

		/// <summary>
		/// 靴ギア読み込み
		/// </summary>
		/// <returns></returns>
		public List<GearModel> ReadShoesGearCsv() {
			return this.ReadGearCsv( 2 );
		}
		
		/// <summary>
		/// 指定ギアの読み込み
		/// </summary>
		/// <param name="gearPosition"></param>
		/// <returns></returns>
		private List<GearModel> ReadGearCsv( int gearPosition ) {
			
			string csvName =
				gearPosition == 0 ? "head.csv" :
				gearPosition == 1 ? "clothe.csv" :
				gearPosition == 2 ? "shoes.csv" : "";

			string path = Application.persistentDataPath + "/Gear/" +
				( gearPosition == 0 ? "Head/" :
				gearPosition == 1 ? "Clothe/" :
				gearPosition == 2 ? "Shoes/" : "" );


			if( !Directory.Exists( path ) )
				Directory.CreateDirectory( path );

			FileStream fileStream = null;
			StreamReader reader = null;

			try {

				fileStream = new FileStream( path + csvName , FileMode.OpenOrCreate , FileAccess.Read );
				reader = new StreamReader( fileStream );
				List<GearModel> models = new List<GearModel>();

				while( reader.Peek() != -1 ) {
					string[] data = reader.ReadLine().Split( ',' );
					if( data.Length == 7 ) {
						models.Add(
							new GearModel() {
								id = data[ 0 ] ,
								name = data[ 1 ] ,
								brandId = data[ 2 ] ,
								mainPowerId = data[ 3 ] ,
								sub1PowerId = data[ 4 ] ,
								sub2PowerId = data[ 5 ] ,
								sub3PowerId = data[ 6 ]
							}
						);
					}
				}
				fileStream.Close();
				reader.Close();
				return models;

			}
			catch( FileNotFoundException ) {
				if( fileStream != null )
					fileStream.Close();
				if( reader != null )
					reader.Close();
				return new List<GearModel>();
			}

		}

		#endregion

		#region 書き込み

		/// <summary>
		/// 頭ギア書き込み
		/// </summary>
		/// <param name="gears"></param>
		public void WriteHeadGearCsv( List<GearModel> gears ) {
			this.WriteCsv( gears , 0 );
		}

		/// <summary>
		/// 服ギア書き込み
		/// </summary>
		/// <param name="gears"></param>
		public void WriteClotheGearCsv( List<GearModel> gears ) {
			this.WriteCsv( gears , 1 );
		}

		/// <summary>
		/// 靴ギア書き込み
		/// </summary>
		/// <param name="gears"></param>
		public void WriteShoesGearCsv( List<GearModel> gears ) {
			this.WriteCsv( gears , 2 );
		}

		/// <summary>
		/// 各ギアの書き込み
		/// </summary>
		/// <param name="gears"></param>
		/// <param name="gearPosition"></param>
		private void WriteCsv( List<GearModel> gears , int gearPosition ) { 
			
			string csvName =
				gearPosition == 0 ? "head.csv" :
				gearPosition == 1 ? "clothe.csv" :
				gearPosition == 2 ? "shoes.csv" : "";

			string path = Application.persistentDataPath + "/Gear/" +
				( gearPosition == 0 ? "Head/" :
				gearPosition == 1 ? "Clothe/" :
				gearPosition == 2 ? "Shoes/" : "" );

			if( !Directory.Exists( path ) )
				Directory.CreateDirectory( path );
			
			StreamWriter streamWriter = new StreamWriter( path + csvName , false );

			foreach( GearModel gear in gears ) {
				streamWriter.Write(
					gear.id +
					"," +
					gear.name +
					"," +
					gear.brandId +
					"," +
					gear.mainPowerId +
					"," +
					gear.sub1PowerId +
					"," +
					gear.sub2PowerId +
					"," +
					gear.sub3PowerId +
					"\r\n"
				);
			}

			streamWriter.Close();
			
		}

		#endregion

	}

}
