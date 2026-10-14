using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x0200000B RID: 11
	[global::System.Serializable]
	public class DataBlockType
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000036 RID: 54 RVA: 0x0000411C File Offset: 0x0000231C
		// (set) Token: 0x06000037 RID: 55 RVA: 0x000041CC File Offset: 0x000023CC
		[global::System.Xml.Serialization.XmlAttribute("PartitionID")]
		public byte PartitionID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2077901827;
				short num2 = num;
				num = (short)753222659;
				switch (num2 == num)
				{
				}
				num = (short)493223936;
				if (num != 0)
				{
				}
				num = (short)1003487233;
				if (num != 0)
				{
				}
				num = (short)1603403776;
				short num3 = num;
				return this.<PartitionID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2043543553;
				if (num != 0)
				{
				}
				num = (short)1347626937;
				short num2 = num;
				num = (short)1923884985;
				switch (num2 == num)
				{
				}
				num = (short)1892614144;
				if (num != 0)
				{
				}
				num = (short)85131264;
				short num3 = num;
				this.<PartitionID>k__BackingField = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00004278 File Offset: 0x00002478
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00004328 File Offset: 0x00002528
		[global::System.Xml.Serialization.XmlAttribute("TypeID")]
		public ushort TypeID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1651671298;
				short num2 = num;
				num = (short)83067138;
				switch (num2 == num)
				{
				default:
				{
					num = (short)119865344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1096810497;
				if (num != 0)
				{
				}
				num = (short)1506869248;
				if (num != 0)
				{
				}
				return this.<TypeID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)169327229;
				short num2 = num;
				num = (short)605665917;
				switch (num2 == num)
				{
				default:
				{
					num = (short)131727360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1349255168;
				if (num != 0)
				{
				}
				num = (short)413270017;
				if (num != 0)
				{
				}
				this.<TypeID>k__BackingField = value;
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000043D8 File Offset: 0x000025D8
		public DataBlockType()
		{
			this.PartitionID = 0;
			this.TypeID = 0;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000043FC File Offset: 0x000025FC
		public DataBlockType(byte partitionID, ushort typeID)
		{
			this.PartitionID = partitionID;
			this.TypeID = typeID;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00004420 File Offset: 0x00002620
		public override bool Equals(object obj)
		{
			short num = (short)472383493;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.Common.Communication.Pba.DataBlockType dataBlockType;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.PartitionID == dataBlockType.PartitionID)
					{
						num = (short)269352964;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
					goto IL_A5;
				case 2:
					dataBlockType = (global::Motorola.Common.Communication.Pba.DataBlockType)obj;
					num = (short)550699008;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)990248961;
					if (num != 0)
					{
					}
					if (obj is global::Motorola.Common.Communication.Pba.DataBlockType)
					{
						num = (short)975831042;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 4:
					goto IL_124;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				}
				IL_3D:
				num = (short)253485715;
				short num3 = num;
				num = (short)1804329619;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)562888704;
					if (num != 0)
					{
					}
					if (this != obj)
					{
						num = (short)1986330627;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				num = (short)928448513;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A5:
			num = (short)287899648;
			short num4 = num;
			return true;
			IL_124:
			return this.TypeID == dataBlockType.TypeID;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000045C0 File Offset: 0x000027C0
		public override int GetHashCode()
		{
			short num = (short)879476688;
			short num2 = num;
			num = (short)442744784;
			switch (num2 == num)
			{
			default:
			{
				num = (short)239796224;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1729691648;
			if (num != 0)
			{
			}
			num = (short)61800449;
			if (num != 0)
			{
			}
			return base.GetHashCode();
		}
	}
}
