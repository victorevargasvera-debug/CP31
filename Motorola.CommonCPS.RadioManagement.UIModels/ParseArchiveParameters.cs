using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000041 RID: 65
	public class ParseArchiveParameters
	{
		// Token: 0x06000181 RID: 385 RVA: 0x000163B8 File Offset: 0x000145B8
		public ParseArchiveParameters()
		{
			this.LanguagePacksInDB = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package>();
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000182 RID: 386 RVA: 0x000163D8 File Offset: 0x000145D8
		// (set) Token: 0x06000183 RID: 387 RVA: 0x00016488 File Offset: 0x00014688
		public string ArchiveFilePath
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)969951721;
				short num2 = num;
				num = (short)2097957353;
				switch (num2 == num)
				{
				}
				num = (short)1262419968;
				short num3 = num;
				num = (short)2134769665;
				if (num != 0)
				{
				}
				num = (short)932315136;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)21883586;
				short num2 = num;
				num = (short)36956866;
				switch (num2 == num)
				{
				}
				num = (short)464060416;
				short num3 = num;
				num = (short)1097531393;
				if (num != 0)
				{
				}
				num = (short)426246144;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00016538 File Offset: 0x00014738
		// (set) Token: 0x06000185 RID: 389 RVA: 0x000165E8 File Offset: 0x000147E8
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> LanguagePacksInDB
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1832338251;
				short num2 = num;
				num = (short)38617931;
				switch (num2 == num)
				{
				}
				num = (short)588840960;
				short num3 = num;
				num = (short)517668865;
				if (num != 0)
				{
				}
				num = (short)1054867456;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)791070107;
				short num2 = num;
				num = (short)1958528411;
				switch (num2 == num)
				{
				}
				num = (short)227147776;
				short num3 = num;
				num = (short)1970012161;
				if (num != 0)
				{
				}
				num = (short)1161494528;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x040000B2 RID: 178
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;

		// Token: 0x040000B3 RID: 179
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> b;
	}
}
