using System.Collections.Generic;
using GearListoon.Models;

namespace GearListoon.Services {

	/// <summary>
	/// Service
	/// </summary>
	public class Service {

		/// <summary>
		/// ユーザ一覧
		/// </summary>
		private List<UserModel> users;

		/// <summary>
		/// サブ武器一覧
		/// </summary>
		private List<SubWeaponModel> subWeapons;

		/// <summary>
		/// スペシャル武器一覧
		/// </summary>
		private List<SpecialWeaponModel> specialWeapons;

		/// <summary>
		/// 武器一覧
		/// </summary>
		private List<WeaponModel> weapons;

		/// <summary>
		/// 所持武器一覧
		/// </summary>
		private List<HavingWeaponModel> havingWeapons;

		/// <summary>
		/// ギアパワー一覧
		/// </summary>
		private List<PowerModel> powers;

		/// <summary>
		/// ブランド一覧
		/// </summary>
		private List<BrandModel> brands;

		/// <summary>
		/// 頭ギア一覧
		/// </summary>
		private List<GearModel> headGears;

		/// <summary>
		/// 服ギア一覧
		/// </summary>
		private List<GearModel> clotheGears;

		/// <summary>
		/// 靴ギア一覧
		/// </summary>
		private List<GearModel> shoesGears;

