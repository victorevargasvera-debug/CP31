using System;
using System.Collections.Generic;
using System.Text;
using NPOI.Util;

namespace NPOI.DDF
{
	// Token: 0x0200052A RID: 1322
	public abstract class AbstractEscherOptRecord : global::NPOI.DDF.EscherRecord
	{
		// Token: 0x060031A2 RID: 12706 RVA: 0x00095F7B File Offset: 0x0009417B
		public void AddEscherProperty(global::NPOI.DDF.EscherProperty prop)
		{
			this.properties.Add(prop);
		}

		// Token: 0x060031A3 RID: 12707 RVA: 0x00095F8C File Offset: 0x0009418C
		public override int FillFields(byte[] data, int offset, global::NPOI.DDF.IEscherRecordFactory recordFactory)
		{
			int num = base.ReadHeader(data, offset);
			short numProperties = global::NPOI.DDF.EscherRecord.ReadInstance(data, offset);
			int offset2 = offset + 8;
			global::NPOI.DDF.EscherPropertyFactory escherPropertyFactory = new global::NPOI.DDF.EscherPropertyFactory();
			this.properties = escherPropertyFactory.CreateProperties(data, offset2, numProperties);
			return num + 8;
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x060031A4 RID: 12708 RVA: 0x00095FC4 File Offset: 0x000941C4
		public global::System.Collections.Generic.List<global::NPOI.DDF.EscherProperty> EscherProperties
		{
			get
			{
				return this.properties;
			}
		}

		// Token: 0x060031A5 RID: 12709 RVA: 0x00095FCC File Offset: 0x000941CC
		public global::NPOI.DDF.EscherProperty GetEscherProperty(int index)
		{
			return this.properties[index];
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x060031A6 RID: 12710 RVA: 0x00095FDC File Offset: 0x000941DC
		private int PropertiesSize
		{
			get
			{
				int num = 0;
				foreach (global::NPOI.DDF.EscherProperty escherProperty in this.properties)
				{
					num += escherProperty.PropertySize;
				}
				return num;
			}
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x060031A7 RID: 12711 RVA: 0x00096034 File Offset: 0x00094234
		public override int RecordSize
		{
			get
			{
				return 8 + this.PropertiesSize;
			}
		}

		// Token: 0x060031A8 RID: 12712 RVA: 0x00096040 File Offset: 0x00094240
		public global::NPOI.DDF.EscherProperty Lookup(int propId)
		{
			foreach (global::NPOI.DDF.EscherProperty escherProperty in this.properties)
			{
				if ((int)escherProperty.PropertyNumber == propId)
				{
					return escherProperty;
				}
			}
			return null;
		}

		// Token: 0x060031A9 RID: 12713 RVA: 0x0009609C File Offset: 0x0009429C
		public override int Serialize(int offset, byte[] data, global::NPOI.DDF.EscherSerializationListener listener)
		{
			listener.BeforeRecordSerialize(offset, this.RecordId, this);
			global::NPOI.Util.LittleEndian.PutShort(data, offset, this.Options);
			global::NPOI.Util.LittleEndian.PutShort(data, offset + 2, this.RecordId);
			global::NPOI.Util.LittleEndian.PutInt(data, offset + 4, this.PropertiesSize);
			int num = offset + 8;
			foreach (global::NPOI.DDF.EscherProperty escherProperty in this.properties)
			{
				num += escherProperty.SerializeSimplePart(data, num);
			}
			foreach (global::NPOI.DDF.EscherProperty escherProperty2 in this.properties)
			{
				num += escherProperty2.SerializeComplexPart(data, num);
			}
			listener.AfterRecordSerialize(num, this.RecordId, num - offset, this);
			return num - offset;
		}

		// Token: 0x060031AA RID: 12714 RVA: 0x0009618C File Offset: 0x0009438C
		public void SortProperties()
		{
			this.properties.Sort(new global::NPOI.DDF.AbstractEscherOptRecord.EscherPropertyComparer());
		}

		// Token: 0x060031AB RID: 12715 RVA: 0x000961A0 File Offset: 0x000943A0
		public void SetEscherProperty(global::NPOI.DDF.EscherProperty value)
		{
			global::System.Collections.Generic.List<global::NPOI.DDF.EscherProperty> list = new global::System.Collections.Generic.List<global::NPOI.DDF.EscherProperty>();
			foreach (global::NPOI.DDF.EscherProperty escherProperty in this.properties)
			{
				if (escherProperty.Id == value.Id)
				{
					list.Add(escherProperty);
				}
			}
			foreach (global::NPOI.DDF.EscherProperty item in list)
			{
				this.EscherProperties.Remove(item);
			}
			this.properties.Add(value);
			this.SortProperties();
		}

		// Token: 0x060031AC RID: 12716 RVA: 0x00096248 File Offset: 0x00094448
		public void RemoveEscherProperty(int num)
		{
			global::System.Collections.Generic.List<global::NPOI.DDF.EscherProperty> list = new global::System.Collections.Generic.List<global::NPOI.DDF.EscherProperty>();
			foreach (global::NPOI.DDF.EscherProperty escherProperty in this.EscherProperties)
			{
				if ((int)escherProperty.PropertyNumber == num)
				{
					list.Add(escherProperty);
				}
			}
			foreach (global::NPOI.DDF.EscherProperty item in list)
			{
				this.EscherProperties.Remove(item);
			}
		}

		// Token: 0x060031AD RID: 12717 RVA: 0x000962D8 File Offset: 0x000944D8
		public override string ToString()
		{
			string newLine = global::System.Environment.NewLine;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(base.GetType().Name);
			stringBuilder.Append(":");
			stringBuilder.Append(newLine);
			stringBuilder.Append("  isContainer: ");
			stringBuilder.Append(base.IsContainerRecord);
			stringBuilder.Append(newLine);
			stringBuilder.Append("  version: 0x");
			stringBuilder.Append(global::NPOI.Util.HexDump.ToHex(this.Version));
			stringBuilder.Append(newLine);
			stringBuilder.Append("  instance: 0x");
			stringBuilder.Append(global::NPOI.Util.HexDump.ToHex(this.Instance));
			stringBuilder.Append(newLine);
			stringBuilder.Append("  recordId: 0x");
			stringBuilder.Append(global::NPOI.Util.HexDump.ToHex(this.RecordId));
			stringBuilder.Append(newLine);
			stringBuilder.Append("  numchildren: ");
			stringBuilder.Append(this.ChildRecords.Count);
			stringBuilder.Append(newLine);
			stringBuilder.Append("  properties:");
			stringBuilder.Append(newLine);
			foreach (global::NPOI.DDF.EscherProperty escherProperty in this.properties)
			{
				stringBuilder.Append("    " + escherProperty.ToString() + newLine);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060031AE RID: 12718 RVA: 0x00096444 File Offset: 0x00094644
		public override string ToXml(string tab)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(tab).Append(base.FormatXmlRecordHeader(base.GetType().Name, global::NPOI.Util.HexDump.ToHex(this.RecordId), global::NPOI.Util.HexDump.ToHex(this.Version), global::NPOI.Util.HexDump.ToHex(this.Instance)));
			foreach (global::NPOI.DDF.EscherProperty escherProperty in this.EscherProperties)
			{
				stringBuilder.Append(escherProperty.ToXml(tab + "\t"));
			}
			stringBuilder.Append(tab).Append("</").Append(base.GetType().Name).Append(">\n");
			return stringBuilder.ToString();
		}

		// Token: 0x0400161E RID: 5662
		protected global::System.Collections.Generic.List<global::NPOI.DDF.EscherProperty> properties = new global::System.Collections.Generic.List<global::NPOI.DDF.EscherProperty>();

		// Token: 0x0200062C RID: 1580
		internal class EscherPropertyComparer : global::System.Collections.Generic.IComparer<global::NPOI.DDF.EscherProperty>
		{
			// Token: 0x060036E6 RID: 14054 RVA: 0x000A7B28 File Offset: 0x000A5D28
			public int Compare(global::NPOI.DDF.EscherProperty p1, global::NPOI.DDF.EscherProperty p2)
			{
				short propertyNumber = p1.PropertyNumber;
				short propertyNumber2 = p2.PropertyNumber;
				if (propertyNumber < propertyNumber2)
				{
					return -1;
				}
				if (propertyNumber != propertyNumber2)
				{
					return 1;
				}
				return 0;
			}
		}
	}
}
