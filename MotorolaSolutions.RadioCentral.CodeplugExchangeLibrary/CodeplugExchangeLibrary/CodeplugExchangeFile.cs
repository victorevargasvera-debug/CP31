using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using CodeplugExchangeLibrary.Enums;
using CodeplugExchangeLibrary.Exceptions;
using CodeplugExchangeLibrary.Extensions;
using CodeplugExchangeLibrary.Utilities;
using Ionic.Zip;
using MotorolaSolutions.RadioCentral.CodeplugExchangeLibrary.Extensions;

namespace CodeplugExchangeLibrary
{
	// Token: 0x02000005 RID: 5
	public sealed class CodeplugExchangeFile : global::System.IDisposable
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002660 File Offset: 0x00000860
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00002710 File Offset: 0x00000910
		public bool IsFileValid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)218169344;
				short num2 = num;
				num = (short)2112749569;
				if (num != 0)
				{
				}
				num = (short)1161940854;
				short num3 = num;
				num = (short)1591594870;
				switch (num3 == num)
				{
				}
				num = (short)944373760;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1224802304;
				short num2 = num;
				num = (short)890608830;
				short num3 = num;
				num = (short)1798151358;
				switch (num3 == num)
				{
				}
				num = (short)787283969;
				if (num != 0)
				{
				}
				num = (short)1958805504;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000027C0 File Offset: 0x000009C0
		internal CodeplugExchangeFile(global::Ionic.Zip.ZipFile cxfFile, global::System.Security.SecureString password, global::CodeplugExchangeLibrary.Enums.CodeplugExchangeFileType fileType)
		{
			this.a = cxfFile;
			this.b = password;
			this.c = fileType;
			this.b();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000027F0 File Offset: 0x000009F0
		public void SaveAs(string path)
		{
			short num = (short)1280573440;
			short num2 = num;
			num = (short)1115593733;
			short num3 = num;
			num = (short)1971493893;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)577961984;
				if (num != 0)
				{
				}
				this.a();
				global::System.IO.FileStream fileStream = this.a(path);
				try
				{
					num = (short)987693057;
					if (num != 0)
					{
					}
					this.b(fileStream);
				}
				finally
				{
					num = (short)29884416;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_E5;
							}
							continue;
						case 1:
							goto IL_11A;
						case 2:
							((global::System.IDisposable)fileStream).Dispose();
							num = (short)110493697;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_E5:
						if (fileStream == null)
						{
							break;
						}
						num = (short)1708589058;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_11A:;
				}
				break;
			}
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000292C File Offset: 0x00000B2C
		public global::System.IO.MemoryStream GetStream()
		{
			short num = (short)1552023552;
			short num2 = num;
			num = (short)1543148849;
			short num3 = num;
			num = (short)742495537;
			switch (num3 == num)
			{
			}
			num = (short)1630601217;
			if (num != 0)
			{
			}
			num = (short)1416822784;
			if (num != 0)
			{
			}
			this.a();
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			this.b(memoryStream);
			return memoryStream;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000029EC File Offset: 0x00000BEC
		public byte[] GetCodeplugBytes()
		{
			int a_ = 17;
			short num = (short)142016512;
			short num2 = num;
			num = (short)894605866;
			short num3 = num;
			num = (short)2134022698;
			switch (num3 == num)
			{
			}
			num = (short)902758400;
			if (num != 0)
			{
			}
			num = (short)1927610369;
			if (num != 0)
			{
			}
			this.a();
			return this.c(global::CodeplugExchangeLibrary.Exceptions.InvalidCxfFilePasswordException.b("귍뿏뛑뇓ꛕ듗꿙믛菟迡铣", a_));
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002ABC File Offset: 0x00000CBC
		public global::CodeplugExchangeLibrary.CodeplugExchageFileMetadata GetMetadata()
		{
			int a_ = 8;
			short num = (short)738863078;
			short num2 = num;
			num = (short)1372334054;
			global::CodeplugExchangeLibrary.CodeplugExchageFileMetadata result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)286851073;
				if (num != 0)
				{
				}
				num = (short)616824832;
				if (num != 0)
				{
				}
				num = (short)400359424;
				short num3 = num;
				this.a();
				byte[] bytes = this.c(global::CodeplugExchangeLibrary.Exceptions.InvalidCxfFilePasswordException.b("꣄ꋆ뷈꫊꧌껎ꗐ닒", a_));
				try
				{
					result = global::CodeplugExchangeLibrary.Utilities.XmlProcessingHelper.Deserialize<global::CodeplugExchangeLibrary.CodeplugExchageFileMetadata>(bytes);
				}
				catch (global::System.Exception innerException)
				{
					throw new global::CodeplugExchangeLibrary.Exceptions.CxfFileException(global::CodeplugExchangeLibrary.Exceptions.InvalidCxfFilePasswordException.b("胄뗆믈꓊뿌뻐냒뛔ꋖꯘ꧚룜믞쇠蟢郤闦胨藪諬쿮菰雲致藶郸黺诼雾漀搂┄猆愈渊ⴌ戎琐朒琔猖砘漚簜ㄞĠ瀢䀤䈦न䈪䌬䄮吰䄲ᔴ制䄸䬺堼尾㕀⩂⩄⥆楈ⵊ≌㵎煐㹒㩔╖㱘筚㥜㩞ᕠɢ౤୦ᩨ䕪", a_), innerException);
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002BBC File Offset: 0x00000DBC
		private void b()
		{
			short num = (short)1929117696;
			short num2 = num;
			num = (short)2015387976;
			short num3 = num;
			num = (short)68182344;
			switch (num3 == num)
			{
			}
			num = (short)448200705;
			if (num != 0)
			{
			}
			num = (short)1172570112;
			if (num != 0)
			{
			}
			this.IsFileValid = this.a.IsValidCodeplugExchangeArchive(this.c == global::CodeplugExchangeLibrary.Enums.CodeplugExchangeFileType.Existing);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002C7C File Offset: 0x00000E7C
		private byte[] c(string A_0)
		{
			short num = (short)712966144;
			short num2 = num;
			num = (short)1516777381;
			short num3 = num;
			num = (short)1179725733;
			byte[] result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1358364672;
				if (num != 0)
				{
				}
				global::System.IO.MemoryStream memoryStream = this.b(A_0);
				try
				{
					num = (short)25821185;
					if (num != 0)
					{
					}
					result = memoryStream.ToArray();
				}
				finally
				{
					num = (short)2089680896;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_DE;
							}
							continue;
						case 1:
							goto IL_113;
						case 2:
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)2119630849;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_DE:
						if (memoryStream == null)
						{
							break;
						}
						num = (short)794689538;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_113:;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002DB0 File Offset: 0x00000FB0
		private global::System.IO.MemoryStream b(string A_0)
		{
			int a_ = 4;
			short num = (short)1061349201;
			short num2 = num;
			num = (short)616163153;
			global::System.IO.MemoryStream memoryStream;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1080623105;
				if (num != 0)
				{
				}
				num = (short)465174528;
				if (num != 0)
				{
				}
				num = (short)1395261440;
				switch (num)
				{
				default:
				{
					num = (short)1869676544;
					short num3 = num;
					global::Ionic.Zip.ZipEntry zipEntry = this.a[A_0];
					memoryStream = new global::System.IO.MemoryStream();
					try
					{
						num = (short)349569024;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_115;
								}
								continue;
							case 1:
								goto IL_192;
							case 2:
								zipEntry.ExtractWithPassword(memoryStream, this.b.ToPlainString());
								num = (short)481886212;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_1AA;
							case 4:
								goto IL_192;
							}
							IL_115:
							if (this.c == global::CodeplugExchangeLibrary.Enums.CodeplugExchangeFileType.Existing)
							{
								num = (short)691798018;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							zipEntry.InputStream.Position = 0L;
							zipEntry.InputStream.CopyTo(memoryStream);
							num = (short)1075183617;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_192:
							num = (short)1967783939;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_1AA:;
					}
					catch (global::Ionic.Zip.BadPasswordException innerException)
					{
						throw new global::CodeplugExchangeLibrary.Exceptions.InvalidCxfFilePasswordException(global::CodeplugExchangeLibrary.Exceptions.InvalidCxfFilePasswordException.b("裀귂도ꛆꗈꋊ꧌ꇐ닒ꛔꓖ께듚꿜믞쇠铢蓤铦짨鯪鿬胮蟰髲釴鋶鷸\udbfa鯼郾猀⌂焄漆氈⬊丌圎圐㌒猔縖甘縚", a_), innerException);
					}
					catch (global::System.Exception innerException2)
					{
						throw new global::CodeplugExchangeLibrary.Exceptions.InvalidCxfFileException(global::CodeplugExchangeLibrary.Exceptions.InvalidCxfFilePasswordException.b("蓀뇂럄꣆믈ꋌ곎닐ꛒ꟔닖뷘ﯚꫜ럞裠迢胤쟦鯨軪駬鷮飰雲菴黶韸鳺\uddfc鯾怀眂搄✆漈礊戌戎ㄐ爒朔琖焘爚欜稞༠", a_), innerException2);
					}
					break;
				}
				}
				break;
			}
			return memoryStream;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002FB4 File Offset: 0x000011B4
		private void b(global::System.IO.Stream A_0)
		{
			short num = (short)1705377792;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::Ionic.Zip.ZipEntry> enumerator;
				switch (num2)
				{
				case 0:
					num = (short)1443692545;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				case 1:
					try
					{
						num = (short)1658322944;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_B6;
								}
								continue;
							case 1:
								if (!enumerator.MoveNext())
								{
									num = (short)550240260;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								enumerator.Current.Password = this.b.ToPlainString();
								num = (short)1223098370;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_12F;
							case 4:
								num = (short)8650755;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_E4:
							num = (short)1752367105;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_B6:
							goto IL_E4;
						}
						IL_12F:
						goto IL_24B;
					}
					finally
					{
						num = (short)1671692288;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_165;
								}
								continue;
							case 1:
								goto IL_1EC;
							case 2:
							{
								num = (short)1733495469;
								short num3 = num;
								num = (short)1818036909;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1EC;
								default:
									num = (short)352714752;
									if (num != 0)
									{
									}
									enumerator.Dispose();
									num = (short)53411841;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_165:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1951858690;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1EC:;
					}
					goto IL_1EF;
				case 2:
					goto IL_79;
				}
				IL_58:
				if (this.c == global::CodeplugExchangeLibrary.Enums.CodeplugExchangeFileType.Existing)
				{
					num = (short)325124098;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1EF:
				num = (short)955449344;
				short num4 = num;
				enumerator = this.a.GetEnumerator();
				num = (short)1250426881;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_79:
			this.a(A_0);
			return;
			IL_24B:
			this.a(A_0);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003224 File Offset: 0x00001424
		private void a(global::System.IO.Stream A_0)
		{
			int a_ = 9;
			short num;
			try
			{
				num = (short)103411907;
				short num2 = num;
				num = (short)2050093251;
				switch (num2 == num)
				{
				}
				num = (short)1818034177;
				if (num != 0)
				{
				}
				num = (short)1672478720;
				if (num != 0)
				{
				}
				this.a.Save(A_0);
				A_0.Position = 0L;
			}
			catch (global::System.Exception innerException)
			{
				throw new global::CodeplugExchangeLibrary.Exceptions.CxfFileException(global::CodeplugExchangeLibrary.Exceptions.InvalidCxfFilePasswordException.b("菅뫇룉ꏋ볍뷑럓뗕귗꣙껛믝蓟싡胣鏥髧菩苫觭탯臱闳胵釷铹鯻\udefd瓿洁␃怅愇昉椋‍』䘑易漕㠗笙笛缝䤟䰡У䨥䤧帩䤫尭ḯ", a_), innerException);
			}
			num = (short)1674641408;
			short num3 = num;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003314 File Offset: 0x00001514
		private global::System.IO.FileStream a(string A_0)
		{
			int a_ = 5;
			short num;
			global::System.IO.FileStream result;
			try
			{
				num = (short)2109518150;
				short num2 = num;
				num = (short)1645654342;
				switch (num2 == num)
				{
				}
				num = (short)2087256064;
				if (num != 0)
				{
				}
				result = global::System.IO.File.Create(A_0);
			}
			catch (global::System.Exception innerException)
			{
				throw new global::CodeplugExchangeLibrary.Exceptions.CxfFileException(global::CodeplugExchangeLibrary.Exceptions.InvalidCxfFilePasswordException.b("蓁귃꫅귇꿋볍뗏돑ꃓ뿕럗듙ﳛ룝臟诡裣菥賧쓩쳫뫭苯诱퓳韵鿷鯹闻都⃿渁攃爅洇砉∋", a_), innerException);
			}
			num = (short)2012610561;
			if (num != 0)
			{
			}
			num = (short)1420951552;
			short num3 = num;
			return result;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000033F4 File Offset: 0x000015F4
		private void a()
		{
			int a_ = 4;
			short num;
			if (!this.IsFileValid)
			{
				num = (short)1584136193;
				if (num != 0)
				{
				}
				num = (short)479959679;
				short num2 = num;
				num = (short)561355391;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)27918336;
					if (num != 0)
					{
					}
					throw new global::CodeplugExchangeLibrary.Exceptions.InvalidCxfFileException(global::CodeplugExchangeLibrary.Exceptions.InvalidCxfFilePasswordException.b("闀ꯂꃄ諈鏊诌럐뫒맔닖律뿚드믞迠쓢釤쟦駨諪黬鳮퇰藲铴鯶郸鿺鳼课栀氂欄⤆⤈弊缌瘎ㄐ眒簔焖缘縚漜稞传圢Ԥ䠦䜨个̬", a_));
				}
			}
			num = (short)608960512;
			short num3 = num;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000034C8 File Offset: 0x000016C8
		public void Dispose()
		{
			short num = (short)92545026;
			short num2 = num;
			num = (short)826810370;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1898381312;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)767033344;
			if (num != 0)
			{
			}
			num = (short)714932225;
			if (num != 0)
			{
			}
			this.a.Dispose();
		}

		// Token: 0x04000005 RID: 5
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		private readonly global::Ionic.Zip.ZipFile a;

		// Token: 0x04000006 RID: 6
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		private readonly global::System.Security.SecureString b;

		// Token: 0x04000007 RID: 7
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		private readonly global::CodeplugExchangeLibrary.Enums.CodeplugExchangeFileType c;

		// Token: 0x04000008 RID: 8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool d;
	}
}