		/// <summary>
		/// CSVService
		/// </summary>
		private CSVService csvService;

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public Service( CSVService csvService ) {

			this.csvService = csvService;

			#region サブ一覧
			this.subWeapons = new List<SubWeaponModel>() {
				new SubWeaponModel(){
					id = "842e87bc-2305-4210-b9b0-a30e2910a7ee" ,
					name = "スプラッシュボム"
				} ,
				new SubWeaponModel(){
					id = "b78117b7-9483-49ec-9937-701159418e09" ,
					name = "クイックボム"
				} ,
				new SubWeaponModel(){
					id = "c6c59d90-d7bb-4da6-9dff-3e163f15a9d0" ,
					name = "キューバンボム"
				} ,
				new SubWeaponModel(){
					id = "1021ca37-d02d-4f75-930a-f631f728490b" ,
					name = "スプリンクラー"
				} ,
				new SubWeaponModel(){
					id = "33b70434-4a60-4231-86f9-44e067cd1577" ,
					name = "ジャンプビーコン"
				} ,
				new SubWeaponModel(){
					id = "5dcec9b5-e03c-4ee5-98a2-1a66d095490f" ,
					name = "スプラッシュシールド"
				} ,
				new SubWeaponModel(){
					id = "9506e4ed-dd1e-410b-a3fd-222e10b6735c" ,
					name = "ポイントセンサー"
				} ,
				new SubWeaponModel(){
					id = "8ae90e7d-2ee1-4d4f-b62e-50c6efaf27ad" ,
					name = "トラップ"
				} ,
				new SubWeaponModel(){
					id = "0ede417d-fe34-4294-9cb0-8147e689e0fe" ,
					name = "カーリングボム"
				} ,
				new SubWeaponModel(){
					id = "2af56965-eb45-47f2-b1f5-eb61485d4225" ,
					name = "ロボットボム"
				} ,
				new SubWeaponModel(){
					id = "d40ccbf5-4302-468e-a713-e600e11481b2" ,
					name = "ポイズンミスト"
				}
			};
			#endregion

			#region スペシャル一覧
			this.specialWeapons = new List<SpecialWeaponModel>() {
				new SpecialWeaponModel(){
					id = "ef748149-3d8e-4ae6-8f47-32684e24c32a" ,
					name = "ジェットパック"
				} ,
				new SpecialWeaponModel(){
					id = "e2a02634-983b-4dc4-8af0-392d3f84cf1a" ,
					name = "スーパーチャクチ"
				} ,
				new SpecialWeaponModel(){
					id = "e1ca1813-1bf4-489f-8b61-c9796d5128eb" ,
					name = "マルチミサイル"
				} ,
				new SpecialWeaponModel(){
					id = "a97730fa-ec8a-48f7-b5a3-cbed7ece6994" ,
					name = "ハイパープレッサー"
				} ,
				new SpecialWeaponModel(){
					id = "5282d2e0-d73e-4d97-84e9-748f321271ac" ,
					name = "アメフラシ"
				} ,
				new SpecialWeaponModel(){
					id = "92fb5934-4c68-4da6-ae9b-6cbb9385ea6d" ,
					name = "スプラッシュボムピッチャー"
				} ,
				new SpecialWeaponModel(){
					id = "f67478c8-5b82-482d-8e91-3b1e974e9467" ,
					name = "キューバンボムピッチャー"
				} ,
				new SpecialWeaponModel(){
					id = "01cbe269-b213-4ebf-b34b-53f602b8654c" ,
					name = "カーリングボムピッチャー"
				} ,
				new SpecialWeaponModel(){
					id = "be3c3c54-7baa-419c-8bc7-5f89176ee924" ,
					name = "インクアーマー"
				} ,
				new SpecialWeaponModel(){
					id = "92d4ceae-11ae-484e-91d9-ac4989da91f5" ,
					name = "イカスフィア"
				} ,
				new SpecialWeaponModel(){
					id = "6979c194-abb4-42c9-a0c8-86a6ca82c07d" ,
					name = "バブルランチャー"
				}
			};
			#endregion

			#region 武器一覧
			this.weapons = new List<WeaponModel>() {
				new WeaponModel(){
					id = "6bccc950-e670-44e0-be3d-27658af0f754" ,
					name = "スプラシューターコラボ" ,
					subId = "842e87bc-2305-4210-b9b0-a30e2910a7ee" ,
					specialId = "ef748149-3d8e-4ae6-8f47-32684e24c32a"
				} ,
				new WeaponModel(){
					id = "4537d4a2-3828-4ad0-af62-f6e40105acf3" ,
					name = ".52ガロン",
					subId = "9506e4ed-dd1e-410b-a3fd-222e10b6735c" ,
					specialId = "92d4ceae-11ae-484e-91d9-ac4989da91f5"
				} ,
				new WeaponModel(){
					id = "46cc2f24-4f59-4f9d-b1fa-9febe86b42ab" ,
					name = "わかばシューター",
					subId = "842e87bc-2305-4210-b9b0-a30e2910a7ee" ,
					specialId = "be3c3c54-7baa-419c-8bc7-5f89176ee924"
				} ,
				new WeaponModel(){
					id = "970d8873-302f-4aba-80b4-14d932161c0c" ,
					name = "シャープマーカー",
					subId = "d40ccbf5-4302-468e-a713-e600e11481b2" ,
					specialId = "ef748149-3d8e-4ae6-8f47-32684e24c32a"
				} ,
				new WeaponModel(){
					id = "0cbc2688-a459-4e43-b859-4879a86a9d6c" ,
					name = "N-ZAP89",
					subId = "2af56965-eb45-47f2-b1f5-eb61485d4225" ,
					specialId = "e1ca1813-1bf4-489f-8b61-c9796d5128eb"
				} ,
				new WeaponModel(){
					id = "d6d0fdd8-968f-4c3e-9142-325d831aaabe" ,
					name = "N-ZAP85",
					subId = "c6c59d90-d7bb-4da6-9dff-3e163f15a9d0" ,
					specialId = "be3c3c54-7baa-419c-8bc7-5f89176ee924"
				} ,
				new WeaponModel(){
					id = "968a4cdd-bd22-4561-bfc7-84e599275e1f" ,
					name = "プライムシューター",
					subId = "9506e4ed-dd1e-410b-a3fd-222e10b6735c" ,
					specialId = "5282d2e0-d73e-4d97-84e9-748f321271ac"
				} ,
				new WeaponModel(){
					id = "e57601ad-ee4f-42f0-bc91-adbc183f553d" ,
					name = "ボールドマーカー",
					subId = "0ede417d-fe34-4294-9cb0-8147e689e0fe" ,
					specialId = "e2a02634-983b-4dc4-8af0-392d3f84cf1a"
				} ,
				new WeaponModel(){
					id = "1c91cdcd-8b8c-4a05-b55b-765c3324f423" ,
					name = "プロモデラーRG",
					subId = "1021ca37-d02d-4f75-930a-f631f728490b" ,
					specialId = "92d4ceae-11ae-484e-91d9-ac4989da91f5"
				} ,
				new WeaponModel(){
					id = "a0dc2000-2d1a-4852-a6fc-492a4c20f8d1" ,
					name = "スプラシューター",
					subId = "b78117b7-9483-49ec-9937-701159418e09" ,
					specialId = "e2a02634-983b-4dc4-8af0-392d3f84cf1a"
				} ,
				new WeaponModel(){
					id = "cb843952-82a4-40ab-a63c-78944ca686d3" ,
					name = "ジェットスイーパーカスタム",
					subId = "b78117b7-9483-49ec-9937-701159418e09" ,
					specialId = "a97730fa-ec8a-48f7-b5a3-cbed7ece6994"
				} ,
				new WeaponModel(){
					id = "7de13a08-59d3-4110-8854-5984bfa13c7c" ,
					name = "プライムシューターコラボ",
					subId = "c6c59d90-d7bb-4da6-9dff-3e163f15a9d0" ,
					specialId = "6979c194-abb4-42c9-a0c8-86a6ca82c07d"
				} ,
				new WeaponModel(){
					id = "bcaa4774-c624-4df5-9439-1203c64ef63e" ,
					name = "もみじシューター",
					subId = "2af56965-eb45-47f2-b1f5-eb61485d4225" ,
					specialId = "5282d2e0-d73e-4d97-84e9-748f321271ac"
				} ,
				new WeaponModel(){
					id = "6fc97630-5963-4cfd-9c58-a2ab98a46b94" ,
					name = "プロモデラーMG",
					subId = "c6c59d90-d7bb-4da6-9dff-3e163f15a9d0" ,
					specialId = "01cbe269-b213-4ebf-b34b-53f602b8654c"
				} ,
				new WeaponModel(){
					id = "e386ce5a-4ac5-45f5-9bd8-e9406c6e51c2" ,
					name = ".96ガロン",
					subId = "1021ca37-d02d-4f75-930a-f631f728490b" ,
					specialId = "be3c3c54-7baa-419c-8bc7-5f89176ee924"
				} ,
				new WeaponModel(){
					id = "35c9e792-28ac-4a38-9e97-8d06b4229841" ,
					name = "ヒーローシューターレプリカ",
					subId = "b78117b7-9483-49ec-9937-701159418e09" ,
					specialId = "e2a02634-983b-4dc4-8af0-392d3f84cf1a"
				} ,
				new WeaponModel(){
					id = "1061a2e5-2e38-4c9c-bbb0-e64abf8a1f2a" ,
					name = "L3リールガン",
					subId = "0ede417d-fe34-4294-9cb0-8147e689e0fe" ,
					specialId = "92d4ceae-11ae-484e-91d9-ac4989da91f5"
				} ,
				new WeaponModel(){
					id = "8e2a47fb-9d71-46ac-a777-6fb291bcd4f1" ,
					name = "ジェットスイーパー",
					subId = "d40ccbf5-4302-468e-a713-e600e11481b2" ,
					specialId = "e1ca1813-1bf4-489f-8b61-c9796d5128eb"
				} ,
				new WeaponModel(){
					id = "0dc84f4f-4722-44cd-800f-9256138b22c8" ,
					name = "H3リールガン",
					subId = "9506e4ed-dd1e-410b-a3fd-222e10b6735c" ,
					specialId = "e1ca1813-1bf4-489f-8b61-c9796d5128eb"
				} ,
				new WeaponModel(){
					id = "edf11ab5-71b0-46a3-8241-888c0c3d5832" ,
					name = "ボトルガイザー",
					subId = "5dcec9b5-e03c-4ee5-98a2-1a66d095490f" ,
					specialId = "a97730fa-ec8a-48f7-b5a3-cbed7ece6994"
				} ,
				new WeaponModel(){
					id = "bb1f0f7d-912d-4be9-9868-862e4b33bbf5" ,
					name = "デュアルスイーパー",
					subId = "9506e4ed-dd1e-410b-a3fd-222e10b6735c" ,
					specialId = "e1ca1813-1bf4-489f-8b61-c9796d5128eb"
				} ,
				new WeaponModel(){
					id = "1f172237-aeba-487f-a5b6-572f5d28786c" ,
					name = "スプラマニューバー",
					subId = "b78117b7-9483-49ec-9937-701159418e09" ,
					specialId = "e1ca1813-1bf4-489f-8b61-c9796d5128eb"
				} ,
				new WeaponModel(){
					id = "39463610-c69e-4e91-b944-819bcbab2ed4" ,
					name = "スプラマニューバーコラボ",
					subId = "0ede417d-fe34-4294-9cb0-8147e689e0fe" ,
					specialId = "ef748149-3d8e-4ae6-8f47-32684e24c32a"
				} ,
				new WeaponModel(){
					id = "9d364db6-fa89-4c02-b0c6-b3b69341a464" ,
					name = "スパッタリー",
					subId = "33b70434-4a60-4231-86f9-44e067cd1577" ,
					specialId = "f67478c8-5b82-482d-8e91-3b1e974e9467"
				} ,
				new WeaponModel(){
					id = "8975c5fc-0c66-43d3-b18c-5451b38278ef" ,
					name = "ヒーローマニューバーレプリカ",
					subId = "b78117b7-9483-49ec-9937-701159418e09" ,
					specialId = "e1ca1813-1bf4-489f-8b61-c9796d5128eb"
				} ,
				new WeaponModel(){
					id = "25ae3af1-07b6-4a35-b8d3-5886dfe5cfc4" ,
					name = "ケルビン525",
					subId = "8ae90e7d-2ee1-4d4f-b62e-50c6efaf27ad" ,
					specialId = "ef748149-3d8e-4ae6-8f47-32684e24c32a"
				} ,
				new WeaponModel(){
					id = "1911ca77-a382-432f-b1d9-5ad2c3342869" ,
					name = "スプラスコープ",
					subId = "842e87bc-2305-4210-b9b0-a30e2910a7ee" ,
					specialId = "a97730fa-ec8a-48f7-b5a3-cbed7ece6994"
				} ,
				new WeaponModel(){
					id = "0ac0a6c6-9328-4e37-a704-ab90931c9f9c" ,
					name = "スクイックリンα",
					subId = "9506e4ed-dd1e-410b-a3fd-222e10b6735c" ,
					specialId = "be3c3c54-7baa-419c-8bc7-5f89176ee924"
				} ,
				new WeaponModel(){
					id = "7170796d-a8cc-4390-b525-a2e1d3145b6f" ,
					name = "スプラチャージャー",
					subId = "842e87bc-2305-4210-b9b0-a30e2910a7ee" ,
					specialId = "a97730fa-ec8a-48f7-b5a3-cbed7ece6994"
				} ,
				new WeaponModel(){
					id = "894615d1-6cee-42aa-8351-535f89c2823d" ,
					name = "14式竹筒銃・甲",
					subId = "0ede417d-fe34-4294-9cb0-8147e689e0fe" ,
					specialId = "e1ca1813-1bf4-489f-8b61-c9796d5128eb"
				} ,
				new WeaponModel(){
					id = "8fbc832d-87f3-4c66-b6f3-6bda9839ce61" ,
					name = "ヒーローチャージャーレプリカ",
					subId = "842e87bc-2305-4210-b9b0-a30e2910a7ee" ,
					specialId = "a97730fa-ec8a-48f7-b5a3-cbed7ece6994"
				} ,
				new WeaponModel(){
					id = "24d42696-7bdf-48d4-a8dc-4ed609480eb7" ,
					name = "ソイチューバー",
					subId = "c6c59d90-d7bb-4da6-9dff-3e163f15a9d0" ,
					specialId = "e2a02634-983b-4dc4-8af0-392d3f84cf1a"
				} ,
				new WeaponModel(){
					id = "8730a4a9-64f1-4a47-ba18-40e041800cb9" ,
					name = "スプラチャージャーコラボ",
					subId = "5dcec9b5-e03c-4ee5-98a2-1a66d095490f" ,
					specialId = "f67478c8-5b82-482d-8e91-3b1e974e9467"
				} ,
				new WeaponModel(){
					id = "c48d4eb5-c417-43c7-aae2-60ec7ddf6e06" ,
					name = "スプラスコープコラボ",
					subId = "5dcec9b5-e03c-4ee5-98a2-1a66d095490f" ,
					specialId = "f67478c8-5b82-482d-8e91-3b1e974e9467"
				} ,
				new WeaponModel(){
					id = "fe443371-185e-4a4b-b139-f47cb47d19dc" ,
					name = "リッター4K",
					subId = "8ae90e7d-2ee1-4d4f-b62e-50c6efaf27ad" ,
					specialId = "5282d2e0-d73e-4d97-84e9-748f321271ac"
				} ,
				new WeaponModel(){
					id = "09886abb-3672-4738-82aa-de84d50add4a" ,
					name = "4Kスコープ",
					subId = "8ae90e7d-2ee1-4d4f-b62e-50c6efaf27ad" ,
					specialId = "5282d2e0-d73e-4d97-84e9-748f321271ac"
				} ,
				new WeaponModel(){
					id = "0c376461-0a04-4397-9dd1-4251b4bcce7c" ,
					name = "リッター4Kカスタム",
					subId = "33b70434-4a60-4231-86f9-44e067cd1577" ,
					specialId = "6979c194-abb4-42c9-a0c8-86a6ca82c07d"
				} ,
				new WeaponModel(){
					id = "16614358-ccd9-488c-9be7-022bbf06d2b4" ,
					name = "4Kスコープカスタム",
					subId = "33b70434-4a60-4231-86f9-44e067cd1577" ,
					specialId = "6979c194-abb4-42c9-a0c8-86a6ca82c07d"
				} ,
				new WeaponModel(){
					id = "c8c3a6cd-d912-4d39-ac44-317b7aee0a6c" ,
					name = "ホットブラスターカスタム",
					subId = "2af56965-eb45-47f2-b1f5-eb61485d4225" ,
					specialId = "ef748149-3d8e-4ae6-8f47-32684e24c32a"
				} ,
				new WeaponModel(){
					id = "71590c17-b6bb-4827-be7b-02a7bb28f726" ,
					name = "ノヴァブラスター",
					subId = "842e87bc-2305-4210-b9b0-a30e2910a7ee" ,
					specialId = "92d4ceae-11ae-484e-91d9-ac4989da91f5"
				} ,
				new WeaponModel(){
					id = "08802a03-27b2-4d11-a851-1a30737656fa" ,
					name = "ラピッドブラスター",
					subId = "8ae90e7d-2ee1-4d4f-b62e-50c6efaf27ad" ,
					specialId = "92fb5934-4c68-4da6-ae9b-6cbb9385ea6d"
				} ,
				new WeaponModel(){
					id = "6763dd5b-8334-4107-894b-1a6e88645d0c" ,
					name = "ホットブラスター",
					subId = "d40ccbf5-4302-468e-a713-e600e11481b2" ,
					specialId = "e2a02634-983b-4dc4-8af0-392d3f84cf1a"
				} ,
				new WeaponModel(){
					id = "18d5defa-3d2d-49a6-9722-f62980688e9c" ,
					name = "Rブラスターエリート",
					subId = "d40ccbf5-4302-468e-a713-e600e11481b2" ,
					specialId = "5282d2e0-d73e-4d97-84e9-748f321271ac"
				} ,
				new WeaponModel(){
					id = "d9c5ab43-55ee-4dc1-8f52-95e51ddb91bb" ,
					name = "ロングブラスター",
					subId = "c6c59d90-d7bb-4da6-9dff-3e163f15a9d0" ,
					specialId = "5282d2e0-d73e-4d97-84e9-748f321271ac"
				} ,
				new WeaponModel(){
					id = "28b201aa-ba55-49b8-a818-d5a77b1dfa95" ,
					name = "クラッシュブラスター",
					subId = "842e87bc-2305-4210-b9b0-a30e2910a7ee" ,
					specialId = "a97730fa-ec8a-48f7-b5a3-cbed7ece6994"
				} ,
				new WeaponModel(){
					id = "61e6a8c2-8883-4778-8120-4aff685d06dd" ,
					name = "ヒーローブラスターレプリカ",
					subId = "d40ccbf5-4302-468e-a713-e600e11481b2" ,
					specialId = "e2a02634-983b-4dc4-8af0-392d3f84cf1a"
				} ,
				new WeaponModel(){
					id = "aec329eb-10f4-4c33-b6dd-90ee2bb026fb" ,
					name = "ダイナモローラー",
					subId = "8ae90e7d-2ee1-4d4f-b62e-50c6efaf27ad" ,
					specialId = "a97730fa-ec8a-48f7-b5a3-cbed7ece6994"
				} ,
				new WeaponModel(){
					id = "3611a1dd-617f-4048-8cb8-29e2d50cb203" ,
					name = "スプラローラーコラボ",
					subId = "33b70434-4a60-4231-86f9-44e067cd1577" ,
					specialId = "92d4ceae-11ae-484e-91d9-ac4989da91f5"
				} ,
				new WeaponModel(){
					id = "e827ca7c-124b-4f64-81fa-1b0d03b90923" ,
					name = "カーボンローラー",
					subId = "2af56965-eb45-47f2-b1f5-eb61485d4225" ,
					specialId = "5282d2e0-d73e-4d97-84e9-748f321271ac"
				} ,
				new WeaponModel(){
					id = "08ec9a89-610e-4d8d-b83e-4c297ae03b46" ,
					name = "ダイナモローラーテスラ",
					subId = "842e87bc-2305-4210-b9b0-a30e2910a7ee" ,
					specialId = "be3c3c54-7baa-419c-8bc7-5f89176ee924"
				} ,
				new WeaponModel(){
					id = "d4f7f96c-9a4d-4f9f-9d97-4c9d36b48ce7" ,
					name = "スプラローラー",
					subId = "0ede417d-fe34-4294-9cb0-8147e689e0fe" ,
					specialId = "e2a02634-983b-4dc4-8af0-392d3f84cf1a"
				} ,
				new WeaponModel(){
					id = "eebca5fd-4f5a-4b7f-9d6f-afa210156dce" ,
					name = "ヒーローローラーレプリカ",
					subId = "0ede417d-fe34-4294-9cb0-8147e689e0fe" ,
					specialId = "e2a02634-983b-4dc4-8af0-392d3f84cf1a"
				} ,
				new WeaponModel(){
					id = "fea59fd3-0ab5-4efa-ae31-91c8401c140a" ,
					name = "ヴァリアブルローラー",
					subId = "5dcec9b5-e03c-4ee5-98a2-1a66d095490f" ,
					specialId = "92fb5934-4c68-4da6-ae9b-6cbb9385ea6d"
				} ,
				new WeaponModel(){
					id = "06484277-3a44-4c6b-ab71-e37810f49b78" ,
					name = "ヴァリアブルローラーフォイル",
					subId = "c6c59d90-d7bb-4da6-9dff-3e163f15a9d0" ,
					specialId = "e1ca1813-1bf4-489f-8b61-c9796d5128eb"
				} ,
				new WeaponModel(){
					id = "0677ff70-6b0d-4469-9079-f9cd23aaa824" ,
					name = "ホクサイ",
					subId = "2af56965-eb45-47f2-b1f5-eb61485d4225" ,
					specialId = "ef748149-3d8e-4ae6-8f47-32684e24c32a"
				} ,
				new WeaponModel(){
					id = "7df02db4-5983-4ffd-8ab6-07842a2fb9a6" ,
					name = "パブロ",
					subId = "842e87bc-2305-4210-b9b0-a30e2910a7ee" ,
					specialId = "e2a02634-983b-4dc4-8af0-392d3f84cf1a"
				} ,
				new WeaponModel(){
					id = "cc7def3d-2cee-4316-8d67-a624fc280be7" ,
					name = "パブロ・ヒュー",
					subId = "8ae90e7d-2ee1-4d4f-b62e-50c6efaf27ad" ,
					specialId = "92d4ceae-11ae-484e-91d9-ac4989da91f5"
				} ,
				new WeaponModel(){
					id = "d71ece2b-33f2-4a31-8c1e-305870e7d536" ,
					name = "ヒーローブラシレプリカ",
					subId = "2af56965-eb45-47f2-b1f5-eb61485d4225" ,
					specialId = "ef748149-3d8e-4ae6-8f47-32684e24c32a"
				} ,
				new WeaponModel(){
					id = "ebf147e6-9009-4639-b89b-29d18666042c" ,
					name = "バケットスロッシャー",
					subId = "c6c59d90-d7bb-4da6-9dff-3e163f15a9d0" ,
					specialId = "e1ca1813-1bf4-489f-8b61-c9796d5128eb"
				} ,
				new WeaponModel(){
					id = "9ebe588b-83bb-437e-8616-e2565bd176e3" ,
					name = "ヒッセン",
					subId = "b78117b7-9483-49ec-9937-701159418e09" ,
					specialId = "be3c3c54-7baa-419c-8bc7-5f89176ee924"
				} ,
				new WeaponModel(){
					id = "990df177-5ce6-4ee6-a47a-038399f67fef" ,
					name = "スクリュースロッシャー",
					subId = "2af56965-eb45-47f2-b1f5-eb61485d4225" ,
					specialId = "a97730fa-ec8a-48f7-b5a3-cbed7ece6994"
				} ,
				new WeaponModel(){
					id = "99977c38-0556-4034-b131-abbfe03b0f22" ,
					name = "バケットスロッシャーデコ",
					subId = "1021ca37-d02d-4f75-930a-f631f728490b" ,
					specialId = "92d4ceae-11ae-484e-91d9-ac4989da91f5"
				} ,
				new WeaponModel(){
					id = "7250edb7-ed19-4a43-bbdc-f356d5448285" ,
					name = "ヒーロースロッシャーレプリカ",
					subId = "c6c59d90-d7bb-4da6-9dff-3e163f15a9d0" ,
					specialId = "e1ca1813-1bf4-489f-8b61-c9796d5128eb"
				} ,
				new WeaponModel(){
					id = "2123f247-131e-439a-891e-fe4b2337dc08" ,
					name = "バレルスピナーデコ",
					subId = "5dcec9b5-e03c-4ee5-98a2-1a66d095490f" ,
					specialId = "6979c194-abb4-42c9-a0c8-86a6ca82c07d"
				} ,
				new WeaponModel(){
					id = "1d49188a-5710-48c1-bff2-5e91c54789e3" ,
					name = "バレルスピナー",
					subId = "1021ca37-d02d-4f75-930a-f631f728490b" ,
					specialId = "a97730fa-ec8a-48f7-b5a3-cbed7ece6994"
				} ,
				new WeaponModel(){
					id = "d1c8a93d-cea3-4dd1-a79a-7ea55ce0a30e" ,
					name = "スプラスピナー",
					subId = "b78117b7-9483-49ec-9937-701159418e09" ,
					specialId = "e1ca1813-1bf4-489f-8b61-c9796d5128eb"
				} ,
				new WeaponModel(){
					id = "80c8a7d4-bc2c-4eba-84ba-75bb2c66a7aa" ,
					name = "ヒーロースピナーレプリカ",
					subId = "1021ca37-d02d-4f75-930a-f631f728490b" ,
					specialId = "a97730fa-ec8a-48f7-b5a3-cbed7ece6994"
				} ,
				new WeaponModel() {
					id = "c6d80f26-0d20-4d62-8157-abfd5b80ee82" ,
					name = "ハイドラント" ,
					subId = "2af56965-eb45-47f2-b1f5-eb61485d4225" ,
					specialId = "e2a02634-983b-4dc4-8af0-392d3f84cf1a" ,
				} ,
				new WeaponModel(){
					id = "5d7cfecd-c39a-455f-b0df-4352cf6bf1d0" ,
					name = "パラシェルター",
					subId = "1021ca37-d02d-4f75-930a-f631f728490b" ,
					specialId = "5282d2e0-d73e-4d97-84e9-748f321271ac"
				} ,
				new WeaponModel(){
					id = "7a3c6d3f-852a-4725-b242-e626b479a9db" ,
					name = "ヒーローシェルターレプリカ",
					subId = "1021ca37-d02d-4f75-930a-f631f728490b" ,
					specialId = "5282d2e0-d73e-4d97-84e9-748f321271ac"
				} ,
				new WeaponModel(){
					id = "30c3e333-68fc-4ce7-9f87-5013791ae89f" ,
					name = "キャンピングシェルター",
					subId = "33b70434-4a60-4231-86f9-44e067cd1577" ,
					specialId = "6979c194-abb4-42c9-a0c8-86a6ca82c07d"
				} ,
				new WeaponModel(){
					id = "2c99affe-0e02-4b6d-bfef-19249daa5ceb" ,
					name = "スパイガジェット",
					subId = "8ae90e7d-2ee1-4d4f-b62e-50c6efaf27ad" ,
					specialId = "e2a02634-983b-4dc4-8af0-392d3f84cf1a"
				}
			};

			foreach( WeaponModel weapon in this.weapons ) {
				weapon.subWeapon = this.GetSubWeapon( weapon.subId );
				weapon.specialWeapon = this.GetSpecialWeapon( weapon.specialId );
			}

			#endregion

			#region ユーザ一覧
			this.users = new List<UserModel>() {
				new UserModel() {
					id = "7733aef7-2811-4e7f-95c5-7213e4760a31" ,
					name = "シャス"
				} ,
				new UserModel() {
					id = "9415c640-640d-47a8-a3f5-817cacdb15c7" ,
					name = "とつ"
				} ,
				new UserModel() {
					id = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" ,
					name = "たなか"
				} ,
				new UserModel() {
					id = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" ,
					name = "した"
				} ,
				new UserModel() {
					id = "366030b9-f148-46b2-9d92-54317d17e664" ,
					name = "みた"
				}
			};
			#endregion

			#region 所持武器一覧
			this.havingWeapons = new List<HavingWeaponModel>() {
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "6bccc950-e670-44e0-be3d-27658af0f754" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "4537d4a2-3828-4ad0-af62-f6e40105acf3" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "46cc2f24-4f59-4f9d-b1fa-9febe86b42ab" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "970d8873-302f-4aba-80b4-14d932161c0c" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "0cbc2688-a459-4e43-b859-4879a86a9d6c" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "d6d0fdd8-968f-4c3e-9142-325d831aaabe" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "968a4cdd-bd22-4561-bfc7-84e599275e1f" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "e57601ad-ee4f-42f0-bc91-adbc183f553d" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "1c91cdcd-8b8c-4a05-b55b-765c3324f423" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "a0dc2000-2d1a-4852-a6fc-492a4c20f8d1" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "cb843952-82a4-40ab-a63c-78944ca686d3" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "7de13a08-59d3-4110-8854-5984bfa13c7c" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "bcaa4774-c624-4df5-9439-1203c64ef63e" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "6fc97630-5963-4cfd-9c58-a2ab98a46b94" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "e386ce5a-4ac5-45f5-9bd8-e9406c6e51c2" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "35c9e792-28ac-4a38-9e97-8d06b4229841" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "1061a2e5-2e38-4c9c-bbb0-e64abf8a1f2a" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "8e2a47fb-9d71-46ac-a777-6fb291bcd4f1" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "0dc84f4f-4722-44cd-800f-9256138b22c8" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "edf11ab5-71b0-46a3-8241-888c0c3d5832" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "bb1f0f7d-912d-4be9-9868-862e4b33bbf5" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "1f172237-aeba-487f-a5b6-572f5d28786c" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "39463610-c69e-4e91-b944-819bcbab2ed4" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "9d364db6-fa89-4c02-b0c6-b3b69341a464" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "8975c5fc-0c66-43d3-b18c-5451b38278ef" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "25ae3af1-07b6-4a35-b8d3-5886dfe5cfc4" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "1911ca77-a382-432f-b1d9-5ad2c3342869" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "0ac0a6c6-9328-4e37-a704-ab90931c9f9c" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "7170796d-a8cc-4390-b525-a2e1d3145b6f" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "894615d1-6cee-42aa-8351-535f89c2823d" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "8fbc832d-87f3-4c66-b6f3-6bda9839ce61" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "24d42696-7bdf-48d4-a8dc-4ed609480eb7" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "8730a4a9-64f1-4a47-ba18-40e041800cb9" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "c48d4eb5-c417-43c7-aae2-60ec7ddf6e06" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "fe443371-185e-4a4b-b139-f47cb47d19dc" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "09886abb-3672-4738-82aa-de84d50add4a" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "0c376461-0a04-4397-9dd1-4251b4bcce7c" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "16614358-ccd9-488c-9be7-022bbf06d2b4" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "c8c3a6cd-d912-4d39-ac44-317b7aee0a6c" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "71590c17-b6bb-4827-be7b-02a7bb28f726" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "08802a03-27b2-4d11-a851-1a30737656fa" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "6763dd5b-8334-4107-894b-1a6e88645d0c" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "18d5defa-3d2d-49a6-9722-f62980688e9c" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "d9c5ab43-55ee-4dc1-8f52-95e51ddb91bb" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "28b201aa-ba55-49b8-a818-d5a77b1dfa95" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "61e6a8c2-8883-4778-8120-4aff685d06dd" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "aec329eb-10f4-4c33-b6dd-90ee2bb026fb" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "3611a1dd-617f-4048-8cb8-29e2d50cb203" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "e827ca7c-124b-4f64-81fa-1b0d03b90923" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "08ec9a89-610e-4d8d-b83e-4c297ae03b46" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "d4f7f96c-9a4d-4f9f-9d97-4c9d36b48ce7" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "eebca5fd-4f5a-4b7f-9d6f-afa210156dce" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "fea59fd3-0ab5-4efa-ae31-91c8401c140a" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "06484277-3a44-4c6b-ab71-e37810f49b78" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "0677ff70-6b0d-4469-9079-f9cd23aaa824" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "7df02db4-5983-4ffd-8ab6-07842a2fb9a6" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "cc7def3d-2cee-4316-8d67-a624fc280be7" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "d71ece2b-33f2-4a31-8c1e-305870e7d536" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "ebf147e6-9009-4639-b89b-29d18666042c" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "9ebe588b-83bb-437e-8616-e2565bd176e3" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "990df177-5ce6-4ee6-a47a-038399f67fef" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "99977c38-0556-4034-b131-abbfe03b0f22" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "7250edb7-ed19-4a43-bbdc-f356d5448285" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "2123f247-131e-439a-891e-fe4b2337dc08" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "1d49188a-5710-48c1-bff2-5e91c54789e3" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "d1c8a93d-cea3-4dd1-a79a-7ea55ce0a30e" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "80c8a7d4-bc2c-4eba-84ba-75bb2c66a7aa" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "c6d80f26-0d20-4d62-8157-abfd5b80ee82" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "5d7cfecd-c39a-455f-b0df-4352cf6bf1d0" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "7a3c6d3f-852a-4725-b242-e626b479a9db" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "30c3e333-68fc-4ce7-9f87-5013791ae89f" } ,
				new HavingWeaponModel(){ userId = "7733aef7-2811-4e7f-95c5-7213e4760a31" , weaponId = "2c99affe-0e02-4b6d-bfef-19249daa5ceb" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "6bccc950-e670-44e0-be3d-27658af0f754" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "4537d4a2-3828-4ad0-af62-f6e40105acf3" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "46cc2f24-4f59-4f9d-b1fa-9febe86b42ab" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "970d8873-302f-4aba-80b4-14d932161c0c" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "0cbc2688-a459-4e43-b859-4879a86a9d6c" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "d6d0fdd8-968f-4c3e-9142-325d831aaabe" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "968a4cdd-bd22-4561-bfc7-84e599275e1f" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "e57601ad-ee4f-42f0-bc91-adbc183f553d" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "1c91cdcd-8b8c-4a05-b55b-765c3324f423" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "a0dc2000-2d1a-4852-a6fc-492a4c20f8d1" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "cb843952-82a4-40ab-a63c-78944ca686d3" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "7de13a08-59d3-4110-8854-5984bfa13c7c" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "bcaa4774-c624-4df5-9439-1203c64ef63e" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "6fc97630-5963-4cfd-9c58-a2ab98a46b94" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "e386ce5a-4ac5-45f5-9bd8-e9406c6e51c2" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "35c9e792-28ac-4a38-9e97-8d06b4229841" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "1061a2e5-2e38-4c9c-bbb0-e64abf8a1f2a" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "8e2a47fb-9d71-46ac-a777-6fb291bcd4f1" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "0dc84f4f-4722-44cd-800f-9256138b22c8" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "edf11ab5-71b0-46a3-8241-888c0c3d5832" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "bb1f0f7d-912d-4be9-9868-862e4b33bbf5" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "1f172237-aeba-487f-a5b6-572f5d28786c" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "39463610-c69e-4e91-b944-819bcbab2ed4" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "9d364db6-fa89-4c02-b0c6-b3b69341a464" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "8975c5fc-0c66-43d3-b18c-5451b38278ef" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "25ae3af1-07b6-4a35-b8d3-5886dfe5cfc4" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "1911ca77-a382-432f-b1d9-5ad2c3342869" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "0ac0a6c6-9328-4e37-a704-ab90931c9f9c" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "7170796d-a8cc-4390-b525-a2e1d3145b6f" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "894615d1-6cee-42aa-8351-535f89c2823d" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "8fbc832d-87f3-4c66-b6f3-6bda9839ce61" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "24d42696-7bdf-48d4-a8dc-4ed609480eb7" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "8730a4a9-64f1-4a47-ba18-40e041800cb9" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "c48d4eb5-c417-43c7-aae2-60ec7ddf6e06" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "fe443371-185e-4a4b-b139-f47cb47d19dc" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "09886abb-3672-4738-82aa-de84d50add4a" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "0c376461-0a04-4397-9dd1-4251b4bcce7c" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "16614358-ccd9-488c-9be7-022bbf06d2b4" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "c8c3a6cd-d912-4d39-ac44-317b7aee0a6c" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "71590c17-b6bb-4827-be7b-02a7bb28f726" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "08802a03-27b2-4d11-a851-1a30737656fa" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "6763dd5b-8334-4107-894b-1a6e88645d0c" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "18d5defa-3d2d-49a6-9722-f62980688e9c" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "d9c5ab43-55ee-4dc1-8f52-95e51ddb91bb" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "28b201aa-ba55-49b8-a818-d5a77b1dfa95" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "61e6a8c2-8883-4778-8120-4aff685d06dd" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "aec329eb-10f4-4c33-b6dd-90ee2bb026fb" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "3611a1dd-617f-4048-8cb8-29e2d50cb203" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "e827ca7c-124b-4f64-81fa-1b0d03b90923" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "08ec9a89-610e-4d8d-b83e-4c297ae03b46" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "d4f7f96c-9a4d-4f9f-9d97-4c9d36b48ce7" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "eebca5fd-4f5a-4b7f-9d6f-afa210156dce" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "fea59fd3-0ab5-4efa-ae31-91c8401c140a" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "06484277-3a44-4c6b-ab71-e37810f49b78" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "0677ff70-6b0d-4469-9079-f9cd23aaa824" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "7df02db4-5983-4ffd-8ab6-07842a2fb9a6" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "cc7def3d-2cee-4316-8d67-a624fc280be7" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "d71ece2b-33f2-4a31-8c1e-305870e7d536" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "ebf147e6-9009-4639-b89b-29d18666042c" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "9ebe588b-83bb-437e-8616-e2565bd176e3" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "990df177-5ce6-4ee6-a47a-038399f67fef" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "99977c38-0556-4034-b131-abbfe03b0f22" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "7250edb7-ed19-4a43-bbdc-f356d5448285" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "2123f247-131e-439a-891e-fe4b2337dc08" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "1d49188a-5710-48c1-bff2-5e91c54789e3" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "d1c8a93d-cea3-4dd1-a79a-7ea55ce0a30e" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "80c8a7d4-bc2c-4eba-84ba-75bb2c66a7aa" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "c6d80f26-0d20-4d62-8157-abfd5b80ee82" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "5d7cfecd-c39a-455f-b0df-4352cf6bf1d0" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "7a3c6d3f-852a-4725-b242-e626b479a9db" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "30c3e333-68fc-4ce7-9f87-5013791ae89f" } ,
				new HavingWeaponModel(){ userId = "9415c640-640d-47a8-a3f5-817cacdb15c7" , weaponId = "2c99affe-0e02-4b6d-bfef-19249daa5ceb" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "6bccc950-e670-44e0-be3d-27658af0f754" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "4537d4a2-3828-4ad0-af62-f6e40105acf3" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "46cc2f24-4f59-4f9d-b1fa-9febe86b42ab" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "970d8873-302f-4aba-80b4-14d932161c0c" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "0cbc2688-a459-4e43-b859-4879a86a9d6c" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "d6d0fdd8-968f-4c3e-9142-325d831aaabe" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "968a4cdd-bd22-4561-bfc7-84e599275e1f" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "e57601ad-ee4f-42f0-bc91-adbc183f553d" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "1c91cdcd-8b8c-4a05-b55b-765c3324f423" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "a0dc2000-2d1a-4852-a6fc-492a4c20f8d1" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "cb843952-82a4-40ab-a63c-78944ca686d3" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "7de13a08-59d3-4110-8854-5984bfa13c7c" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "bcaa4774-c624-4df5-9439-1203c64ef63e" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "6fc97630-5963-4cfd-9c58-a2ab98a46b94" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "e386ce5a-4ac5-45f5-9bd8-e9406c6e51c2" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "35c9e792-28ac-4a38-9e97-8d06b4229841" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "1061a2e5-2e38-4c9c-bbb0-e64abf8a1f2a" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "8e2a47fb-9d71-46ac-a777-6fb291bcd4f1" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "0dc84f4f-4722-44cd-800f-9256138b22c8" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "edf11ab5-71b0-46a3-8241-888c0c3d5832" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "bb1f0f7d-912d-4be9-9868-862e4b33bbf5" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "1f172237-aeba-487f-a5b6-572f5d28786c" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "39463610-c69e-4e91-b944-819bcbab2ed4" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "9d364db6-fa89-4c02-b0c6-b3b69341a464" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "8975c5fc-0c66-43d3-b18c-5451b38278ef" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "25ae3af1-07b6-4a35-b8d3-5886dfe5cfc4" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "1911ca77-a382-432f-b1d9-5ad2c3342869" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "0ac0a6c6-9328-4e37-a704-ab90931c9f9c" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "7170796d-a8cc-4390-b525-a2e1d3145b6f" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "894615d1-6cee-42aa-8351-535f89c2823d" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "8fbc832d-87f3-4c66-b6f3-6bda9839ce61" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "24d42696-7bdf-48d4-a8dc-4ed609480eb7" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "8730a4a9-64f1-4a47-ba18-40e041800cb9" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "c48d4eb5-c417-43c7-aae2-60ec7ddf6e06" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "fe443371-185e-4a4b-b139-f47cb47d19dc" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "09886abb-3672-4738-82aa-de84d50add4a" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "0c376461-0a04-4397-9dd1-4251b4bcce7c" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "16614358-ccd9-488c-9be7-022bbf06d2b4" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "c8c3a6cd-d912-4d39-ac44-317b7aee0a6c" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "71590c17-b6bb-4827-be7b-02a7bb28f726" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "08802a03-27b2-4d11-a851-1a30737656fa" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "6763dd5b-8334-4107-894b-1a6e88645d0c" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "18d5defa-3d2d-49a6-9722-f62980688e9c" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "d9c5ab43-55ee-4dc1-8f52-95e51ddb91bb" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "28b201aa-ba55-49b8-a818-d5a77b1dfa95" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "61e6a8c2-8883-4778-8120-4aff685d06dd" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "aec329eb-10f4-4c33-b6dd-90ee2bb026fb" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "3611a1dd-617f-4048-8cb8-29e2d50cb203" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "e827ca7c-124b-4f64-81fa-1b0d03b90923" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "08ec9a89-610e-4d8d-b83e-4c297ae03b46" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "d4f7f96c-9a4d-4f9f-9d97-4c9d36b48ce7" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "eebca5fd-4f5a-4b7f-9d6f-afa210156dce" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "fea59fd3-0ab5-4efa-ae31-91c8401c140a" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "06484277-3a44-4c6b-ab71-e37810f49b78" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "0677ff70-6b0d-4469-9079-f9cd23aaa824" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "7df02db4-5983-4ffd-8ab6-07842a2fb9a6" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "cc7def3d-2cee-4316-8d67-a624fc280be7" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "d71ece2b-33f2-4a31-8c1e-305870e7d536" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "ebf147e6-9009-4639-b89b-29d18666042c" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "9ebe588b-83bb-437e-8616-e2565bd176e3" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "990df177-5ce6-4ee6-a47a-038399f67fef" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "99977c38-0556-4034-b131-abbfe03b0f22" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "7250edb7-ed19-4a43-bbdc-f356d5448285" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "2123f247-131e-439a-891e-fe4b2337dc08" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "1d49188a-5710-48c1-bff2-5e91c54789e3" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "d1c8a93d-cea3-4dd1-a79a-7ea55ce0a30e" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "80c8a7d4-bc2c-4eba-84ba-75bb2c66a7aa" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "c6d80f26-0d20-4d62-8157-abfd5b80ee82" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "5d7cfecd-c39a-455f-b0df-4352cf6bf1d0" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "7a3c6d3f-852a-4725-b242-e626b479a9db" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "30c3e333-68fc-4ce7-9f87-5013791ae89f" } ,
				new HavingWeaponModel(){ userId = "63b85169-0557-4b71-bad1-7f6e0ce9e6fd" , weaponId = "2c99affe-0e02-4b6d-bfef-19249daa5ceb" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "6bccc950-e670-44e0-be3d-27658af0f754" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "4537d4a2-3828-4ad0-af62-f6e40105acf3" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "46cc2f24-4f59-4f9d-b1fa-9febe86b42ab" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "970d8873-302f-4aba-80b4-14d932161c0c" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "0cbc2688-a459-4e43-b859-4879a86a9d6c" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "d6d0fdd8-968f-4c3e-9142-325d831aaabe" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "968a4cdd-bd22-4561-bfc7-84e599275e1f" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "e57601ad-ee4f-42f0-bc91-adbc183f553d" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "1c91cdcd-8b8c-4a05-b55b-765c3324f423" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "a0dc2000-2d1a-4852-a6fc-492a4c20f8d1" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "cb843952-82a4-40ab-a63c-78944ca686d3" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "7de13a08-59d3-4110-8854-5984bfa13c7c" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "bcaa4774-c624-4df5-9439-1203c64ef63e" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "6fc97630-5963-4cfd-9c58-a2ab98a46b94" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "e386ce5a-4ac5-45f5-9bd8-e9406c6e51c2" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "35c9e792-28ac-4a38-9e97-8d06b4229841" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "1061a2e5-2e38-4c9c-bbb0-e64abf8a1f2a" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "8e2a47fb-9d71-46ac-a777-6fb291bcd4f1" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "0dc84f4f-4722-44cd-800f-9256138b22c8" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "edf11ab5-71b0-46a3-8241-888c0c3d5832" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "bb1f0f7d-912d-4be9-9868-862e4b33bbf5" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "1f172237-aeba-487f-a5b6-572f5d28786c" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "39463610-c69e-4e91-b944-819bcbab2ed4" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "9d364db6-fa89-4c02-b0c6-b3b69341a464" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "8975c5fc-0c66-43d3-b18c-5451b38278ef" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "25ae3af1-07b6-4a35-b8d3-5886dfe5cfc4" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "1911ca77-a382-432f-b1d9-5ad2c3342869" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "0ac0a6c6-9328-4e37-a704-ab90931c9f9c" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "7170796d-a8cc-4390-b525-a2e1d3145b6f" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "894615d1-6cee-42aa-8351-535f89c2823d" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "8fbc832d-87f3-4c66-b6f3-6bda9839ce61" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "24d42696-7bdf-48d4-a8dc-4ed609480eb7" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "8730a4a9-64f1-4a47-ba18-40e041800cb9" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "c48d4eb5-c417-43c7-aae2-60ec7ddf6e06" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "fe443371-185e-4a4b-b139-f47cb47d19dc" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "09886abb-3672-4738-82aa-de84d50add4a" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "0c376461-0a04-4397-9dd1-4251b4bcce7c" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "16614358-ccd9-488c-9be7-022bbf06d2b4" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "c8c3a6cd-d912-4d39-ac44-317b7aee0a6c" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "71590c17-b6bb-4827-be7b-02a7bb28f726" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "08802a03-27b2-4d11-a851-1a30737656fa" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "6763dd5b-8334-4107-894b-1a6e88645d0c" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "18d5defa-3d2d-49a6-9722-f62980688e9c" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "d9c5ab43-55ee-4dc1-8f52-95e51ddb91bb" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "28b201aa-ba55-49b8-a818-d5a77b1dfa95" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "61e6a8c2-8883-4778-8120-4aff685d06dd" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "aec329eb-10f4-4c33-b6dd-90ee2bb026fb" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "3611a1dd-617f-4048-8cb8-29e2d50cb203" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "e827ca7c-124b-4f64-81fa-1b0d03b90923" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "08ec9a89-610e-4d8d-b83e-4c297ae03b46" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "d4f7f96c-9a4d-4f9f-9d97-4c9d36b48ce7" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "eebca5fd-4f5a-4b7f-9d6f-afa210156dce" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "fea59fd3-0ab5-4efa-ae31-91c8401c140a" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "06484277-3a44-4c6b-ab71-e37810f49b78" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "0677ff70-6b0d-4469-9079-f9cd23aaa824" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "7df02db4-5983-4ffd-8ab6-07842a2fb9a6" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "cc7def3d-2cee-4316-8d67-a624fc280be7" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "d71ece2b-33f2-4a31-8c1e-305870e7d536" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "ebf147e6-9009-4639-b89b-29d18666042c" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "9ebe588b-83bb-437e-8616-e2565bd176e3" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "990df177-5ce6-4ee6-a47a-038399f67fef" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "99977c38-0556-4034-b131-abbfe03b0f22" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "7250edb7-ed19-4a43-bbdc-f356d5448285" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "2123f247-131e-439a-891e-fe4b2337dc08" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "1d49188a-5710-48c1-bff2-5e91c54789e3" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "d1c8a93d-cea3-4dd1-a79a-7ea55ce0a30e" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "80c8a7d4-bc2c-4eba-84ba-75bb2c66a7aa" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "c6d80f26-0d20-4d62-8157-abfd5b80ee82" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "5d7cfecd-c39a-455f-b0df-4352cf6bf1d0" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "7a3c6d3f-852a-4725-b242-e626b479a9db" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "30c3e333-68fc-4ce7-9f87-5013791ae89f" } ,
				new HavingWeaponModel(){ userId = "e2f83cd9-43ab-4aa9-9216-a6ce2a6a6bb5" , weaponId = "2c99affe-0e02-4b6d-bfef-19249daa5ceb" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "6bccc950-e670-44e0-be3d-27658af0f754" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "4537d4a2-3828-4ad0-af62-f6e40105acf3" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "46cc2f24-4f59-4f9d-b1fa-9febe86b42ab" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "970d8873-302f-4aba-80b4-14d932161c0c" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "0cbc2688-a459-4e43-b859-4879a86a9d6c" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "d6d0fdd8-968f-4c3e-9142-325d831aaabe" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "968a4cdd-bd22-4561-bfc7-84e599275e1f" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "e57601ad-ee4f-42f0-bc91-adbc183f553d" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "1c91cdcd-8b8c-4a05-b55b-765c3324f423" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "a0dc2000-2d1a-4852-a6fc-492a4c20f8d1" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "cb843952-82a4-40ab-a63c-78944ca686d3" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "7de13a08-59d3-4110-8854-5984bfa13c7c" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "bcaa4774-c624-4df5-9439-1203c64ef63e" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "6fc97630-5963-4cfd-9c58-a2ab98a46b94" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "e386ce5a-4ac5-45f5-9bd8-e9406c6e51c2" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "35c9e792-28ac-4a38-9e97-8d06b4229841" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "1061a2e5-2e38-4c9c-bbb0-e64abf8a1f2a" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "8e2a47fb-9d71-46ac-a777-6fb291bcd4f1" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "0dc84f4f-4722-44cd-800f-9256138b22c8" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "edf11ab5-71b0-46a3-8241-888c0c3d5832" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "bb1f0f7d-912d-4be9-9868-862e4b33bbf5" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "1f172237-aeba-487f-a5b6-572f5d28786c" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "39463610-c69e-4e91-b944-819bcbab2ed4" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "9d364db6-fa89-4c02-b0c6-b3b69341a464" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "8975c5fc-0c66-43d3-b18c-5451b38278ef" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "25ae3af1-07b6-4a35-b8d3-5886dfe5cfc4" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "1911ca77-a382-432f-b1d9-5ad2c3342869" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "0ac0a6c6-9328-4e37-a704-ab90931c9f9c" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "7170796d-a8cc-4390-b525-a2e1d3145b6f" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "894615d1-6cee-42aa-8351-535f89c2823d" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "8fbc832d-87f3-4c66-b6f3-6bda9839ce61" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "24d42696-7bdf-48d4-a8dc-4ed609480eb7" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "8730a4a9-64f1-4a47-ba18-40e041800cb9" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "c48d4eb5-c417-43c7-aae2-60ec7ddf6e06" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "fe443371-185e-4a4b-b139-f47cb47d19dc" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "09886abb-3672-4738-82aa-de84d50add4a" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "0c376461-0a04-4397-9dd1-4251b4bcce7c" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "16614358-ccd9-488c-9be7-022bbf06d2b4" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "c8c3a6cd-d912-4d39-ac44-317b7aee0a6c" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "71590c17-b6bb-4827-be7b-02a7bb28f726" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "08802a03-27b2-4d11-a851-1a30737656fa" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "6763dd5b-8334-4107-894b-1a6e88645d0c" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "18d5defa-3d2d-49a6-9722-f62980688e9c" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "d9c5ab43-55ee-4dc1-8f52-95e51ddb91bb" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "28b201aa-ba55-49b8-a818-d5a77b1dfa95" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "61e6a8c2-8883-4778-8120-4aff685d06dd" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "aec329eb-10f4-4c33-b6dd-90ee2bb026fb" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "3611a1dd-617f-4048-8cb8-29e2d50cb203" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "e827ca7c-124b-4f64-81fa-1b0d03b90923" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "08ec9a89-610e-4d8d-b83e-4c297ae03b46" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "d4f7f96c-9a4d-4f9f-9d97-4c9d36b48ce7" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "eebca5fd-4f5a-4b7f-9d6f-afa210156dce" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "fea59fd3-0ab5-4efa-ae31-91c8401c140a" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "06484277-3a44-4c6b-ab71-e37810f49b78" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "0677ff70-6b0d-4469-9079-f9cd23aaa824" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "7df02db4-5983-4ffd-8ab6-07842a2fb9a6" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "cc7def3d-2cee-4316-8d67-a624fc280be7" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "d71ece2b-33f2-4a31-8c1e-305870e7d536" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "ebf147e6-9009-4639-b89b-29d18666042c" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "9ebe588b-83bb-437e-8616-e2565bd176e3" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "990df177-5ce6-4ee6-a47a-038399f67fef" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "99977c38-0556-4034-b131-abbfe03b0f22" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "7250edb7-ed19-4a43-bbdc-f356d5448285" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "2123f247-131e-439a-891e-fe4b2337dc08" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "1d49188a-5710-48c1-bff2-5e91c54789e3" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "d1c8a93d-cea3-4dd1-a79a-7ea55ce0a30e" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "80c8a7d4-bc2c-4eba-84ba-75bb2c66a7aa" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "c6d80f26-0d20-4d62-8157-abfd5b80ee82" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "5d7cfecd-c39a-455f-b0df-4352cf6bf1d0" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "7a3c6d3f-852a-4725-b242-e626b479a9db" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "30c3e333-68fc-4ce7-9f87-5013791ae89f" } ,
				new HavingWeaponModel(){ userId = "366030b9-f148-46b2-9d92-54317d17e664" , weaponId = "2c99affe-0e02-4b6d-bfef-19249daa5ceb" }
			};
			foreach( HavingWeaponModel havingWeapon in this.havingWeapons ) {
				havingWeapon.user = GetUser( havingWeapon.userId );
				havingWeapon.weapon = GetWeapon( havingWeapon.weaponId );
			}
			#endregion

