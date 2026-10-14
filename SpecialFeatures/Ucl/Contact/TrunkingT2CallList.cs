using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.Contact
{
	// Token: 0x0200020D RID: 525
	[global::System.Serializable]
	public class TrunkingT2CallList : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06001A95 RID: 6805 RVA: 0x00228CF0 File Offset: 0x00226EF0
		public global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListCallListSection CallListT2
		{
			get
			{
				short num = (short)1307770880;
				short num2 = num;
				num = (short)361562113;
				if (num != 0)
				{
				}
				num = (short)1944625278;
				short num3 = num;
				num = (short)1534238846;
				switch (num3 == num)
				{
				}
				num = (short)625475584;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListCallListSection)base[10412];
			}
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x00003D8F File Offset: 0x00001F8F
		private TrunkingT2CallList() : this(null)
		{
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x00228DA8 File Offset: 0x00226FA8
		internal TrunkingT2CallList(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 5;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc87ﲋ낏\udb91\udd93뚕첗쮟쮡쪣솥袧", a_);
			base.UIName = global::CommonResources.AppResources.Type_II_Trunking_ID;
			base.AddFeatureSection(new global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListCallListSection(this));
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x00228DF0 File Offset: 0x00226FF0
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)691666944;
			short num2 = num;
			num = (short)1908097255;
			short num3 = num;
			num = (short)202457319;
			switch (num3 == num)
			{
			}
			num = (short)551747585;
			if (num != 0)
			{
			}
			num = (short)853213184;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x000038AD File Offset: 0x00001AAD
		protected TrunkingT2CallList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x00228EA4 File Offset: 0x002270A4
		internal static global::AcpCommonLib.IAcpFeatureNode GetTrunkingT2CallList()
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
					result = ((global::AcpBusinessLayer.Recordset)global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2200)).TemplateNode[10411].EmbeddedRecset[0];
					num2 = (short)775290884;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)1111162881;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1186463750;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return result;
				case 4:
					return result;
				case 5:
				{
					num2 = (short)1259995137;
					if (num2 != 0)
					{
					}
					result = ((global::AcpBusinessLayer.Recordset)global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2200)).TemplateNode[10411].EmbeddedRecset[0];
					num2 = (short)1927463434;
					short num3 = num2;
					num2 = (short)260882954;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)632553472;
						if (num2 != 0)
						{
						}
						num2 = (short)1557266432;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 6:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num2 = (short)1089208320;
						short num4 = num2;
						num2 = (short)605093893;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = ((global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(2200)).TemplateNode[10411].EmbeddedRecset[0];
					num2 = (short)1923153923;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_2C;
			}
			return result;
			IL_2C:
			result = null;
			num2 = (short)701562882;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06001A9B RID: 6811 RVA: 0x002290D0 File Offset: 0x002272D0
		public override string ReferenceKey
		{
			get
			{
				int a_ = 18;
				short num = (short)1758003205;
				int num2 = (int)((global::System.IntPtr)num);
				string result;
				for (;;)
				{
					global::AcpBusinessLayer.FeatureNode referencedNode;
					switch (num2)
					{
					case 0:
						if (this.CallListT2.UclT2Trk_IndividualID_A00019Object != null)
						{
							num = (short)1615134726;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A8;
					case 1:
						num = (short)34078720;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)1849622543;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_92;
					case 4:
						result = this.CallListT2.UclT2Trk_CustomizedSystemID_A00021Object.ToString() + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뢔", a_) + this.CallListT2.UclT2Trk_IndividualID_A00019Object.ToString();
						num = (short)1263075335;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_6E;
						}
						continue;
					case 6:
						result = string.Empty;
						num = (short)2063466509;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						return result;
					case 8:
						if (referencedNode != null)
						{
							num = (short)1028980739;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = this.CallListT2.UclT2Trk_SystemAlias_A00017Object.InvalidText;
						num = (short)2069102602;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)590807041;
						if (num != 0)
						{
						}
						if (this.CallListT2.UclT2Trk_SystemAlias_A00017Value == 65535)
						{
							num = (short)1144455172;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						referencedNode = this.CallListT2.UclT2Trk_SystemAlias_A00017Object.ReferencedNode;
						num = (short)1625030664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						return result;
					case 11:
						return result;
					case 12:
					{
						num = (short)548349182;
						short num3 = num;
						num = (short)1828988158;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_92;
						default:
						{
							num = (short)1136721920;
							if (num != 0)
							{
							}
							result = global::CommonResources.AppResources.Unassigned_ID + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뢔", a_) + this.CallListT2.UclT2Trk_IndividualID_A00019Object.ToString();
							num = (short)1904017408;
							short num4 = num;
							num = (short)11075598;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 13:
						if (this.CallListT2.UclT2Trk_SystemAlias_A00017Value == 0)
						{
							num = (short)1511718924;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)32309257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_2ED;
					case 15:
						if (this.CallListT2.UclT2Trk_SystemID_A00018Object != null)
						{
							num = (short)1086521345;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A8;
					}
					IL_6E:
					if (this.CallListT2 != null)
					{
						num = (short)1841758210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3A8;
					IL_92:
					result = (referencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem).General.TrkSysGeneralSystemID_A9239.ToString() + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뢔", a_) + this.CallListT2.UclT2Trk_IndividualID_A00019Object.ToString();
					num = (short)839712779;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_2ED:
				return result;
				IL_3A8:
				return base.FeatureName;
			}
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x0022948C File Offset: 0x0022768C
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
					goto IL_15B;
				case 1:
					num2 = (short)634322945;
					if (num2 != 0)
					{
					}
					num2 = (short)1734934532;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (this.CallListT2 != null)
					{
						goto IL_4D;
					}
					goto IL_15B;
				case 3:
					num2 = (short)1748631558;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (this.CallListT2.UclT2Trk_SystemAlias_A00017Value == 0)
					{
						num2 = (short)386203651;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_15B;
				case 5:
				{
					num2 = (short)56557568;
					short num3 = num2;
					result = true;
					num2 = (short)588709888;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					if (this.CallListT2.UclT2Trk_IndividualID_A00019Value == 0)
					{
						num2 = (short)354156549;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_15B;
				}
				goto IL_2C;
				IL_4D:
				num2 = (short)1291517953;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_15B:
				num2 = (short)37408901;
				short num4 = num2;
				num2 = (short)1778110597;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_4D;
				default:
					goto IL_190;
				}
			}
			IL_190:
			num2 = (short)159580160;
			if (num2 != 0)
			{
			}
			return result;
			IL_2C:
			result = false;
			num2 = (short)544604162;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
