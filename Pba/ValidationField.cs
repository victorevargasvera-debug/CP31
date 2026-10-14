using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000034 RID: 52
	[global::System.Diagnostics.DebuggerDisplay("PrtID={PartitionID}, BlkTyp={BlockType}, BlkID={BlockID}, Content={Content.Length} bytes")]
	[global::System.Serializable]
	public class ValidationField
	{
		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x0001B8C8 File Offset: 0x00019AC8
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x0001B97C File Offset: 0x00019B7C
		[global::System.Xml.Serialization.XmlAttribute("Partition")]
		public byte PartitionID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)176978321;
				short num2 = num;
				num = (short)527530385;
				switch (num2 == num)
				{
				}
				num = (short)2144075777;
				if (num != 0)
				{
				}
				num = (short)779026432;
				if (num != 0)
				{
				}
				num = (short)915144704;
				short num3 = num;
				return this.<PartitionID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)993570192;
				short num2 = num;
				num = (short)978693520;
				switch (num2 == num)
				{
				}
				num = (short)481558529;
				if (num != 0)
				{
				}
				num = (short)1282932736;
				if (num != 0)
				{
				}
				num = (short)304611328;
				short num3 = num;
				this.<PartitionID>k__BackingField = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x0001BA2C File Offset: 0x00019C2C
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x0001BADC File Offset: 0x00019CDC
		[global::System.Xml.Serialization.XmlAttribute("BlockType")]
		public ushort BlockType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1743026660;
				short num2 = num;
				num = (short)1433893348;
				switch (num2 == num)
				{
				}
				num = (short)525205504;
				if (num != 0)
				{
				}
				num = (short)1461321729;
				if (num != 0)
				{
				}
				num = (short)2012217344;
				short num3 = num;
				return this.<BlockType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2061830569;
				short num2 = num;
				num = (short)1877871017;
				switch (num2 == num)
				{
				}
				num = (short)431947777;
				if (num != 0)
				{
				}
				num = (short)1000538112;
				if (num != 0)
				{
				}
				num = (short)299892736;
				short num3 = num;
				this.<BlockType>k__BackingField = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x0001BB8C File Offset: 0x00019D8C
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x0001BC3C File Offset: 0x00019E3C
		[global::System.Xml.Serialization.XmlAttribute("BlockID")]
		public ushort BlockID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1951858689;
				if (num != 0)
				{
				}
				num = (short)728472019;
				short num2 = num;
				num = (short)597662163;
				switch (num2 == num)
				{
				}
				num = (short)822935552;
				if (num != 0)
				{
				}
				num = (short)694091776;
				short num3 = num;
				return this.<BlockID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)449750236;
				short num2 = num;
				num = (short)512861404;
				switch (num2 == num)
				{
				}
				num = (short)1377828865;
				if (num != 0)
				{
				}
				num = (short)400228352;
				if (num != 0)
				{
				}
				num = (short)2109407232;
				short num3 = num;
				this.<BlockID>k__BackingField = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x0001BCEC File Offset: 0x00019EEC
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x0001BD98 File Offset: 0x00019F98
		[global::System.Xml.Serialization.XmlAttribute("OffsetInBits")]
		public uint OffsetInBits
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1231064575;
				short num2 = num;
				num = (short)938839551;
				switch (num2 == num)
				{
				}
				num = (short)217382913;
				if (num != 0)
				{
				}
				num = (short)452919296;
				if (num != 0)
				{
				}
				num = (short)1673265152;
				short num3 = num;
				return this.<OffsetInBits>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)42081777;
				short num2 = num;
				num = (short)302128625;
				switch (num2 == num)
				{
				}
				num = (short)1454178304;
				if (num != 0)
				{
				}
				num = (short)1067057153;
				if (num != 0)
				{
				}
				num = (short)154075136;
				short num3 = num;
				this.<OffsetInBits>k__BackingField = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x0001BE4C File Offset: 0x0001A04C
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x0001BEFC File Offset: 0x0001A0FC
		[global::System.Xml.Serialization.XmlAttribute("LengthInBits")]
		public uint LengthInBits
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1847718884;
				short num2 = num;
				num = (short)1478685668;
				switch (num2 == num)
				{
				}
				num = (short)132382721;
				if (num != 0)
				{
				}
				num = (short)566689792;
				if (num != 0)
				{
				}
				num = (short)1566375936;
				short num3 = num;
				return this.<LengthInBits>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)938509140;
				short num2 = num;
				num = (short)1341293396;
				switch (num2 == num)
				{
				}
				num = (short)1632698368;
				if (num != 0)
				{
				}
				num = (short)1472200705;
				if (num != 0)
				{
				}
				num = (short)1397358592;
				short num3 = num;
				this.<LengthInBits>k__BackingField = value;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001BA RID: 442 RVA: 0x0001BFB0 File Offset: 0x0001A1B0
		// (set) Token: 0x060001BB RID: 443 RVA: 0x0001C060 File Offset: 0x0001A260
		[global::System.Xml.Serialization.XmlElement("Content")]
		public byte[] Content
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1073872897;
				if (num != 0)
				{
				}
				num = (short)503836150;
				short num2 = num;
				num = (short)2119101942;
				switch (num2 == num)
				{
				}
				num = (short)487456768;
				if (num != 0)
				{
				}
				num = (short)526909440;
				short num3 = num;
				return this.<Content>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)267518855;
				short num2 = num;
				num = (short)456983431;
				switch (num2 == num)
				{
				}
				num = (short)1739390976;
				if (num != 0)
				{
				}
				num = (short)841744385;
				if (num != 0)
				{
				}
				num = (short)334692352;
				short num3 = num;
				this.<Content>k__BackingField = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001BC RID: 444 RVA: 0x0001C114 File Offset: 0x0001A314
		// (set) Token: 0x060001BD RID: 445 RVA: 0x0001C1C4 File Offset: 0x0001A3C4
		[global::System.Xml.Serialization.XmlElement("BypassMissing")]
		public bool BypassMissing
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)227726844;
				short num2 = num;
				num = (short)780129788;
				switch (num2 == num)
				{
				}
				num = (short)323682304;
				if (num != 0)
				{
				}
				num = (short)348913665;
				if (num != 0)
				{
				}
				num = (short)1752694784;
				short num3 = num;
				return this.<BypassMissing>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1973346796;
				short num2 = num;
				num = (short)1064231404;
				switch (num2 == num)
				{
				}
				num = (short)1082195969;
				if (num != 0)
				{
				}
				num = (short)679149568;
				if (num != 0)
				{
				}
				num = (short)897777664;
				short num3 = num;
				this.<BypassMissing>k__BackingField = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001BE RID: 446 RVA: 0x0001C274 File Offset: 0x0001A474
		// (set) Token: 0x060001BF RID: 447 RVA: 0x0001C324 File Offset: 0x0001A524
		[global::System.Xml.Serialization.XmlElement("AutoFill")]
		public bool AutoFill
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)245232550;
				short num2 = num;
				num = (short)410973094;
				switch (num2 == num)
				{
				}
				num = (short)1153892353;
				if (num != 0)
				{
				}
				num = (short)491388928;
				if (num != 0)
				{
				}
				num = (short)1371406336;
				short num3 = num;
				return this.<AutoFill>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1565647623;
				short num2 = num;
				num = (short)1133568775;
				switch (num2 == num)
				{
				}
				num = (short)1398472705;
				if (num != 0)
				{
				}
				num = (short)1464401920;
				if (num != 0)
				{
				}
				num = (short)1533149184;
				short num3 = num;
				this.<AutoFill>k__BackingField = value;
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0001C3D4 File Offset: 0x0001A5D4
		public ValidationField()
		{
			this.PartitionID = 0;
			this.BlockType = 0;
			this.BlockID = 0;
			this.OffsetInBits = 0U;
			this.LengthInBits = 0U;
			this.Content = null;
			this.BypassMissing = false;
			this.AutoFill = false;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0001C420 File Offset: 0x0001A620
		public ValidationField(byte partitionID, ushort blockType, ushort blockID, uint offsetInBits, uint lengthInBits, byte[] content, bool bypassMissing = false, global::Motorola.Common.CustomException.CommonErrorCode errorToThrow = global::Motorola.Common.CustomException.CommonErrorCode.None)
		{
			this.PartitionID = partitionID;
			this.BlockType = blockType;
			this.BlockID = blockID;
			this.OffsetInBits = offsetInBits;
			this.LengthInBits = lengthInBits;
			this.Content = content;
			this.BypassMissing = bypassMissing;
			this.ErrorToThrow = errorToThrow;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0001C470 File Offset: 0x0001A670
		public ValidationField(global::Motorola.Common.Communication.Pba.ValidationField field)
		{
			this.PartitionID = field.PartitionID;
			this.BlockType = field.BlockType;
			this.BlockID = field.BlockID;
			this.OffsetInBits = field.OffsetInBits;
			this.LengthInBits = field.LengthInBits;
			this.Content = field.Content;
			this.BypassMissing = field.BypassMissing;
			this.ErrorToThrow = field.ErrorToThrow;
			this.BypassValidateWiredJob = field.BypassValidateWiredJob;
			this.AutoFill = field.AutoFill;
		}

		// Token: 0x04000137 RID: 311
		[global::System.Runtime.Serialization.OptionalField]
		[global::System.Xml.Serialization.XmlAttribute("ErrorToThrow")]
		public global::Motorola.Common.CustomException.CommonErrorCode ErrorToThrow;

		// Token: 0x04000138 RID: 312
		[global::System.Xml.Serialization.XmlAttribute("BypassValidateWiredJob")]
		[global::System.Runtime.Serialization.OptionalField]
		public global::Motorola.Common.Communication.Pba.ValidateCode BypassValidateWiredJob;
	}
}