			#region ギアパワー一覧
			this.powers = new List<PowerModel>() {
				new PowerModel() {
					id = "9a28baa7-520a-4e1a-9348-391d5ed05a99" ,
					name = "サブ性能"
				} ,
				new PowerModel() {
					id = "b71c74a0-f4a7-425a-b01f-455c90e952b6" ,
					name = "サブ効率"
				} ,
				new PowerModel() {
					id = "dac60773-5fad-4b1f-b780-3aeab732d5b7" ,
					name = "スペ増"
				} ,
				new PowerModel() {
					id = "4d04c4dd-15e6-4a50-81d2-27aa0eeb52ae" ,
					name = "スペ減"
				} ,
				new PowerModel() {
					id = "9eb9ee16-299e-44f6-a4b3-b952835bb940" ,
					name = "スペ性能"
				} ,
				new PowerModel() {
					id = "e2b0c798-994d-474b-b19b-8874286f63a6" ,
					name = "イカ速"
				} ,
				new PowerModel() {
					id = "76e88d20-30ae-416a-990b-df6e6cd75538" ,
					name = "ヒト速"
				} ,
				new PowerModel() {
					id = "4e518beb-de42-4f48-a069-63a508bc500a" ,
					name = "ニンジャ"
				} ,
				new PowerModel() {
					id = "d4e7221c-cf73-4919-9021-ff1d872b0bba" ,
					name = "相手インク"
				} ,
				new PowerModel() {
					id = "949ac24c-896a-418e-95f7-d40664b87fd6" ,
					name = "メイン効率"
				} ,
				new PowerModel() {
					id = "816e1f6e-371a-4983-9ef6-b7465ee1315d" ,
					name = "インク回復"
				} ,
				new PowerModel() {
					id = "21d286c9-ff1d-47eb-9af0-0018173b2976" ,
					name = "ステジャン"
				} ,
				new PowerModel() {
					id = "f099676a-ee43-433f-a131-eddbc7818e6c" ,
					name = "スパジャン"
				} ,
				new PowerModel() {
					id = "5e88bb43-8b7c-4c04-ba23-4f4658d03f02" ,
					name = "復活短縮"
				} ,
				new PowerModel() {
					id = "2a0fa9f2-e643-4ce2-b99a-57887e09cc74" ,
					name = "スタダ"
				} ,
				new PowerModel() {
					id = "340a8c1e-3874-433d-ad27-d832ea8b76ce" ,
					name = "カムバ"
				} ,
				new PowerModel() {
					id = "cce89d3b-baea-432e-b445-e59ced55116a" ,
					name = "逆境"
				} ,
				new PowerModel() {
					id = "3ca6e386-cf70-46d0-ad56-2c06e227e296" ,
					name = "爆風軽減"
				} ,
				new PowerModel() {
					id = "b99b9725-ae09-4d13-bf0a-7940a13c02f6" ,
					name = "マキ短"
				} ,
				new PowerModel() {
					id = "e8808ea9-636e-46c4-974e-28da6d8eda21" ,
					name = "サーマル"
				} ,
				new PowerModel() {
					id = "b7800add-aa15-4973-a051-fe18d06bd5bc" ,
					name = "対物"
				} ,
				new PowerModel() {
					id = "04e060f7-33c8-45fb-9f54-b05c29c98f08" ,
					name = "受け身"
				} ,
				new PowerModel() {
					id = "00337511-ffe5-460a-bb82-977c7b0866be" ,
					name = "ペナ"
				} ,
				new PowerModel() {
					id = "f830c85c-97df-4005-944b-c2ed532c3237" ,
					name = "リベンジ"
				} ,
				new PowerModel() {
					id = "91d11d15-9764-4b78-a52f-0afa7b5ee1a9" ,
					name = "ラスパ"
				}
			};
			#endregion

