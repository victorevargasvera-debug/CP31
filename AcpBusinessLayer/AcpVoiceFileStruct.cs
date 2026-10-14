using System;
using System.IO;
using ACPVoiceAnnouncementLib;

namespace AcpBusinessLayer
{
	// Token: 0x02000024 RID: 36
	[global::System.Serializable]
	public struct AcpVoiceFileStruct : global::System.IComparable, global::System.IComparable<global::AcpBusinessLayer.AcpVoiceFileStruct>
	{
		// Token: 0x060002FA RID: 762 RVA: 0x0003A6A8 File Offset: 0x000388A8
		public AcpVoiceFileStruct(string voicefile)
		{
			try
			{
				global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementFileClass acpmotVoiceAnnouncementFileClass = global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementFileClass.LoadFromFile(voicefile);
				if (acpmotVoiceAnnouncementFileClass != null)
				{
					this.compressionParam = acpmotVoiceAnnouncementFileClass.CompressionParam;
					this.compressionType = acpmotVoiceAnnouncementFileClass.CompressionType;
					this.hashcode = acpmotVoiceAnnouncementFileClass.CheckSum32;
					this.voiceData = new global::System.IO.MemoryStream(acpmotVoiceAnnouncementFileClass.VoiceData, 0, acpmotVoiceAnnouncementFileClass.VoiceData.Length, true, true);
					this.voicefile = voicefile;
				}
				else
				{
					this.compressionParam = 6;
					this.compressionType = global::ACPVoiceAnnouncementLib.MotVoiceFileCompressionCode.AMR;
					this.voiceData = new global::System.IO.MemoryStream();
					this.voicefile = "";
					this.hashcode = 0U;
				}
			}
			catch
			{
				this.compressionParam = 6;
				this.compressionType = global::ACPVoiceAnnouncementLib.MotVoiceFileCompressionCode.AMR;
				this.voiceData = new global::System.IO.MemoryStream();
				this.voicefile = "";
				this.hashcode = 0U;
			}
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0003A77C File Offset: 0x0003897C
		public int CompareTo(object obj)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			int result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1560621790;
					short num3 = num2;
					num2 = (short)1602433758;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
					{
						num2 = (short)967639040;
						if (num2 != 0)
						{
						}
						num2 = (short)585105408;
						short num4 = num2;
						num2 = (short)1230897153;
						if (num2 != 0)
						{
						}
						if (obj != null)
						{
							num2 = (short)1944584193;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					}
					break;
				}
				case 1:
				{
					global::AcpBusinessLayer.AcpVoiceFileStruct vaObj = (global::AcpBusinessLayer.AcpVoiceFileStruct)obj;
					result = this.CompareTo(vaObj);
					num2 = (short)525860866;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					return result;
				}
				goto IL_1C;
			}
			return result;
			IL_1C:
			result = -1;
			num2 = (short)1032650752;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0003A89C File Offset: 0x00038A9C
		public static global::AcpBusinessLayer.AcpVoiceFileStruct Parse(string vaVal)
		{
			switch (0)
			{
			case 0:
				goto IL_4E;
			}
			short num;
			int num3;
			global::AcpBusinessLayer.AcpVoiceFileStruct result;
			for (;;)
			{
				IL_0A:
				num = (short)857407488;
				short num2 = num;
				switch (num3)
				{
				case 0:
					num = (short)1936588804;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return result;
				case 2:
					if (vaVal != null)
					{
						num = (short)855769088;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 3:
				{
					for (;;)
					{
						num = (short)1043113249;
						short num4 = num;
						num = (short)1506845985;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_BD;
						}
					}
					IL_BD:
					num = (short)711983105;
					if (num != 0)
					{
					}
					num = (short)458162176;
					if (num != 0)
					{
					}
					result.compressionType = global::ACPVoiceAnnouncementLib.MotVoiceFileCompressionCode.AMR;
					result.compressionParam = 6;
					byte[] array = global::AcpBusinessLayer.VAUtilities.StrToByteArray(vaVal);
					result.voiceData = new global::System.IO.MemoryStream(array, 0, array.Length, true, true);
					result.hashcode = result.GetHashCode();
					num = (short)1813315585;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					if (vaVal != string.Empty)
					{
						num = (short)1026949123;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				}
				goto IL_4E;
			}
			return result;
			IL_4E:
			result = default(global::AcpBusinessLayer.AcpVoiceFileStruct);
			num = (short)899940354;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0003AA38 File Offset: 0x00038C38
		public int getVoiceFileDuration()
		{
			short num = (short)1265827840;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_72;
				}
				int num3;
				int num4;
				int num7;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_21E;
					case 1:
					{
						num3 = (int)this.voiceData.Length - 6;
						num4 = 20;
						int num5 = this.compressionParam;
						num = (short)1511063562;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_21E;
					case 3:
						if (num3 > 0)
						{
							num = (short)219414536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return 0;
					case 4:
						goto IL_1A3;
					case 5:
						num = (short)1904410635;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_21E;
					case 7:
						goto IL_21E;
					case 8:
						num = (short)1163067393;
						if (num != 0)
						{
						}
						num = (short)711524365;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (this.compressionType == global::ACPVoiceAnnouncementLib.MotVoiceFileCompressionCode.AMR)
						{
							num = (short)164102145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21E;
					case 10:
					{
						int num5;
						switch (num5)
						{
						case 0:
						{
							num = (short)1596260352;
							short num6 = num;
							num7 = 13;
							num = (short)142868494;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							num7 = 14;
							num = (short)865533954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							num = (short)1883784560;
							short num8 = num;
							num = (short)1878410608;
							switch ((num8 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)478347264;
								if (num != 0)
								{
								}
								num7 = 16;
								num = (short)1113849871;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							num7 = 18;
							num = (short)1074921472;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							break;
						case 5:
							num7 = 21;
							num = (short)2087911440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							num7 = 27;
							num = (short)1652948999;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							num7 = 32;
							num = (short)1415249932;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)2059730949;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num7 = 20;
						num = (short)1855586310;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_21E;
					case 12:
						goto IL_21E;
					case 13:
						if (num7 > 0)
						{
							num = (short)1137180676;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return 0;
					case 14:
						goto IL_21E;
					case 15:
						goto IL_21E;
					case 16:
						goto IL_21E;
					}
					goto IL_72;
					IL_21E:
					num = (short)1145569283;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1A3:
				return num4 * (num3 / num7);
				IL_72:
				num4 = 20;
				num7 = 0;
				num3 = 0;
				num = (short)1369440265;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0003ADA0 File Offset: 0x00038FA0
		public int CompareTo(global::AcpBusinessLayer.AcpVoiceFileStruct vaObj)
		{
			short num = (short)841809920;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_64;
				}
				int result;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
					{
						int num3;
						if ((long)num3 >= this.voiceData.Length)
						{
							num = (short)2059075588;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)699531274;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						byte[] buffer = this.voiceData.GetBuffer();
						byte[] buffer2 = vaObj.voiceData.GetBuffer();
						result = 0;
						int num3 = 0;
						num = (short)2105278465;
						if (num != 0)
						{
						}
						num = (short)1070333961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_17C;
					case 3:
						result = -1;
						num = (short)800784390;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_1C0;
					case 5:
						if (this.voiceData != null)
						{
							num = (short)426508296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 6:
						goto IL_E8;
					case 7:
						if (this.voiceData.Length == vaObj.voiceData.Length)
						{
							num = (short)332791809;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 8:
						num = (short)151977995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_17C;
					case 10:
					{
						int num3;
						byte[] buffer;
						byte[] buffer2;
						if (buffer[num3] != buffer2[num3])
						{
							num = (short)2054553603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3++;
						num = (short)818937858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						if (vaObj.voiceData != null)
						{
							num = (short)756875276;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 12:
						num = (short)1493172231;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_64;
					IL_17C:
					num = (short)286261248;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E8:
				return result;
				IL_1C0:
				num = (short)2089619077;
				short num4 = num;
				num = (short)617090693;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)344457216;
					if (num != 0)
					{
					}
					break;
				}
				return result;
				IL_64:
				result = -1;
				num = (short)1921646592;
				short num5 = num;
				num = (short)139329541;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0003B080 File Offset: 0x00039280
		public new uint GetHashCode()
		{
			while (this.voiceData != null)
			{
				short num = (short)1980238774;
				short num2 = num;
				num = (short)328338358;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num = (short)1271267328;
					short num3 = num;
					break;
				}
				}
				num = (short)533200897;
				if (num != 0)
				{
				}
				num = (short)1135542272;
				if (num != 0)
				{
				}
				return global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementFileClass.CalculateHashcode(this.voiceData.GetBuffer(), 0, (int)this.voiceData.Length);
			}
			return 0U;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0003B154 File Offset: 0x00039354
		public override string ToString()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			string result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1900635681;
					short num3 = num2;
					num2 = (short)486630945;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
					{
						num2 = (short)268304384;
						if (num2 != 0)
						{
						}
						num2 = (short)2110521344;
						short num4 = num2;
						num2 = (short)38600705;
						if (num2 != 0)
						{
						}
						if (this.voiceData != null)
						{
							num2 = (short)799997953;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					}
					break;
				}
				case 1:
					result = global::AcpBusinessLayer.VAUtilities.ByteArrayToStr(this.voiceData.GetBuffer(), (int)this.voiceData.Length);
					num2 = (short)524156930;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return result;
				}
				goto IL_1C;
			}
			return result;
			IL_1C:
			result = string.Empty;
			num2 = (short)1997668352;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040000A0 RID: 160
		public global::System.IO.MemoryStream voiceData;

		// Token: 0x040000A1 RID: 161
		public int compressionParam;

		// Token: 0x040000A2 RID: 162
		public global::ACPVoiceAnnouncementLib.MotVoiceFileCompressionCode compressionType;

		// Token: 0x040000A3 RID: 163
		public string voicefile;

		// Token: 0x040000A4 RID: 164
		public uint hashcode;
	}
}
