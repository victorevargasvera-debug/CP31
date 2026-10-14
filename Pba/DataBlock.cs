using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x0200000A RID: 10
	[global::System.Serializable]
	public class DataBlock
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00003614 File Offset: 0x00001814
		// (set) Token: 0x06000028 RID: 40 RVA: 0x000036C8 File Offset: 0x000018C8
		[global::System.Xml.Serialization.XmlAttribute("Type")]
		public ushort BlockType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1005319455;
				short num2 = num;
				num = (short)543356191;
				switch (num2 == num)
				{
				}
				num = (short)338231296;
				if (num != 0)
				{
				}
				num = (short)668073985;
				if (num != 0)
				{
				}
				num = (short)347734016;
				short num3 = num;
				return this.<BlockType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)639133836;
				short num2 = num;
				num = (short)616523916;
				switch (num2 == num)
				{
				}
				num = (short)1918042112;
				if (num != 0)
				{
				}
				num = (short)736559105;
				if (num != 0)
				{
				}
				num = (short)97583104;
				short num3 = num;
				this.<BlockType>k__BackingField = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00003778 File Offset: 0x00001978
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00003828 File Offset: 0x00001A28
		[global::System.Xml.Serialization.XmlAttribute("ID")]
		public ushort BlockID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2003263021;
				short num2 = num;
				num = (short)240279085;
				switch (num2 == num)
				{
				}
				num = (short)246218752;
				if (num != 0)
				{
				}
				num = (short)373227521;
				if (num != 0)
				{
				}
				num = (short)839909376;
				short num3 = num;
				return this.<BlockID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)338808911;
				short num2 = num;
				num = (short)906350671;
				switch (num2 == num)
				{
				}
				num = (short)1089273857;
				if (num != 0)
				{
				}
				num = (short)2132606976;
				if (num != 0)
				{
				}
				num = (short)1277034496;
				short num3 = num;
				this.<BlockID>k__BackingField = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600002B RID: 43 RVA: 0x000038DC File Offset: 0x00001ADC
		// (set) Token: 0x0600002C RID: 44 RVA: 0x0000398C File Offset: 0x00001B8C
		[global::System.Xml.Serialization.XmlAttribute("Size")]
		public int LegthInBits
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)669818700;
				short num2 = num;
				num = (short)1828298572;
				switch (num2 == num)
				{
				}
				num = (short)888930305;
				if (num != 0)
				{
				}
				num = (short)1885339648;
				if (num != 0)
				{
				}
				num = (short)357367808;
				short num3 = num;
				return this.<LegthInBits>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)52203313;
				short num2 = num;
				num = (short)802787121;
				switch (num2 == num)
				{
				}
				num = (short)1216348160;
				if (num != 0)
				{
				}
				num = (short)316080129;
				if (num != 0)
				{
				}
				num = (short)1478033408;
				short num3 = num;
				this.<LegthInBits>k__BackingField = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00003A3C File Offset: 0x00001C3C
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00003AEC File Offset: 0x00001CEC
		public byte[] PacketValue
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1725482021;
				short num2 = num;
				num = (short)1418118181;
				switch (num2 == num)
				{
				}
				num = (short)34209792;
				if (num != 0)
				{
				}
				num = (short)546439169;
				if (num != 0)
				{
				}
				num = (short)2120417280;
				short num3 = num;
				return this.<PacketValue>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)652603743;
				short num2 = num;
				num = (short)124449119;
				switch (num2 == num)
				{
				}
				num = (short)509542401;
				if (num != 0)
				{
				}
				num = (short)1530462208;
				if (num != 0)
				{
				}
				num = (short)832045056;
				short num3 = num;
				this.<PacketValue>k__BackingField = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00003BA0 File Offset: 0x00001DA0
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00003C50 File Offset: 0x00001E50
		public int Offset
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)234749953;
				if (num != 0)
				{
				}
				num = (short)1804892348;
				short num2 = num;
				num = (short)1144092860;
				switch (num2 == num)
				{
				}
				num = (short)1056768000;
				if (num != 0)
				{
				}
				num = (short)611319808;
				short num3 = num;
				return this.<Offset>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)161571668;
				short num2 = num;
				num = (short)654402388;
				switch (num2 == num)
				{
				}
				num = (short)234225665;
				if (num != 0)
				{
				}
				num = (short)1069809664;
				if (num != 0)
				{
				}
				num = (short)1657733120;
				short num3 = num;
				this.<Offset>k__BackingField = value;
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003D00 File Offset: 0x00001F00
		public DataBlock()
		{
			this.LegthInBits = 0;
			this.PacketValue = null;
			this.Offset = 0;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003D28 File Offset: 0x00001F28
		public void Initialize(global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> block)
		{
			this.BlockID = block.Key.IshID;
			this.BlockType = block.Key.IshType;
			this.LegthInBits = block.Value.ItemSize * 8;
			if (this.LegthInBits == 0)
			{
				short num = (short)1910964225;
				if (num != 0)
				{
				}
				num = (short)1230069254;
				short num2 = num;
				num = (short)858152454;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1232207872;
					short num3 = num;
					num = (short)657391616;
					if (num != 0)
					{
					}
					this.PacketValue = null;
					return;
				}
				}
			}
			this.PacketValue = new byte[block.Value.Data.Length];
			global::System.Array.Copy(block.Value.Data, this.PacketValue, block.Value.Data.Length);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003E6C File Offset: 0x0000206C
		public void Initialize(global::System.Collections.Generic.KeyValuePair<ushort, byte[]> fdiBlock)
		{
			short num = (short)761247389;
			short num2 = num;
			num = (short)1764996765;
			switch (num2 == num)
			{
			}
			num = (short)387645440;
			if (num != 0)
			{
			}
			num = (short)472121345;
			if (num != 0)
			{
			}
			num = (short)325517312;
			short num3 = num;
			this.BlockID = fdiBlock.Key;
			this.BlockType = 0;
			this.LegthInBits = fdiBlock.Value.Length * 8;
			this.PacketValue = new byte[fdiBlock.Value.Length];
			global::System.Array.Copy(fdiBlock.Value, this.PacketValue, fdiBlock.Value.Length);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003F6C File Offset: 0x0000216C
		public void Initialize(byte[] cpImage)
		{
			short num = (short)1473253111;
			short num2 = num;
			num = (short)822808311;
			switch (num2 == num)
			{
			}
			num = (short)1049624576;
			if (num != 0)
			{
			}
			num = (short)947781633;
			if (num != 0)
			{
			}
			num = (short)142213120;
			short num3 = num;
			this.BlockID = 0;
			this.BlockType = 0;
			this.LegthInBits = cpImage.Length * 8;
			this.PacketValue = new byte[cpImage.Length];
			global::System.Array.Copy(cpImage, this.PacketValue, cpImage.Length);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000404C File Offset: 0x0000224C
		public void UpdateWithNewData(global::Motorola.Common.Communication.Pba.DataBlock newDataBlock)
		{
			short num = (short)1833112822;
			short num2 = num;
			num = (short)1696535798;
			switch (num2 == num)
			{
			}
			num = (short)116850688;
			if (num != 0)
			{
			}
			num = (short)761397249;
			if (num != 0)
			{
			}
			num = (short)107413504;
			short num3 = num;
			this.LegthInBits = newDataBlock.LegthInBits;
			this.Offset = newDataBlock.Offset;
			this.PacketValue = newDataBlock.PacketValue;
		}
	}
}
