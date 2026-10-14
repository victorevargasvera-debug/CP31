using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.ConventionalSystem;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.Contact
{
	// Token: 0x020001F2 RID: 498
	[global::System.Serializable]
	public class AstroCallList : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x060017F0 RID: 6128 RVA: 0x00206B0C File Offset: 0x00204D0C
		public global::SpecialFeatures.Ucl.Contact.AstroCallListCallListSection CallListAstro
		{
			get
			{
				short num = (short)115184888;
				short num2 = num;
				num = (short)70620408;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1064697856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2104426497;
				if (num != 0)
				{
				}
				num = (short)1222246400;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.Ucl.Contact.AstroCallListCallListSection)base[10404];
			}
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x00003C0A File Offset: 0x00001E0A
		private AstroCallList() : this(null)
		{
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x00206BC4 File Offset: 0x00204DC4
		internal AstroCallList(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 16;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튒붜\udc9e캠춢펤슦잨\udfaa쒬삮\udfb0튲\ud9b4鞶ﾺ", a_);
			base.UIName = global::CommonResources.AppResources.Astro_Conventional_ID;
			base.AddFeatureSection(new global::SpecialFeatures.Ucl.Contact.AstroCallListCallListSection(this));
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x00206C0C File Offset: 0x00204E0C
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)1917814575;
			short num2 = num;
			num = (short)1430554415;
			switch (num2 == num)
			{
			default:
			{
				num = (short)458752000;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1193541633;
			if (num != 0)
			{
			}
			num = (short)258867200;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x000038AD File Offset: 0x00001AAD
		protected AstroCallList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x00206CC0 File Offset: 0x00204EC0
		public static global::AcpCommonLib.IAcpFeatureNode GetAstroCallList()
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpFeatureNode result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_163;
				case 1:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num2 = (short)699334662;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = ((global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(2200)).TemplateNode[10403].EmbeddedRecset[0];
					num2 = (short)1760886789;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_123;
				case 3:
				{
					if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)1292107777;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2135966855;
					short num3 = num2;
					num2 = (short)1714046087;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_163;
					default:
						num2 = (short)932773888;
						if (num2 != 0)
						{
						}
						num2 = (short)131072000;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					goto IL_1A9;
				case 5:
					goto IL_1EC;
				case 6:
					result = ((global::AcpBusinessLayer.Recordset)global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2200)).TemplateNode[10403].EmbeddedRecset[0];
					num2 = (short)2116157442;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_2C;
				IL_163:
				result = ((global::AcpBusinessLayer.Recordset)global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2200)).TemplateNode[10403].EmbeddedRecset[0];
				num2 = (short)909901828;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_123:
			IL_1A9:
			IL_1EC:
			num2 = (short)776994816;
			short num4 = num2;
			return result;
			IL_2C:
			num2 = (short)464125953;
			if (num2 != 0)
			{
			}
			result = null;
			num2 = (short)725155843;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x060017F6 RID: 6134 RVA: 0x00206EE8 File Offset: 0x002050E8
		public override string ReferenceKey
		{
			get
			{
				int a_ = 17;
				short num = (short)98107401;
				int num2 = (int)((global::System.IntPtr)num);
				string result;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return result;
					case 1:
					{
						num = (short)1213399040;
						short num3 = num;
						num = (short)350420993;
						if (num != 0)
						{
						}
						if (this.CallListAstro.UclAstroCnv_SystemGroupNumber_A00023Object != null)
						{
							num = (short)22675461;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_444;
					}
					case 2:
						return result;
					case 3:
					{
						if (this.CallListAstro.UclAstroCnv_SystemAlias_A00022Value == 65535)
						{
							num = (short)125566987;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.FeatureNode referencedNode = this.CallListAstro.UclAstroCnv_SystemAlias_A00022Object.ReferencedNode;
						num = (short)243859471;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)1685127169;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1157431306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_3CF;
					case 7:
						result = string.Concat(new string[]
						{
							global::CommonResources.AppResources.Unassigned_ID,
							global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("릓", a_),
							this.CallListAstro.UclAstroCnv_IndividualID_A00024Object.ToString(),
							global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("릓", a_),
							this.CallListAstro.UclAstroCnv_ListinfoCallType_A00025Object.ToString()
						});
						num = (short)995753997;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						result = string.Empty;
						num = (short)192937990;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						switch (0)
						{
						case 0:
							goto IL_6D;
						}
						continue;
					case 10:
						if (this.CallListAstro.UclAstroCnv_IndividualID_A00024Object != null)
						{
							num = (short)995229704;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_444;
					case 11:
						result = string.Concat(new string[]
						{
							this.CallListAstro.UclAstroCnv_CustomizedSysGrpNumber_A00027Object.ToString(),
							global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("릓", a_),
							this.CallListAstro.UclAstroCnv_IndividualID_A00024Object.ToString(),
							global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("릓", a_),
							this.CallListAstro.UclAstroCnv_ListinfoCallType_A00025Object.ToString()
						});
						num = (short)691994624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						num = (short)1776114821;
						short num4 = num;
						num = (short)636050565;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3CF;
						default:
							goto IL_14C;
						}
						break;
					}
					case 13:
						goto IL_3AD;
					case 14:
					{
						global::AcpBusinessLayer.FeatureNode referencedNode;
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = referencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
						result = string.Concat(new string[]
						{
							conventionalSystem.General.CnvSysGeneralSystemGroupNumber_A21960.ToString(),
							global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("릓", a_),
							this.CallListAstro.UclAstroCnv_IndividualID_A00024Object.ToString(),
							global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("릓", a_),
							this.CallListAstro.UclAstroCnv_ListinfoCallType_A00025Object.ToString()
						});
						num = (short)26411020;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
					{
						global::AcpBusinessLayer.FeatureNode referencedNode;
						if (referencedNode != null)
						{
							num = (short)932577294;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = this.CallListAstro.UclAstroCnv_SystemAlias_A00022Object.InvalidText;
						num = (short)1824587778;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_6D:
					if (this.CallListAstro != null)
					{
						num = (short)34996228;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_444;
					IL_3CF:
					if (this.CallListAstro.UclAstroCnv_SystemAlias_A00022Value == 0)
					{
						num = (short)466616327;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)892207107;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_14C:
				num = (short)1353187328;
				if (num != 0)
				{
				}
				return result;
				IL_3AD:
				return result;
				IL_444:
				return base.FeatureName;
			}
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x00207340 File Offset: 0x00205540
		internal bool IsDefaultNode()
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (this.CallListAstro.UclAstroCnv_ListinfoCallType_A00025Value == 0)
					{
						num2 = (short)1840316420;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
				{
					if (this.CallListAstro.UclAstroCnv_IndividualID_A00024Value != 0)
					{
						return result;
					}
					num2 = (short)836129999;
					short num3 = num2;
					num2 = (short)205935823;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B2;
					default:
						num2 = (short)1369440256;
						if (num2 != 0)
						{
						}
						num2 = (short)1491337224;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					num2 = (short)1491271681;
					if (num2 != 0)
					{
					}
					if (this.CallListAstro.UclAstroCnv_SystemAlias_A00022Value == 0)
					{
						num2 = (short)1416822784;
						short num4 = num2;
						num2 = (short)388038662;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					num2 = (short)823459842;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					result = true;
					num2 = (short)1070333959;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (this.CallListAstro != null)
					{
						num2 = (short)1988624387;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 6:
					goto IL_B2;
				case 7:
					return result;
				case 8:
					num2 = (short)1651179520;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_34;
				IL_B2:
				num2 = (short)17825793;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_34:
			result = false;
			num2 = (short)105185285;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
