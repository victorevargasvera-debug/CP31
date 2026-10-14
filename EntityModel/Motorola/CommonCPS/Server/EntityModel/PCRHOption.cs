using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020001B6 RID: 438
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class PCRHOption : global::Motorola.CommonCPS.Server.EntityModel.HOption
	{
		// Token: 0x060016AD RID: 5805 RVA: 0x000F3D84 File Offset: 0x000F1F84
		public PCRHOption()
		{
			this.IsFree = false;
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x060016AE RID: 5806 RVA: 0x000F3DA0 File Offset: 0x000F1FA0
		// (set) Token: 0x060016AF RID: 5807 RVA: 0x000F3E50 File Offset: 0x000F2050
		[global::System.Xml.Serialization.XmlAttribute("f")]
		[global::System.Runtime.Serialization.DataMember]
		public bool IsFree
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1323106304;
				short num2 = num;
				num = (short)112908575;
				short num3 = num;
				num = (short)1783159071;
				switch (num3 == num)
				{
				}
				num = (short)1586823169;
				if (num != 0)
				{
				}
				num = (short)1108344832;
				if (num != 0)
				{
				}
				return this.<IsFree>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)606601216;
				short num2 = num;
				num = (short)277726031;
				short num3 = num;
				num = (short)1323680591;
				switch (num3 == num)
				{
				}
				num = (short)1877868545;
				if (num != 0)
				{
				}
				num = (short)1983709184;
				if (num != 0)
				{
				}
				this.<IsFree>k__BackingField = value;
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x060016B0 RID: 5808 RVA: 0x000F3F04 File Offset: 0x000F2104
		// (set) Token: 0x060016B1 RID: 5809 RVA: 0x000F3FB4 File Offset: 0x000F21B4
		[global::System.Xml.Serialization.XmlAttribute("v")]
		[global::System.Runtime.Serialization.DataMember]
		public bool Visible
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)968425472;
				short num2 = num;
				num = (short)811978062;
				short num3 = num;
				num = (short)1586351438;
				switch (num3 == num)
				{
				}
				num = (short)176095233;
				if (num != 0)
				{
				}
				num = (short)675741696;
				if (num != 0)
				{
				}
				return this.<Visible>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)459276288;
				short num2 = num;
				num = (short)702866682;
				short num3 = num;
				num = (short)1481041146;
				switch (num3 == num)
				{
				}
				num = (short)2033254401;
				if (num != 0)
				{
				}
				num = (short)1174798336;
				if (num != 0)
				{
				}
				this.<Visible>k__BackingField = value;
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x060016B2 RID: 5810 RVA: 0x000F4064 File Offset: 0x000F2264
		// (set) Token: 0x060016B3 RID: 5811 RVA: 0x000F4110 File Offset: 0x000F2310
		[global::System.Xml.Serialization.XmlAttribute("p")]
		[global::System.Runtime.Serialization.DataMember]
		public string ParentOptionID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)988610560;
				short num2 = num;
				num = (short)565332875;
				short num3 = num;
				num = (short)590039947;
				switch (num3 == num)
				{
				}
				num = (short)1881669632;
				if (num != 0)
				{
				}
				num = (short)1670447105;
				if (num != 0)
				{
				}
				return this.<ParentOptionID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1153695744;
				short num2 = num;
				num = (short)222612830;
				short num3 = num;
				num = (short)2052246878;
				switch (num3 == num)
				{
				}
				num = (short)1434648577;
				if (num != 0)
				{
				}
				num = (short)150536192;
				if (num != 0)
				{
				}
				this.<ParentOptionID>k__BackingField = value;
			}
		}
	}
}