			#region ブランド一覧
			this.brands = new List<BrandModel>() {
				new BrandModel() {
					id = "a888c3ed-10eb-445b-9814-b6d1df650ce8" ,
					name = "アイロニック" ,
					easyToHoldPowerId = "f099676a-ee43-433f-a131-eddbc7818e6c" ,
					difficultToHoldPowerId = "5e88bb43-8b7c-4c04-ba23-4f4658d03f02"
				} ,
				new BrandModel() {
					id = "87832f5f-2bb5-4cf6-a2b5-c6e733d0b8ed" ,
					name = "アナアキ" ,
					easyToHoldPowerId = "b99b9725-ae09-4d13-bf0a-7940a13c02f6" ,
					difficultToHoldPowerId = "4d04c4dd-15e6-4a50-81d2-27aa0eeb52ae"
				} ,
				new BrandModel() {
					id = "4c274bfb-cfcd-4853-abea-3d0f97cee6eb" ,
					name = "アロメ" ,
					easyToHoldPowerId = "816e1f6e-371a-4983-9ef6-b7465ee1315d" ,
					difficultToHoldPowerId = "f099676a-ee43-433f-a131-eddbc7818e6c"
				} ,
				new BrandModel() {
					id = "3573cd5e-fabe-4bf5-95b5-f49282a2c820" ,
					name = "エゾッコ" ,
					easyToHoldPowerId = "4d04c4dd-15e6-4a50-81d2-27aa0eeb52ae" ,
					difficultToHoldPowerId = "dac60773-5fad-4b1f-b780-3aeab732d5b7"
				} ,
				new BrandModel() {
					id = "9c7bbe9e-0a8a-4e97-b807-61f460f3c28d" ,
					name = "エンペリー" ,
					easyToHoldPowerId = "9a28baa7-520a-4e1a-9348-391d5ed05a99" ,
					difficultToHoldPowerId = "d4e7221c-cf73-4919-9021-ff1d872b0bba"
				} ,
				new BrandModel() {
					id = "eab2c5f2-a740-4b96-8d52-07913a909cf2" ,
					name = "クラーゲス" ,
					easyToHoldPowerId = "e2b0c798-994d-474b-b19b-8874286f63a6" ,
					difficultToHoldPowerId = "3ca6e386-cf70-46d0-ad56-2c06e227e296"
				} ,
				new BrandModel() {
					id = "d06fd0a0-fc19-4793-9367-1ab1402391f9" ,
					name = "シグレニ" ,
					easyToHoldPowerId = "3ca6e386-cf70-46d0-ad56-2c06e227e296" ,
					difficultToHoldPowerId = "b99b9725-ae09-4d13-bf0a-7940a13c02f6"
				} ,
				new BrandModel() {
					id = "13e88049-c176-4391-9391-63d34dc53c93" ,
					name = "ジモン" ,
					easyToHoldPowerId = "949ac24c-896a-418e-95f7-d40664b87fd6" ,
					difficultToHoldPowerId = "76e88d20-30ae-416a-990b-df6e6cd75538"
				} ,
				new BrandModel() {
					id = "4fa28b14-cb83-47f8-b69e-d7dc01e6847b" ,
					name = "タタキケンサキ" ,
					easyToHoldPowerId = "b99b9725-ae09-4d13-bf0a-7940a13c02f6" ,
					difficultToHoldPowerId = "9a28baa7-520a-4e1a-9348-391d5ed05a99"
				} ,
				new BrandModel() {
					id = "5017fd40-1e57-4341-9d28-1aa6cbc340a8" ,
					name = "バトロイカ" ,
					easyToHoldPowerId = "d4e7221c-cf73-4919-9021-ff1d872b0bba" ,
					difficultToHoldPowerId = "949ac24c-896a-418e-95f7-d40664b87fd6"
				} ,
				new BrandModel() {
					id = "850a760b-304e-419d-a520-cd8182eaeab7" ,
					name = "フォーリマ" ,
					easyToHoldPowerId = "9eb9ee16-299e-44f6-a4b3-b952835bb940" ,
					difficultToHoldPowerId = "b71c74a0-f4a7-425a-b01f-455c90e952b6"
				} ,
				new BrandModel() {
					id = "38b66388-9073-4e6a-aa8c-e7f658a116ee" ,
					name = "ホタックス" ,
					easyToHoldPowerId = "5e88bb43-8b7c-4c04-ba23-4f4658d03f02" ,
					difficultToHoldPowerId = "4d04c4dd-15e6-4a50-81d2-27aa0eeb52ae"
				} ,
				new BrandModel() {
					id = "e2d1cd74-c840-4d2a-af8c-04e59ec49fbc" ,
					name = "ホッコリー" ,
					easyToHoldPowerId = "b71c74a0-f4a7-425a-b01f-455c90e952b6" ,
					difficultToHoldPowerId = "816e1f6e-371a-4983-9ef6-b7465ee1315d"
				} ,
				new BrandModel() {
					id = "98f46caf-7604-4fa8-8ea3-4b14c98ab240" ,
					name = "ロッケンベルク" ,
					easyToHoldPowerId = "76e88d20-30ae-416a-990b-df6e6cd75538" ,
					difficultToHoldPowerId = "e2b0c798-994d-474b-b19b-8874286f63a6"
				} ,
				new BrandModel() {
					id = "bd5663d4-6f2c-470a-a540-2e729ccecba1" ,
					name = "ヤコ" ,
					easyToHoldPowerId = "dac60773-5fad-4b1f-b780-3aeab732d5b7" ,
					difficultToHoldPowerId = "9eb9ee16-299e-44f6-a4b3-b952835bb940"
				} ,
				new BrandModel() {
					id = "b1bb35a2-25ec-4245-afeb-0163d371be7b" ,
					name = "アタリメイド"
				} ,
				new BrandModel() {
					id = "9fc0df89-a7e5-4ec2-884a-67fbca0fb6b1" ,
					name = "アミーボ"
				} ,
				new BrandModel() {
					id = "ea9041d1-82ba-48a0-a05a-f46e325cf3a3" ,
					name = "クマサン商会"
				}
			};

