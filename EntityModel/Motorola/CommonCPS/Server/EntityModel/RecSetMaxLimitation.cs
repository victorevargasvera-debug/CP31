using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000190 RID: 400
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class RecSetMaxLimitation : global::Motorola.CommonCPS.Server.EntityModel.SerializableClass<global::Motorola.CommonCPS.Server.EntityModel.RecSetMaxLimitation>
	{
		// Token: 0x0600155D RID: 5469 RVA: 0x000E3974 File Offset: 0x000E1B74
		public RecSetMaxLimitation()
		{
			this.RecSetMaxDef = new global::System.Collections.Generic.HashSet<global::Motorola.CommonCPS.Server.EntityModel.RecSetMaxDefItem>();
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x0600155E RID: 5470 RVA: 0x000E3994 File Offset: 0x000E1B94
		// (set) Token: 0x0600155F RID: 5471 RVA: 0x000E3A44 File Offset: 0x000E1C44
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.HashSet<global::Motorola.CommonCPS.Server.EntityModel.RecSetMaxDefItem> RecSetMaxDef
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1431961600;
				short num2 = num;
				num = (short)399245313;
				if (num != 0)
				{
				}
				num = (short)2044070185;
				short num3 = num;
				num = (short)1888225577;
				switch (num3 == num)
				{
				}
				num = (short)1630339072;
				if (num != 0)
				{
				}
				return this.<RecSetMaxDef>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1636958208;
				short num2 = num;
				num = (short)2011365377;
				if (num != 0)
				{
				}
				num = (short)2140378789;
				short num3 = num;
				num = (short)1501206181;
				switch (num3 == num)
				{
				}
				num = (short)694288384;
				if (num != 0)
				{
				}
				this.<RecSetMaxDef>k__BackingField = value;
			}
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x000E3AF4 File Offset: 0x000E1CF4
		public int GetMaxNum(string OneRecSetName)
		{
			short num = (short)660078592;
			short num2 = num;
			num = (short)1828855056;
			short num3 = num;
			num = (short)1514806544;
			switch (num3 == num)
			{
			}
			num = (short)1049100288;
			if (num != 0)
			{
			}
			num = (short)1772224513;
			if (num != 0)
			{
			}
			return this.a(new global::Motorola.CommonCPS.Server.EntityModel.RecSetMaxDefItem
			{
				MultipleRecSetNames = new global::System.Collections.Generic.HashSet<string>
				{
					OneRecSetName
				}
			});
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x000E3BBC File Offset: 0x000E1DBC
		public int GetMaxNumOfPool(global::System.Collections.Generic.HashSet<string> MultRecSetNames)
		{
			short num = (short)860740862;
			short num2 = num;
			num = (short)949935358;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1377828864;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1118633984;
			if (num != 0)
			{
			}
			num = (short)125960193;
			if (num != 0)
			{
			}
			return this.a(new global::Motorola.CommonCPS.Server.EntityModel.RecSetMaxDefItem
			{
				MultipleRecSetNames = MultRecSetNames
			});
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x000E3C78 File Offset: 0x000E1E78
		private int a(global::Motorola.CommonCPS.Server.EntityModel.RecSetMaxDefItem A_0)
		{
			int a_ = 11;
			global::Motorola.CommonCPS.Server.EntityModel.RecSetMaxLimitation.a a = new global::Motorola.CommonCPS.Server.EntityModel.RecSetMaxLimitation.a();
			a.a = A_0;
			global::Motorola.CommonCPS.Server.EntityModel.RecSetMaxDefItem recSetMaxDefItem = this.RecSetMaxDef.First(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.RecSetMaxDefItem, bool>(a.b));
			if (recSetMaxDefItem != null)
			{
				short num = (short)444197089;
				short num2 = num;
				num = (short)944367841;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_D9;
				case 1:
					break;
				default:
				{
					num = (short)1316028416;
					short num3 = num;
					break;
				}
				}
				num = (short)971309056;
				if (num != 0)
				{
				}
				num = (short)1946025985;
				if (num != 0)
				{
				}
				return recSetMaxDefItem.MaxNum;
			}
			IL_D9:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ThereIsNoMaxNumDefForNameSet, string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("崈挊栌紎琐㌒簔搖㤘甚爜㼞氠䈢崤椦尨䘪ബ䬮吰唲尴夶倸伺吼倾⽀捂⍄⡆㭈歊͌⹎㱐㙒ٔ㉖ⵘ筚穜⑞兠Ṣ䉤", a_), a.a));
		}

		// Token: 0x02000192 RID: 402
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06001567 RID: 5479 RVA: 0x000E3F20 File Offset: 0x000E2120
			internal bool b(global::Motorola.CommonCPS.Server.EntityModel.RecSetMaxDefItem A_0)
			{
				short num = (short)22881078;
				short num2 = num;
				num = (short)1373905718;
				switch (num2 == num)
				{
				default:
				{
					num = (short)272695296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)185663489;
				if (num != 0)
				{
				}
				num = (short)1788477440;
				if (num != 0)
				{
				}
				return A_0.MultipleRecSetNames.SetEquals(this.a.MultipleRecSetNames);
			}

			// Token: 0x04000A05 RID: 2565
			public global::Motorola.CommonCPS.Server.EntityModel.RecSetMaxDefItem a;
		}
	}
}
