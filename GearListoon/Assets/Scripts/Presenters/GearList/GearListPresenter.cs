using System;
using System.Collections.Generic;
using GearListoon.Models;
using GearListoon.Services;
using GearListoon.Views.BrandSelector;
using GearListoon.Views.GearList;
using GearListoon.Views.GearPowerSelector;
using GearListoon.Views.NameInputer;
using UnityEngine;

namespace GearListoon.Presenters.GearList {

	/// <summary>
	/// ギア一覧Presenter
	/// </summary>
	public class GearListPresenter {

		/// <summary>
		/// Service
		/// </summary>
		private GearService GearService { set; get; }
		
		#region Viewer

		/// <summary>
		/// ギア一覧Viewer
		/// </summary>
		private GearListViewer GearListViewer { set; get; }

		/// <summary>
		/// ギア選択Viewer
		/// </summary>
		private GearPowerSelectorViewer GearPowerSelectorViewer { set; get; }

		/// <summary>
		/// ブランド選択Viewer
		/// </summary>
		private BrandSelectorViewer BrandSelectorViewer { set; get; }

		/// <summary>
		/// 名前入力Viewer
		/// </summary>
		private NameInputerViewer NameInputerViewer { set; get; }

		#endregion

		#region Prefabs

		/// <summary>
		/// ギアノード
		/// </summary>
		private GameObject GearNode { set; get; }

		/// <summary>
		/// ギアパワーノード
		/// </summary>
		private GameObject GearPowerSelectorNode { set; get; }

		/// <summary>
		/// ブランドノード
		/// </summary>
		private GameObject BrandSelectorNode { set; get; }

		#endregion

		#region ギアパワー選択ダイアログ

		/// <summary>
		/// ギアパワー選択ダイアログから選んだギアパワー
		/// </summary>
		private PowerModel selectedGearPower;

		/// <summary>
		/// ギアパワー選択ダイアログでギアパワーを選んだ後のコールバック
		/// </summary>
		private Action SelectedGearPowerCallback { set; get; }

		/// <summary>
		/// ギアパワーノードクリック時イベント
		/// </summary>
		/// <param name="nodeViewer">ノード</param>
		private void OnClickedGearPowerNodeButton( GearPowerSelectorNodeViewer nodeViewer ) {
			this.selectedGearPower = nodeViewer.PowerModel;
			this.GearPowerSelectorViewer.gameObject.SetActive( false );
			if( this.SelectedGearPowerCallback != null )
				this.SelectedGearPowerCallback.Invoke();
		}

		/// <summary>
		/// ギアパワー選択ダイアログ表示
		/// </summary>
		private void ShowGearPowerSelectorViewer() {
			this.GearPowerSelectorViewer.gameObject.SetActive( true );
		}
		
		#endregion

		#region ブランド選択ダイアログ

		/// <summary>
		/// ブランド選択ダイアログから選んだブランド
		/// </summary>
		private BrandModel selectedBrand;

		/// <summary>
		/// ブランド選択ダイアログでブランドを得ランんだ後のコールバック
		/// </summary>
		private Action SelectedBrandCallback { set; get; }

		/// <summary>
		/// ブランドノードクリック時イベント
		/// </summary>
		/// <param name="nodeViewer">ノード</param>
		private void OnClickedBrandNodeButton( BrandSelectorNodeViewer nodeViewer ) {
			this.selectedBrand = nodeViewer.BrandModel;
			this.BrandSelectorViewer.gameObject.SetActive( false );
			if( this.SelectedBrandCallback != null )
				this.SelectedBrandCallback.Invoke();
		}

		/// <summary>
		/// ブランド選択ダイアログ表示
		/// </summary>
		private void ShowBrandSelectorViewer() {
			this.BrandSelectorViewer.gameObject.SetActive( true );
		}
		
		#endregion

		/// <summary>
		/// 名前入力でOKボタン押下時コールバック
		/// </summary>
		private Action OnClickedNameInputerOkCallback { set; get; }

