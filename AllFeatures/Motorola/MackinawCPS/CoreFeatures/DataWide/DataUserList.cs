using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004CE RID: 1230
	[global::System.Serializable]
	public class DataUserList : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600A306 RID: 41734 RVA: 0x009804B0 File Offset: 0x0097E6B0
		public DataUserList(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataUserListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600A307 RID: 41735 RVA: 0x009804F0 File Offset: 0x0097E6F0
		protected DataUserList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600A308 RID: 41736 RVA: 0x00980508 File Offset: 0x0097E708
		public override void Init()
		{
			int a_ = 4;
			short num = (short)209936787;
			short num2 = num;
			num = (short)654467475;
			switch (num2 == num)
			{
			}
			num = (short)444661760;
			short num3 = num;
			num = (short)722206720;
			if (num != 0)
			{
			}
			num = (short)1670512641;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臄ꛆ뷈꫊髎ꋐ뛒꟔闘닚껜ꯞ", a_);
			base.Id = 10069;
			base.UIName = global::CommonResources.AcgResources.ID_DATAUSERLIST;
			base.DataTransferOrder = 4;
		}

		// Token: 0x0600A309 RID: 41737 RVA: 0x009805EC File Offset: 0x0097E7EC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 2;
			short num = (short)997549009;
			short num2 = num;
			num = (short)1917674449;
			switch (num2 == num)
			{
			}
			num = (short)2106851328;
			short num3 = num;
			num = (short)630587393;
			if (num != 0)
			{
			}
			num = (short)670498816;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蟂꓄돆꣈飌볎듐ꇒ鯖냘꣚꧜", a_);
			base.Id = 10069;
			base.UIName = global::CommonResources.AcgResources.ID_DATAUSERLIST;
			base.DataTransferOrder = 4;
		}

		// Token: 0x0600A30A RID: 41738 RVA: 0x009806D0 File Offset: 0x0097E8D0
		public override void PopulateReferences()
		{
			short num = (short)959905793;
			if (num != 0)
			{
			}
			num = (short)654244455;
			short num2 = num;
			num = (short)328071783;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1552285696;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1485307904;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A30B RID: 41739 RVA: 0x00980778 File Offset: 0x0097E978
		public override void DropReferences()
		{
			short num = (short)378994689;
			if (num != 0)
			{
			}
			num = (short)163899717;
			short num2 = num;
			num = (short)1889003845;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1876426752;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1771307008;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A30C RID: 41740 RVA: 0x00980824 File Offset: 0x0097EA24
		public override void SetConstraints()
		{
			short num = (short)429383889;
			short num2 = num;
			num = (short)1126949073;
			switch (num2 == num)
			{
			}
			num = (short)1361575936;
			short num3 = num;
			num = (short)1801519105;
			if (num != 0)
			{
			}
			num = (short)2138898432;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A30D RID: 41741 RVA: 0x009808D0 File Offset: 0x0097EAD0
		public override void SetupDependencies()
		{
			short num = (short)1859816039;
			short num2 = num;
			num = (short)1070828135;
			switch (num2 == num)
			{
			}
			num = (short)703004672;
			short num3 = num;
			num = (short)1183907841;
			if (num != 0)
			{
			}
			num = (short)560726016;
			if (num != 0)
			{
			}
		}

		// Token: 0x170051B5 RID: 20917
		// (get) Token: 0x0600A30E RID: 41742 RVA: 0x0098097C File Offset: 0x0097EB7C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1973939783;
				short num2 = num;
				num = (short)1076096583;
				switch (num2 == num)
				{
				}
				num = (short)2006384640;
				short num3 = num;
				num = (short)1666580480;
				if (num != 0)
				{
				}
				num = (short)10682369;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600A30F RID: 41743 RVA: 0x00980A2C File Offset: 0x0097EC2C
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			int num;
			global::AcpCommonLib.IAcpRecordset result;
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
						return result;
					case 1:
						num2 = (short)1444020225;
						if (num2 != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)737673216;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						if (base.ParentRecset != null)
						{
							num2 = (short)1379860483;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 3:
					{
						num2 = (short)2068574382;
						short num3 = num2;
						num2 = (short)217378990;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_26;
						default:
						{
							num2 = (short)2109276160;
							if (num2 != 0)
							{
							}
							num2 = (short)725811200;
							short num4 = num2;
							num2 = (short)940572676;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 4:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)160038913;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					goto IL_24;
				}
				return result;
			}
			IL_24:
			result = null;
			IL_26:
			num2 = (short)742981634;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04004E1C RID: 19996
		private global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataUserListInnerRecset innerRecset;
	}
}
