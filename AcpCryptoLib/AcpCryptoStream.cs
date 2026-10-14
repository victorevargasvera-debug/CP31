using System;
using System.IO;
using System.Security.Cryptography;

namespace AcpCryptoLib
{
	// Token: 0x0200000C RID: 12
	public class AcpCryptoStream : global::AcpCryptoLib.AcpCryptoBase, global::AcpCryptoLib.IAcpCryptoStream, global::System.IDisposable
	{
		// Token: 0x0600001D RID: 29 RVA: 0x0000465C File Offset: 0x0000285C
		public global::System.IO.Stream GetWriter(global::System.IO.Stream stream)
		{
			int a_ = 0;
			short num = (short)1822162944;
			switch (num)
			{
			default:
			{
				num = (short)1122107392;
				short num2 = num;
				num = (short)2136408065;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1123418113;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_113;
					case 1:
					{
						num = (short)1403185666;
						short num4 = num;
						num = (short)803924482;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_113;
						default:
							num = (short)461176832;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_F7;
							}
							continue;
						}
						break;
					}
					case 2:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_139;
							}
							global::System.Security.Cryptography.ICryptoTransform transform;
							for (;;)
							{
								IL_122:
								switch (num3)
								{
								case 0:
									if (this.a != null)
									{
										num = (short)1994194946;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1C9;
								case 1:
									goto IL_1C9;
								case 2:
									this.a.FlushFinalBlock();
									this.a.Close();
									num = (short)674168833;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_20B;
								}
								goto IL_139;
								IL_1C9:
								this.a = new global::System.Security.Cryptography.CryptoStream(stream, transform, global::System.Security.Cryptography.CryptoStreamMode.Write);
								byte[] array = global::AcpCryptoLib.AcpRNGenerator.GenerateSalt(7, 128);
								this.a.Write(array, 0, array.Length);
								num = (short)2133786627;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_20B:
							goto IL_25F;
							IL_139:
							global::AcpCryptoLib.AcpCryptoHeader acpCryptoHeader = new global::AcpCryptoLib.AcpCryptoHeader();
							stream.Write(acpCryptoHeader.Data, 0, acpCryptoHeader.Data.Length);
							transform = ((global::System.Security.Cryptography.SymmetricAlgorithm)acpCryptoHeader.Key).CreateEncryptor();
							num = (short)1111490560;
							num3 = (int)((global::System.IntPtr)num);
							goto IL_122;
						}
						catch (global::System.Exception ex)
						{
							throw new global::System.Exception(global::AcpCryptoLib.XmlEncryptionUtil.b("뻾戀猂䘄甆瀈笊礌怎䈐朒朔爖砘瘚㌜堞䐠圢爤唦䀨弪䠬崮ᄰḲᔴ父䄸堺堼伾㕀⩂⩄⥆獈歊", a_) + ex.Message);
						}
						goto IL_22D;
					}
					IL_F7:
					if (stream == null)
					{
						num = (short)1564278784;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_22D:
					num = (short)1962999810;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_113:
				throw new global::System.ArgumentNullException(global::AcpCryptoLib.XmlEncryptionUtil.b("곾甀焂怄昆搈⬊攌渎成㌒琔㜖眘渚焜猞Ġ儢䀤䄦䰨太䠬䄮到嘲᬴", a_));
				IL_25F:
				return this.a;
			}
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000048E0 File Offset: 0x00002AE0
		public global::System.IO.Stream GetReader(global::System.IO.Stream stream)
		{
			int a_ = 12;
			short num = (short)943128577;
			if (num != 0)
			{
			}
			num = (short)1954873344;
			short num2 = num;
			num = (short)1350107137;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_EF;
				case 1:
					goto IL_6F;
				case 2:
					try
					{
						switch (0)
						{
						case 0:
							goto IL_114;
						}
						global::System.Security.Cryptography.ICryptoTransform transform;
						for (;;)
						{
							IL_FE:
							switch (num3)
							{
							case 0:
								if (this.b != null)
								{
									num = (short)150077442;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_188;
							case 1:
								goto IL_188;
							case 2:
								this.b.Close();
								num = (short)1198653441;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_1BA;
							}
							goto IL_114;
							IL_188:
							this.b = new global::System.Security.Cryptography.CryptoStream(stream, transform, global::System.Security.Cryptography.CryptoStreamMode.Read);
							base.ExtractSalt(this.b);
							num = (short)1379401731;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_1BA:
						goto IL_20D;
						IL_114:
						transform = ((global::System.Security.Cryptography.SymmetricAlgorithm)new global::AcpCryptoLib.AcpCryptoHeader(base.ExtractHeader(stream)).Key).CreateDecryptor();
						num = (short)1898512384;
						num3 = (int)((global::System.IntPtr)num);
						goto IL_FE;
					}
					catch (global::System.Exception ex)
					{
						throw new global::System.Exception(global::AcpCryptoLib.XmlEncryptionUtil.b("䨊渌缎刐愒气朖洘琚东欞匠䘢䐤䨦ܨ氪䠬嬮挰嘲吴匶尸䤺ᴼሾ慀ق㵄⑆ⱈ㭊㥌♎㹐㵒潔睖", a_) + ex.Message);
					}
					goto IL_1DC;
				}
				goto IL_8B;
				IL_6F:
				switch (0)
				{
				case 0:
				{
					IL_8B:
					if (stream != null)
					{
						goto IL_1DC;
					}
					num = (short)1711206342;
					short num4 = num;
					num = (short)644083654;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6F;
					default:
						num = (short)634191872;
						if (num != 0)
						{
						}
						num = (short)1104150528;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
				}
				continue;
				IL_1DC:
				num = (short)1181614082;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_EF:
			throw new global::System.ArgumentNullException(global::AcpCryptoLib.XmlEncryptionUtil.b("堊礌紎琐爒研㜖焘稚渜㼞䀠̢䬤刦䔨䜪ബ崮吰唲倴䔶尸唺帼娾潀", a_));
			IL_20D:
			return this.b;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00004B10 File Offset: 0x00002D10
		public void Dispose()
		{
			short num;
			try
			{
				num = (short)799866885;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_102;
					case 1:
						goto IL_179;
					case 2:
						goto IL_160;
					case 3:
						goto IL_11A;
					case 4:
						this.a.FlushFinalBlock();
						this.a.Close();
						num = (short)1437138946;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_40;
						}
						continue;
					case 6:
						this.b.Close();
						num = (short)1221787648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_40:
					num = (short)1917201282;
					short num3 = num;
					num = (short)505949058;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_11A:
						if (this.a != null)
						{
							num = (short)430047236;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_160;
					default:
						num = (short)267517953;
						if (num != 0)
						{
						}
						num = (short)1606090752;
						if (num != 0)
						{
						}
						if (this.b != null)
						{
							num = (short)277938182;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					IL_102:
					num = (short)77463555;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_160:
					num = (short)1975648257;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_179:;
			}
			catch (global::System.Exception)
			{
			}
			num = (short)953810944;
			short num4 = num;
		}

		// Token: 0x04000019 RID: 25
		private global::System.Security.Cryptography.CryptoStream a;

		// Token: 0x0400001A RID: 26
		private global::System.Security.Cryptography.CryptoStream b;
	}
}
