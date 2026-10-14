using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality;

namespace Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList
{
	// Token: 0x020005DD RID: 1501
	[global::System.Serializable]
	public class ASTROTalkgroupListRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600CF29 RID: 53033 RVA: 0x00C0C2DC File Offset: 0x00C0A4DC
		public ASTROTalkgroupListRecset() : base(global::CommonResources.AcgResources.ID_ASTROTALKGROUPLIST, global::CommonResources.AcgResources.ID_LIST)
		{
			this.SetValues();
		}

		// Token: 0x0600CF2A RID: 53034 RVA: 0x00C0C300 File Offset: 0x00C0A500
		public ASTROTalkgroupListRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x1700681D RID: 26653
		// (get) Token: 0x0600CF2B RID: 53035 RVA: 0x00C0C32C File Offset: 0x00C0A52C
		public override int MaxPool
		{
			get
			{
				short num = (short)1974272000;
				short num2 = num;
				num = (short)379804081;
				short num3 = num;
				num = (short)1797872049;
				switch (num3 == num)
				{
				}
				num = (short)1723858945;
				if (num != 0)
				{
				}
				num = (short)1201012736;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset._MaxPool;
			}
		}

		// Token: 0x1700681E RID: 26654
		// (get) Token: 0x0600CF2C RID: 53036 RVA: 0x00C0C3D8 File Offset: 0x00C0A5D8
		// (set) Token: 0x0600CF2D RID: 53037 RVA: 0x00C0C498 File Offset: 0x00C0A698
		public override int Max
		{
			get
			{
				short num = (short)1559402694;
				short num2 = num;
				num = (short)719165638;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_AC;
				case 1:
					break;
				default:
				{
					num = (short)790626304;
					short num3 = num;
					break;
				}
				}
				num = (short)448004096;
				if (num != 0)
				{
				}
				if (this._DynMax == -1)
				{
					num = (short)1163919361;
					if (num != 0)
					{
					}
					return global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset._Max;
				}
				IL_AC:
				return this._DynMax;
			}
			set
			{
				short num = (short)940376064;
				short num2 = num;
				num = (short)1800173604;
				short num3 = num;
				num = (short)1203664932;
				switch (num3 == num)
				{
				}
				num = (short)951386113;
				if (num != 0)
				{
				}
				num = (short)58064896;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x1700681F RID: 26655
		// (get) Token: 0x0600CF2E RID: 53038 RVA: 0x00C0C54C File Offset: 0x00C0A74C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1631518720;
				short num2 = num;
				num = (short)519897089;
				if (num != 0)
				{
				}
				num = (short)362125839;
				short num3 = num;
				num = (short)1302764047;
				switch (num3 == num)
				{
				}
				num = (short)1961361408;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17006820 RID: 26656
		// (get) Token: 0x0600CF2F RID: 53039 RVA: 0x00C0C600 File Offset: 0x00C0A800
		// (set) Token: 0x0600CF30 RID: 53040 RVA: 0x00C0C6AC File Offset: 0x00C0A8AC
		public override int Min
		{
			get
			{
				short num = (short)888733696;
				short num2 = num;
				num = (short)64522379;
				short num3 = num;
				num = (short)1423280267;
				switch (num3 == num)
				{
				}
				num = (short)22413313;
				if (num != 0)
				{
				}
				num = (short)886505472;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset._Min;
			}
			set
			{
				short num = (short)853934080;
				short num2 = num;
				num = (short)187843187;
				short num3 = num;
				num = (short)147276403;
				switch (num3 == num)
				{
				}
				num = (short)1410269184;
				if (num != 0)
				{
				}
				num = (short)374472705;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset._Min = value;
			}
		}

		// Token: 0x0600CF31 RID: 53041 RVA: 0x00C0C75C File Offset: 0x00C0A95C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)292814848;
			short num2 = num;
			num = (short)325406577;
			short num3 = num;
			num = (short)1463897969;
			switch (num3 == num)
			{
			}
			num = (short)1240530945;
			if (num != 0)
			{
			}
			num = (short)105709568;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList(this);
		}

		// Token: 0x0600CF32 RID: 53042 RVA: 0x00C0C80C File Offset: 0x00C0AA0C
		internal void SetValues()
		{
			int a_ = 14;
			short num = (short)1317404672;
			short num2 = num;
			num = (short)1802052190;
			short num3 = num;
			num = (short)1424892510;
			switch (num3 == num)
			{
			}
			num = (short)50528256;
			if (num != 0)
			{
			}
			num = (short)1690370049;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.Id = 2062;
			base.SingleInstance = false;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("軎뷐뿒鏔닖룘꿚꣜귞蓠郢\udee4ꓦ蛨蛪鷬胮鿰雲鯴菶ꗸ룺鋼釾眀昂欄猆怈搊挌渎紐㌒嘔砖眘級琜砞吠儢䐤匦䀨䐪䌬献瀰怲愴收瘸ᬺ椼帾ⵀ⡂≄㕆♈㹊㵌潎ᵐ㩒♔⍖՘ᩚ๜୞㍠Ɫㅤ٦ըj੬ᵮṰٲմ㭶ၸࡺॼ⭾ꮄﾆ", a_);
			base.UIName = global::CommonResources.AcgResources.ID_ASTROTALKGROUPLIST;
			base.KeySeed = global::CommonResources.AcgResources.ID_LIST;
			base.DataTransferOrder = 31;
		}

