using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004EB RID: 1259
	[global::System.Serializable]
	public class QuickTextMessageList : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600A96A RID: 43370 RVA: 0x009D3DAC File Offset: 0x009D1FAC
		public QuickTextMessageList(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.DataWide.QuickTextMessageListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600A96B RID: 43371 RVA: 0x009D3DEC File Offset: 0x009D1FEC
		protected QuickTextMessageList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600A96C RID: 43372 RVA: 0x009D3E04 File Offset: 0x009D2004
		public override void Init()
		{
			int a_ = 1;
			short num = (short)2122005580;
			short num2 = num;
			num = (short)374029388;
			switch (num2 == num)
			{
			}
			num = (short)1744568321;
			if (num != 0)
			{
			}
			num = (short)107216896;
			short num3 = num;
			num = (short)613220352;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鏁뇃꿅ꯇꇉ髍뗏꫑ꃓ闗뿙꿛귝臟藡臣웥ꓧ菩鿫髭", a_);
			base.Id = 10071;
			base.UIName = global::CommonResources.AcgResources.ID_QUICKTEXTMESSAGELIST;
			base.DataTransferOrder = 5;
		}

		// Token: 0x0600A96D RID: 43373 RVA: 0x009D3EE4 File Offset: 0x009D20E4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 7;
			short num = (short)1671168001;
			if (num != 0)
			{
			}
			num = (short)560351931;
			short num2 = num;
			num = (short)592988859;
			switch (num2 == num)
			{
			}
			num = (short)1817444352;
			short num3 = num;
			num = (short)269549568;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("駇뿉ꗋ귍믏胓돕ꃗ껙ﳛ鏝藟釡韣蟥迧迩쳫ꋭ駯臱胳", a_);
			base.Id = 10071;
			base.UIName = global::CommonResources.AcgResources.ID_QUICKTEXTMESSAGELIST;
			base.DataTransferOrder = 5;
		}

		// Token: 0x0600A96E RID: 43374 RVA: 0x009D3FC8 File Offset: 0x009D21C8
		public override void PopulateReferences()
		{
			short num = (short)2142396998;
			short num2 = num;
			num = (short)900620870;
			switch (num2 == num)
			{
			}
			num = (short)397672449;
			if (num != 0)
			{
			}
			num = (short)2005663744;
			short num3 = num;
			num = (short)1386414080;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A96F RID: 43375 RVA: 0x009D4070 File Offset: 0x009D2270
		public override void DropReferences()
		{
			short num = (short)1188932118;
			short num2 = num;
			num = (short)66038294;
			switch (num2 == num)
			{
			}
			num = (short)101646337;
			if (num != 0)
			{
			}
			num = (short)2128805888;
			short num3 = num;
			num = (short)1672282112;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A970 RID: 43376 RVA: 0x009D411C File Offset: 0x009D231C
		public override void SetConstraints()
		{
			short num = (short)1048500101;
			short num2 = num;
			num = (short)610457477;
			switch (num2 == num)
			{
			}
			num = (short)1103888385;
			if (num != 0)
			{
			}
			num = (short)84344832;
			short num3 = num;
			num = (short)682098688;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A971 RID: 43377 RVA: 0x009D41C8 File Offset: 0x009D23C8
		public override void SetupDependencies()
		{
			short num = (short)437264815;
			short num2 = num;
			num = (short)1392648623;
			switch (num2 == num)
			{
			}
			num = (short)831193088;
			if (num != 0)
			{
			}
			num = (short)689766400;
			short num3 = num;
			num = (short)1604845569;
			if (num != 0)
			{
			}
		}

		// Token: 0x17005518 RID: 21784
		// (get) Token: 0x0600A972 RID: 43378 RVA: 0x009D4270 File Offset: 0x009D2470
		public bool HasDiffs
		{
			get
			{
				short num = (short)966888321;
				short num2 = num;
				num = (short)1929874305;
				switch (num2 == num)
				{
				}
				num = (short)1122238465;
				if (num != 0)
				{
				}
				num = (short)41615360;
				short num3 = num;
				num = (short)435617792;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600A973 RID: 43379 RVA: 0x009D4320 File Offset: 0x009D2520
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (base.ParentRecset.ContainerDoc == null)
					{
						return result;
					}
					num2 = (short)897026484;
					short num3 = num2;
					num2 = (short)156928436;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_161;
					default:
						num2 = (short)794492928;
						if (num2 != 0)
						{
						}
						num2 = (short)1682178049;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_161;
				case 2:
					if (base.ParentRecset != null)
					{
						num2 = (short)551092227;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					num2 = (short)1684471808;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_83;
				}
				goto IL_24;
				IL_161:
				result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
				num2 = (short)1760165892;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_83:
			num2 = (short)786366465;
			if (num2 != 0)
			{
			}
			num2 = (short)1974861824;
			short num4 = num2;
			return result;
			IL_24:
			result = null;
			num2 = (short)523239426;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04005144 RID: 20804
		private global::Motorola.MackinawCPS.CoreFeatures.DataWide.QuickTextMessageListInnerRecset innerRecset;
	}
}