		/// <summary>
		/// 選択中のギア
		/// </summary>
		private int GearPosition { set; get; }

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public GearListPresenter() {

			this.GearService = new GearService( new CSVService() );
			
			#region Viewerの取得

			this.GearListViewer = GameObject.Find( "GearList" ).GetComponent<GearListViewer>();
			this.GearPowerSelectorViewer = GameObject.Find( "GearPowerSelector" ).GetComponent<GearPowerSelectorViewer>();
			this.BrandSelectorViewer = GameObject.Find( "BrandSelector" ).GetComponent<BrandSelectorViewer>();
			this.NameInputerViewer = GameObject.Find( "NameInputer" ).GetComponent<NameInputerViewer>();

			#endregion

			#region イベントハンドラの設定

			this.GearListViewer.OnClickedHeadButtonEventHandler = this.OnClickedHeadButtonEvent();
			this.GearListViewer.OnClickedClotheButtonEventHandler = this.OnClickedClotheButtonEvent();
			this.GearListViewer.OnClickedShoesButtonEventHandler = this.OnClickedShoesButtonEvent();
			this.GearListViewer.OnClickedAddGearButtonEventHandler = this.OnClickedAddGearButtonEvent();
			
			#endregion

			#region Resources.Load

			this.GearNode = Resources.Load( "GearList/ScrollViewNode/GearNode" ) as GameObject;
			this.GearPowerSelectorNode = Resources.Load( "GearList/ScrollViewNode/GearPowerNode" ) as GameObject;
			this.BrandSelectorNode = Resources.Load( "BrandList/ScrollViewNode/BrandNode" ) as GameObject;

			#endregion

			#region 名前入力ダイアログ初期設定
			
			this.NameInputerViewer.OnClickedOkButtonEventHandler = () => {
				if( this.OnClickedNameInputerOkCallback != null )
					this.OnClickedNameInputerOkCallback.Invoke();
				this.NameInputerViewer.SetActive( false );
			};
			this.NameInputerViewer.OnClickedCancelButtonEventHandler = () => {
				this.NameInputerViewer.SetActive( false );
			};
			this.NameInputerViewer.SetActive( false );

			#endregion

			#region ギアパワー選択ダイアログ初期設定

			foreach( PowerModel power in this.GearService.GetPowers() ) {

				// ノードのインスタンス作成
				GameObject nodeObj = GameObject.Instantiate( this.GearPowerSelectorNode );
				GearPowerSelectorNodeViewer nodeViewer = nodeObj.GetComponent<GearPowerSelectorNodeViewer>();
				this.GearPowerSelectorViewer.SetScrollNode( nodeViewer );
				nodeViewer.SetPower( power );
				nodeViewer.OnClickedNodeButtonEventHandler = () => {
					this.OnClickedGearPowerNodeButton( nodeViewer );
				};
			}
			this.GearPowerSelectorViewer.OnClickedCancelButtonEventHandler = () => {
				this.GearPowerSelectorViewer.gameObject.SetActive( false );
			};
			this.GearPowerSelectorViewer.gameObject.SetActive( false );

			#endregion

			#region ブランド選択ダイアログ初期設定

			foreach( BrandModel brand in this.GearService.GetBrands() ) {

				// ノードのインスタンス作成
				GameObject nodeObj = GameObject.Instantiate( this.BrandSelectorNode );
				BrandSelectorNodeViewer nodeViewer = nodeObj.GetComponent<BrandSelectorNodeViewer>();
				this.BrandSelectorViewer.SetScrollNode( nodeViewer );
				nodeViewer.SetPower( brand );
				nodeViewer.OnClickedNodeButtonEventHandler = () => {
					this.OnClickedBrandNodeButton( nodeViewer );
				};
			}
			this.BrandSelectorViewer.OnClickedCancelButtonEventHandler = () => {
				this.BrandSelectorViewer.gameObject.SetActive( false );
			};
			this.BrandSelectorViewer.gameObject.SetActive( false );

			#endregion

			this.GearListViewer.OnClickedHeadButtonEventHandler.Invoke();

		}

