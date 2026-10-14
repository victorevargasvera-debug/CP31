using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000030 RID: 48
	[global::System.Serializable]
	public class TypeLevelChangeDiscovery
	{
		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600019A RID: 410 RVA: 0x0001A8A8 File Offset: 0x00018AA8
		// (set) Token: 0x0600019B RID: 411 RVA: 0x0001A95C File Offset: 0x00018B5C
		[global::System.Xml.Serialization.XmlAttribute("Partition")]
		public byte IshPartition
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)427259738;
				short num2 = num;
				num = (short)1496348506;
				switch (num2 == num)
				{
				}
				num = (short)406126593;
				if (num != 0)
				{
				}
				num = (short)865665024;
				short num3 = num;
				num = (short)399376384;
				if (num != 0)
				{
				}
				return this.<IshPartition>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1198213258;
				short num2 = num;
				num = (short)1998276746;
				switch (num2 == num)
				{
				}
				num = (short)1701576704;
				if (num != 0)
				{
				}
				num = (short)1876164608;
				short num3 = num;
				num = (short)259522561;
				if (num != 0)
				{
				}
				this.<IshPartition>k__BackingField = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600019C RID: 412 RVA: 0x0001AA0C File Offset: 0x00018C0C
		// (set) Token: 0x0600019D RID: 413 RVA: 0x0001AABC File Offset: 0x00018CBC
		[global::System.Xml.Serialization.XmlAttribute("Type")]
		public ushort IshType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1823543313;
				short num2 = num;
				num = (short)1000476689;
				switch (num2 == num)
				{
				}
				num = (short)1768882176;
				if (num != 0)
				{
				}
				num = (short)2052784128;
				short num3 = num;
				num = (short)1367605249;
				if (num != 0)
				{
				}
				return this.<IshType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2088525302;
				short num2 = num;
				num = (short)925064694;
				switch (num2 == num)
				{
				}
				num = (short)124125185;
				if (num != 0)
				{
				}
				num = (short)962920448;
				short num3 = num;
				num = (short)1820983296;
				if (num != 0)
				{
				}
				this.<IshType>k__BackingField = value;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600019E RID: 414 RVA: 0x0001AB70 File Offset: 0x00018D70
		// (set) Token: 0x0600019F RID: 415 RVA: 0x0001AC20 File Offset: 0x00018E20
		[global::System.Xml.Serialization.XmlAttribute("Counter")]
		public uint Counter
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)252441244;
				short num2 = num;
				num = (short)1720644252;
				switch (num2 == num)
				{
				}
				num = (short)435617792;
				if (num != 0)
				{
				}
				num = (short)20381696;
				short num3 = num;
				num = (short)1815019521;
				if (num != 0)
				{
				}
				return this.<Counter>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)155701242;
				short num2 = num;
				num = (short)788779002;
				switch (num2 == num)
				{
				}
				num = (short)2063073281;
				if (num != 0)
				{
				}
				num = (short)1781006336;
				short num3 = num;
				num = (short)585170944;
				if (num != 0)
				{
				}
				this.<Counter>k__BackingField = value;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x0001ACD0 File Offset: 0x00018ED0
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x0001AD80 File Offset: 0x00018F80
		[global::System.Xml.Serialization.XmlAttribute("IsModified")]
		public bool IsModified
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2115286201;
				short num2 = num;
				num = (short)2071508153;
				switch (num2 == num)
				{
				}
				num = (short)1596456961;
				if (num != 0)
				{
				}
				num = (short)639238144;
				short num3 = num;
				num = (short)775356416;
				if (num != 0)
				{
				}
				return this.<IsModified>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1380796662;
				short num2 = num;
				num = (short)1831946486;
				switch (num2 == num)
				{
				}
				num = (short)13959169;
				if (num != 0)
				{
				}
				num = (short)921829376;
				short num3 = num;
				num = (short)1228144640;
				if (num != 0)
				{
				}
				this.<IsModified>k__BackingField = value;
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0001AE2C File Offset: 0x0001902C
		public TypeLevelChangeDiscovery()
		{
			this.IshPartition = 0;
			this.IshType = 0;
			this.Counter = 0U;
			this.IsModified = false;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0001AE5C File Offset: 0x0001905C
		public TypeLevelChangeDiscovery(byte partition, ushort ishType, uint counter = 0U, bool isModified = false)
		{
			this.IshPartition = partition;
			this.IshType = ishType;
			this.Counter = counter;
			this.IsModified = isModified;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0001AE8C File Offset: 0x0001908C
		public override bool Equals(object obj)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery typeLevelChangeDiscovery;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (this.IshPartition == typeLevelChangeDiscovery.IshPartition)
					{
						num2 = (short)2076377089;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 1:
					num2 = (short)666304516;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return false;
				case 3:
					goto IL_11C;
				case 4:
					goto IL_F4;
				case 5:
					if (typeLevelChangeDiscovery == null)
					{
						num2 = (short)143851522;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)91947008;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_28;
			}
			return false;
			IL_F4:
			if (this.IshType == typeLevelChangeDiscovery.IshType)
			{
				goto IL_105;
			}
			return false;
			IL_11C:
			num2 = (short)1072168960;
			short num3 = num2;
			return this.Counter == typeLevelChangeDiscovery.Counter;
			IL_28:
			num2 = (short)1802152615;
			short num4 = num2;
			num2 = (short)399157927;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_105:
				num2 = (short)1670119427;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)609222656;
				if (num2 != 0)
				{
				}
				num2 = (short)1429864449;
				if (num2 != 0)
				{
				}
				typeLevelChangeDiscovery = (obj as global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery);
				num2 = (short)811597829;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0001B038 File Offset: 0x00019238
		public override int GetHashCode()
		{
			short num = (short)1280573197;
			short num2 = num;
			num = (short)1290665741;
			switch (num2 == num)
			{
			}
			num = (short)140378113;
			if (num != 0)
			{
			}
			num = (short)844365824;
			if (num != 0)
			{
			}
			num = (short)127401984;
			short num3 = num;
			return this.IshPartition.GetHashCode() ^ this.IshType.GetHashCode() ^ this.Counter.GetHashCode();
		}
	}
}