			foreach( BrandModel brand in this.brands ) {
				brand.easyToHoldPower = this.GetPower( brand.easyToHoldPowerId );
				brand.difficultToHoldPower = this.GetPower( brand.difficultToHoldPowerId );
			}
			#endregion

			#region 頭ギア一覧
			this.headGears = csvService.ReadHeadGearCsv();
			foreach( GearModel gear in this.headGears ) {
				gear.brand = this.GetBrand( gear.brandId );
				gear.mainPower = this.GetPower( gear.mainPowerId );
				gear.sub1Power = this.GetPower( gear.sub1PowerId );
				gear.sub2Power = this.GetPower( gear.sub2PowerId );
				gear.sub3Power = this.GetPower( gear.sub3PowerId );
			}
			
			#endregion

			#region 服ギア一覧
			this.clotheGears = csvService.ReadClotheGearCsv();
			foreach( GearModel gear in this.clotheGears ) {
				gear.brand = this.GetBrand( gear.brandId );
				gear.mainPower = this.GetPower( gear.mainPowerId );
				gear.sub1Power = this.GetPower( gear.sub1PowerId );
				gear.sub2Power = this.GetPower( gear.sub2PowerId );
				gear.sub3Power = this.GetPower( gear.sub3PowerId );
			}
			#endregion