		#region ギアパワー押下時イベント

		/// <summary>
		/// メインギアパワー押下時イベント
		/// </summary>
		/// <param name="model">モデル</param>
		/// <param name="viewer">押したノードのスクリプト</param>
		private void OnClickedMainPowerButton( GearModel model , GearNodeViewer viewer ) {
			this.ShowGearPowerSelectorViewer();
			this.SelectedGearPowerCallback = () => {
				model.mainPower = this.selectedGearPower;
				model.mainPowerId = this.selectedGearPower.id;
				viewer.SetNode( model );
				switch( this.GearPosition ) {
					case 0:
						for( int i = 0 ; i < this.GearService.GetHeadGears().Count ; i++ ) {
							if( model.id.Equals( this.GearService.GetHeadGears()[ i ].id ) ) {
								this.GearService.GetHeadGears()[ i ] = model;
								break;
							}
						}
						break;
					case 1:
						for( int i = 0 ; i < this.GearService.GetClotheGears().Count ; i++ ) {
							if( model.id.Equals( this.GearService.GetClotheGears()[ i ].id ) ) {
								this.GearService.GetClotheGears()[ i ] = model;
								break;
							}
						}
						break;
					case 2:
						for( int i = 0 ; i < this.GearService.GetShoesGears().Count ; i++ ) {
							if( model.id.Equals( this.GearService.GetShoesGears()[ i ].id ) ) {
								this.GearService.GetShoesGears()[ i ] = model;
								break;
							}
						}
						break;
				}

				this.UpdateGears();
			};
		}

		/// <summary>
		/// サブ１ギアパワー押下時イベント
		/// </summary>
		/// <param name="model">モデル</param>
		/// <param name="viewer">押したノードのスクリプト</param>
		private void OnClickedSub1PowerButton( GearModel model , GearNodeViewer viewer ) {
			this.ShowGearPowerSelectorViewer();
			this.SelectedGearPowerCallback = () => {
				model.sub1Power = this.selectedGearPower;
				model.sub1PowerId = this.selectedGearPower.id;
				viewer.SetNode( model );
				switch( this.GearPosition ) {
					case 0:
						for( int i = 0 ; i < this.GearService.GetHeadGears().Count ; i++ ) {
							if( model.id.Equals( this.GearService.GetHeadGears()[ i ].id ) ) {
								this.GearService.GetHeadGears()[ i ] = model;
								break;
							}
						}
						break;
					case 1:
						for( int i = 0 ; i < this.GearService.GetClotheGears().Count ; i++ ) {
							if( model.id.Equals( this.GearService.GetClotheGears()[ i ].id ) ) {
								this.GearService.GetClotheGears()[ i ] = model;
								break;
							}
						}
						break;
					case 2:
						for( int i = 0 ; i < this.GearService.GetShoesGears().Count ; i++ ) {
							if( model.id.Equals( this.GearService.GetShoesGears()[ i ].id ) ) {
								this.GearService.GetShoesGears()[ i ] = model;
								break;
							}
						}
						break;
				}

				this.UpdateGears();
			};
		}

		/// <summary>
		/// サブ２ギアパワー押下時イベント
		/// </summary>
		/// <param name="model">モデル</param>
		/// <param name="viewer">押したノードのスクリプト</param>
		private void OnClickedSub2PowerButton( GearModel model , GearNodeViewer viewer ) {
			this.ShowGearPowerSelectorViewer();
			this.SelectedGearPowerCallback = () => {
				model.sub2Power = this.selectedGearPower;
				model.sub2PowerId = this.selectedGearPower.id;
				viewer.SetNode( model );
				switch( this.GearPosition ) {
					case 0:
						for( int i = 0 ; i < this.GearService.GetHeadGears().Count ; i++ ) {
							if( model.id.Equals( this.GearService.GetHeadGears()[ i ].id ) ) {
								this.GearService.GetHeadGears()[ i ] = model;
								break;
							}
						}
						break;
					case 1:
						for( int i = 0 ; i < this.GearService.GetClotheGears().Count ; i++ ) {
							if( model.id.Equals( this.GearService.GetClotheGears()[ i ].id ) ) {
								this.GearService.GetClotheGears()[ i ] = model;
								break;
							}
						}
						break;
					case 2:
						for( int i = 0 ; i < this.GearService.GetShoesGears().Count ; i++ ) {
							if( model.id.Equals( this.GearService.GetShoesGears()[ i ].id ) ) {
								this.GearService.GetShoesGears()[ i ] = model;
								break;
							}
						}
						break;
				}

				this.UpdateGears();
			};
		}