		// Token: 0x0600CF33 RID: 53043 RVA: 0x00C0C90C File Offset: 0x00C0AB0C
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1276379136;
			short num2 = num;
			num = (short)2120078626;
			short num3 = num;
			num = (short)1834341666;
			switch (num3 == num)
			{
			}
			num = (short)970981377;
			if (num != 0)
			{
			}
			num = (short)1995309056;
			if (num != 0)
			{
			}
			this.c(record);
			base.OnFinishedRemoveRecord(record);
			this.b(record);
			this.d(record);
		}

		// Token: 0x0600CF34 RID: 53044 RVA: 0x00C0C9D4 File Offset: 0x00C0ABD4
		private void d(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)644415488;
			short num2 = num;
			num = (short)1954873345;
			if (num != 0)
			{
			}
			num = (short)1497300763;
			short num3 = num;
			num = (short)813629211;
			switch (num3 == num)
			{
			}
			num = (short)328531968;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600CF35 RID: 53045 RVA: 0x00C0CA7C File Offset: 0x00C0AC7C
		private void c(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)333971456;
			short num2 = num;
			num = (short)317654954;
			short num3 = num;
			num = (short)1225000874;
			switch (num3 == num)
			{
			}
			num = (short)475201536;
			if (num != 0)
			{
			}
			num = (short)2051997697;
			if (num != 0)
			{
			}
			this.a(A_0);
		}

		// Token: 0x0600CF36 RID: 53046 RVA: 0x00C0CB2C File Offset: 0x00C0AD2C
		private void b(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1298857984;
			short num2 = num;
			num = (short)1603319988;
			short num3 = num;
			num = (short)815642804;
			switch (num3 == num)
			{
			}
			num = (short)271450112;
			if (num != 0)
			{
			}
			num = (short)1803223041;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x0600CF37 RID: 53047 RVA: 0x00C0CBD8 File Offset: 0x00C0ADD8
		private void a()
		{
			short num = (short)985858048;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				global::AcpCommonLib.IAcpRecordset feature;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						if (feature != null)
						{
							num = (short)1016659972;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						if (feature.Count == 0)
						{
							num = (short)363528194;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_306;
					case 2:
						return;
					case 3:
					{
						num = (short)1329266459;
						short num3 = num;
						num = (short)1802764059;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)967442432;
							if (num != 0)
							{
							}
							try
							{
								num = (short)1323630596;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
										conventionalPersonality.General.CnvPerGeneralTalkgroupTextList_A19822.UIValue = acpFeatureNode.ReferenceKey.ToString();
										num = (short)1163132931;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
									{
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
										if (acpFeatureNode != null)
										{
											num = (short)1331363840;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset astrotalkgroupListRecset;
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = astrotalkgroupListRecset[0];
										num = (short)1956839425;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										switch (0)
										{
										case 0:
											goto IL_12A;
										}
										continue;
									case 5:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1522270218;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
										num = (short)497090567;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
										goto IL_296;
									case 7:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
										if (conventionalPersonality.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkgroupList_A9283.ReferencedNode == null)
										{
											num = (short)524877833;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 8:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset astrotalkgroupListRecset;
										if (astrotalkgroupListRecset != null)
										{
											num = (short)581763074;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 9:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset astrotalkgroupListRecset = global::AcpCommonLib.FeatureManager.GetFeature(2062) as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset;
										num = (short)1911095304;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 10:
										num = (short)1785528326;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_160:
									num = (short)697171973;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_12A:
									goto IL_160;
								}
								IL_296:
								return;
							}
							finally
							{
								num = (short)776077312;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_2CD;
										}
										continue;
									case 1:
										goto IL_303;
									case 2:
										enumerator.Dispose();
										num = (short)246022145;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_2CD:
									if (enumerator == null)
									{
										break;
									}
									num = (short)469368834;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_303:;
							}
							goto IL_306;
						}
						break;
					}
					case 4:
						num = (short)799473665;
						if (num != 0)
						{
						}
						num = (short)1420165121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_42;
					IL_306:
					enumerator = ((global::AcpBusinessLayer.Recordset)feature).GetEnumerator();
					num = (short)198901763;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_42:
				feature = global::AcpCommonLib.FeatureManager.GetFeature(2059);
				num = (short)1438318592;
				short num4 = num;
				num = (short)669319168;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600CF38 RID: 53048 RVA: 0x00C0CFBC File Offset: 0x00C0B1BC
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)312475648;
			switch (num)
			{
			default:
			{
				num = (short)780402688;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList astrotalkgroupList2;
					global::AcpCommonLib.IAcpRecordset feature;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_7D;
						}
						continue;
					case 1:
						goto IL_2C5;
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList astrotalkgroupList;
						if (astrotalkgroupList != null)
						{
							goto IL_379;
						}
						return;
					}
					case 3:
						return;
					case 4:
						try
						{
							num = (short)2001534977;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)952369159;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
									num = (short)114688011;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_4DC;
									}
									continue;
								case 2:
									num = (short)1622999045;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (!global::AcpCommonLib.Permission.Have(global::AcpCommonLib.Permissions.RefernceDisabled, conventionalPersonality.Permissions))
									{
										num = (short)115605513;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_694;
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (global::CommonResources.AppResources.Zone_Reserved == conventionalPersonality.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkgroupList_A9283.UIValue)
									{
										num = (short)671285256;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									num = (short)1972043780;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									num = (short)965214220;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList astrotalkgroupList;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									conventionalPersonality.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkgroupList_A9283.UIValue = astrotalkgroupList.ReferenceKey;
									num = (short)460914694;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									num = (short)395968515;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									if (astrotalkgroupList2 != null)
									{
										num = (short)1181745154;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 12:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (!conventionalPersonality.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkgroupList_A9283.Applicable)
									{
										num = (short)1349255178;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_63F:
								num = (short)416022528;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4DC:
								goto IL_63F;
							}
							IL_694:
							return;
						}
						finally
						{
							num = (short)39190528;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_6CC;
									}
									continue;
								case 1:
									goto IL_703;
								case 2:
									enumerator.Dispose();
									num = (short)1951203329;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_6CC:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1347026946;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_703:;
						}
						goto IL_706;
					case 5:
						if (base.ContainerDoc.IsOpen)
						{
							num = (short)2055733259;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
					{
						if (feature.Count == 0)
						{
							num = (short)1874657283;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList astrotalkgroupList = null;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (A_0.Parent as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset).Items.GetEnumerator();
						num = (short)1709864634;
						short num3 = num;
						num = (short)1876784826;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_379;
						default:
							num = (short)1368457216;
							if (num != 0)
							{
							}
							num = (short)1556480012;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						goto IL_706;
					case 8:
						if (feature != null)
						{
							num = (short)1406861321;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
						num = (short)158597126;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = ((global::AcpBusinessLayer.Recordset)feature).GetEnumerator();
						num = (short)63832068;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						num = (short)514719757;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						num = (short)1326120960;
						short num4 = num;
						try
						{
							num = (short)1848573954;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1486815233;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList astrotalkgroupList3 = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList;
									num = (short)410255363;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)1472135174;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_143;
									}
									continue;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList astrotalkgroupList3;
									if (astrotalkgroupList3.ReferenceKey != astrotalkgroupList2.ReferenceKey)
									{
										num = (short)2123104260;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									num = (short)1608056840;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList astrotalkgroupList3;
									global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList astrotalkgroupList = astrotalkgroupList3;
									num = (short)1364918279;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_253;
								case 7:
									goto IL_1F7;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList astrotalkgroupList3;
									if (!global::AcpCommonLib.Permission.Have(global::AcpCommonLib.Permissions.RefernceDisabled, astrotalkgroupList3.Permissions))
									{
										num = (short)1953562629;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_1FC:
								num = (short)1097728000;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_143:
								goto IL_1FC;
							}
							IL_1F7:
							IL_253:
							goto IL_359;
						}
						finally
						{
							num = (short)2007695360;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_28B;
									}
									continue;
								case 1:
									goto IL_2C2;
								case 2:
									enumerator.Dispose();
									num = (short)1529085953;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_28B:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2074279938;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2C2:;
						}
						goto IL_2C5;
						IL_359:
						num = (short)599457794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						if (base.ContainerDoc.DocType != global::AcpCommonLib.DocumentType.Comparator)
						{
							num = (short)1106444289;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_7D:
					num = (short)475004929;
					if (num != 0)
					{
					}
					if (base.ContainerDoc != null)
					{
						num = (short)883097607;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_2C5:
					astrotalkgroupList2 = (A_0 as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList);
					feature = global::AcpCommonLib.FeatureManager.GetFeature(2059);
					num = (short)1579024392;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_379:
					num = (short)881131530;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_706:
					num = (short)1758461957;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x0600CF39 RID: 53049 RVA: 0x00C0D74C File Offset: 0x00C0B94C
		// Note: this type is marked as 'beforefieldinit'.
		static ASTROTalkgroupListRecset()
		{
			short num = (short)130351104;
			short num2 = num;
			num = (short)1582563329;
			if (num != 0)
			{
			}
			num = (short)927469121;
			short num3 = num;
			num = (short)79236673;
			switch (num3 == num)
			{
			}
			num = (short)499843072;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset._Min = 1;
		}

		// Token: 0x0400659B RID: 26011
		public static int _MaxPool;

		// Token: 0x0400659C RID: 26012
		public static int _Max;

		// Token: 0x0400659D RID: 26013
		public int _DynMax;

		// Token: 0x0400659E RID: 26014
		public static int _Min;
	}
}