			#region 靴ギア一覧
			this.shoesGears = csvService.ReadShoesGearCsv();
			foreach( GearModel gear in this.shoesGears ) {
				gear.brand = this.GetBrand( gear.brandId );
				gear.mainPower = this.GetPower( gear.mainPowerId );
				gear.sub1Power = this.GetPower( gear.sub1PowerId );
				gear.sub2Power = this.GetPower( gear.sub2PowerId );
				gear.sub3Power = this.GetPower( gear.sub3PowerId );
			}
			#endregion

		}

		/// <summary>
		/// ユーザ取得
		/// </summary>
		/// <param name="id">ユーザId</param>
		/// <returns>ユーザ</returns>
		public UserModel GetUser( string id ) {
			foreach( UserModel user in this.users ) {
				if( user.id.Equals( id ) )
					return user;
			}
			return null;
		}

		/// <summary>
		/// 武器取得
		/// </summary>
		/// <param name="id">武器Id</param>
		/// <returns>武器</returns>
		public WeaponModel GetWeapon( string id ) {
			foreach( WeaponModel weapon in this.weapons ) {
				if( weapon.id.Equals( id ) )
					return weapon;
			}
			return null;
		}

		/// <summary>
		/// サブ取得
		/// </summary>
		/// <param name="id">サブId</param>
		/// <returns>サブ</returns>
		public SubWeaponModel GetSubWeapon( string id ) {
			foreach( SubWeaponModel subWeapon in this.subWeapons ) {
				if( subWeapon.id.Equals( id ) )
					return subWeapon;
			}
			return null;
		}