		/// <summary>
		/// サブ３ギアパワー押下時イベント
		/// </summary>
		/// <param name="model">モデル</param>
		/// <param name="viewer">押したノードのスクリプト</param>
		private void OnClickedSub3PowerButton( GearModel model , GearNodeViewer viewer ) {
			this.ShowGearPowerSelectorViewer();
			this.SelectedGearPowerCallback = () => {
				model.sub3Power = this.selectedGearPower;
				model.sub3PowerId = this.selectedGearPower.id;
				viewer.SetNode( model );
				switch( this.GearPosition ) {
					case 0:
						for( int i = 0 ; i < this.GearService.GetHeadGears().Count ; i++ ) {
							if( model.id.Equals( this.GearService.GetHeadGears()[ i ].id ) ) {
								this.GearService.GetHeadGears()[ i ] = model;
								break;
							}
						}
						break;
					case 1:
						for( int i = 0 ; i < this.GearService.GetClotheGears().Count ; i++ ) {
							if( model.id.Equals( this.GearService.GetClotheGears()[ i ].id ) ) {
								this.GearService.GetClotheGears()[ i ] = model;
								break;
							}
						}
						break;
					case 2:
						for( int i = 0 ; i < this.GearService.GetShoesGears().Count ; i++ ) {
							if( model.id.Equals( this.GearService.GetShoesGears()[ i ].id ) ) {
								this.GearService.GetShoesGears()[ i ] = model;
								break;
							}
						}
						break;
				}

				this.UpdateGears();
			};
		}

		#endregion

		/// <summary>
		/// ブランド押下時イベント
		/// </summary>
		/// <param name="model">モデル</param>
		/// <param name="viewer">押したノードのスクリプト</param>
		private void OnClickedBrandButton( GearModel model , GearNodeViewer viewer ) {
			this.ShowBrandSelectorViewer();
			this.SelectedBrandCallback = () => {
				model.brand = this.selectedBrand;
				model.brandId = this.selectedBrand.id;
				viewer.SetNode( model );
				switch( this.GearPosition ) {
					case 0:
						for( int i = 0 ; i < this.GearService.GetHeadGears().Count ; i++ ) {
							if( model.id.Equals( this.GearService.GetHeadGears()[i].id ) ) {
								this.GearService.GetHeadGears()[ i ] = model;
								break;
							}
						}
						break;
					case 1:
						for( int i = 0 ; i < this.GearService.GetClotheGears().Count ; i++ ) {
							if( model.id.Equals( this.GearService.GetClotheGears()[ i ].id ) ) {
								this.GearService.GetClotheGears()[ i ] = model;
								break;
							}
						}
						break;
					case 2:
						for( int i = 0 ; i < this.GearService.GetShoesGears().Count ; i++ ) {
							if( model.id.Equals( this.GearService.GetShoesGears()[ i ].id ) ) {
								this.GearService.GetShoesGears()[ i ] = model;
								break;
							}
						}
						break;
				}
				this.UpdateGears();
			};
		}

		/// <summary>
		/// ギア一覧を更新する
		/// </summary>
		private void UpdateGears() {
			switch( this.GearPosition ) {
				case 0:
					this.GearService.UpdateHeadGears( this.GearService.GetHeadGears() );
					break;
				case 1:
					this.GearService.UpdateClotheGears( this.GearService.GetClotheGears() );
					break;
				case 2:
					this.GearService.UpdateShoesGears( this.GearService.GetShoesGears() );
					break;
			}
		}
		
