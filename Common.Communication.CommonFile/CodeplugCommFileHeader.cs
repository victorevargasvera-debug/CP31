using System;
using System.Runtime.CompilerServices;

namespace Motorola.Common.Communication.CommonFile
{
	// Token: 0x02000003 RID: 3
	public class CodeplugCommFileHeader
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000253C File Offset: 0x0000073C
		// (set) Token: 0x06000005 RID: 5 RVA: 0x000025E8 File Offset: 0x000007E8
		public global::Motorola.Common.Communication.CommonFile.FullDeltaCodeplug FullDelta
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			internal get
			{
				short num = (short)1268944386;
				short num2 = num;
				num = (short)880184834;
				switch (num2 == num)
				{
				}
				num = (short)1287127041;
				if (num != 0)
				{
				}
				num = (short)1110441984;
				if (num != 0)
				{
				}
				num = (short)1845231616;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)236548350;
				short num2 = num;
				num = (short)268529918;
				switch (num2 == num)
				{
				}
				num = (short)66191360;
				if (num != 0)
				{
				}
				num = (short)59244545;
				if (num != 0)
				{
				}
				num = (short)1279983616;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002698 File Offset: 0x00000898
		// (set) Token: 0x06000007 RID: 7 RVA: 0x0000274C File Offset: 0x0000094C
		public byte HeaderVer
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			internal get
			{
				short num = (short)1560755616;
				short num2 = num;
				num = (short)240270752;
				switch (num2 == num)
				{
				}
				num = (short)752484353;
				if (num != 0)
				{
				}
				num = (short)1955790848;
				if (num != 0)
				{
				}
				num = (short)408420352;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1593346662;
				short num2 = num;
				num = (short)1006078566;
				switch (num2 == num)
				{
				}
				num = (short)522321920;
				if (num != 0)
				{
				}
				num = (short)1685848065;
				if (num != 0)
				{
				}
				num = (short)1541079040;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000027FC File Offset: 0x000009FC
		// (set) Token: 0x06000009 RID: 9 RVA: 0x000028AC File Offset: 0x00000AAC
		public global::Motorola.Common.Communication.CommonFile.InfoLevel Level
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			internal get
			{
				short num = (short)99905056;
				short num2 = num;
				num = (short)1027436064;
				switch (num2 == num)
				{
				}
				num = (short)1860698113;
				if (num != 0)
				{
				}
				num = (short)1625096192;
				if (num != 0)
				{
				}
				num = (short)1482227712;
				short num3 = num;
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)652659691;
				short num2 = num;
				num = (short)1539886059;
				switch (num2 == num)
				{
				}
				num = (short)449839105;
				if (num != 0)
				{
				}
				num = (short)800456704;
				if (num != 0)
				{
				}
				num = (short)1312161792;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002960 File Offset: 0x00000B60
		public CodeplugCommFileHeader()
		{
			this.FullDelta = global::Motorola.Common.Communication.CommonFile.FullDeltaCodeplug.Full;
			this.HeaderVer = 16;
			this.Level = global::Motorola.Common.Communication.CommonFile.InfoLevel.TypeLevelChangeDisc;
		}

		// Token: 0x04000003 RID: 3
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.CommonFile.FullDeltaCodeplug a;

		// Token: 0x04000004 RID: 4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private byte b;

		// Token: 0x04000005 RID: 5
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.CommonFile.InfoLevel c;
	}
}
