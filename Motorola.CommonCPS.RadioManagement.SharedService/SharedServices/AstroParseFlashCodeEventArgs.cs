using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000080 RID: 128
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class AstroParseFlashCodeEventArgs : global::System.EventArgs
	{
		// Token: 0x06000812 RID: 2066 RVA: 0x00060864 File Offset: 0x0005EA64
		public AstroParseFlashCodeEventArgs(string flashCode, string modelNumber)
		{
			this.FlashCode = flashCode;
			this.ModelNumber = modelNumber;
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x00060888 File Offset: 0x0005EA88
		// (set) Token: 0x06000814 RID: 2068 RVA: 0x00060934 File Offset: 0x0005EB34
		[global::System.Runtime.Serialization.DataMember]
		public string FlashCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1152803371;
				short num2 = num;
				num = (short)2050974251;
				switch (num2 == num)
				{
				}
				num = (short)1264975872;
				short num3 = num;
				num = (short)1851785217;
				if (num != 0)
				{
				}
				num = (short)811859968;
				if (num != 0)
				{
				}
				return this.<FlashCode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1703553245;
				short num2 = num;
				num = (short)480979165;
				switch (num2 == num)
				{
				}
				num = (short)2062942208;
				short num3 = num;
				num = (short)947585025;
				if (num != 0)
				{
				}
				num = (short)945553408;
				if (num != 0)
				{
				}
				this.<FlashCode>k__BackingField = value;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x000609E4 File Offset: 0x0005EBE4
		// (set) Token: 0x06000816 RID: 2070 RVA: 0x00060A94 File Offset: 0x0005EC94
		[global::System.Runtime.Serialization.DataMember]
		public string ModelNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2106246049;
				short num2 = num;
				num = (short)273204129;
				switch (num2 == num)
				{
				}
				num = (short)963248128;
				short num3 = num;
				num = (short)484376577;
				if (num != 0)
				{
				}
				num = (short)1537474560;
				if (num != 0)
				{
				}
				return this.<ModelNumber>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1112310552;
				short num2 = num;
				num = (short)810189592;
				switch (num2 == num)
				{
				}
				num = (short)865075200;
				short num3 = num;
				num = (short)374013953;
				if (num != 0)
				{
				}
				num = (short)1951203328;
				if (num != 0)
				{
				}
				this.<ModelNumber>k__BackingField = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x00060B48 File Offset: 0x0005ED48
		// (set) Token: 0x06000818 RID: 2072 RVA: 0x00060BF8 File Offset: 0x0005EDF8
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.Dictionary<int, string> FeatureTagNameList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1851826189;
				short num2 = num;
				num = (short)986423309;
				switch (num2 == num)
				{
				}
				num = (short)159580160;
				short num3 = num;
				num = (short)509870081;
				if (num != 0)
				{
				}
				num = (short)180486144;
				if (num != 0)
				{
				}
				return this.<FeatureTagNameList>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)253355288;
				short num2 = num;
				num = (short)411231512;
				switch (num2 == num)
				{
				}
				num = (short)1568800768;
				short num3 = num;
				num = (short)2144403457;
				if (num != 0)
				{
				}
				num = (short)1701969920;
				if (num != 0)
				{
				}
				this.<FeatureTagNameList>k__BackingField = value;
			}
		}
	}
}
