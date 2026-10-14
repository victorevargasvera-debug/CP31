using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.ConventionalSystem;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.Contact
{
	// Token: 0x020001FE RID: 510
	[global::System.Serializable]
	public class MDCCallList : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x060018C6 RID: 6342 RVA: 0x002114CC File Offset: 0x0020F6CC
		public global::SpecialFeatures.Ucl.Contact.MDCCallListCallListSection CallListMDC
		{
			get
			{
				short num = (short)371916800;
				short num2 = num;
				num = (short)1787363329;
				if (num != 0)
				{
				}
				num = (short)58909587;
				short num3 = num;
				num = (short)1442374547;
				switch (num3 == num)
				{
				}
				num = (short)834863104;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.Ucl.Contact.MDCCallListCallListSection)base[10406];
			}
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x00003C85 File Offset: 0x00001E85
		private MDCCallList() : this(null)
		{
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x00211584 File Offset: 0x0020F784
		internal MDCCallList(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 9;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솋쪍펏늑힓秊鍊풟쮡쮣좥즧용貫", a_);
			base.UIName = global::CommonResources.AppResources.MDC_Conventional_ID;
			base.AddFeatureSection(new global::SpecialFeatures.Ucl.Contact.MDCCallListCallListSection(this));
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x002115CC File Offset: 0x0020F7CC
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)951844864;
			short num2 = num;
			num = (short)510459905;
			if (num != 0)
			{
			}
			num = (short)1719732994;
			short num3 = num;
			num = (short)1294273282;
			switch (num3 == num)
			{
			}
			num = (short)1496449024;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x000038AD File Offset: 0x00001AAD
		protected MDCCallList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060018CB RID: 6347 RVA: 0x0021167C File Offset: 0x0020F87C
		internal static global::AcpCommonLib.IAcpFeatureNode GetMDCCallList()
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			global::AcpCommonLib.IAcpFeatureNode result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					result = ((global::AcpBusinessLayer.Recordset)global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2200)).TemplateNode[10405].EmbeddedRecset[0];
					num2 = (short)633339910;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)1516175364;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1895956485;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)1066011570;
					short num3 = num2;
					num2 = (short)738855858;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D6;
					default:
						goto IL_194;
					}
					break;
				}
				case 4:
					num2 = (short)1796341761;
					if (num2 != 0)
					{
					}
					result = ((global::AcpBusinessLayer.Recordset)global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2200)).TemplateNode[10405].EmbeddedRecset[0];
					num2 = (short)1536425987;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num2 = (short)941359105;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = ((global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(2200)).TemplateNode[10405].EmbeddedRecset[0];
					goto IL_1D6;
				case 6:
					goto IL_D5;
				}
				goto IL_2C;
				IL_1D6:
				num2 = (short)400949248;
				short num4 = num2;
				num2 = (short)672006144;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_D5:
			return result;
			IL_194:
			num2 = (short)705691648;
			if (num2 != 0)
			{
			}
			return result;
			IL_2C:
			result = null;
			num2 = (short)1760559106;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x060018CC RID: 6348 RVA: 0x002118A4 File Offset: 0x0020FAA4
		public override string ReferenceKey
		{
			get
			{
				int a_ = 9;
				short num = (short)1961164811;
				int num2 = (int)((global::System.IntPtr)num);
				string result;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_320;
					case 1:
						return result;
					case 2:
						result = global::CommonResources.AppResources.Unassigned_ID + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꆋ", a_) + this.CallListMDC.UclMDCCnv_PrimaryID_A00030Object.ToString();
						num = (short)934543360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return result;
					case 4:
						result = this.CallListMDC.UclMDCCnv_CustomizedSysGrpNumber_A00032Object.ToString() + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꆋ", a_) + this.CallListMDC.UclMDCCnv_PrimaryID_A00030Object.ToString();
						num = (short)826998787;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						if (this.CallListMDC.UclMDCCnv_SystemAlias_A00028Value == 65535)
						{
							num = (short)922550276;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.FeatureNode referencedNode = this.CallListMDC.UclMDCCnv_SystemAlias_A00028Object.ReferencedNode;
						num = (short)1322909705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)694288392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (this.CallListMDC.UclMDCCnv_SystemAlias_A00028Value == 0)
						{
							num = (short)618004482;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1062731781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (this.CallListMDC.UclMDCCnv_SystemGroupNumber_A00029Object != null)
						{
							num = (short)1797718030;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B7;
					case 9:
					{
						global::AcpBusinessLayer.FeatureNode referencedNode;
						if (referencedNode != null)
						{
							num = (short)1177681932;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = this.CallListMDC.UclMDCCnv_SystemAlias_A00028Object.InvalidText;
						num = (short)2024603648;
						short num3 = num;
						num = (short)1032323082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						return result;
					case 11:
						switch (0)
						{
						case 0:
							goto IL_6E;
						}
						continue;
					case 12:
					{
						global::AcpBusinessLayer.FeatureNode referencedNode;
						result = (referencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem).General.CnvSysGeneralSystemGroupNumber_A21960.ToString() + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꆋ", a_) + this.CallListMDC.UclMDCCnv_PrimaryID_A00030Object.ToString();
						num = (short)1076035585;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						if (this.CallListMDC.UclMDCCnv_PrimaryID_A00030Object == null)
						{
							goto IL_3B7;
						}
						num = (short)1495882639;
						short num4 = num;
						num = (short)1172855695;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1059782657;
							if (num != 0)
							{
							}
							num = (short)755302400;
							if (num != 0)
							{
							}
							num = (short)2030108687;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 14:
						num = (short)1522008077;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						result = string.Empty;
						num = (short)1231290375;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_6E:
					if (this.CallListMDC == null)
					{
						goto IL_3B7;
					}
					num = (short)279379974;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_320:
				return result;
				IL_3B7:
				return base.FeatureName;
			}
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x00211C70 File Offset: 0x0020FE70
		internal bool IsDefaultNode()
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
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
					num2 = (short)2092367877;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					result = true;
					num2 = (short)367853574;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (this.CallListMDC != null)
					{
						num2 = (short)2063269892;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					if (this.CallListMDC.UclMDCCnv_SystemAlias_A00028Value == 0)
					{
						num2 = (short)1013514241;
						if (num2 != 0)
						{
						}
						num2 = (short)79623792;
						short num3 = num2;
						num2 = (short)1056765552;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_97;
						case 1:
							break;
						default:
						{
							num2 = (short)1407057920;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)1721761792;
						if (num2 != 0)
						{
						}
						num2 = (short)1217003520;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					num2 = (short)1169162243;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_97;
				case 6:
					return result;
				}
				goto IL_2C;
				IL_97:
				if (this.CallListMDC.UclMDCCnv_PrimaryID_A00030Value != 0)
				{
					break;
				}
				num2 = (short)1365508097;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_2C:
			result = false;
			num2 = (short)1828257794;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
