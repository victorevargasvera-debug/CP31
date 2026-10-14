using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Xml;
using ASK.Core;
using ASK.Interface;
using ASKLib;

namespace CommonASK
{
	// Token: 0x02000004 RID: 4
	public class MockSystemKeyManager : global::ASK.Interface.ISystemKeyManager
	{
		// Token: 0x0600000E RID: 14 RVA: 0x000027C8 File Offset: 0x000009C8
		private global::ASK.Interface.SystemKeyPermissionData a(int A_0, global::ASK.Interface.KeyType A_1, global::ASK.Interface.KeySource A_2, global::ASK.Core.AccessRecord A_3, string A_4, bool A_5, global::System.DateTime? A_6)
		{
			short num = (short)1571655962;
			short num2 = num;
			num = (short)1391497498;
			switch (num2 == num)
			{
			}
			num = (short)1016922112;
			if (num != 0)
			{
			}
			num = (short)1672806400;
			short num3 = num;
			num = (short)1549664257;
			if (num != 0)
			{
			}
			string accessLevel = string.Empty;
			accessLevel = A_3.ToXMLString();
			global::ASK.Interface.SystemKeyPermissionData systemKeyPermissionData = new global::ASK.Interface.SystemKeyPermissionData
			{
				UuId = global::System.Guid.NewGuid(),
				SystemID = A_0,
				Type = (int)A_1,
				Source = (int)A_2,
				AccessLevel = accessLevel,
				SerialNumber = A_4,
				NeverExpires = A_5,
				ExpirationDate = A_6
			};
			systemKeyPermissionData.CheckSum = global::ASK.Core.AcpSecurity.CalculateCheckSum(new string[]
			{
				systemKeyPermissionData.UuId.ToString(),
				systemKeyPermissionData.SystemID.ToString(global::System.Globalization.CultureInfo.InvariantCulture),
				systemKeyPermissionData.Type.ToString(global::System.Globalization.CultureInfo.InvariantCulture),
				systemKeyPermissionData.Source.ToString(global::System.Globalization.CultureInfo.InvariantCulture),
				systemKeyPermissionData.SerialNumber,
				systemKeyPermissionData.NeverExpires.ToString(),
				systemKeyPermissionData.ExpirationDate.ToString(),
				systemKeyPermissionData.AccessLevel
			});
			return systemKeyPermissionData;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000296C File Offset: 0x00000B6C
		private global::ASK.Interface.SystemKeyPermissionData b(global::ASK.Interface.ISystemKeyData A_0)
		{
			while (A_0.AccessLevelType == global::ASK.Interface.KeyAccessLevelType.LIMITED_ACC)
			{
				short num = (short)226912350;
				short num2 = num;
				num = (short)1271621726;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)774373376;
					short num3 = num;
					num = (short)555024385;
					if (num != 0)
					{
					}
					num = (short)1631387648;
					if (num != 0)
					{
					}
					global::ASK.Core.AccessRecord a_ = this.a(A_0.OtapEnabled);
					return this.a(A_0.SystemID, A_0.Type, A_0.Source, a_, A_0.iBtnSerialNum, true, null);
				}
				}
			}
			global::ASK.Core.AccessRecord a_2 = this.a(A_0.OtapEnabled, A_0.WriteProtectEnabled);
			return this.a(A_0.SystemID, A_0.Type, A_0.Source, a_2, A_0.iBtnSerialNum, true, null);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002A94 File Offset: 0x00000C94
		private global::ASK.Core.AccessRecord a(bool A_0)
		{
			int a_ = 9;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			string text;
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					text += global::CommonASK.SystemKeyHelper.b("儤唦尨个", a_);
					num2 = (short)1795948547;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (A_0)
					{
						num2 = (short)235864064;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					text += global::CommonASK.SystemKeyHelper.b("䌤䘦䔨堪䠬", a_);
					num2 = (short)1001586690;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_176;
				case 3:
					goto IL_1CB;
				}
				goto IL_29;
			}
			IL_176:
			num2 = (short)477626369;
			if (num2 != 0)
			{
			}
			IL_1CB:
			text += global::CommonASK.SystemKeyHelper.b("Ԥᬦب搪礬渮愰怲䄴嘶䴸为丼ľ䭀", a_);
			text += global::CommonASK.SystemKeyHelper.b("Ⱔᬦب礪䠬䰮帰䄲儴श㌸", a_);
			global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
			xmlDocument.LoadXml(text);
			return new global::ASK.Core.AccessRecord(xmlDocument.DocumentElement, true);
			IL_29:
			num2 = (short)556335104;
			short num3 = num2;
			num2 = (short)1911248147;
			short num4 = num2;
			num2 = (short)1646548243;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_13;
			default:
			{
				num2 = (short)2123235328;
				if (num2 != 0)
				{
				}
				text = "";
				text += global::CommonASK.SystemKeyHelper.b("Ⱔᬦ笨个丬䀮䌰圲଴㴶〸㈺ļ績≀⁂⁄㑆㩈Պⱌ≎㑐浒畔ᩖ㙘㡚㙜ᑞѠᩢ⍤ࡦ᭨㽪࡬ᱮհひᑴѶᱸ孺䅼偾삀愈쎌ﲐꮔ鶖邘銚ꆜ\ud99e좠욢즤쎦쒪즬쪮辰鎲", a_);
				text += global::CommonASK.SystemKeyHelper.b("ᔤᜦᤨᬪᴬἮİ̲Դܶस଺഼༾煀獂畄睆祈筊経罎慐捒敔杖楘歚浜潞兠卢呤坦婨孪嵬屮ၰ䙲䕴䕶䥸䵺䩼᥾뚀", a_);
				text += global::CommonASK.SystemKeyHelper.b("Ԥᬦب洪䐬䨮崰圲瘴堶崸帺̼㔾䡀䩂祄୆⁈♊⑌㭎㑐㝒ᅔ㙖ⵘ㩚ཛྷ㩞ɠౢᝤͦ❨Ṫl兮兰", a_);
				text = text + string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::CommonASK.SystemKeyHelper.b("帤ᜦ吨", a_), 0) + global::CommonASK.SystemKeyHelper.b("Ԥᬦب未䐬䈮堰䜲倴匶紸娺䤼帾ፀ♂♄⡆㭈⽊͌㩎㱐浒彔幖偘杚ቜ୞⁠㍢㙤፦ࡨὪᡬᱮ佰卲", a_);
				num2 = (short)79626241;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002CB0 File Offset: 0x00000EB0
		private global::ASK.Core.AccessRecord a(bool A_0, bool A_1)
		{
			int a_ = 17;
			switch (0)
			{
			case 0:
				goto IL_61;
			}
			short num;
			int num2;
			string text;
			for (;;)
			{
				IL_13:
				num = (short)1537277953;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					if (A_0)
					{
						num = (short)1951662086;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					text += global::CommonASK.SystemKeyHelper.b("䬬丮崰䀲倴", a_);
					num = (short)1483407367;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					text += global::CommonASK.SystemKeyHelper.b("䬬䤮地唲匴儶弸崺嬼夾❀╂⍄ⅆ⽈ⵊ⭌⥎㝐㕒㍔ㅖ㽘㵚㭜㥞ݠբͤŦཨ൪୬८ᝰᕲ፴ᅶὸᵺ᭼᥾", a_);
					num = (short)620560388;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (A_1)
					{
						num = (short)1612513281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					text += global::CommonASK.SystemKeyHelper.b("䬬䤮地唲匴儶弸崺嬼夾❀╂⍄ⅆ⽈ⵊ⭌⥎㝐㕒㍔ㅖ㽘㵚㭜㥞ݠ呢ͤŦཨ൪୬८ᝰᕲ፴ᅶὸᵺ᭼᥾", a_);
					num = (short)783679491;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					IL_21D:
					goto IL_E5;
				case 4:
					goto IL_E5;
				case 5:
					goto IL_222;
				case 6:
					text += global::CommonASK.SystemKeyHelper.b("夬崮䐰嘲", a_);
					num = (short)273350661;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					num = (short)772407296;
					short num3 = num;
					goto IL_222;
				}
				}
				goto IL_61;
				IL_E5:
				text += global::CommonASK.SystemKeyHelper.b("ബጮḰ甲尴制唸强縼倾╀♂筄䵆䁈䉊煌͎㡐㹒㱔⍖㱘㽚ᥜ㹞ᕠɢ㝤ɦ੨ѪὬ୮㽰ٲᡴ䥶奸", a_);
				text = text + string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::CommonASK.SystemKeyHelper.b("嘬Ἦ䰰", a_), 0) + global::CommonASK.SystemKeyHelper.b("ബጮḰ缲尴娶倸伺堼嬾Հ≂ㅄ♆ᭈ⹊⹌⁎⍐㝒᭔≖㑘敚坜噞桠形⩤㍦⡨㭪㹬᭮ၰݲtѶ䝸孺", a_);
				num = (short)562167808;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_222:
				num = (short)1284153267;
				short num4 = num;
				num = (short)380346291;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_21D;
				default:
					goto IL_258;
				}
			}
			IL_258:
			num = (short)1583546368;
			if (num != 0)
			{
			}
			text += global::CommonASK.SystemKeyHelper.b("ബጮḰ簲愴瘶椸栺䤼帾㕀㙂㙄祆䍈", a_);
			text += global::CommonASK.SystemKeyHelper.b("␬ጮḰ愲倴吶嘸䤺夼ľ䭀", a_);
			global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
			xmlDocument.LoadXml(text);
			return new global::ASK.Core.AccessRecord(xmlDocument.DocumentElement, true);
			IL_61:
			text = "";
			text += global::CommonASK.SystemKeyHelper.b("␬ጮ挰嘲嘴堶䬸强̼㔾䡀䩂祄ن⩈⡊⡌㱎≐ᵒ㑔㩖㱘敚絜቞๠b๤ⱦ౨ቪ⭬nͰ❲ၴѶ൸㡺ᱼ౾ꎂ름ꢆ좈\udb94ﺚꎜ閞ꢠꪢ馤삨캪솬쮮\udcb2톴튶螸鮺", a_);
			num = (short)1092157442;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002F6C File Offset: 0x0000116C
		private bool a(global::ASK.Interface.ISystemKeyData A_0)
		{
			short num = (short)2035417088;
			short num2 = num;
			num = (short)1662572840;
			short num3 = num;
			num = (short)1668995368;
			bool result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1409613824;
				if (num != 0)
				{
				}
				result = false;
				global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator = this.a.LoadedUserSystemKeys.GetEnumerator();
				try
				{
					num = (short)595656709;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
						{
							global::ASK.Interface.ISystemKeyData systemKeyData;
							if (systemKeyData.SystemID == A_0.SystemID)
							{
								num = (short)420216841;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							goto IL_217;
						case 2:
						{
							global::ASK.Interface.ISystemKeyData systemKeyData;
							if (systemKeyData.Source == A_0.Source)
							{
								num = (short)823001091;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							num = (short)108068871;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_1B5;
						case 5:
							switch (0)
							{
							case 0:
								goto IL_D9;
							}
							continue;
						case 6:
							num = (short)336068609;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
						{
							global::ASK.Interface.ISystemKeyData systemKeyData;
							if (systemKeyData.Type == A_0.Type)
							{
								num = (short)1660289034;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 8:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1481572358;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::ASK.Interface.ISystemKeyData systemKeyData = enumerator.Current;
							num = (short)1228668928;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							num = (short)863764482;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							result = true;
							num = (short)1184628740;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_116:
						num = (short)1895825416;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_D9:
						goto IL_116;
					}
					IL_1B5:
					IL_217:;
				}
				finally
				{
					num = (short)2138832896;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_249;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)1774714882;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_27D;
						}
						IL_249:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1629356033;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_27D:;
				}
				break;
			}
			}
			num = (short)1622736897;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00003240 File Offset: 0x00001440
		public MockSystemKeyManager()
		{
			this.a = global::ASKLib.SystemKeyManager.GetInstance();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003260 File Offset: 0x00001460
		public bool LoadMockSystemKey(global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> keyDataCollection)
		{
			short num = (short)598212608;
			short num2 = num;
			num = (short)570359423;
			short num3 = num;
			num = (short)112721535;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1846542336;
				if (num != 0)
				{
				}
				num = (short)1069088768;
				switch (num)
				{
				}
				break;
			}
			bool result = true;
			global::System.Collections.Generic.List<global::ASK.Interface.SystemKeyPermissionData> list = new global::System.Collections.Generic.List<global::ASK.Interface.SystemKeyPermissionData>();
			global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator = keyDataCollection.GetEnumerator();
			try
			{
				num = (short)626458625;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						num = (short)2060255236;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_DE;
						}
						continue;
					case 3:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)701169664;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::ASK.Interface.ISystemKeyData a_ = enumerator.Current;
						list.Add(this.b(a_));
						num = (short)1392967682;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_159;
					}
					IL_10C:
					num = (short)586678275;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_DE:
					goto IL_10C;
				}
				IL_159:;
			}
			finally
			{
				num = (short)1701380097;
				if (num != 0)
				{
				}
				num = (short)828506112;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_1B8;
						}
						continue;
					case 1:
						enumerator.Dispose();
						num = (short)885522434;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_1ED;
					}
					IL_1B8:
					if (enumerator == null)
					{
						break;
					}
					num = (short)705232897;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_1ED:;
			}
			this.a.LoadUserKeys(list);
			return result;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000347C File Offset: 0x0000167C
		public void RemoveAllMockKeys()
		{
			short num = (short)1379245947;
			short num2 = num;
			num = (short)998154107;
			switch (num2 == num)
			{
			}
			num = (short)1422655489;
			if (num != 0)
			{
			}
			num = (short)1588264960;
			short num3 = num;
			num = (short)68878336;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.List<global::ASK.Interface.SystemKeyPermissionData> userSysKeyPermissions = new global::System.Collections.Generic.List<global::ASK.Interface.SystemKeyPermissionData>();
			this.a.LoadUserKeys(userSysKeyPermissions);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00003538 File Offset: 0x00001738
		public void AddUserKeys(global::System.Collections.Generic.List<global::ASK.Interface.SystemKeyPermissionData> userSysKeyPermissions)
		{
			short num = (short)883556353;
			if (num != 0)
			{
			}
			num = (short)1376886207;
			short num2 = num;
			num = (short)371957183;
			switch (num2 == num)
			{
			}
			num = (short)1221197824;
			short num3 = num;
			num = (short)114098176;
			if (num != 0)
			{
			}
			this.a.AddUserKeys(userSysKeyPermissions);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000035F0 File Offset: 0x000017F0
		public bool IsAnyUnLimitedASKLoaded()
		{
			short num = (short)1983856408;
			short num2 = num;
			num = (short)922435352;
			switch (num2 == num)
			{
			}
			num = (short)1479540737;
			if (num != 0)
			{
			}
			num = (short)1658847232;
			short num3 = num;
			num = (short)704970752;
			if (num != 0)
			{
			}
			return this.a.IsAnyUnLimitedASKLoaded();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000036A4 File Offset: 0x000018A4
		public bool IsFieldEditable(global::ASK.Interface.AccessElementIDType id, global::ASK.Interface.KeyType type, int sysId, bool bAskOnly)
		{
			short num = (short)468251363;
			short num2 = num;
			num = (short)1217852131;
			switch (num2 == num)
			{
			}
			num = (short)596770816;
			if (num != 0)
			{
			}
			num = (short)222363648;
			short num3 = num;
			num = (short)1731198977;
			if (num != 0)
			{
			}
			return this.a.IsFieldEditable(id, type, sysId, bAskOnly);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003760 File Offset: 0x00001960
		public bool IsRangeField(global::ASK.Interface.AccessElementIDType id)
		{
			short num = (short)1109170990;
			short num2 = num;
			num = (short)1506122542;
			switch (num2 == num)
			{
			}
			num = (short)425656321;
			if (num != 0)
			{
			}
			num = (short)1724907520;
			short num3 = num;
			num = (short)1919352832;
			if (num != 0)
			{
			}
			return this.a.IsRangeField(id);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003814 File Offset: 0x00001A14
		public bool IsRangeValueValid(global::ASK.Interface.AccessElementIDType id, global::ASK.Interface.KeyType type, int sysId, int value, bool bAskOnly)
		{
			short num = (short)1156839411;
			short num2 = num;
			num = (short)913962995;
			switch (num2 == num)
			{
			}
			num = (short)253558785;
			if (num != 0)
			{
			}
			num = (short)1031995392;
			short num3 = num;
			num = (short)1925382144;
			if (num != 0)
			{
			}
			return this.a.IsRangeValueValid(id, type, sysId, value, bAskOnly);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000038D0 File Offset: 0x00001AD0
		public bool IsSystemKeyLoaded(int systemId, global::ASK.Interface.KeyType keyType, bool bAskOnly)
		{
			short num = (short)50661637;
			short num2 = num;
			num = (short)1495599365;
			switch (num2 == num)
			{
			}
			num = (short)1048969216;
			if (num != 0)
			{
			}
			num = (short)1036976128;
			short num3 = num;
			num = (short)548143105;
			if (num != 0)
			{
			}
			return this.a.IsSystemKeyLoaded(systemId, keyType, bAskOnly);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003988 File Offset: 0x00001B88
		public bool IsUnLimitedASKLoaded(int systemId, global::ASK.Interface.KeyType keyType, bool bSearchWriteProtectOnly)
		{
			short num = (short)256311297;
			if (num != 0)
			{
			}
			num = (short)1034809486;
			short num2 = num;
			num = (short)1839132814;
			switch (num2 == num)
			{
			}
			num = (short)236584960;
			short num3 = num;
			num = (short)2129330176;
			if (num != 0)
			{
			}
			return this.a.IsUnLimitedASKLoaded(systemId, keyType, bSearchWriteProtectOnly);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003A40 File Offset: 0x00001C40
		public int LoadUserKeys(global::System.Collections.Generic.List<global::ASK.Interface.SystemKeyPermissionData> userSysKeyPermissions)
		{
			short num = (short)1357053953;
			if (num != 0)
			{
			}
			num = (short)1845706424;
			short num2 = num;
			num = (short)2142518968;
			switch (num2 == num)
			{
			}
			num = (short)1986461696;
			short num3 = num;
			num = (short)1178730496;
			if (num != 0)
			{
			}
			return this.a.LoadUserKeys(userSysKeyPermissions);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003AF8 File Offset: 0x00001CF8
		public void ClearUserKeys()
		{
			short num = (short)1649871237;
			short num2 = num;
			num = (short)809961861;
			switch (num2 == num)
			{
			}
			num = (short)1536360449;
			if (num != 0)
			{
			}
			num = (short)1252917248;
			short num3 = num;
			num = (short)802095104;
			if (num != 0)
			{
			}
			this.a.ClearUserKeys();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003BAC File Offset: 0x00001DAC
		public global::System.Collections.Generic.List<global::ASK.Interface.SystemKeyPermissionData> ReadHardwareKeys()
		{
			short num = (short)1691549697;
			if (num != 0)
			{
			}
			num = (short)1075075048;
			short num2 = num;
			num = (short)915101672;
			switch (num2 == num)
			{
			}
			num = (short)486998016;
			short num3 = num;
			num = (short)190709760;
			if (num != 0)
			{
			}
			return this.a.ReadHardwareKeys();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003C60 File Offset: 0x00001E60
		public global::System.Collections.Generic.List<global::ASK.Interface.SystemKeyPermissionData> ReadLegacySoftwareKeys(string[] keyFileNames)
		{
			short num = (short)1072324120;
			short num2 = num;
			num = (short)842751512;
			switch (num2 == num)
			{
			}
			num = (short)1320812544;
			if (num != 0)
			{
			}
			num = (short)1927020544;
			short num3 = num;
			num = (short)1435172865;
			if (num != 0)
			{
			}
			return this.a.ReadLegacySoftwareKeys(keyFileNames);
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00003D18 File Offset: 0x00001F18
		public global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::ASK.Interface.ISystemKeyData> LoadedASKs
		{
			get
			{
				short num = (short)774288601;
				short num2 = num;
				num = (short)2011935961;
				switch (num2 == num)
				{
				}
				num = (short)1604059137;
				if (num != 0)
				{
				}
				num = (short)2052521984;
				short num3 = num;
				num = (short)1760886784;
				if (num != 0)
				{
				}
				return this.a.LoadedASKs;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00003DD0 File Offset: 0x00001FD0
		public global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::ASK.Interface.ISystemKeyData> LoadedUserSystemKeys
		{
			get
			{
				short num = (short)413833376;
				short num2 = num;
				num = (short)1034786976;
				switch (num2 == num)
				{
				}
				num = (short)114819073;
				if (num != 0)
				{
				}
				num = (short)423100416;
				short num3 = num;
				num = (short)2037317632;
				if (num != 0)
				{
				}
				return this.a.LoadedUserSystemKeys;
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003E84 File Offset: 0x00002084
		public void ClearNonDefaultUserKeys()
		{
			short num = (short)336200162;
			short num2 = num;
			num = (short)2005795298;
			switch (num2 == num)
			{
			}
			num = (short)1773273088;
			if (num != 0)
			{
			}
			num = (short)1182072832;
			short num3 = num;
			num = (short)1844117505;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003F38 File Offset: 0x00002138
		public int LoadKeysFromPath(string path)
		{
			short num = (short)1679687681;
			if (num != 0)
			{
			}
			num = (short)1539443294;
			short num2 = num;
			num = (short)1723861598;
			switch (num2 == num)
			{
			}
			num = (short)692977664;
			short num3 = num;
			num = (short)1156710400;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0400000C RID: 12
		private global::ASK.Interface.ISystemKeyManager a;
	}
}
