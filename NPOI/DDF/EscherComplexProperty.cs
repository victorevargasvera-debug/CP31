using System;
using System.IO;
using System.Text;
using NPOI.Util;

namespace NPOI.DDF
{
	// Token: 0x02000538 RID: 1336
	public class EscherComplexProperty : global::NPOI.DDF.EscherProperty
	{
		// Token: 0x06003251 RID: 12881 RVA: 0x0009910E File Offset: 0x0009730E
		public EscherComplexProperty(short id, byte[] complexData) : base(id)
		{
			if (complexData == null)
			{
				throw new global::System.ArgumentNullException("complexData can't be null");
			}
			this._complexData = (byte[])complexData.Clone();
		}

		// Token: 0x06003252 RID: 12882 RVA: 0x00099142 File Offset: 0x00097342
		public EscherComplexProperty(short propertyNumber, bool isBlipId, byte[] complexData) : base(propertyNumber, true, isBlipId)
		{
			if (complexData == null)
			{
				throw new global::System.ArgumentNullException("complexData can't be null");
			}
			this._complexData = (byte[])complexData.Clone();
		}

		// Token: 0x06003253 RID: 12883 RVA: 0x00099178 File Offset: 0x00097378
		public override int SerializeSimplePart(byte[] data, int pos)
		{
			global::NPOI.Util.LittleEndian.PutShort(data, pos, this.Id);
			global::NPOI.Util.LittleEndian.PutInt(data, pos + 2, this._complexData.Length);
			return 6;
		}

		// Token: 0x06003254 RID: 12884 RVA: 0x00099199 File Offset: 0x00097399
		public override int SerializeComplexPart(byte[] data, int pos)
		{
			global::System.Array.Copy(this._complexData, 0, data, pos, this._complexData.Length);
			return this._complexData.Length;
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x06003255 RID: 12885 RVA: 0x000991B9 File Offset: 0x000973B9
		public byte[] ComplexData
		{
			get
			{
				return this._complexData;
			}
		}

		// Token: 0x06003256 RID: 12886 RVA: 0x000991C4 File Offset: 0x000973C4
		public override bool Equals(object o)
		{
			if (this == o)
			{
				return true;
			}
			if (o == null || !(o is global::NPOI.DDF.EscherComplexProperty))
			{
				return false;
			}
			global::NPOI.DDF.EscherComplexProperty escherComplexProperty = (global::NPOI.DDF.EscherComplexProperty)o;
			return global::NPOI.Util.Arrays.Equals(this._complexData, escherComplexProperty._complexData);
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x06003257 RID: 12887 RVA: 0x00099201 File Offset: 0x00097401
		public override int PropertySize
		{
			get
			{
				return 6 + this._complexData.Length;
			}
		}

		// Token: 0x06003258 RID: 12888 RVA: 0x0009920D File Offset: 0x0009740D
		public override int GetHashCode()
		{
			return (int)(this.Id * 11);
		}

		// Token: 0x06003259 RID: 12889 RVA: 0x00099218 File Offset: 0x00097418
		public override string ToString()
		{
			string text;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				try
				{
					global::NPOI.Util.HexDump.Dump(this._complexData, 0L, memoryStream, 0);
					text = memoryStream.ToString();
				}
				catch (global::System.Exception ex)
				{
					text = ex.ToString();
				}
			}
			return string.Concat(new string[]
			{
				"propNum: ",
				this.PropertyNumber.ToString(),
				", propName: ",
				global::NPOI.DDF.EscherProperties.GetPropertyName(this.PropertyNumber),
				", complex: ",
				this.IsComplex.ToString(),
				", blipId: ",
				this.IsBlipId.ToString(),
				", data: ",
				global::System.Environment.NewLine,
				text
			});
		}

		// Token: 0x0600325A RID: 12890 RVA: 0x000992F4 File Offset: 0x000974F4
		public override string ToXml(string tab)
		{
			global::NPOI.Util.HexDump.ToHex(this._complexData, 32);
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(tab).Append("<").Append(base.GetType().Name).Append(" id=\"0x").Append(global::NPOI.Util.HexDump.ToHex(this.Id)).Append("\" name=\"").Append(this.Name).Append("\" blipId=\"").Append(this.IsBlipId).Append("\">\n");
			stringBuilder.Append(tab).Append("</").Append(base.GetType().Name).Append(">\n");
			return stringBuilder.ToString();
		}

		// Token: 0x04001679 RID: 5753
		protected byte[] _complexData = new byte[0];
	}
}
