using System.Collections.Generic;
using System.IO;
using GearListoon.Models;
using UnityEngine;

namespace GearListoon.Services {

	public class CSVService {

		public List<GearModel> ReadHeadGearCsv() {
			return this.ReadGearCsv( 0 );
		}

		public List<GearModel> ReadClotheGearCsv() {
			return this.ReadGearCsv( 1 );
		}

		public List<GearModel> ReadShoesGearCsv() {
			return this.ReadGearCsv( 2 );
		}
		
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

		public void WriteHeadGearCsv( List<GearModel> gears ) {
			this.WriteCsv( gears , 0 );
		}

		public void WriteClotheGearCsv( List<GearModel> gears ) {
			this.WriteCsv( gears , 1 );
		}

		public void WriteShoesGearCsv( List<GearModel> gears ) {
			this.WriteCsv( gears , 2 );
		}

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

			FileStream fileStream = new FileStream( path + csvName , FileMode.OpenOrCreate , FileAccess.Write );
			StreamWriter streamWriter = new StreamWriter( fileStream );

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

	}

}
