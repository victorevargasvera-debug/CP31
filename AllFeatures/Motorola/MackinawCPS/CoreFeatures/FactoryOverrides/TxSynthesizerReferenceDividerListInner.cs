using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.FactoryOverrides
{
	// Token: 0x0200046B RID: 1131
	[global::System.Serializable]
	public class TxSynthesizerReferenceDividerListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17004B31 RID: 19249
		// (get) Token: 0x060095A7 RID: 38311 RVA: 0x008CA4CC File Offset: 0x008C86CC
		public global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSynthesizerReferenceDividerListInnerSection TxSynthesizerReferenceDividerListInnerSection
		{
			get
			{
				short num = (short)1485594583;
				short num2 = num;
				num = (short)155279319;
				switch (num2 == num)
				{
				default:
				{
					num = (short)296157184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1993736192;
				if (num != 0)
				{
				}
				num = (short)957480961;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSynthesizerReferenceDividerListInnerSection)base[10009];
			}
		}

		// Token: 0x060095A8 RID: 38312 RVA: 0x008CA584 File Offset: 0x008C8784
		public TxSynthesizerReferenceDividerListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 6;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鏆뇈黌뛎뿐꟒뷔닖꫘닚Ƛ뫞鏠쏢럤苦迨軪鿬諮鿰郲郴ퟶ뷸鋺诼雾攀昂眄✆䔈戊縌笎", a_);
			base.UIName = global::CommonResources.AcgResources.ID_TXSYNTHESIZERREFERENCEDIVIDERLIST;
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSynthesizerReferenceDividerListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSynthesizerReferenceDividerListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x060095A9 RID: 38313 RVA: 0x008CA5D0 File Offset: 0x008C87D0
		protected TxSynthesizerReferenceDividerListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 14;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鯎꧐蛔껖럘꿚뗜뫞鋠諢鿤苦鯨쯪뿬諮韰雲蟴鋶韸飺飼\udffe䔀樂猄渆洈渊缌⼎崐稒昔挖", a_);
		}
	}
}
