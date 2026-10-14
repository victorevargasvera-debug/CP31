using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;
using Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000FB RID: 251
	[global::System.Xml.Serialization.XmlInclude(typeof(global::Motorola.CommonCPS.Server.EntityModel.DBField))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::Motorola.CommonCPS.Server.EntityModel.Record))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::Motorola.CommonCPS.Server.EntityModel.RefRecord))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::Motorola.CommonCPS.Server.EntityModel.RefSet))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.DBField))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.DBRefField))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.Record))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::Motorola.CommonCPS.Server.EntityModel.DBRefField))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.RefSet))]
	[global::System.Diagnostics.DebuggerDisplay("Name={Name}")]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.RefRecord))]
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class DBNode
	{
		// Token: 0x06000F2C RID: 3884 RVA: 0x000A10EC File Offset: 0x0009F2EC
		public virtual void Accept(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.IDBNodeVisitor visitor)
		{
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator = this.ChildNodesList.GetEnumerator();
			short num;
			try
			{
				num = (short)1441792003;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_81;
					case 1:
						goto IL_106;
					case 2:
					{
						num = (short)187579507;
						short num3 = num;
						num = (short)1594899571;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_81;
						default:
							num = (short)1746337792;
							if (num != 0)
							{
							}
							num = (short)1018888193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_46;
						}
						continue;
					}
					goto IL_46;
					IL_81:
					if (!enumerator.MoveNext())
					{
						num = (short)656932866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					enumerator.Current.Accept(visitor);
					num = (short)385417220;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6B:
					num = (short)1820590080;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_46:
					goto IL_6B;
				}
				IL_106:;
			}
			finally
			{
				num = (short)1998913537;
				if (num != 0)
				{
				}
				((global::System.IDisposable)enumerator).Dispose();
			}
			num = (short)315031552;
			short num4 = num;
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06000F2D RID: 3885 RVA: 0x000A1270 File Offset: 0x0009F470
		// (set) Token: 0x06000F2E RID: 3886 RVA: 0x000A131C File Offset: 0x0009F51C
		[global::System.Xml.Serialization.XmlAttribute("Name")]
		[global::System.Runtime.Serialization.DataMember]
		public string Name
		{
			get
			{
				short num = (short)913413590;
				short num2 = num;
				num = (short)1266980310;
				switch (num2 == num)
				{
				}
				num = (short)623116288;
				short num3 = num;
				num = (short)1281163265;
				if (num != 0)
				{
				}
				num = (short)1549402112;
				if (num != 0)
				{
				}
				return this._name;
			}
			set
			{
				short num = (short)99861335;
				short num2 = num;
				num = (short)2042020695;
				switch (num2 == num)
				{
				}
				num = (short)1077936128;
				short num3 = num;
				num = (short)18743296;
				if (num != 0)
				{
				}
				num = (short)1164181505;
				if (num != 0)
				{
				}
				this._name = ((value == null) ? null : string.Intern(value));
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06000F2F RID: 3887 RVA: 0x000A13D8 File Offset: 0x0009F5D8
		// (set) Token: 0x06000F30 RID: 3888 RVA: 0x000A1488 File Offset: 0x0009F688
		[global::System.Xml.Serialization.XmlAttribute("OriginalVersion")]
		[global::System.Runtime.Serialization.DataMember]
		public string OriginalVersion
		{
			get
			{
				short num = (short)2042241187;
				short num2 = num;
				num = (short)1526276259;
				switch (num2 == num)
				{
				}
				num = (short)264634368;
				short num3 = num;
				num = (short)559939585;
				if (num != 0)
				{
				}
				num = (short)106823680;
				if (num != 0)
				{
				}
				return this._originalVersion;
			}
			set
			{
				short num = (short)104529921;
				if (num != 0)
				{
				}
				num = (short)1240087809;
				short num2 = num;
				num = (short)1095974145;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1243086848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)953024512;
				if (num != 0)
				{
				}
				this._originalVersion = ((value == null) ? null : string.Intern(value));
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06000F31 RID: 3889 RVA: 0x000A1548 File Offset: 0x0009F748
		// (set) Token: 0x06000F32 RID: 3890 RVA: 0x000A15F4 File Offset: 0x0009F7F4
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Xml.Serialization.XmlAttribute("Type")]
		public string Type
		{
			get
			{
				short num = (short)2057903255;
				short num2 = num;
				num = (short)1647844503;
				switch (num2 == num)
				{
				}
				num = (short)1381433344;
				short num3 = num;
				num = (short)1004994561;
				if (num != 0)
				{
				}
				num = (short)491978752;
				if (num != 0)
				{
				}
				return this._type;
			}
			set
			{
				short num = (short)837222401;
				if (num != 0)
				{
				}
				num = (short)351744564;
				short num2 = num;
				num = (short)1888039476;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1210056704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)612106240;
				if (num != 0)
				{
				}
				this._type = ((value == null) ? null : string.Intern(value));
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06000F33 RID: 3891 RVA: 0x000A16B0 File Offset: 0x0009F8B0
		// (set) Token: 0x06000F34 RID: 3892 RVA: 0x000A1760 File Offset: 0x0009F960
		[global::System.Xml.Serialization.XmlAttribute("Shareable")]
		[global::System.Runtime.Serialization.DataMember]
		public bool Shareable
		{
			get
			{
				short num = (short)1882415375;
				short num2 = num;
				num = (short)107110671;
				switch (num2 == num)
				{
				}
				num = (short)611516416;
				short num3 = num;
				num = (short)1987641345;
				if (num != 0)
				{
				}
				num = (short)614924288;
				if (num != 0)
				{
				}
				return this._shareable;
			}
			set
			{
				short num = (short)2078624312;
				short num2 = num;
				num = (short)1153518136;
				switch (num2 == num)
				{
				}
				num = (short)1632305152;
				short num3 = num;
				num = (short)504037377;
				if (num != 0)
				{
				}
				num = (short)243990528;
				if (num != 0)
				{
				}
				this._shareable = value;
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06000F35 RID: 3893 RVA: 0x000A1814 File Offset: 0x0009FA14
		// (set) Token: 0x06000F36 RID: 3894 RVA: 0x000A18C4 File Offset: 0x0009FAC4
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Xml.Serialization.XmlAttribute("ProductFamily")]
		public int ProductFamily
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1396611862;
				short num2 = num;
				num = (short)1859754774;
				switch (num2 == num)
				{
				}
				num = (short)312475648;
				short num3 = num;
				num = (short)517079041;
				if (num != 0)
				{
				}
				num = (short)1360134144;
				if (num != 0)
				{
				}
				return this.<ProductFamily>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1179926583;
				short num2 = num;
				num = (short)261963831;
				switch (num2 == num)
				{
				}
				num = (short)216924160;
				short num3 = num;
				num = (short)1232863232;
				if (num != 0)
				{
				}
				num = (short)664469505;
				if (num != 0)
				{
				}
				this.<ProductFamily>k__BackingField = value;
			}
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x000A1974 File Offset: 0x0009FB74
		public bool ShouldSerializeProductFamily()
		{
			short num = (short)1606858008;
			short num2 = num;
			num = (short)1206170904;
			switch (num2 == num)
			{
			}
			num = (short)828768256;
			short num3 = num;
			num = (short)1010302977;
			if (num != 0)
			{
			}
			num = (short)1877278720;
			if (num != 0)
			{
			}
			return this.ProductFamily != 0;
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06000F38 RID: 3896 RVA: 0x000A1A24 File Offset: 0x0009FC24
		// (set) Token: 0x06000F39 RID: 3897 RVA: 0x000A1AD8 File Offset: 0x0009FCD8
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Xml.Serialization.XmlElement("DBNode")]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode> ChildNodesList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1062076452;
				short num2 = num;
				num = (short)1007747108;
				switch (num2 == num)
				{
				}
				num = (short)553910272;
				short num3 = num;
				num = (short)460849152;
				if (num != 0)
				{
				}
				num = (short)1516961793;
				if (num != 0)
				{
				}
				return this.<ChildNodesList>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)668855811;
				short num2 = num;
				num = (short)1373826563;
				switch (num2 == num)
				{
				}
				num = (short)1180631040;
				short num3 = num;
				num = (short)1651376129;
				if (num != 0)
				{
				}
				num = (short)615579648;
				if (num != 0)
				{
				}
				this.<ChildNodesList>k__BackingField = value;
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06000F3A RID: 3898 RVA: 0x000A1B88 File Offset: 0x0009FD88
		// (set) Token: 0x06000F3B RID: 3899 RVA: 0x000A1C38 File Offset: 0x0009FE38
		[global::System.Xml.Serialization.XmlAttribute("IsVisible")]
		public bool IsVisible
		{
			get
			{
				short num = (short)1832134471;
				short num2 = num;
				num = (short)962209607;
				switch (num2 == num)
				{
				}
				num = (short)221970432;
				short num3 = num;
				num = (short)1811283969;
				if (num != 0)
				{
				}
				num = (short)980811776;
				if (num != 0)
				{
				}
				return this._isVisible;
			}
			set
			{
				short num = (short)1396425605;
				short num2 = num;
				num = (short)1445905285;
				switch (num2 == num)
				{
				}
				num = (short)2073034752;
				short num3 = num;
				num = (short)122290177;
				if (num != 0)
				{
				}
				num = (short)1383071744;
				if (num != 0)
				{
				}
				this._isVisible = value;
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06000F3C RID: 3900 RVA: 0x000A1CE8 File Offset: 0x0009FEE8
		// (set) Token: 0x06000F3D RID: 3901 RVA: 0x000A1D98 File Offset: 0x0009FF98
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Xml.Serialization.XmlAttribute("Nature")]
		public string Nature
		{
			get
			{
				short num = (short)141401271;
				short num2 = num;
				num = (short)1179950263;
				switch (num2 == num)
				{
				}
				num = (short)100466688;
				short num3 = num;
				num = (short)1104347137;
				if (num != 0)
				{
				}
				num = (short)1325006848;
				if (num != 0)
				{
				}
				return this._nature;
			}
			set
			{
				short num = (short)1897922811;
				short num2 = num;
				num = (short)2109866235;
				switch (num2 == num)
				{
				}
				num = (short)72744960;
				short num3 = num;
				num = (short)1855193088;
				if (num != 0)
				{
				}
				num = (short)931856385;
				if (num != 0)
				{
				}
				this._nature = value;
			}
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x000A1E48 File Offset: 0x000A0048
		public bool ShouldSerializeNature()
		{
			short num = (short)672975436;
			short num2 = num;
			num = (short)1447414348;
			switch (num2 == num)
			{
			}
			num = (short)681050112;
			short num3 = num;
			num = (short)1820983297;
			if (num != 0)
			{
			}
			num = (short)1958608896;
			if (num != 0)
			{
			}
			return !string.IsNullOrEmpty(this.Nature);
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x000A1EFC File Offset: 0x000A00FC
		public DBNode()
		{
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x000A1F28 File Offset: 0x000A0128
		public DBNode(string name)
		{
			this.Name = name;
			this.ChildNodesList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>();
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x000A1F68 File Offset: 0x000A0168
		public void Serialize(string xmlFilePath)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::System.Xml.Serialization.XmlSerializer xmlSerializer;
			for (;;)
			{
				IL_0A:
				global::System.IO.Stream stream;
				switch (num)
				{
				case 0:
				{
					num2 = (short)1452539904;
					short num3 = num2;
					global::System.IO.Directory.CreateDirectory(global::System.IO.Path.GetDirectoryName(xmlFilePath));
					num2 = (short)1993342978;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					try
					{
						stream.SetLength(0L);
						global::System.Xml.XmlTextWriter xmlWriter = new global::System.Xml.XmlTextWriter(stream, global::System.Text.Encoding.UTF8)
						{
							Formatting = global::System.Xml.Formatting.Indented
						};
						xmlSerializer.Serialize(xmlWriter, this);
						stream.Flush();
						return;
					}
					finally
					{
						num2 = (short)1348599810;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
							{
								num2 = (short)179918807;
								short num4 = num2;
								num2 = (short)220354519;
								switch ((num4 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_198;
								default:
									num2 = (short)51183616;
									if (num2 != 0)
									{
									}
									((global::System.IDisposable)stream).Dispose();
									num2 = (short)2037252097;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 1:
								goto IL_198;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_116;
								}
								continue;
							}
							IL_116:
							if (stream == null)
							{
								break;
							}
							num2 = (short)40828928;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_198:;
					}
					goto IL_19B;
				case 2:
					goto IL_19B;
				case 3:
					if (!global::System.IO.Directory.Exists(global::System.IO.Path.GetDirectoryName(xmlFilePath)))
					{
						num2 = (short)2140864512;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_19B;
				}
				goto IL_20;
				IL_19B:
				stream = new global::System.IO.FileStream(xmlFilePath, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.ReadWrite);
				num2 = (short)124256257;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_20:
			xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(base.GetType());
			num2 = (short)582483969;
			if (num2 != 0)
			{
			}
			num2 = (short)1858666499;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x000A216C File Offset: 0x000A036C
		public byte[] SerializeAndZip()
		{
			short num = (short)1275592704;
			switch (num)
			{
			default:
			{
				num = (short)1316028416;
				short num2 = num;
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				goto IL_50;
				byte[] result;
				try
				{
					for (;;)
					{
						IL_50:
						global::System.IO.Compression.DeflateStream deflateStream = new global::System.IO.Compression.DeflateStream(new global::System.IO.BufferedStream(memoryStream), global::System.IO.Compression.CompressionLevel.Optimal);
						try
						{
							global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(base.GetType());
							global::System.Xml.XmlTextWriter xmlWriter = new global::System.Xml.XmlTextWriter(deflateStream, global::System.Text.Encoding.UTF8);
							xmlSerializer.Serialize(xmlWriter, this);
							deflateStream.Flush();
						}
						finally
						{
							num = (short)1483931650;
							int num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									((global::System.IDisposable)deflateStream).Dispose();
									num = (short)2144731137;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_ED;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_B8;
									}
									continue;
								}
								IL_B8:
								if (deflateStream == null)
								{
									break;
								}
								num = (short)789315584;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_ED:;
						}
						num = (short)679634866;
						short num4 = num;
						num = (short)2050516914;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_124;
						}
					}
					IL_124:
					num = (short)1579417600;
					if (num != 0)
					{
					}
					result = memoryStream.ToArray();
				}
				finally
				{
					num = (short)417267714;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)394264577;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_1AD;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_175;
							}
							continue;
						}
						IL_175:
						if (memoryStream == null)
						{
							break;
						}
						num = (short)497418240;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1AD:;
				}
				num = (short)808714241;
				if (num != 0)
				{
				}
				return result;
			}
			}
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x000A2370 File Offset: 0x000A0570
		public void SerializeAndZip(string filePath)
		{
			short num = (short)557711361;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.IO.FileStream fileStream;
				switch (num2)
				{
				case 0:
				{
					num = (short)2099904512;
					short num3 = num;
					global::System.IO.Directory.CreateDirectory(global::System.IO.Path.GetDirectoryName(filePath));
					num = (short)1628569601;
					if (num != 0)
					{
					}
					num = (short)949708421;
					short num4 = num;
					num = (short)54617733;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1747189760;
						if (num != 0)
						{
						}
						num = (short)1858863106;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 2:
					goto IL_18C;
				case 3:
					try
					{
						global::System.IO.Compression.DeflateStream deflateStream = new global::System.IO.Compression.DeflateStream(new global::System.IO.BufferedStream(fileStream), global::System.IO.Compression.CompressionLevel.Optimal);
						try
						{
							global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(base.GetType());
							global::System.Xml.XmlTextWriter xmlWriter = new global::System.Xml.XmlTextWriter(deflateStream, global::System.Text.Encoding.UTF8);
							xmlSerializer.Serialize(xmlWriter, this);
							deflateStream.Flush();
							return;
						}
						finally
						{
							num = (short)269484032;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_EE;
									}
									continue;
								case 1:
									goto IL_121;
								case 2:
									((global::System.IDisposable)deflateStream).Dispose();
									num = (short)1616052225;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_EE:
								if (deflateStream == null)
								{
									break;
								}
								num = (short)745013250;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_121:;
						}
					}
					finally
					{
						num = (short)1267335168;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_156;
								}
								continue;
							case 1:
								goto IL_189;
							case 2:
								((global::System.IDisposable)fileStream).Dispose();
								num = (short)192348161;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_156:
							if (fileStream == null)
							{
								break;
							}
							num = (short)1299644418;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_189:;
					}
					goto IL_18C;
				}
				IL_35:
				if (!global::System.IO.Directory.Exists(global::System.IO.Path.GetDirectoryName(filePath)))
				{
					num = (short)1354498048;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_18C:
				fileStream = global::System.IO.File.Open(filePath, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.Write);
				num = (short)963903491;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x000A25E8 File Offset: 0x000A07E8
		public static global::Motorola.CommonCPS.Server.EntityModel.DBNode DeserializeFromZip(byte[] datasource)
		{
			short num = (short)1670053888;
			switch (num)
			{
			default:
			{
				num = (short)1359806464;
				int num2 = (int)((global::System.IntPtr)num);
				global::Motorola.CommonCPS.Server.EntityModel.DBNode result;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					case 1:
					{
						global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(datasource, false);
						num = (short)603193347;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_205;
					case 3:
						try
						{
							global::System.IO.MemoryStream memoryStream;
							global::System.IO.Compression.DeflateStream deflateStream = new global::System.IO.Compression.DeflateStream(new global::System.IO.BufferedStream(memoryStream), global::System.IO.Compression.CompressionMode.Decompress);
							try
							{
								global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(global::Motorola.CommonCPS.Server.EntityModel.DBNode));
								global::System.Xml.XmlTextReader xmlReader = new global::System.Xml.XmlTextReader(deflateStream);
								result = (global::Motorola.CommonCPS.Server.EntityModel.DBNode)xmlSerializer.Deserialize(xmlReader);
								goto IL_264;
							}
							finally
							{
								num = (short)549519360;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_15C;
										}
										continue;
									case 1:
										goto IL_194;
									case 2:
										((global::System.IDisposable)deflateStream).Dispose();
										num = (short)676855809;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_15C:
									if (deflateStream == null)
									{
										break;
									}
									num = (short)1722220546;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_194:;
							}
						}
						finally
						{
							num = (short)1835139072;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.IO.MemoryStream memoryStream;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1C9;
									}
									continue;
								case 1:
									goto IL_202;
								case 2:
									((global::System.IDisposable)memoryStream).Dispose();
									num = (short)427556865;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1C9:
								if (memoryStream == null)
								{
									break;
								}
								num = (short)1691549698;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_202:;
						}
						goto IL_205;
					case 4:
						goto IL_21E;
					}
					IL_59:
					num = (short)1189628233;
					short num3 = num;
					num = (short)399788361;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_21E:
						if (datasource.Length != 0)
						{
							num = (short)1310785537;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23C;
					default:
						num = (short)1279197185;
						if (num != 0)
						{
						}
						num = (short)717357056;
						if (num != 0)
						{
						}
						if (datasource != null)
						{
							num = (short)1191116802;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23C;
					}
					IL_205:
					num = (short)473563140;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_23C:
				return null;
				IL_264:
				num = (short)1314848768;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x000A28A0 File Offset: 0x000A0AA0
		public static global::Motorola.CommonCPS.Server.EntityModel.DBNode DeserializeFromZipFile(string filePath)
		{
			short num = (short)383582208;
			short num2 = num;
			num = (short)264779305;
			short num3 = num;
			num = (short)13973033;
			global::Motorola.CommonCPS.Server.EntityModel.DBNode result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)628490240;
				if (num != 0)
				{
				}
				num = (short)495058944;
				switch (num)
				{
				default:
				{
					global::System.IO.FileStream fileStream = global::System.IO.File.Open(filePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
					try
					{
						num = (short)1545207809;
						if (num != 0)
						{
						}
						global::System.IO.Compression.DeflateStream deflateStream = new global::System.IO.Compression.DeflateStream(new global::System.IO.BufferedStream(fileStream), global::System.IO.Compression.CompressionMode.Decompress);
						try
						{
							global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(global::Motorola.CommonCPS.Server.EntityModel.DBNode));
							global::System.Xml.XmlTextReader xmlReader = new global::System.Xml.XmlTextReader(deflateStream);
							result = (global::Motorola.CommonCPS.Server.EntityModel.DBNode)xmlSerializer.Deserialize(xmlReader);
						}
						finally
						{
							num = (short)1598816256;
							int num4 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num4)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_12B;
									}
									continue;
								case 1:
									goto IL_163;
								case 2:
									((global::System.IDisposable)deflateStream).Dispose();
									num = (short)741277697;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_12B:
								if (deflateStream == null)
								{
									break;
								}
								num = (short)1581645826;
								num4 = (int)((global::System.IntPtr)num);
							}
							IL_163:;
						}
					}
					finally
					{
						num = (short)760938496;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_198;
								}
								continue;
							case 1:
								goto IL_1CF;
							case 2:
								((global::System.IDisposable)fileStream).Dispose();
								num = (short)983236609;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_198:
							if (fileStream == null)
							{
								break;
							}
							num = (short)796852226;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_1CF:;
					}
					break;
				}
				}
				break;
			}
			return result;
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x000A2A9C File Offset: 0x000A0C9C
		public static global::Motorola.CommonCPS.Server.EntityModel.DBNode DeserializeFrom(string xmlFilePath)
		{
			short num = (short)1271332864;
			short num2 = num;
			num = (short)1246987649;
			short num3 = num;
			num = (short)1426949505;
			global::Motorola.CommonCPS.Server.EntityModel.DBNode result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1264582656;
				if (num != 0)
				{
				}
				num = (short)1254162433;
				if (num != 0)
				{
				}
				num = (short)249036800;
				switch (num)
				{
				default:
				{
					global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(global::Motorola.CommonCPS.Server.EntityModel.DBNode));
					global::System.IO.Stream stream = new global::System.IO.FileStream(xmlFilePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
					try
					{
						global::System.Xml.XmlTextReader xmlReader = new global::System.Xml.XmlTextReader(stream);
						result = (global::Motorola.CommonCPS.Server.EntityModel.DBNode)xmlSerializer.Deserialize(xmlReader);
					}
					finally
					{
						num = (short)959709184;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_11A;
								}
								continue;
							case 1:
								goto IL_151;
							case 2:
								((global::System.IDisposable)stream).Dispose();
								num = (short)1567752193;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_11A:
							if (stream == null)
							{
								break;
							}
							num = (short)1882128386;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_151:;
					}
					break;
				}
				}
				break;
			}
			return result;
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x000A2C10 File Offset: 0x000A0E10
		public void AddChild(global::Motorola.CommonCPS.Server.EntityModel.DBNode node)
		{
			short num;
			for (;;)
			{
				IL_00:
				num = (short)330432512;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1118041511;
						short num3 = num;
						num = (short)1978529191;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)90767360;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_7B;
							}
							continue;
						}
						break;
					}
					case 1:
						goto IL_E2;
					case 2:
						this.ChildNodesList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>();
						num = (short)1291452417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7B:
					num = (short)2096037888;
					short num4 = num;
					if (this.ChildNodesList != null)
					{
						goto IL_10A;
					}
					num = (short)1769078786;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_E2:
			num = (short)205193217;
			if (num != 0)
			{
			}
			IL_10A:
			this.ChildNodesList.Add(node);
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x000A2D34 File Offset: 0x000A0F34
		public global::System.Collections.Generic.List<string> CompareNodeZipFile(string FileNameSrc, string FileNameDes)
		{
			int a_ = 3;
			short num = (short)758317056;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4C;
				}
				global::System.Collections.Generic.List<string> list;
				global::System.Collections.Generic.HashSet<string> hashSet;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						if (global::System.IO.File.Exists(FileNameSrc))
						{
							num = (short)113770498;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BF7;
					case 1:
					{
						list = new global::System.Collections.Generic.List<string>();
						global::System.IO.FileStream fileStream = global::System.IO.File.Open(FileNameSrc, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.Read);
						num = (short)684457987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_B3A;
					case 3:
						try
						{
							global::System.IO.FileStream fileStream;
							global::System.IO.Compression.DeflateStream deflateStream = new global::System.IO.Compression.DeflateStream(new global::System.IO.BufferedStream(fileStream), global::System.IO.Compression.CompressionMode.Decompress);
							try
							{
								global::System.IO.FileStream fileStream2 = global::System.IO.File.Open(FileNameDes, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.Read);
								try
								{
									global::System.IO.Compression.DeflateStream deflateStream2 = new global::System.IO.Compression.DeflateStream(new global::System.IO.BufferedStream(fileStream2), global::System.IO.Compression.CompressionMode.Decompress);
									try
									{
										global::System.Xml.XmlReader xmlReader = global::System.Xml.XmlReader.Create(new global::System.IO.BufferedStream(deflateStream), new global::System.Xml.XmlReaderSettings
										{
											IgnoreWhitespace = true,
											IgnoreComments = true
										});
										try
										{
											global::System.Xml.XmlReader xmlReader2 = global::System.Xml.XmlReader.Create(new global::System.IO.BufferedStream(deflateStream2), new global::System.Xml.XmlReaderSettings
											{
												IgnoreWhitespace = true,
												IgnoreComments = true
											});
											try
											{
												switch (0)
												{
												case 0:
													goto IL_243;
												}
												global::System.Xml.IXmlLineInfo xmlLineInfo;
												for (;;)
												{
													IL_1A4:
													int num3;
													switch (num2)
													{
													case 0:
													{
														global::System.Text.StringBuilder stringBuilder;
														string name;
														stringBuilder.Append(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("怀眂焄甆怈椊砌笎琐㌒簔搖㤘甚爜欞Ġ倢䐤䨦䰨瀪䰬嬮䔰䄲尴唶䰸伺堼Ἶ⽀≂⡄≆獈汊㙌罎ⱐ瑒畔", a_), name));
														string value;
														stringBuilder.AppendLine(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("爀焂昄✆缈樊愌税琐⤒㈔氖⤘昚㨜㌞䔠䘢嘤ܦ弨䨪䄬娮吰लሴ䰶࠸䘺ᨼ戾慀", a_), value, xmlReader2.GetAttribute(name)));
														num = (short)1735000083;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													case 1:
													{
														string name;
														if (!(name == global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("刀昂焄䤆栈昊栌", a_)))
														{
															num = (short)1706164259;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														num = (short)1731854350;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													case 2:
														goto IL_47B;
													case 3:
														goto IL_840;
													case 4:
														num = (short)151322640;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													case 5:
														if (xmlReader is global::System.Xml.IXmlLineInfo)
														{
															num = (short)514981896;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														goto IL_344;
													case 6:
														goto IL_344;
													case 7:
														goto IL_344;
													case 8:
														xmlLineInfo = (xmlReader as global::System.Xml.IXmlLineInfo);
														num = (short)555286535;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													case 9:
													{
														global::System.Guid empty;
														if (!global::System.Guid.TryParse(xmlReader.GetAttribute(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("圀戂椄爆氈", a_)), out empty))
														{
															num = (short)1813905437;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														goto IL_42F;
													}
													case 10:
													{
														string name;
														if (!hashSet.Contains(name))
														{
															num = (short)1064697893;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														goto IL_577;
													}
													case 11:
														goto IL_42F;
													case 12:
														goto IL_6B6;
													case 13:
														goto IL_858;
													case 14:
													{
														string value;
														if (string.IsNullOrEmpty(value))
														{
															num = (short)72876062;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														goto IL_42F;
													}
													case 15:
														num3 = 0;
														num = (short)2072903698;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													case 16:
													{
														string name;
														if (!(name == global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("伀戂栄戆", a_)))
														{
															num = (short)737738778;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														string attribute = xmlReader.GetAttribute(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("礀瀂氄㴆紈爊紌樎", a_));
														num = (short)653590549;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													case 17:
														goto IL_577;
													case 18:
														goto IL_47B;
													case 19:
														goto IL_577;
													case 20:
													{
														string name;
														string value;
														if (!value.Equals(xmlReader2.GetAttribute(name)))
														{
															num = (short)216334336;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														goto IL_577;
													}
													case 21:
													{
														string attribute;
														if (!(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("匀昂昄栆笈漊", a_) == attribute))
														{
															num = (short)1098645515;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														goto IL_577;
													}
													case 22:
													{
														if (num3 >= xmlReader.AttributeCount)
														{
															num = (short)1886912524;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														xmlReader.MoveToAttribute(num3);
														string name = xmlReader.Name;
														string value = xmlReader.Value;
														num = (short)380633098;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													case 23:
													{
														global::System.Text.StringBuilder stringBuilder;
														if (stringBuilder.Length > 0)
														{
															num = (short)122159135;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														goto IL_344;
													}
													case 24:
														num = (short)1181548578;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													case 25:
														if (xmlReader.Read())
														{
															num = (short)1470890008;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														goto IL_840;
													case 26:
														num = (short)500826139;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													case 27:
														goto IL_42F;
													case 28:
													{
														string str = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䔀樂挄愆氈礊栌愎爐瘒㔔瘖洘㬚漜瀞嘠̢䬤刦䐨䤪䠬崮樰ጲ临ܶ䐸ᬺ怼ጾ䱀䥂", a_), (xmlLineInfo == null) ? global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("娀伂䀄娆", a_) : xmlLineInfo.LineNumber.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
														global::System.Text.StringBuilder stringBuilder;
														list.Add(str + stringBuilder.ToString());
														num = (short)1583677446;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													case 29:
														num = (short)186384416;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													case 30:
														num = (short)280625169;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													case 31:
														num = (short)704446492;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													case 32:
														goto IL_577;
													case 33:
													{
														string name;
														if (!(name == global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("匀昂挄戆笈堊栌笎弐爒研爖", a_)))
														{
															num = (short)1624702980;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														global::System.Guid empty = global::System.Guid.Empty;
														num = (short)1482555401;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													case 34:
													{
														if (!xmlReader2.Read())
														{
															num = (short)469958659;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
														num = (short)220463140;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													case 35:
														num = (short)615186465;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													case 36:
														if (xmlReader.HasAttributes)
														{
															num = (short)300351503;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														goto IL_6B6;
													case 37:
														num = (short)1787297793;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_243;
													IL_344:
													num = (short)898105369;
													num2 = (int)((global::System.IntPtr)num);
													continue;
													IL_42F:
													num = (short)1802174484;
													num2 = (int)((global::System.IntPtr)num);
													continue;
													IL_47B:
													num = (short)265945110;
													num2 = (int)((global::System.IntPtr)num);
													continue;
													IL_577:
													num3++;
													num = (short)1490944002;
													num2 = (int)((global::System.IntPtr)num);
													continue;
													IL_6B6:
													num = (short)568655895;
													num2 = (int)((global::System.IntPtr)num);
													continue;
													IL_840:
													num = (short)489357325;
													num2 = (int)((global::System.IntPtr)num);
												}
												IL_858:
												return list;
												IL_243:
												xmlLineInfo = null;
												num = (short)2068774917;
												num2 = (int)((global::System.IntPtr)num);
												goto IL_1A4;
											}
											finally
											{
												num = (short)1769473;
												num2 = (int)((global::System.IntPtr)num);
												for (;;)
												{
													switch (num2)
													{
													case 0:
														goto IL_917;
													case 1:
														switch (0)
														{
														case 0:
															goto IL_88F;
														}
														continue;
													case 2:
													{
														num = (short)109903774;
														short num4 = num;
														num = (short)1625292702;
														switch ((num4 == num) ? 1 : 0)
														{
														case 0:
														case 2:
															break;
														default:
															num = (short)472514560;
															if (num != 0)
															{
															}
															((global::System.IDisposable)xmlReader2).Dispose();
															num = (short)1172635648;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														break;
													}
													}
													IL_88F:
													if (xmlReader2 == null)
													{
														break;
													}
													num = (short)1974796290;
													num2 = (int)((global::System.IntPtr)num);
												}
												IL_917:;
											}
										}
										finally
										{
											num = (short)1010302977;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
													goto IL_984;
												case 1:
													switch (0)
													{
													case 0:
														goto IL_94C;
													}
													continue;
												case 2:
													((global::System.IDisposable)xmlReader).Dispose();
													num = (short)1845035008;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												IL_94C:
												if (xmlReader == null)
												{
													break;
												}
												num = (short)1037041666;
												num2 = (int)((global::System.IntPtr)num);
											}
											IL_984:;
										}
									}
									finally
									{
										num = (short)912850945;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_9F2;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_9B9;
												}
												continue;
											case 2:
												((global::System.IDisposable)deflateStream2).Dispose();
												num = (short)539492352;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_9B9:
											if (deflateStream2 == null)
											{
												break;
											}
											num = (short)423428098;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_9F2:;
									}
								}
								finally
								{
									num = (short)1172832257;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											goto IL_A60;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_A27;
											}
											continue;
										case 2:
											((global::System.IDisposable)fileStream2).Dispose();
											num = (short)1649016832;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_A27:
										if (fileStream2 == null)
										{
											break;
										}
										num = (short)210960386;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_A60:;
								}
							}
							finally
							{
								num = (short)1412628481;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_ACB;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_A95;
										}
										continue;
									case 2:
										((global::System.IDisposable)deflateStream).Dispose();
										num = (short)1334509568;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_A95:
									if (deflateStream == null)
									{
										break;
									}
									num = (short)847839234;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_ACB:;
							}
						}
						finally
						{
							num = (short)1104478209;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.IO.FileStream fileStream;
								switch (num2)
								{
								case 0:
									goto IL_B37;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_B00;
									}
									continue;
								case 2:
									((global::System.IDisposable)fileStream).Dispose();
									num = (short)415039488;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_B00:
								if (fileStream == null)
								{
									break;
								}
								num = (short)1410138114;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_B37:;
						}
						goto IL_B3A;
					case 4:
						num = (short)1816199169;
						if (num != 0)
						{
						}
						if (global::System.IO.File.Exists(FileNameDes))
						{
							num = (short)1839333376;
							short num5 = num;
							num = (short)531562497;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BF7;
					}
					goto IL_4C;
					IL_B3A:
					num = (short)479199236;
					num2 = (int)((global::System.IntPtr)num);
				}
				return list;
				IL_BF7:
				throw new global::System.Exception(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("甀欂怄✆稈礊渌⼎瀐紒焔㜖紘縚渜㼞夠丢䤤ܦ伨䈪䄬䨮ᄰ倲吴夶圸吺䤼Ἶ⍀♂敄ⅆ♈㹊⍌⭎灐", a_));
				IL_4C:
				hashSet = new global::System.Collections.Generic.HashSet<string>
				{
					global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("礀渂椄椆稈ㄊ甌簎砐", a_),
					global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("礀渂椄椆稈ㄊ甌簎甐", a_),
					global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䠀瀂匄渆稈戊漌挎琐", a_),
					global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䠀瀂匄渆笈缊砌渎紐", a_),
					global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("唀樂栄戆稈缊氌戎愐", a_),
					global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䴀戂瘄猆䐈搊椌明眐稒瀔猖崘稚検稞", a_),
					global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("儀焂樄挆簈栊礌䤎瀐縒簔笖怘", a_)
				};
				num = (short)740556800;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x000A39E0 File Offset: 0x000A1BE0
		public global::System.Collections.Generic.List<string> Compare(global::Motorola.CommonCPS.Server.EntityModel.DBNode desNode)
		{
			int a_ = 10;
			short num = (short)1476198400;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				global::System.Collections.Generic.List<string> result;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						if (this == desNode)
						{
							num = (short)1790574593;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21E;
					case 1:
						return result;
					case 2:
						goto IL_28F;
					}
					goto IL_43;
				}
				return result;
				IL_28F:
				try
				{
					global::Motorola.CommonCPS.Server.EntityModel.DBNode.deepSqrt(this);
					global::Motorola.CommonCPS.Server.EntityModel.DBNode.deepSqrt(desNode);
					string text;
					this.SerializeAndZip(text);
					string text2;
					desNode.SerializeAndZip(text2);
					return this.CompareNodeZipFile(text, text2);
				}
				finally
				{
					num = (short)478543875;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						string text;
						switch (num2)
						{
						case 0:
							goto IL_1E1;
						case 1:
							goto IL_1E3;
						case 2:
							global::System.IO.File.Delete(text);
							num = (short)1387397121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_188;
							}
							continue;
						case 4:
						{
							string text2;
							global::System.IO.File.Delete(text2);
							num = (short)1304494080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							string text2;
							if (global::System.IO.File.Exists(text2))
							{
								num = (short)912982020;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_21D;
						}
						}
						IL_188:
						if (global::System.IO.File.Exists(text))
						{
							num = (short)1407778818;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1E3:
						num = (short)1046347781;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1E1:
					IL_21D:;
				}
				goto IL_21E;
				IL_43:
				num = (short)1731456467;
				short num3 = num;
				num = (short)1053027795;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_21E:
					string text = global::System.IO.Path.GetTempPath() + global::System.Guid.NewGuid().ToString() + global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("☇瀉攋縍", a_);
					string text2 = global::System.IO.Path.GetTempPath() + global::System.Guid.NewGuid().ToString() + global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("☇瀉攋縍", a_);
					num = (short)1042743298;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				default:
				{
					num = (short)1995243520;
					short num4 = num;
					num = (short)1923481601;
					if (num != 0)
					{
					}
					num = (short)1278738432;
					if (num != 0)
					{
					}
					result = new global::System.Collections.Generic.List<string>();
					num = (short)1889927168;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				}
				break;
			}
			}
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x000A3C98 File Offset: 0x000A1E98
		private string a(global::System.Xml.XmlReader A_0, global::System.Xml.XmlReader A_1)
		{
			int a_ = 4;
			switch (0)
			{
			case 0:
				goto IL_41;
			}
			int num;
			short num2;
			string result;
			for (;;)
			{
				IL_13:
				global::System.Xml.IXmlLineInfo xmlLineInfo;
				global::System.Xml.IXmlLineInfo xmlLineInfo2;
				switch (num)
				{
				case 0:
					goto IL_C7;
				case 1:
					goto IL_103;
				case 2:
				{
					if (!A_0.HasAttributes)
					{
						goto IL_81;
					}
					num2 = (short)80347277;
					short num3 = num2;
					num2 = (short)659554445;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_68;
					default:
						num2 = (short)670564352;
						if (num2 != 0)
						{
						}
						num2 = (short)203816968;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					num2 = (short)1973485569;
					if (num2 != 0)
					{
					}
					if (A_1 is global::System.Xml.IXmlLineInfo)
					{
						num2 = (short)294322176;
						short num4 = num2;
						num2 = (short)1046609925;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_191;
				case 4:
					if (A_0 is global::System.Xml.IXmlLineInfo)
					{
						goto IL_68;
					}
					goto IL_191;
				case 5:
					xmlLineInfo = (A_0 as global::System.Xml.IXmlLineInfo);
					xmlLineInfo2 = (A_1 as global::System.Xml.IXmlLineInfo);
					num2 = (short)277544962;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (A_1.HasAttributes)
					{
						num2 = (short)1215430657;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_81;
				case 7:
					num2 = (short)544407555;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					num2 = (short)1519910918;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					return result;
				}
				goto IL_41;
				IL_68:
				num2 = (short)92733447;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_81:
				result = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䘁洃怅渇漉縋欍縏焑焓㘕礗渙㰛洝刟䄡ḣ吥䜧崩ఫ䀭䔯弱嘳匵䨷䄹఻䌽氿♁⅃㕅片㡉⍋㥍灏㱑⅓㭕㩗㽙⹛摝᭟卡ᥣ", a_), xmlLineInfo.LineNumber, xmlLineInfo2.LineNumber);
				num2 = (short)1364525056;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_191:
				result = global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("威椃樅䐇按戋欍夏簑爓礕㠗洙紛洝\u001f䰡䬣別ࠧ天夫席䀯崱䘳䈵崷帹᰻尽㤿扁ぃ⹅ⅇ㥉汋㙍㵏㹑ٓ㍕㥗㹙㥛ⱝ䅟䍡", a_);
				num2 = (short)1629618185;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_C7:
			return result;
			IL_103:
			A_0.GetAttribute(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("圁儃伅䰇", a_));
			A_1.GetAttribute(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("圁儃伅䰇", a_));
			A_0.GetAttribute(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("儁愃爅䘇欉愋欍", a_));
			A_1.GetAttribute(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("儁愃爅䘇欉愋欍", a_));
			return result;
			IL_41:
			result = "";
			num2 = (short)591003652;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x000A3F50 File Offset: 0x000A2150
		public static void deepSqrt(global::Motorola.CommonCPS.Server.EntityModel.DBNode node)
		{
			short num = (short)935002117;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.DBNode> enumerator;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (node.ChildNodesList != null)
					{
						num = (short)1517420550;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					enumerator = node.ChildNodesList.Where(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.DBNode, bool>(global::Motorola.CommonCPS.Server.EntityModel.DBNode.<>c.<>9.a)).GetEnumerator();
					num = (short)1567490052;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)264699905;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)2102591488;
					short num3 = num;
					enumerator = node.ChildNodesList.Where(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.DBNode, bool>(global::Motorola.CommonCPS.Server.EntityModel.DBNode.<>c.<>9.b)).GetEnumerator();
					num = (short)1126236169;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					try
					{
						num = (short)716963842;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)1026555907;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								if (!enumerator.MoveNext())
								{
									num = (short)1907884032;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.DBNode.deepSqrt(enumerator.Current);
								num = (short)1581449220;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1A7;
								}
								continue;
							case 3:
								goto IL_214;
							}
							IL_1A9:
							num = (short)988741633;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1A7:
							goto IL_1A9;
						}
						IL_214:
						return;
					}
					finally
					{
						num = (short)790953984;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							num = (short)1784729236;
							short num4 = num;
							num = (short)1845284500;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)2031943680;
								if (num != 0)
								{
								}
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_294;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)639303682;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_2CB;
								}
								IL_294:
								if (enumerator == null)
								{
									goto IL_2CD;
								}
								break;
							}
							num = (short)302645249;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_2CB:
						IL_2CD:;
					}
					goto IL_2CE;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_50;
					}
					continue;
				case 6:
					num = (short)1418002439;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (node is global::Motorola.CommonCPS.Server.EntityModel.RefSet)
					{
						num = (short)1455161346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2CE;
				case 8:
					num = (short)445775873;
					if (num != 0)
					{
					}
					num = (short)531693568;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_3A2;
				case 10:
					node.ChildNodesList.Sort(new global::System.Comparison<global::Motorola.CommonCPS.Server.EntityModel.DBNode>(global::Motorola.CommonCPS.Server.EntityModel.DBNode.<>c.<>9.a));
					num = (short)1634861059;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_50:
				if (node != null)
				{
					num = (short)1007091720;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_2CE:
				num = (short)1100873738;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_3A2:
			try
			{
				num = (short)1175977986;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)436338691;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (!enumerator.MoveNext())
						{
							num = (short)194969600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.DBNode.deepSqrt(enumerator.Current);
						num = (short)193462276;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_3DC;
						}
						continue;
					case 3:
						goto IL_449;
					}
					IL_3DE:
					num = (short)1850146817;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3DC:
					goto IL_3DE;
				}
				IL_449:
				return;
			}
			finally
			{
				num = (short)2008678400;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_47B;
						}
						continue;
					case 1:
						enumerator.Dispose();
						num = (short)1659502594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_4AF;
					}
					IL_47B:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1412825089;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_4AF:;
			}
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x000A442C File Offset: 0x000A262C
		public global::Motorola.CommonCPS.Server.EntityModel.DBNode deepSqrt()
		{
			short num = (short)1122407580;
			short num2 = num;
			num = (short)1552651420;
			switch (num2 == num)
			{
			}
			num = (short)1466826752;
			short num3 = num;
			num = (short)1405681664;
			if (num != 0)
			{
			}
			num = (short)854392833;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.EntityModel.DBNode.deepSqrt(this);
			return this;
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x000A44DC File Offset: 0x000A26DC
		// Note: this type is marked as 'beforefieldinit'.
		static DBNode()
		{
			short num = (short)1551044465;
			short num2 = num;
			num = (short)634654577;
			switch (num2 == num)
			{
			}
			num = (short)614989824;
			short num3 = num;
			num = (short)2107375617;
			if (num != 0)
			{
			}
			num = (short)1862074368;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.EntityModel.DBNode.NatureTypeNone = global::Motorola.CommonCPS.Server.CommonDBConstants.NatureType.None.ToString();
		}

		// Token: 0x0400072A RID: 1834
		private string _name;

		// Token: 0x0400072B RID: 1835
		private string _type;

		// Token: 0x0400072C RID: 1836
		private string _originalVersion;

		// Token: 0x0400072D RID: 1837
		private bool _shareable = true;

		// Token: 0x04000730 RID: 1840
		private bool _isVisible = true;

		// Token: 0x04000731 RID: 1841
		private static string NatureTypeNone;

		// Token: 0x04000732 RID: 1842
		private string _nature = global::Motorola.CommonCPS.Server.EntityModel.DBNode.NatureTypeNone;
	}
}
