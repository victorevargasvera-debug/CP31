using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000437 RID: 1079
	public class UnknownRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x060027DA RID: 10202 RVA: 0x00078025 File Offset: 0x00076225
		public UnknownRecord(int id, byte[] data)
		{
			this._sid = (id & 65535);
			this._rawData = data;
		}

		// Token: 0x060027DB RID: 10203 RVA: 0x00078041 File Offset: 0x00076241
		public UnknownRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this._sid = (int)in1.Sid;
			this._rawData = in1.ReadRemainder();
		}

		// Token: 0x060027DC RID: 10204 RVA: 0x00078061 File Offset: 0x00076261
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.Write(this._rawData);
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x060027DD RID: 10205 RVA: 0x0007806F File Offset: 0x0007626F
		protected override int DataSize
		{
			get
			{
				return this._rawData.Length;
			}
		}

		// Token: 0x060027DE RID: 10206 RVA: 0x0007807C File Offset: 0x0007627C
		public override string ToString()
		{
			string text = global::NPOI.HSSF.Record.UnknownRecord.GetBiffName(this._sid);
			if (text == null)
			{
				text = "UNKNOWNRECORD";
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[").Append(text).Append("] (0x");
			stringBuilder.Append(global::NPOI.Util.StringUtil.ToHexString(this._sid).ToUpper() + ")\n");
			if (this._rawData.Length != 0)
			{
				stringBuilder.Append("  rawData=").Append(global::NPOI.Util.HexDump.ToHex(this._rawData)).Append("\n");
			}
			stringBuilder.Append("[/").Append(text).Append("]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060027DF RID: 10207 RVA: 0x00078134 File Offset: 0x00076334
		public static string GetBiffName(int sid)
		{
			if (sid <= 241)
			{
				if (sid <= 157)
				{
					if (sid <= 129)
					{
						if (sid <= 80)
						{
							if (sid == 77)
							{
								return "PLS";
							}
							if (sid == 80)
							{
								return "DCON";
							}
						}
						else
						{
							if (sid == 127)
							{
								return "IMDATA";
							}
							if (sid == 129)
							{
								return "SHEETPR";
							}
						}
					}
					else if (sid <= 148)
					{
						if (sid == 144)
						{
							return "SORT";
						}
						if (sid == 148)
						{
							return "LHRECORD";
						}
					}
					else
					{
						if (sid == 153)
						{
							return "STANDARDWIDTH";
						}
						if (sid == 157)
						{
							return "AUTOFILTERINFO";
						}
					}
				}
				else if (sid <= 220)
				{
					if (sid <= 181)
					{
						if (sid == 174)
						{
							return "SCENMAN";
						}
						switch (sid)
						{
						case 178:
							return "SXVI";
						case 180:
							return "SXIVD";
						case 181:
							return "SXLI";
						}
					}
					else
					{
						if (sid == 211)
						{
							return "OBPROJ";
						}
						if (sid == 220)
						{
							return "PARAMQRY";
						}
					}
				}
				else if (sid <= 233)
				{
					if (sid == 222)
					{
						return "OLESIZE";
					}
					if (sid == 233)
					{
						return "BITMAP";
					}
				}
				else
				{
					if (sid == 239)
					{
						return "PHONETICPR";
					}
					if (sid == 241)
					{
						return "SXEX";
					}
				}
			}
			else if (sid <= 2066)
			{
				if (sid <= 442)
				{
					if (sid <= 425)
					{
						if (sid == 351)
						{
							return "LABELRANGES";
						}
						if (sid == 425)
						{
							return "USERBVIEW";
						}
					}
					else
					{
						if (sid == 429)
						{
							return "QSI";
						}
						if (sid == 442)
						{
							return "CODENAME";
						}
					}
				}
				else if (sid <= 2053)
				{
					if (sid == 448)
					{
						return "EXCEL9FILE";
					}
					switch (sid)
					{
					case 2048:
						return "QUICKTIP";
					case 2050:
						return "QSISXTAG";
					case 2051:
						return "DBQUERYEXT";
					case 2053:
						return "TXTQUERY";
					}
				}
				else
				{
					if (sid == 2064)
					{
						return "SXVIEWEX9";
					}
					if (sid == 2066)
					{
						return "CONTINUEFRT";
					}
				}
			}
			else if (sid <= 2175)
			{
				if (sid <= 2155)
				{
					switch (sid)
					{
					case 2147:
						return "BOOKEXT";
					case 2148:
						return "SXADDL";
					case 2149:
					case 2150:
						break;
					case 2151:
						return "SHEETPROTECTION";
					default:
						if (sid == 2155)
						{
							return "DATALABEXTCONTENTS";
						}
						break;
					}
				}
				else
				{
					if (sid == 2156)
					{
						return "CELLWATCH";
					}
					switch (sid)
					{
					case 2162:
						return "SHARED FEATURE v11";
					case 2164:
						return "DROPDOWNOBJIDS";
					case 2166:
						return "DCONN";
					case 2168:
						return "SHARED FEATURE v12";
					case 2171:
						return "CFEX";
					case 2172:
						return "XFCRC";
					case 2173:
						return "XFEXT";
					case 2175:
						return "CONTINUEFRT12";
					}
				}
			}
			else if (sid <= 2248)
			{
				switch (sid)
				{
				case 2187:
					return "PLV";
				case 2188:
					return "COMPAT12";
				case 2189:
					return "DXF";
				case 2190:
				case 2191:
				case 2192:
				case 2193:
				case 2195:
				case 2196:
				case 2197:
				case 2200:
				case 2201:
				case 2208:
				case 2210:
					break;
				case 2194:
					return "STYLEEXT";
				case 2198:
					return "THEME";
				case 2199:
					return "GUIDTYPELIB";
				case 2202:
					return "MTRSETTINGS";
				case 2203:
					return "COMPRESSPICTURES";
				case 2204:
					return "HEADERFOOTER";
				case 2205:
					return "CRTLAYOUT12";
				case 2206:
					return "CRTMLFRT";
				case 2207:
					return "CRTMLFRTCONTINUE";
				case 2209:
					return "SHAPEPROPSSTREAM";
				case 2211:
					return "FORCEFULLCALCULATION";
				case 2212:
					return "SHAPEPROPSSTREAM";
				case 2213:
					return "TEXTPROPSSTREAM";
				case 2214:
					return "RICHTEXTSTREAM";
				case 2215:
					return "CRTLAYOUT12A";
				default:
					if (sid == 2248)
					{
						return "PLV{Mac Excel}";
					}
					break;
				}
			}
			else
			{
				if (sid == 4097)
				{
					return "UNITS";
				}
				if (sid == 4102)
				{
					return "CHARTDATAFORMAT";
				}
				if (sid == 4103)
				{
					return "CHARTLINEFORMAT";
				}
			}
			if (global::NPOI.HSSF.Record.UnknownRecord.IsObservedButUnknown(sid))
			{
				return "UNKNOWN-" + global::NPOI.Util.StringUtil.ToHexString(sid).ToUpper();
			}
			return "BIFF Record-" + global::NPOI.Util.StringUtil.ToHexString(sid).ToUpper();
		}

		// Token: 0x060027E0 RID: 10208 RVA: 0x00078614 File Offset: 0x00076814
		private static bool IsObservedButUnknown(int sid)
		{
			if (sid <= 4120)
			{
				if (sid <= 445)
				{
					if (sid - 51 > 1 && sid != 445)
					{
						return false;
					}
				}
				else if (sid != 450 && sid != 4108 && sid != 4120)
				{
					return false;
				}
			}
			else if (sid <= 4134)
			{
				if (sid != 4123)
				{
					switch (sid)
					{
					case 4128:
					case 4129:
					case 4130:
					case 4132:
					case 4134:
						break;
					case 4131:
					case 4133:
						return false;
					default:
						return false;
					}
				}
			}
			else if (sid - 4147 > 2)
			{
				switch (sid)
				{
				case 4161:
				case 4163:
				case 4164:
				case 4165:
				case 4170:
				case 4171:
				case 4174:
				case 4175:
				case 4176:
				case 4177:
					break;
				case 4162:
				case 4166:
				case 4167:
				case 4168:
				case 4169:
				case 4172:
				case 4173:
					return false;
				default:
					switch (sid)
					{
					case 4188:
					case 4189:
					case 4191:
					case 4193:
					case 4194:
					case 4195:
					case 4196:
					case 4198:
					case 4199:
					case 4200:
						break;
					case 4190:
					case 4192:
					case 4197:
						return false;
					default:
						return false;
					}
					break;
				}
			}
			return true;
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x060027E1 RID: 10209 RVA: 0x00078753 File Offset: 0x00076953
		public override short Sid
		{
			get
			{
				return (short)this._sid;
			}
		}

		// Token: 0x060027E2 RID: 10210 RVA: 0x0000F20C File Offset: 0x0000D40C
		public override object Clone()
		{
			return this;
		}

		// Token: 0x040010E7 RID: 4327
		public const int PLS_004D = 77;

		// Token: 0x040010E8 RID: 4328
		public const int SHEETPR_0081 = 129;

		// Token: 0x040010E9 RID: 4329
		public const int SORT_0090 = 144;

		// Token: 0x040010EA RID: 4330
		public const int STANDARDWIDTH_0099 = 153;

		// Token: 0x040010EB RID: 4331
		public const int BITMAP_00E9 = 233;

		// Token: 0x040010EC RID: 4332
		public const int PHONETICPR_00EF = 239;

		// Token: 0x040010ED RID: 4333
		public const int LABELRANGES_015F = 351;

		// Token: 0x040010EE RID: 4334
		public const int QUICKTIP_0800 = 2048;

		// Token: 0x040010EF RID: 4335
		public const int SHEETPROTECTION_0867 = 2151;

		// Token: 0x040010F0 RID: 4336
		public const int HEADER_FOOTER_089C = 2204;

		// Token: 0x040010F1 RID: 4337
		public const int CODENAME_1BA = 442;

		// Token: 0x040010F2 RID: 4338
		public const int PLV_MAC = 2248;

		// Token: 0x040010F3 RID: 4339
		private int _sid;

		// Token: 0x040010F4 RID: 4340
		private byte[] _rawData;
	}
}
