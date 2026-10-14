using System;
using System.Globalization;
using System.Runtime.Serialization;
using Motorola.Common.Communication.CommonUtil.Extensions;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200004A RID: 74
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public struct IshHeader : global::System.IComparable<global::Motorola.Common.Communication.CommonUtil.IshHeader>
	{
		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00020408 File Offset: 0x0001E608
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x000204B8 File Offset: 0x0001E6B8
		[global::System.Runtime.Serialization.DataMember]
		public byte PartitionNumber
		{
			get
			{
				short num = (short)1875836929;
				if (num != 0)
				{
				}
				num = (short)276340236;
				short num2 = num;
				num = (short)1642438156;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1721303040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1609433088;
				if (num != 0)
				{
				}
				return this.m_PartitionNumber;
			}
			set
			{
				short num = (short)598781367;
				short num2 = num;
				num = (short)657436087;
				switch (num2 == num)
				{
				}
				num = (short)1140719616;
				short num3 = num;
				num = (short)926154752;
				if (num != 0)
				{
				}
				num = (short)564068353;
				if (num != 0)
				{
				}
				this.m_PartitionNumber = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00020568 File Offset: 0x0001E768
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x00020618 File Offset: 0x0001E818
		[global::System.Runtime.Serialization.DataMember]
		public ushort IshType
		{
			get
			{
				short num = (short)708247553;
				if (num != 0)
				{
				}
				num = (short)1483272842;
				short num2 = num;
				num = (short)1507062410;
				switch (num2 == num)
				{
				default:
				{
					num = (short)520421376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)215482368;
				if (num != 0)
				{
				}
				return this.m_IshType;
			}
			set
			{
				short num = (short)847085105;
				short num2 = num;
				num = (short)1696890417;
				switch (num2 == num)
				{
				}
				num = (short)1166344192;
				short num3 = num;
				num = (short)1972961281;
				if (num != 0)
				{
				}
				num = (short)386531328;
				if (num != 0)
				{
				}
				this.m_IshType = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x000206C8 File Offset: 0x0001E8C8
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x00020778 File Offset: 0x0001E978
		[global::System.Runtime.Serialization.DataMember]
		public ushort IshID
		{
			get
			{
				short num = (short)1052228904;
				short num2 = num;
				num = (short)268352808;
				switch (num2 == num)
				{
				}
				num = (short)1605632000;
				short num3 = num;
				num = (short)1366622208;
				if (num != 0)
				{
				}
				num = (short)726728705;
				if (num != 0)
				{
				}
				return this.m_IshID;
			}
			set
			{
				short num = (short)2008007969;
				short num2 = num;
				num = (short)169854241;
				switch (num2 == num)
				{
				}
				num = (short)2045837312;
				short num3 = num;
				num = (short)1969094657;
				if (num != 0)
				{
				}
				num = (short)1076756480;
				if (num != 0)
				{
				}
				this.m_IshID = value;
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00020828 File Offset: 0x0001EA28
		public IshHeader(byte partitionNumber, ushort ishType, ushort ishId)
		{
			this.m_PartitionNumber = partitionNumber;
			this.m_IshType = ishType;
			this.m_IshID = ishId;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0002084C File Offset: 0x0001EA4C
		public override int GetHashCode()
		{
			short num = (short)1239875585;
			if (num != 0)
			{
			}
			num = (short)2046598025;
			short num2 = num;
			num = (short)1627626377;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1177616384;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1366491136;
			if (num != 0)
			{
			}
			uint num4 = (uint)((ulong)((uint)((ulong)((uint)((ulong)((uint)((ulong)((-2128831035 ^ (int)this.m_PartitionNumber) * 16777619) ^ (ulong)((long)(this.m_IshType >> 8 & 255))) * 16777619U) ^ (ulong)((long)(this.m_IshType & 255))) * 16777619U) ^ (ulong)((long)(this.m_IshID >> 8 & 255))) * 16777619U) ^ (ulong)((long)(this.m_IshID & 255))) * 16777619U;
			uint num5 = num4 + (num4 << 13);
			uint num6 = num5 ^ num5 >> 7;
			uint num7 = num6 + (num6 << 3);
			uint num8 = num7 ^ num7 >> 17;
			return (int)(num8 + (num8 << 5));
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0002097C File Offset: 0x0001EB7C
		public override string ToString()
		{
			int a_ = 5;
			short num = (short)129040385;
			if (num != 0)
			{
			}
			num = (short)1117444435;
			short num2 = num;
			num = (short)738449747;
			switch (num2 == num)
			{
			default:
			{
				num = (short)695074816;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)197263360;
			if (num != 0)
			{
			}
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("夈樊缌笎砐朒簔砖眘☚昜⼞尠༢Ԥ猦倨嬪䠬ሮ䨰Ȳ䠴ᬶᤸ爺礼Ⱦ㩀煂㡄", a_), this.PartitionNumber, this.IshType, this.IshID);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00020A68 File Offset: 0x0001EC68
		public override bool Equals(object obj)
		{
			while (obj is global::Motorola.Common.Communication.CommonUtil.IshHeader)
			{
				short num = (short)1201656343;
				short num2 = num;
				num = (short)953930263;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)452067328;
					short num3 = num;
					num = (short)604438529;
					if (num != 0)
					{
					}
					num = (short)1501757440;
					if (num != 0)
					{
					}
					global::Motorola.Common.Communication.CommonUtil.IshHeader objB = (global::Motorola.Common.Communication.CommonUtil.IshHeader)obj;
					return this == objB;
				}
				}
			}
			return false;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00020B34 File Offset: 0x0001ED34
		public int CompareTo(global::Motorola.Common.Communication.CommonUtil.IshHeader other)
		{
			short num = (short)1642570440;
			short num2 = num;
			num = (short)1170580168;
			switch (num2 == num)
			{
			}
			num = (short)1620115456;
			short num3 = num;
			num = (short)1767899137;
			if (num != 0)
			{
			}
			num = (short)1118961664;
			if (num != 0)
			{
			}
			return global::System.Math.Sign(this.Int64HeaderID - other.Int64HeaderID);
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00020BF4 File Offset: 0x0001EDF4
		[global::System.Runtime.Serialization.IgnoreDataMember]
		public long Int64HeaderID
		{
			get
			{
				short num = (short)449904641;
				if (num != 0)
				{
				}
				num = (short)264475929;
				short num2 = num;
				num = (short)1831507225;
				switch (num2 == num)
				{
				default:
				{
					num = (short)212598784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1597112320;
				if (num != 0)
				{
				}
				return (long)((ulong)this.PartitionNumber << 32 | (ulong)this.IshType << 16 | (ulong)this.IshID);
			}
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00020CBC File Offset: 0x0001EEBC
		public static bool operator ==(global::Motorola.Common.Communication.CommonUtil.IshHeader objA, global::Motorola.Common.Communication.CommonUtil.IshHeader objB)
		{
			short num = (short)677314561;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1851260928;
				short num3 = num;
				num = (short)1242038273;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					num = (short)88014851;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_85;
					}
					continue;
				case 2:
					goto IL_14E;
				case 3:
				{
					num = (short)233522599;
					short num4 = num;
					num = (short)1125598631;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
						num = (short)419823616;
						if (num != 0)
						{
						}
						if (objA.IshType == objB.IshType)
						{
							num = (short)1568800770;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					break;
				}
				}
				IL_85:
				if (objA.PartitionNumber != objB.PartitionNumber)
				{
					return false;
				}
				num = (short)385810432;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_14E:
			return objA.IshID == objB.IshID;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00020E20 File Offset: 0x0001F020
		public static bool operator !=(global::Motorola.Common.Communication.CommonUtil.IshHeader objA, global::Motorola.Common.Communication.CommonUtil.IshHeader objB)
		{
			short num = (short)2144421928;
			short num2 = num;
			num = (short)1994344488;
			switch (num2 == num)
			{
			}
			num = (short)2041774081;
			if (num != 0)
			{
			}
			num = (short)1730412544;
			if (num != 0)
			{
			}
			num = (short)1846870016;
			short num3 = num;
			return !(objA == objB);
		}

		// Token: 0x040001C8 RID: 456
		private byte m_PartitionNumber;

		// Token: 0x040001C9 RID: 457
		private ushort m_IshType;

		// Token: 0x040001CA RID: 458
		private ushort m_IshID;
	}
}
