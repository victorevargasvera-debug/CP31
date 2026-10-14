using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Motorola.Common.CommonLib;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;

namespace Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels
{
	// Token: 0x020001E6 RID: 486
	public sealed class NameMappingManager
	{
		// Token: 0x0600181A RID: 6170 RVA: 0x00103D94 File Offset: 0x00101F94
		private NameMappingManager()
		{
		}

		// Token: 0x0600181B RID: 6171 RVA: 0x00103DA8 File Offset: 0x00101FA8
		private static global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.NameMappingManager a()
		{
			int a_ = 3;
			global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.NameMappingManager nameMappingManager = new global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.NameMappingManager();
			global::System.IO.Stream stream = global::Motorola.Common.CommonLib.EmbeddedResourceManager.GetStream(typeof(global::Motorola.CommonCPS.Server.EntityModel.Configuration).Assembly, global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䰀氂焄栆笈搊愌渎㼐倒稔稖琘琚猜尞焠瀢ତ琦䰨太嬬䨮䌰ᴲ瀴夶䴸刺䤼䘾ీⱂ⅄≆╈敊ੌ⩎㽐㙒❔㹖㩘ᙚ㉜㭞Ѡར䭤⍦⭨╪ɬ୮ᑰ㝲ᑴͶᡸ㙺ቼ᭾ꦆ쮈잊소슎펖ﲜ놞\ud9a0캢즤", a_));
			short num;
			try
			{
				nameMappingManager.b = global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SetInfoUtils.GetAllSetInfo(stream).ToDictionary(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SetInfo, string>(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.NameMappingManager.<>c.<>9.a), new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SetInfo, global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SetInfo>(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.NameMappingManager.<>c.<>9.b));
			}
			finally
			{
				num = (short)1103953922;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_13E;
					case 1:
						((global::System.IDisposable)stream).Dispose();
						goto IL_12A;
					case 2:
					{
						num = (short)110632672;
						short num3 = num;
						num = (short)543891168;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_12A;
						default:
							num = (short)438173696;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_10B;
							}
							continue;
						}
						break;
					}
					}
					IL_10B:
					if (stream != null)
					{
						num = (short)675086337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_12A:
					num = (short)1870987264;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_13E:;
			}
			num = (short)1934032897;
			if (num != 0)
			{
			}
			num = (short)808583168;
			short num4 = num;
			return nameMappingManager;
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x0600181C RID: 6172 RVA: 0x00103F58 File Offset: 0x00102158
		public static global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.NameMappingManager Instance
		{
			get
			{
				short num = (short)1855356448;
				short num2 = num;
				num = (short)1950055968;
				switch (num2 == num)
				{
				}
				num = (short)1758199809;
				if (num != 0)
				{
				}
				num = (short)369557504;
				if (num != 0)
				{
				}
				num = (short)2134114304;
				short num3 = num;
				return global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.NameMappingManager.a.Value;
			}
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x00104008 File Offset: 0x00102208
		public global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.FieldInfo GetForwardMap(string SetType, string FieldName)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.FieldInfo result;
			global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SetInfo setInfo;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1047527425;
					if (num2 != 0)
					{
					}
					num2 = (short)1507772986;
					short num3 = num2;
					num2 = (short)1924647482;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3E;
					default:
						goto IL_114;
					}
					break;
				}
				case 1:
					goto IL_3E;
				case 2:
					return result;
				case 3:
					result = setInfo.GetForwardMap(FieldName);
					num2 = (short)1802436610;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
				IL_3E:
				if (setInfo != null)
				{
					num2 = (short)669057027;
					num = (int)((global::System.IntPtr)num2);
				}
				else
				{
					num2 = (short)956956672;
					short num4 = num2;
					result = new global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.FieldInfo
					{
						BLLFieldName = FieldName,
						RMFieldName = FieldName,
						IsNeedToEncrypt = false
					};
					num2 = (short)1760428032;
					num = (int)((global::System.IntPtr)num2);
				}
			}
			IL_114:
			num2 = (short)1810759680;
			if (num2 != 0)
			{
			}
			return result;
			IL_20:
			result = null;
			setInfo = this.GetSetInfo(SetType);
			num2 = (short)1973813249;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x00104164 File Offset: 0x00102364
		public global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.FieldInfo GetReverseMap(string SetType, string FieldName)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.FieldInfo result;
			global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SetInfo setInfo;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)554300677;
					short num3 = num2;
					num2 = (short)1567028485;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_40;
					default:
						goto IL_116;
					}
					break;
				}
				case 1:
					goto IL_40;
				case 2:
					return result;
				case 3:
				{
					num2 = (short)664469504;
					short num4 = num2;
					result = setInfo.GetReverseMap(FieldName);
					num2 = (short)11468802;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_20;
				IL_40:
				if (setInfo != null)
				{
					num2 = (short)1526792193;
					if (num2 != 0)
					{
					}
					num2 = (short)2051735555;
					num = (int)((global::System.IntPtr)num2);
				}
				else
				{
					result = new global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.FieldInfo
					{
						BLLFieldName = FieldName,
						RMFieldName = FieldName,
						IsNeedToEncrypt = false
					};
					num2 = (short)1877737472;
					num = (int)((global::System.IntPtr)num2);
				}
			}
			IL_116:
			num2 = (short)1569718272;
			if (num2 != 0)
			{
			}
			return result;
			IL_20:
			result = null;
			setInfo = this.GetSetInfo(SetType);
			num2 = (short)1440940033;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x001042C0 File Offset: 0x001024C0
		public global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SetInfo GetSetInfo(string SetType)
		{
			while (this.b.ContainsKey(SetType))
			{
				short num = (short)2043084800;
				short num2 = num;
				num = (short)1574249936;
				short num3 = num;
				num = (short)1894589904;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1814953984;
					if (num != 0)
					{
					}
					num = (short)2072379393;
					if (num != 0)
					{
					}
					return this.b[SetType];
				}
			}
			return null;
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x00104388 File Offset: 0x00102588
		public global::System.Collections.Generic.List<string> ListAllSharedSets()
		{
			short num = (short)2035252516;
			short num2 = num;
			num = (short)1130003748;
			switch (num2 == num)
			{
			}
			num = (short)249561089;
			if (num != 0)
			{
			}
			num = (short)289800192;
			if (num != 0)
			{
			}
			num = (short)1488650240;
			short num3 = num;
			return this.b.Where(new global::System.Func<global::System.Collections.Generic.KeyValuePair<string, global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SetInfo>, bool>(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.NameMappingManager.<>c.<>9.a)).Select(new global::System.Func<global::System.Collections.Generic.KeyValuePair<string, global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SetInfo>, string>(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.NameMappingManager.<>c.<>9.b)).ToList<string>();
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x0010448C File Offset: 0x0010268C
		// Note: this type is marked as 'beforefieldinit'.
		static NameMappingManager()
		{
			short num = (short)225470185;
			short num2 = num;
			num = (short)185624297;
			switch (num2 == num)
			{
			}
			num = (short)924581888;
			if (num != 0)
			{
			}
			num = (short)1369964545;
			if (num != 0)
			{
			}
			num = (short)3670016;
			short num3 = num;
			global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.NameMappingManager.a = new global::System.Lazy<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.NameMappingManager>(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.NameMappingManager>(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.NameMappingManager.<>c.<>9.a));
		}

		// Token: 0x04000B30 RID: 2864
		private static readonly global::System.Lazy<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.NameMappingManager> a;

		// Token: 0x04000B31 RID: 2865
		private global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SetInfo> b;
	}
}
