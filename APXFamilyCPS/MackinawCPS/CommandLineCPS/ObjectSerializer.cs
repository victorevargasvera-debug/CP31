using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using PreEmptive.SoS.Runtime;

namespace MackinawCPS.CommandLineCPS
{
	// Token: 0x02000097 RID: 151
	public static class ObjectSerializer
	{
		// Token: 0x060005E8 RID: 1512 RVA: 0x000FB4D8 File Offset: 0x000F96D8
		internal static byte[] Serialize(object instance)
		{
			int a_ = 13;
			short num = (short)1283784705;
			if (num != 0)
			{
			}
			num = (short)1026717039;
			short num2 = num;
			num = (short)128808303;
			switch (num2 == num)
			{
			}
			num = (short)1762721792;
			short num3 = num;
			num = (short)218955776;
			if (num != 0)
			{
			}
			global::System.Diagnostics.Trace.WriteLine(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뛬ꃮ鏰駲郴银跸꣺飼跾栀戂椄渆猈渊缌刎䨐娒笔焖瘘椚瀜縞唠䨢䨤䤦琨瀪漬䨮嘰娲嬴樶戸栺堼䴾⡀≂⥄⹆㍈⹊၌", a_));
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter().Serialize(memoryStream, instance);
			byte[] result = memoryStream.ToArray();
			global::System.Diagnostics.Trace.WriteLine(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뛬ꃮ鏰駲郴银跸꣺飼跾栀戂椄渆猈渊缌刎䨐娒笔焖瘘椚瀜縞唠䨢䨤䤦琨瀪栬䄮唰渲渴搶尸䤺吼帾ⵀ⩂㽄≆ᑈ", a_));
			return result;
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x000FB5C8 File Offset: 0x000F97C8
		internal static T Deserialize<T>(byte[] array)
		{
			int a_ = 7;
			global::System.Diagnostics.Trace.WriteLine(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("볦ꛨ觪蟬諮鋰蟲꛴鋶诸鋺鳼鏾栀礂怄甆合倊䐌愎眐簒朔稖砘漚琜瀞传縢縤攦䰨䰪䐬䄮氰栲焴制䨸帺似嘾⁀⽂ⱄ㵆ⱈᙊ", a_));
			global::System.IO.MemoryStream memoryStream = null;
			short num;
			T result;
			try
			{
				num = (short)1201668097;
				if (num != 0)
				{
				}
				memoryStream = new global::System.IO.MemoryStream(array);
				result = (T)((object)new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter().Deserialize(memoryStream));
			}
			finally
			{
				num = (short)1872560130;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_11B;
					case 1:
					{
						num = (short)1920519330;
						short num3 = num;
						num = (short)1891159202;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1333985280;
							if (num != 0)
							{
							}
							memoryStream.Close();
							break;
						}
						num = (short)334036992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_96;
						}
						continue;
					}
					IL_96:
					if (memoryStream == null)
					{
						break;
					}
					num = (short)132120577;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_11B:
				memoryStream = null;
				global::System.Diagnostics.Trace.WriteLine(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("볦ꛨ觪蟬諮鋰蟲꛴鋶诸鋺鳼鏾栀礂怄甆合倊䐌愎眐簒朔稖砘漚琜瀞传縢縤戦䜨伪瀬琮田嘲䘴制䬸刺尼匾⡀㥂⁄ᩆ", a_));
			}
			num = (short)652935168;
			short num4 = num;
			return result;
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x000FB744 File Offset: 0x000F9944
		internal static void SerializeToFile(string filePath, object instance)
		{
			int a_ = 19;
			short num = (short)1982922142;
			short num2 = num;
			num = (short)1298857374;
			switch (num2 == num)
			{
			}
			num = (short)540082176;
			if (num != 0)
			{
			}
			num = (short)833028096;
			short num3 = num;
			num = (short)502398977;
			if (num != 0)
			{
			}
			global::System.Diagnostics.Trace.WriteLine(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꣲ뫴闶鏸黺黼课刀昂眄渆栈朊搌甎琐愒䠔䰖倘甚笜瀞匠丢䐤匦䀨䐪䌬爮樰焲倴倶倸唺怼搾ቀ♂㝄⹆⡈❊⑌㕎㑐ݒ㩔ᅖじ㝚㡜ɞ", a_));
			global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter = new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
			global::System.IO.Stream stream = new global::System.IO.FileStream(filePath, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.ReadWrite);
			stream.SetLength(0L);
			binaryFormatter.Serialize(stream, instance);
			stream.Close();
			global::System.Diagnostics.Trace.WriteLine(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꣲ뫴闶鏸黺黼课刀昂眄渆栈朊搌甎琐愒䠔䰖倘甚笜瀞匠丢䐤匦䀨䐪䌬爮樰瘲嬴匶搸怺渼娾㍀⩂⑄⭆⁈ㅊ⡌᭎㹐ᕒ㱔㭖㱘ٚ", a_));
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x000FB83C File Offset: 0x000F9A3C
		internal static T DeserializeFromFile<T>(string filePath)
		{
			int a_ = 12;
			short num = (short)1462239232;
			short num2 = num;
			num = (short)253634062;
			short num3 = num;
			num = (short)1568417294;
			T result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1520173056;
				if (num != 0)
				{
				}
				global::System.Diagnostics.Trace.WriteLine(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("럫ꇭ鋯飱釳闵賷꧹駻賽槿持栃漅爇漉縋匍䬏嬑稓瀕眗栙焛缝吟䬡䬣䠥甧焩渫䬭圯嬱娳欵挷縹夻䴽┿ぁⵃ❅⑇⍉㙋⭍ᙏ⁑㭓㭕ṗ㍙せ㭝㵟", a_));
				global::System.IO.Stream stream = null;
				try
				{
					num = (short)475529217;
					if (num != 0)
					{
					}
					stream = new global::System.IO.FileStream(filePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
					result = (T)((object)new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter().Deserialize(stream));
				}
				finally
				{
					num = (short)1779630082;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_139;
						case 1:
							stream.Close();
							num = (short)409534464;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_106;
							}
							continue;
						}
						IL_106:
						if (stream == null)
						{
							break;
						}
						num = (short)1350828033;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_139:
					stream = null;
					global::System.Diagnostics.Trace.WriteLine(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("럫ꇭ鋯飱釳闵賷꧹駻賽槿持栃漅爇漉縋匍䬏嬑稓瀕眗栙焛缝吟䬡䬣䠥甧焩椫䀭启漱漳爵崷䤹夻䰽⤿⍁⡃⽅㉇⽉ੋ㱍㽏㽑ቓ㽕㑗㽙ś", a_));
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x000FB9AC File Offset: 0x000F9BAC
		internal static byte[] XmlSerialize(object instance)
		{
			int a_ = 6;
			short num = (short)1235943424;
			short num2 = num;
			num = (short)1349029892;
			short num3 = num;
			num = (short)1960873988;
			switch (num3 == num)
			{
			}
			num = (short)102301697;
			if (num != 0)
			{
			}
			num = (short)1561591808;
			if (num != 0)
			{
			}
			global::System.Diagnostics.Trace.WriteLine(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뷥꟧裩蛫语鏯蛱ꟳ鏵諷鏹鷻鋽槿码愃琅唇儉䔋怍瘏紑易笕礗渙甛焝丟缡缣搥䴧䴩䔫䀭洯椱氳嬵吷椹夻䰽⤿⍁⡃⽅㉇⽉ᅋ", a_));
			global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(instance.GetType());
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			xmlSerializer.Serialize(memoryStream, instance);
			byte[] result = memoryStream.ToArray();
			memoryStream.Close();
			global::System.Diagnostics.Trace.WriteLine(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뷥꟧裩蛫语鏯蛱ꟳ鏵諷鏹鷻鋽槿码愃琅唇儉䔋怍瘏紑易笕礗渙甛焝丟缡缣挥䘧丩焫甭栯弱堳攵崷䠹唻弽ⰿ⭁㹃⍅ᕇ", a_));
			return result;
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x000FBAA8 File Offset: 0x000F9CA8
		internal static T XmlDeserialize<T>(byte[] array)
		{
			int a_ = 0;
			short num = (short)761069568;
			short num2 = num;
			num = (short)2081141171;
			short num3 = num;
			num = (short)15380915;
			T result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1994653696;
				if (num != 0)
				{
				}
				global::System.Diagnostics.Trace.WriteLine(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("믟귡蛣賥跧觩飫뷭闯胱鷳韵铷鏹蛻鯽狿弁弃伅昇氉挋簍紏猑怓缕眗琙䄛䔝戟䜡䌣伥䘧眩眫瘭崯帱瀳匵䬷弹主圽ℿ⹁ⵃ㱅ⵇᝉ", a_));
				global::System.IO.MemoryStream memoryStream = null;
				try
				{
					num = (short)1889861633;
					if (num != 0)
					{
					}
					memoryStream = new global::System.IO.MemoryStream(array);
					result = (T)((object)new global::System.Xml.Serialization.XmlSerializer(typeof(T)).Deserialize(memoryStream));
				}
				finally
				{
					num = (short)1231552513;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_145;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_110;
							}
							continue;
						case 2:
							memoryStream.Close();
							num = (short)181993472;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_110:
						if (memoryStream == null)
						{
							break;
						}
						num = (short)691404802;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_145:
					memoryStream = null;
					global::System.Diagnostics.Trace.WriteLine(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("믟귡蛣賥跧觩飫뷭闯胱鷳韵铷鏹蛻鯽狿弁弃伅昇氉挋簍紏猑怓缕眗琙䄛䔝攟䰡䀣笥猧爩䄫䈭琯圱䜳匵䨷匹崻刽⤿㡁⅃ᭅ", a_));
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x000FBC24 File Offset: 0x000F9E24
		internal static void XmlSerializeToFile(string xmlFilePath, object instance)
		{
			int a_ = 13;
			short num = (short)1174994944;
			short num2 = num;
			num = (short)461599692;
			short num3 = num;
			num = (short)611873740;
			switch (num3 == num)
			{
			}
			num = (short)129892353;
			if (num != 0)
			{
			}
			num = (short)1264320512;
			if (num != 0)
			{
			}
			global::System.Diagnostics.Trace.WriteLine(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뛬ꃮ鏰駲郴银跸꣺飼跾栀戂椄渆猈渊缌刎䨐娒笔焖瘘椚瀜縞唠䨢䨤䤦琨瀪漬䨮嘰娲嬴樶戸挺值匾ቀ♂㝄⹆⡈❊⑌㕎㑐ݒ㩔ᅖじ㝚㡜ɞ", a_));
			global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(instance.GetType());
			global::System.IO.Stream stream = new global::System.IO.FileStream(xmlFilePath, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.ReadWrite);
			stream.SetLength(0L);
			xmlSerializer.Serialize(stream, instance);
			stream.Close();
			global::System.Diagnostics.Trace.WriteLine(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뛬ꃮ鏰駲郴银跸꣺飼跾栀戂椄渆猈渊缌刎䨐娒笔焖瘘椚瀜縞唠䨢䨤䤦琨瀪栬䄮唰渲渴漶吸场渼娾㍀⩂⑄⭆⁈ㅊ⡌᭎㹐ᕒ㱔㭖㱘ٚ", a_));
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x000FBD28 File Offset: 0x000F9F28
		internal static T XmlDeserializeFromFile<T>(string xmlFilePath)
		{
			int a_ = 3;
			short num = (short)556924928;
			short num2 = num;
			num = (short)268169867;
			short num3 = num;
			num = (short)267580043;
			T result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1586626560;
				if (num != 0)
				{
				}
				global::System.Diagnostics.Trace.WriteLine(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("룢ꫤ藦菨軪軬鯮ꋰ雲蟴黶飸韺铼藾搀焂堄将䀈攊欌怎挐縒琔挖瀘琚猜䈞稠愢䀤䀦䀨䔪瀬琮椰帲头猶尸䠺堼䴾⡀≂⥄⹆㍈⹊ୌ㵎㹐㹒ፔ㹖㕘㹚\\", a_));
				global::System.IO.Stream stream = null;
				try
				{
					global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(T));
					stream = new global::System.IO.FileStream(xmlFilePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
					result = (T)((object)xmlSerializer.Deserialize(stream));
				}
				finally
				{
					num = (short)107872257;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_11D;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_E9;
							}
							continue;
						case 2:
							stream.Close();
							num = (short)126615552;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_E9:
						if (stream == null)
						{
							break;
						}
						num = (short)1475870722;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_11D:
					stream = null;
					global::System.Diagnostics.Trace.WriteLine(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("룢ꫤ藦菨軪軬鯮ꋰ雲蟴黶飸韺铼藾搀焂堄将䀈攊欌怎挐縒琔挖瀘琚猜䈞稠昢䬤䌦琨瀪甬䈮崰眲倴䐶尸䤺吼帾ⵀ⩂㽄≆཈㥊≌≎ᝐ㩒㥔㉖ј", a_));
				}
				break;
			}
			}
			num = (short)1050411009;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x000FBEA4 File Offset: 0x000FA0A4
		public static T DataContract_DeserializeFromFile<T>(string filePath)
		{
			short num = (short)1273430016;
			short num2 = num;
			num = (short)1556380642;
			short num3 = num;
			num = (short)1667005410;
			T result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1721040897;
				if (num != 0)
				{
				}
				num = (short)1381105664;
				if (num != 0)
				{
				}
				global::System.IO.Stream stream = null;
				try
				{
					stream = new global::System.IO.FileStream(filePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
					result = (T)((object)new global::System.Runtime.Serialization.DataContractSerializer(typeof(T)).ReadObject(stream));
				}
				finally
				{
					num = (short)841809921;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_128;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_F4;
							}
							continue;
						case 2:
							stream.Close();
							num = (short)1206190080;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_F4:
						if (stream == null)
						{
							break;
						}
						num = (short)1515585538;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_128:
					stream = null;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x000FBFF0 File Offset: 0x000FA1F0
		public static void DataContract_SerializeToFile(string filePath, object instance)
		{
			short num = (short)349634560;
			short num2 = num;
			num = (short)1928849066;
			short num3 = num;
			num = (short)1936320170;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1676476417;
				if (num != 0)
				{
				}
				num = (short)1039204352;
				if (num != 0)
				{
				}
				global::System.Runtime.Serialization.DataContractSerializer dataContractSerializer = new global::System.Runtime.Serialization.DataContractSerializer(instance.GetType());
				global::System.IO.Stream stream = new global::System.IO.FileStream(filePath, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.ReadWrite);
				try
				{
					stream.SetLength(0L);
					dataContractSerializer.WriteObject(stream, instance);
				}
				finally
				{
					num = (short)311099393;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_126;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_F3;
							}
							continue;
						case 2:
							((global::System.IDisposable)stream).Dispose();
							num = (short)804061184;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_F3:
						if (stream == null)
						{
							break;
						}
						num = (short)646840322;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_126:;
				}
				break;
			}
			}
		}

		// Token: 0x040003A7 RID: 935
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
