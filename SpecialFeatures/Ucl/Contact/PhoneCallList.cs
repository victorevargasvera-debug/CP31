using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.Contact
{
	// Token: 0x02000202 RID: 514
	[global::System.Serializable]
	public class PhoneCallList : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06001939 RID: 6457 RVA: 0x0021753C File Offset: 0x0021573C
		public global::SpecialFeatures.Ucl.Contact.PhoneCallListCallListSection CallListPhone
		{
			get
			{
				short num = (short)1075702622;
				short num2 = num;
				num = (short)1670507358;
				switch (num2 == num)
				{
				}
				num = (short)121700352;
				short num3 = num;
				num = (short)909967361;
				if (num != 0)
				{
				}
				num = (short)287440896;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.Ucl.Contact.PhoneCallListCallListSection)base[10414];
			}
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x00003CD4 File Offset: 0x00001ED4
		private PhoneCallList() : this(null)
		{
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x002175F4 File Offset: 0x002157F4
		internal PhoneCallList(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 2;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햄꾎\udf90ﲘ", a_);
			base.UIName = global::CommonResources.AppResources.Phone_Number;
			base.AddFeatureSection(new global::SpecialFeatures.Ucl.Contact.PhoneCallListCallListSection(this));
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x0021763C File Offset: 0x0021583C
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)1591244675;
			short num2 = num;
			num = (short)736327555;
			switch (num2 == num)
			{
			}
			num = (short)373227520;
			short num3 = num;
			num = (short)912850944;
			if (num != 0)
			{
			}
			num = (short)1750335489;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x000038AD File Offset: 0x00001AAD
		protected PhoneCallList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x002176EC File Offset: 0x002158EC
		internal static global::AcpCommonLib.IAcpFeatureNode GetPhoneCallList()
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
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num2 = (short)1884553218;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = ((global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(2200)).TemplateNode[10413].EmbeddedRecset[0];
					num2 = (short)1152843779;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return result;
				case 2:
					num2 = (short)2131230721;
					if (num2 != 0)
					{
					}
					result = ((global::AcpBusinessLayer.Recordset)global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2200)).TemplateNode[10413].EmbeddedRecset[0];
					goto IL_131;
				case 3:
					return result;
				case 4:
					return result;
				case 5:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)1706622976;
						short num3 = num2;
						num2 = (short)1232076806;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1656684544;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					num2 = (short)425932978;
					short num4 = num2;
					num2 = (short)907950258;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_131;
					default:
						num2 = (short)141295616;
						if (num2 != 0)
						{
						}
						result = ((global::AcpBusinessLayer.Recordset)global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2200)).TemplateNode[10413].EmbeddedRecset[0];
						num2 = (short)1637351425;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_2C;
				IL_131:
				num2 = (short)1887043588;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_2C:
			result = null;
			num2 = (short)1119944709;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x0600193F RID: 6463 RVA: 0x00217914 File Offset: 0x00215B14
		public override string ReferenceKey
		{
			get
			{
				int a_ = 11;
				short num = (short)1080754180;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (this.CallListPhone.UclPhone_PhoneNumber_A00033Object != null)
						{
							num = (short)1643970560;
							short num3 = num;
							num = (short)1659699201;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C2;
					case 1:
						goto IL_12E;
					case 2:
						if (this.CallListPhone.UclPhone_ListinfoPhoneCategory_A00034Object != null)
						{
							num = (short)1306656771;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C2;
					case 3:
						num = (short)1961754624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_46;
						}
						continue;
					case 5:
					{
						num = (short)1931592194;
						short num4 = num;
						num = (short)1804583426;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_12E;
						default:
							num = (short)1584201728;
							if (num != 0)
							{
							}
							num = (short)882180098;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_46:
					if (this.CallListPhone == null)
					{
						goto IL_1C2;
					}
					num = (short)1575682049;
					if (num != 0)
					{
					}
					num = (short)790888453;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_12E:
				return this.CallListPhone.UclPhone_ListinfoPhoneCategory_A00034Object.ToString() + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뒍낏", a_) + this.CallListPhone.UclPhone_PhoneNumber_A00033Object.ToString();
				IL_1C2:
				return base.FeatureName;
			}
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x00217AEC File Offset: 0x00215CEC
		internal bool IsDefaultNode()
		{
			int a_ = 0;
			switch (0)
			{
			case 0:
				goto IL_35;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (this.CallListPhone.UclPhone_ListinfoPhoneCategory_A00034Value == 0)
					{
						num2 = (short)801505282;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					if (this.CallListPhone.UclPhone_PhoneNumber_A00033Value == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얂", a_))
					{
						num2 = (short)1537540099;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
				{
					num2 = (short)446167276;
					short num3 = num2;
					num2 = (short)1268644076;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_102;
					default:
						num2 = (short)1755119616;
						if (num2 != 0)
						{
						}
						result = true;
						num2 = (short)27197444;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					num2 = (short)894959616;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_102;
				case 5:
					if (this.CallListPhone != null)
					{
						num2 = (short)1792671750;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 6:
					num2 = (short)1346502657;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_35;
			}
			IL_102:
			num2 = (short)1468071936;
			short num4 = num2;
			return result;
			IL_35:
			num2 = (short)1684668417;
			if (num2 != 0)
			{
			}
			result = false;
			num2 = (short)493355013;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}
	}
}
