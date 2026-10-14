using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x0200034A RID: 842
	[global::System.Serializable]
	public class ConsolidatedActionBCOList : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008107 RID: 33031 RVA: 0x0076749C File Offset: 0x0076569C
		public ConsolidatedActionBCOList(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06008108 RID: 33032 RVA: 0x007674DC File Offset: 0x007656DC
		protected ConsolidatedActionBCOList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008109 RID: 33033 RVA: 0x007674F4 File Offset: 0x007656F4
		public override void Init()
		{
			int a_ = 7;
			short num = (short)357450658;
			short num2 = num;
			num = (short)362169250;
			switch (num2 == num)
			{
			}
			num = (short)180420609;
			if (num != 0)
			{
			}
			num = (short)1550385152;
			short num3 = num;
			num = (short)594018304;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("诇ꗉꋋ뷍뿏뻑뷓닕맗껙맛뫝샟ꏡ蟣鋥臧藩苫컭닯뇱믳훵듷鏹迻諽", a_);
			base.Id = 10622;
			base.UIName = global::CommonResources.AcgResources.ID_CONSOLIDATEDACTIONBCOLIST;
			base.DataTransferOrder = 8;
		}

		// Token: 0x0600810A RID: 33034 RVA: 0x007675D8 File Offset: 0x007657D8
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 5;
			short num = (short)138127308;
			short num2 = num;
			num = (short)222996428;
			switch (num2 == num)
			{
			}
			num = (short)218431489;
			if (num != 0)
			{
			}
			num = (short)358809600;
			short num3 = num;
			num = (short)1900085248;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("藅Ꟈ꓉뿋ꇍ볏믑냓럕곗뿙룛ﻝꇟ臡郣迥蟧蓩쳫곭돯뷱퓳뫵釷觹裻", a_);
			base.Id = 10622;
			base.UIName = global::CommonResources.AcgResources.ID_CONSOLIDATEDACTIONBCOLIST;
			base.DataTransferOrder = 8;
		}

		// Token: 0x0600810B RID: 33035 RVA: 0x007676BC File Offset: 0x007658BC
		public override void PopulateReferences()
		{
			short num = (short)281042783;
			short num2 = num;
			num = (short)675241823;
			switch (num2 == num)
			{
			}
			num = (short)1082327041;
			if (num != 0)
			{
			}
			num = (short)255000576;
			short num3 = num;
			num = (short)422969344;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600810C RID: 33036 RVA: 0x00767768 File Offset: 0x00765968
		public override void DropReferences()
		{
			short num = (short)439812097;
			if (num != 0)
			{
			}
			num = (short)99015479;
			short num2 = num;
			num = (short)256432951;
			switch (num2 == num)
			{
			}
			num = (short)677773312;
			short num3 = num;
			num = (short)862978048;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600810D RID: 33037 RVA: 0x00767810 File Offset: 0x00765A10
		public override void SetConstraints()
		{
			short num = (short)1226511502;
			short num2 = num;
			num = (short)1460081806;
			switch (num2 == num)
			{
			}
			num = (short)161218561;
			if (num != 0)
			{
			}
			num = (short)356909056;
			short num3 = num;
			num = (short)291176448;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600810E RID: 33038 RVA: 0x007678B8 File Offset: 0x00765AB8
		public override void SetupDependencies()
		{
			short num = (short)1500849498;
			short num2 = num;
			num = (short)215491930;
			switch (num2 == num)
			{
			}
			num = (short)1239416832;
			if (num != 0)
			{
			}
			num = (short)1874264064;
			short num3 = num;
			num = (short)2053570561;
			if (num != 0)
			{
			}
		}

		// Token: 0x170041F4 RID: 16884
		// (get) Token: 0x0600810F RID: 33039 RVA: 0x00767960 File Offset: 0x00765B60
		public bool HasDiffs
		{
			get
			{
				short num = (short)936237539;
				short num2 = num;
				num = (short)1837160931;
				switch (num2 == num)
				{
				}
				num = (short)1098711040;
				if (num != 0)
				{
				}
				num = (short)1839595520;
				short num3 = num;
				num = (short)1829306369;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06008110 RID: 33040 RVA: 0x00767A10 File Offset: 0x00765C10
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)1313800193;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_4A;
			}
			int num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_30:
				switch (num2)
				{
				case 0:
				{
					if (base.ParentRecset.ContainerDoc == null)
					{
						return result;
					}
					num = (short)1780023296;
					short num3 = num;
					num = (short)74297010;
					short num4 = num;
					num = (short)1135521458;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7F;
					default:
						num = (short)130351104;
						if (num != 0)
						{
						}
						num = (short)1757282307;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					return result;
				case 2:
					goto IL_7F;
				case 3:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)1462763521;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (base.ParentRecset != null)
					{
						num = (short)1796669442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				}
				goto IL_4A;
				IL_7F:
				num = (short)1651703808;
				num2 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_4A:
			result = null;
			num = (short)2036727812;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_30;
		}

		// Token: 0x040039CE RID: 14798
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset innerRecset;
	}
}
