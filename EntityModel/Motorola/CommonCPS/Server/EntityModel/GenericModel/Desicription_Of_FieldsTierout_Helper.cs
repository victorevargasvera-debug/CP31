using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.CommonContract;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;

namespace Motorola.CommonCPS.Server.EntityModel.GenericModel
{
	// Token: 0x020001D1 RID: 465
	public class Desicription_Of_FieldsTierout_Helper
	{
		// Token: 0x06001791 RID: 6033 RVA: 0x000FED24 File Offset: 0x000FCF24
		public bool IsTieredOut(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.Desicription_Of_FieldsTierout> List_Desicription_Of_FieldsTierout, string UIPropertyName, string BLRecSetName = null)
		{
			int a_ = 0;
			short num = (short)1963327489;
			if (num != 0)
			{
			}
			num = (short)712581168;
			short num2 = num;
			num = (short)764289072;
			switch (num2 == num)
			{
			}
			num = (short)1416101888;
			if (num != 0)
			{
			}
			num = (short)726597632;
			short num3 = num;
			global::Motorola.CommonCPS.Server.EntityModel.GenericModel.Desicription_Of_FieldsTierout_Helper.a a = new global::Motorola.CommonCPS.Server.EntityModel.GenericModel.Desicription_Of_FieldsTierout_Helper.a();
			a.a = UIPropertyName;
			global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.Desicription_Of_FieldsTierout> source = List_Desicription_Of_FieldsTierout.Where(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.Desicription_Of_FieldsTierout, bool>(a.b));
			if (source.Count<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.Desicription_Of_FieldsTierout>() != 1)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("룽懿欁栃挅氇⨉笋昍甏簑㐓朕洗缙減朝\u001f瘡䴣䌥娧伩䠫䄭䔯䘱ᐳ䘵䨷唹䰻嬽㈿㙁㵃晅❇ⱉ汋⡍㥏㝑㡓㉕癗", a_));
			}
			return source.First<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.Desicription_Of_FieldsTierout>().TieredOut;
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x000FEE20 File Offset: 0x000FD020
		public bool IsTieredOut(string string_Desicription_Of_FieldsTierout, string UIPropertyName, string BLRecSetName = null)
		{
			short num = (short)760297211;
			short num2 = num;
			num = (short)987707131;
			switch (num2 == num)
			{
			}
			num = (short)1677721601;
			if (num != 0)
			{
			}
			num = (short)467599360;
			if (num != 0)
			{
			}
			num = (short)894500864;
			short num3 = num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.Desicription_Of_FieldsTierout> list_Desicription_Of_FieldsTierout = global::Motorola.CommonCPS.CommonContract.Serializer.Deserialize_FromXMLString(string_Desicription_Of_FieldsTierout, typeof(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.Desicription_Of_FieldsTierout>)) as global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.Desicription_Of_FieldsTierout>;
			return this.IsTieredOut(list_Desicription_Of_FieldsTierout, UIPropertyName, BLRecSetName);
		}

		// Token: 0x020001D2 RID: 466
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06001795 RID: 6037 RVA: 0x000FEF14 File Offset: 0x000FD114
			internal bool b(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.Desicription_Of_FieldsTierout A_0)
			{
				short num = (short)628621313;
				if (num != 0)
				{
				}
				num = (short)1164905772;
				short num2 = num;
				num = (short)1090653484;
				switch (num2 == num)
				{
				}
				num = (short)1131610112;
				if (num != 0)
				{
				}
				num = (short)953745408;
				short num3 = num;
				return A_0.UIPropertyName == this.a;
			}

			// Token: 0x04000AF9 RID: 2809
			public string a;
		}
	}
}
