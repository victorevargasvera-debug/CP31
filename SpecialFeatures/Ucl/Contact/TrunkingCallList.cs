using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.Contact
{
	// Token: 0x02000209 RID: 521
	[global::System.Serializable]
	public class TrunkingCallList : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x060019EC RID: 6636 RVA: 0x002201EC File Offset: 0x0021E3EC
		public global::SpecialFeatures.Ucl.Contact.TrunkingCallListCallListSection CallList
		{
			get
			{
				short num = (short)1208121496;
				short num2 = num;
				num = (short)1326151832;
				switch (num2 == num)
				{
				}
				num = (short)1796145152;
				short num3 = num;
				num = (short)638648320;
				if (num != 0)
				{
				}
				num = (short)359727105;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.Ucl.Contact.TrunkingCallListCallListSection)base[10402];
			}
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x00003D2F File Offset: 0x00001F2F
		private TrunkingCallList() : this(null)
		{
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x002202A8 File Offset: 0x0021E4A8
		internal TrunkingCallList(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 16;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튒붜궞钠莢햦\udca8얪욬욮\udfb0풲閴ﺶﶸ", a_);
			base.UIName = global::CommonResources.AppResources.Astro_25_Trunking_ID;
			base.AddFeatureSection(new global::SpecialFeatures.Ucl.Contact.TrunkingCallListCallListSection(this));
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x002202F0 File Offset: 0x0021E4F0
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)931489027;
			short num2 = num;
			num = (short)897606915;
			switch (num2 == num)
			{
			}
			num = (short)33357824;
			short num3 = num;
			num = (short)1490419712;
			if (num != 0)
			{
			}
			num = (short)1899102209;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x000038AD File Offset: 0x00001AAD
		protected TrunkingCallList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x002203A0 File Offset: 0x0021E5A0
		internal static global::AcpCommonLib.IAcpFeatureNode GetTrunkingCallList()
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
				{
					num2 = (short)1141833729;
					if (num2 != 0)
					{
					}
					num2 = (short)1600189435;
					short num3 = num2;
					num2 = (short)990180347;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1B8;
					default:
						num2 = (short)348520448;
						if (num2 != 0)
						{
						}
						result = ((global::AcpBusinessLayer.Recordset)global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2200)).TemplateNode[10401].EmbeddedRecset[0];
						num2 = (short)325713922;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
				{
					num2 = (short)326631424;
					short num4 = num2;
					result = ((global::AcpBusinessLayer.Recordset)global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2200)).TemplateNode[10401].EmbeddedRecset[0];
					goto IL_1B8;
				}
				case 2:
					return result;
				case 3:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num2 = (short)112132096;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = ((global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(2200)).TemplateNode[10401].EmbeddedRecset[0];
					num2 = (short)2003435526;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)1856176129;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1371930627;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					return result;
				case 6:
					return result;
				}
				goto IL_2C;
				IL_1B8:
				num2 = (short)1419509765;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_2C:
			result = null;
			num2 = (short)2097610756;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x060019F2 RID: 6642 RVA: 0x002205C8 File Offset: 0x0021E7C8
		public override string ReferenceKey
		{
			get
			{
				int a_ = 9;
				short num = (short)573571087;
				int num2 = (int)((global::System.IntPtr)num);
				string result;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1548091404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return result;
					case 2:
						num = (short)24444932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_323;
					case 4:
						if (this.CallList.UclAstro25Trk_WACNID_A00011Object != null)
						{
							num = (short)458293248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48D;
					case 5:
					{
						if (this.CallList.UclAstro25Trk_SystemAlias_A00010Value == 65535)
						{
							num = (short)1989672969;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.FeatureNode referencedNode = this.CallList.UclAstro25Trk_SystemAlias_A00010Object.ReferencedNode;
						num = (short)1810104331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_43F;
					case 7:
						return result;
					case 8:
					{
						global::AcpBusinessLayer.FeatureNode referencedNode;
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = referencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
						result = string.Concat(new string[]
						{
							trunkingSystem.General.TrkSysGeneralHomeWACNID_A8205.ToString(),
							global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꆋ", a_),
							trunkingSystem.General.TrkSysGeneralSystemID_A9239.ToString(),
							global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꆋ", a_),
							this.CallList.UclAstro25Trk_IndividualID_A00013Object.ToString()
						});
						num = (short)1685782529;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_177;
					case 10:
						num = (short)1501233165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						global::AcpBusinessLayer.FeatureNode referencedNode;
						if (referencedNode != null)
						{
							num = (short)1308033032;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = this.CallList.UclAstro25Trk_SystemAlias_A00010Object.InvalidText;
						num = (short)724238343;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						if (this.CallList.UclAstro25Trk_HomeSystemID_A00012Object != null)
						{
							num = (short)1735720970;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48D;
					case 13:
						num = (short)183304193;
						if (num != 0)
						{
						}
						if (this.CallList.UclAstro25Trk_IndividualID_A00013Object != null)
						{
							num = (short)1337131022;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48D;
					case 14:
						result = string.Empty;
						num = (short)1668284433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						switch (0)
						{
						case 0:
							goto IL_76;
						}
						continue;
					case 16:
						result = string.Concat(new string[]
						{
							global::CommonResources.AppResources.Unassigned_ID,
							global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꆋ", a_),
							global::CommonResources.AppResources.Unassigned_ID,
							global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꆋ", a_),
							this.CallList.UclAstro25Trk_IndividualID_A00013Object.ToString()
						});
						num = (short)844693507;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						if (this.CallList.UclAstro25Trk_SystemAlias_A00010Value == 0)
						{
							num = (short)1337458704;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1279983036;
						short num3 = num;
						num = (short)1822227900;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_177;
						default:
							num = (short)345440256;
							if (num != 0)
							{
							}
							num = (short)1818034181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_76:
					if (this.CallList != null)
					{
						num = (short)332726274;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_48D;
					IL_177:
					num = (short)1671299072;
					short num4 = num;
					result = string.Concat(new string[]
					{
						this.CallList.UclAstro25Trk_CustomizedWACNID_A00015Object.ToString(),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꆋ", a_),
						this.CallList.UclAstro25Trk_CustomizedHomeSystemID_A00016Object.ToString(),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꆋ", a_),
						this.CallList.UclAstro25Trk_IndividualID_A00013Object.ToString()
					});
					num = (short)79626246;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_323:
				IL_43F:
				return result;
				IL_48D:
				return base.FeatureName;
			}
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x00220A68 File Offset: 0x0021EC68
		internal bool IsDefaultNode()
		{
			int num;
			bool result;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						result = true;
						num2 = (short)1696137218;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						num2 = (short)406978565;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						return result;
					case 3:
						if (this.CallList.UclAstro25Trk_IndividualID_A00013Value == 0)
						{
							num2 = (short)1080295424;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 4:
						if (this.CallList != null)
						{
							num2 = (short)1255800833;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 5:
						if (this.CallList.UclAstro25Trk_SystemAlias_A00010Value == 0)
						{
							num2 = (short)2027356166;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 6:
					{
						num2 = (short)790512102;
						short num3 = num2;
						num2 = (short)1013465574;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2E;
						default:
						{
							num2 = (short)465174529;
							if (num2 != 0)
							{
							}
							num2 = (short)759824384;
							short num4 = num2;
							num2 = (short)1900871680;
							if (num2 != 0)
							{
							}
							num2 = (short)237043715;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					}
					goto IL_2C;
				}
				return result;
			}
			IL_2C:
			result = false;
			IL_2E:
			num2 = (short)1280245764;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