		/// <summary>
		/// スペシャル取得
		/// </summary>
		/// <param name="id">スペシャルId</param>
		/// <returns>スペシャル</returns>
		public SpecialWeaponModel GetSpecialWeapon( string id ) {
			foreach( SpecialWeaponModel specialWeapon in this.specialWeapons ) {
				if( specialWeapon.id.Equals( id ) )
					return specialWeapon;
			}
			return null;
		}

		/// <summary>
		/// ギアパワー取得
		/// </summary>
		/// <param name="powerId">ギアパワーId</param>
		/// <returns>ギアパワー</returns>
		public PowerModel GetPower( string powerId ) {
			if( powerId == null )
				return null;
			foreach( PowerModel power in this.powers ) {
				if( powerId.Equals( power.id ) )
					return power;
			}
			return null;
		}

		/// <summary>
		/// ユーザ一覧取得
		/// </summary>
		/// <returns>ユーザ一覧</returns>
		public List<UserModel> GetUsers() { 
			return this.users;
		}

		/// <summary>
		/// 武器一覧取得
		/// </summary>
		/// <returns>武器一覧</returns>
		public List<WeaponModel> GetWeapons() { 
			return this.weapons;
		}

		/// <summary>
		/// サブ一覧取得
		/// </summary>
		/// <returns>サブ一覧</returns>
		public List<SubWeaponModel> GetSubWeapons() {
			return this.subWeapons;
		}

