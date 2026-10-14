using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000162 RID: 354
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class PCRSiteSelectionList
	{
		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06001364 RID: 4964 RVA: 0x000CE2A4 File Offset: 0x000CC4A4
		// (set) Token: 0x06001365 RID: 4965 RVA: 0x000CE354 File Offset: 0x000CC554
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRSiteSelection> PCRSiteSelections
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1946746880;
				short num2 = num;
				num = (short)2039742465;
				if (num != 0)
				{
				}
				num = (short)19857103;
				short num3 = num;
				num = (short)306970319;
				switch (num3 == num)
				{
				}
				num = (short)1708326912;
				if (num != 0)
				{
				}
				return this.<PCRSiteSelections>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1427439616;
				short num2 = num;
				num = (short)905474446;
				short num3 = num;
				num = (short)2001170830;
				switch (num3 == num)
				{
				}
				num = (short)219873281;
				if (num != 0)
				{
				}
				num = (short)852819968;
				if (num != 0)
				{
				}
				this.<PCRSiteSelections>k__BackingField = value;
			}
		}
	}
}