		#region ヘッダ部の各ボタン押下時イベント

		/// <summary>
		/// 頭ボタン押下時イベント
		/// </summary>
		/// <returns>イベント</returns>
		private Action OnClickedHeadButtonEvent() {
			return this.OnClickedGearButtonEvent( this.GearService.GetHeadGears() , 0 );
		}

		/// <summary>
		/// 服ボタン押下時イベント
		/// </summary>
		/// <returns>イベント</returns>
		private Action OnClickedClotheButtonEvent() {
			return this.OnClickedGearButtonEvent( this.GearService.GetClotheGears() , 1 );
		}
		
		/// <summary>
		/// 靴ボタン押下時イベント
		/// </summary>
		/// <returns>イベント</returns>
		private Action OnClickedShoesButtonEvent() {
			return this.OnClickedGearButtonEvent( this.GearService.GetShoesGears() , 2 );
		}
		
		/// <summary>
		/// ヘッダの各ボタン押下時イベント
		/// </summary>
		/// <param name="gears"></param>
		/// <param name="gearPosition">0:頭,1:服,2:靴</param>
		/// <returns></returns>
		private Action OnClickedGearButtonEvent( List<GearModel> gears , int gearPosition ) {
			return () => {
				this.GearPosition = gearPosition;
				this.GearListViewer.ResetScrollContent( gearPosition );
				foreach( GearModel model in gears ) {

					// インスタンス生成
					GameObject obj = GameObject.Instantiate( this.GearNode );
					GearNodeViewer nodeViewer = obj.GetComponent<GearNodeViewer>();
					this.GearListViewer.SetScrollViewNode( gearPosition , nodeViewer );
					nodeViewer.SetNode( model );
					nodeViewer.OnClickedGearNameButtonHandler = () => {
						this.OnClickedNameInputerOkCallback = () => {
							model.name = this.NameInputerViewer.GetInputFieldText();
							nodeViewer.SetNode( model );
							this.UpdateGears();
						};
						this.NameInputerViewer.SetActive( true );
					};
					nodeViewer.OnClickedMainGearButtonEventHandler = () => {
						this.OnClickedMainPowerButton( model , nodeViewer );
					};
					nodeViewer.OnClickedSubGear1ButtonEventHandler = () => {
						this.OnClickedSub1PowerButton( model , nodeViewer );
					};
					nodeViewer.OnClickedSubGear2ButtonEventHandler = () => {
						this.OnClickedSub2PowerButton( model , nodeViewer );
					};
					nodeViewer.OnClickedSubGear3ButtonEventHandler = () => {
						this.OnClickedSub3PowerButton( model , nodeViewer );
					};
					nodeViewer.OnClickedBrandButtonHandler = () => {
						this.OnClickedBrandButton( model , nodeViewer );
					};
					nodeViewer.OnClickedDeleteButtonEventHandler = () => {
						this.GearService.DeleteGear( model , gearPosition );
						this.OnClickedGearButtonEvent( gears , gearPosition ).Invoke();
					};
				}
				this.GearListViewer.ShowScrollView( gearPosition );
			};
		}
		
		#endregion

		/// <summary>
		/// ギア追加ボタン押下時イベント
		/// </summary>
		/// <returns></returns>
		private Action OnClickedAddGearButtonEvent() {
			return () => {
				GearModel model = new GearModel() {
					id = Guid.NewGuid().ToString() ,
					name = ""
				};
				switch( this.GearPosition ) {
					case 0:
						this.GearService.GetHeadGears().Add( model );
						this.OnClickedHeadButtonEvent().Invoke();
						break;
					case 1:
						this.GearService.GetClotheGears().Add( model );
						this.OnClickedClotheButtonEvent().Invoke();
						break;
					case 2:
						this.GearService.GetShoesGears().Add( model );
						this.OnClickedShoesButtonEvent().Invoke();
						break;
					default:
						break;
				}
				this.UpdateGears();
			};
		}
		
	}

}