		/// <summary>
		/// スペシャル一覧取得
		/// </summary>
		/// <returns>スペシャル一覧</returns>
		public List<SpecialWeaponModel> GetSpecialWeapons() {
			return this.specialWeapons;
		}

		/// <summary>
		/// 所持武器一覧取得
		/// </summary>
		/// <param name="userId">ユーザId</param>
		/// <returns>所持武器一覧</returns>
		public List<HavingWeaponModel> GetHavingWeapon( string userId ) {
			List<HavingWeaponModel> havingWeapons = new List<HavingWeaponModel>();
			foreach( HavingWeaponModel havingWeapon in this.havingWeapons ) {
				if( userId.Equals( havingWeapon.userId ) )
					havingWeapons.Add( havingWeapon );
			}
			return havingWeapons;
		}

		/// <summary>
		/// ギアパワー一覧取得
		/// </summary>
		/// <returns>ギアパワー一覧</returns>
		public List<PowerModel> GetPowers() { 
			return this.powers;
		}

		/// <summary>
		/// ブランド取得
		/// </summary>
		/// <param name="brandId">ブランドID</param>
		/// <returns>ブランド</returns>
		public BrandModel GetBrand( string brandId ) {
			foreach( BrandModel brand in this.brands ) {
				if( brand.id.Equals( brandId ) )
					return brand;
			}
			return null;
		}

		/// <summary>
		/// ブランド一覧取得
		/// </summary>
		/// <returns>ブランド一覧</returns>
		public List<BrandModel> GetBrands() { 
			return this.brands;
		}
		
		/// <summary>
		/// 頭ギア一覧取得
		/// </summary>
		/// <returns>頭ギア一覧</returns>
		public List<GearModel> GetHeadGears() {
			return this.headGears;
		}

		/// <summary>
		/// 服ギア一覧取得
		/// </summary>
		/// <returns>服ギア一覧</returns>
		public List<GearModel> GetClotheGears() {
			return this.clotheGears;
		}

		/// <summary>
		/// 靴ギア一覧取得
		/// </summary>
		/// <returns>靴ギア一覧</returns>
		public List<GearModel> GetShoesGears() {
			return this.shoesGears;
		}

		/// <summary>
		/// 頭ギア更新
		/// </summary>
		/// <param name="gears"></param>
		public void UpdateHeadGears( List<GearModel> gears ) {
			this.headGears = gears;
			this.csvService.WriteHeadGearCsv( gears );
		}

		/// <summary>
		/// 頭ギア更新
		/// </summary>
		/// <param name="gears"></param>
		public void UpdateClotheGears( List<GearModel> gears ) {
			this.clotheGears = gears;
			this.csvService.WriteClotheGearCsv( gears );
		}

		/// <summary>
		/// 頭ギア更新
		/// </summary>
		/// <param name="gears"></param>
		public void UpdateShoesGears( List<GearModel> gears ) {
			this.shoesGears = gears;
			this.csvService.WriteShoesGearCsv( gears );
		}

	}

}