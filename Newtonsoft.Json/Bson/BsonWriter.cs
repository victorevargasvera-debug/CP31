using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000112 RID: 274
	[global::System.Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
	public class BsonWriter : global::Newtonsoft.Json.JsonWriter
	{
		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000DAE RID: 3502 RVA: 0x000369B5 File Offset: 0x00034BB5
		// (set) Token: 0x06000DAF RID: 3503 RVA: 0x000369C2 File Offset: 0x00034BC2
		public global::System.DateTimeKind DateTimeKindHandling
		{
			get
			{
				return this._writer.DateTimeKindHandling;
			}
			set
			{
				this._writer.DateTimeKindHandling = value;
			}
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x000369D0 File Offset: 0x00034BD0
		public BsonWriter(global::System.IO.Stream stream)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(stream, "stream");
			this._writer = new global::Newtonsoft.Json.Bson.BsonBinaryWriter(new global::System.IO.BinaryWriter(stream));
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x000369F4 File Offset: 0x00034BF4
		public BsonWriter(global::System.IO.BinaryWriter writer)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(writer, "writer");
			this._writer = new global::Newtonsoft.Json.Bson.BsonBinaryWriter(writer);
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x00036A13 File Offset: 0x00034C13
		public override void Flush()
		{
			this._writer.Flush();
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x00036A20 File Offset: 0x00034C20
		protected override void WriteEnd(global::Newtonsoft.Json.JsonToken token)
		{
			base.WriteEnd(token);
			this.RemoveParent();
			if (base.Top == 0)
			{
				this._writer.WriteToken(this._root);
			}
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x00036A48 File Offset: 0x00034C48
		public override void WriteComment(string text)
		{
			throw global::Newtonsoft.Json.JsonWriterException.Create(this, "Cannot write JSON comment as BSON.", null);
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x00036A56 File Offset: 0x00034C56
		public override void WriteStartConstructor(string name)
		{
			throw global::Newtonsoft.Json.JsonWriterException.Create(this, "Cannot write JSON constructor as BSON.", null);
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x00036A64 File Offset: 0x00034C64
		public override void WriteRaw(string json)
		{
			throw global::Newtonsoft.Json.JsonWriterException.Create(this, "Cannot write raw JSON as BSON.", null);
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x00036A72 File Offset: 0x00034C72
		public override void WriteRawValue(string json)
		{
			throw global::Newtonsoft.Json.JsonWriterException.Create(this, "Cannot write raw JSON as BSON.", null);
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x00036A80 File Offset: 0x00034C80
		public override void WriteStartArray()
		{
			base.WriteStartArray();
			this.AddParent(new global::Newtonsoft.Json.Bson.BsonArray());
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x00036A93 File Offset: 0x00034C93
		public override void WriteStartObject()
		{
			base.WriteStartObject();
			this.AddParent(new global::Newtonsoft.Json.Bson.BsonObject());
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x00036AA6 File Offset: 0x00034CA6
		public override void WritePropertyName(string name)
		{
			base.WritePropertyName(name);
			this._propertyName = name;
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x00036AB6 File Offset: 0x00034CB6
		public override void Close()
		{
			base.Close();
			if (base.CloseOutput)
			{
				global::Newtonsoft.Json.Bson.BsonBinaryWriter writer = this._writer;
				if (writer == null)
				{
					return;
				}
				writer.Close();
			}
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x00036AD6 File Offset: 0x00034CD6
		private void AddParent(global::Newtonsoft.Json.Bson.BsonToken container)
		{
			this.AddToken(container);
			this._parent = container;
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00036AE6 File Offset: 0x00034CE6
		private void RemoveParent()
		{
			this._parent = this._parent.Parent;
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x00036AF9 File Offset: 0x00034CF9
		private void AddValue(object value, global::Newtonsoft.Json.Bson.BsonType type)
		{
			this.AddToken(new global::Newtonsoft.Json.Bson.BsonValue(value, type));
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x00036B08 File Offset: 0x00034D08
		internal void AddToken(global::Newtonsoft.Json.Bson.BsonToken token)
		{
			if (this._parent != null)
			{
				global::Newtonsoft.Json.Bson.BsonObject bsonObject = this._parent as global::Newtonsoft.Json.Bson.BsonObject;
				if (bsonObject != null)
				{
					bsonObject.Add(this._propertyName, token);
					this._propertyName = null;
					return;
				}
				((global::Newtonsoft.Json.Bson.BsonArray)this._parent).Add(token);
				return;
			}
			else
			{
				if (token.Type != global::Newtonsoft.Json.Bson.BsonType.Object && token.Type != global::Newtonsoft.Json.Bson.BsonType.Array)
				{
					throw global::Newtonsoft.Json.JsonWriterException.Create(this, "Error writing {0} value. BSON must start with an Object or Array.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, token.Type), null);
				}
				this._parent = token;
				this._root = token;
				return;
			}
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00036B98 File Offset: 0x00034D98
		public override void WriteValue(object value)
		{
			if (value is global::System.Numerics.BigInteger)
			{
				global::System.Numerics.BigInteger bigInteger = (global::System.Numerics.BigInteger)value;
				base.SetWriteState(global::Newtonsoft.Json.JsonToken.Integer, null);
				this.AddToken(new global::Newtonsoft.Json.Bson.BsonBinary(bigInteger.ToByteArray(), global::Newtonsoft.Json.Bson.BsonBinaryType.Binary));
				return;
			}
			base.WriteValue(value);
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00036BD7 File Offset: 0x00034DD7
		public override void WriteNull()
		{
			base.WriteNull();
			this.AddToken(global::Newtonsoft.Json.Bson.BsonEmpty.Null);
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x00036BEA File Offset: 0x00034DEA
		public override void WriteUndefined()
		{
			base.WriteUndefined();
			this.AddToken(global::Newtonsoft.Json.Bson.BsonEmpty.Undefined);
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x00036BFD File Offset: 0x00034DFD
		public override void WriteValue(string value)
		{
			base.WriteValue(value);
			this.AddToken((value == null) ? global::Newtonsoft.Json.Bson.BsonEmpty.Null : new global::Newtonsoft.Json.Bson.BsonString(value, true));
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x00036C1D File Offset: 0x00034E1D
		public override void WriteValue(int value)
		{
			base.WriteValue(value);
			this.AddValue(value, global::Newtonsoft.Json.Bson.BsonType.Integer);
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x00036C34 File Offset: 0x00034E34
		[global::System.CLSCompliant(false)]
		public override void WriteValue(uint value)
		{
			if (value > 2147483647U)
			{
				throw global::Newtonsoft.Json.JsonWriterException.Create(this, "Value is too large to fit in a signed 32 bit integer. BSON does not support unsigned values.", null);
			}
			base.WriteValue(value);
			this.AddValue(value, global::Newtonsoft.Json.Bson.BsonType.Integer);
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x00036C60 File Offset: 0x00034E60
		public override void WriteValue(long value)
		{
			base.WriteValue(value);
			this.AddValue(value, global::Newtonsoft.Json.Bson.BsonType.Long);
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x00036C77 File Offset: 0x00034E77
		[global::System.CLSCompliant(false)]
		public override void WriteValue(ulong value)
		{
			if (value > 9223372036854775807UL)
			{
				throw global::Newtonsoft.Json.JsonWriterException.Create(this, "Value is too large to fit in a signed 64 bit integer. BSON does not support unsigned values.", null);
			}
			base.WriteValue(value);
			this.AddValue(value, global::Newtonsoft.Json.Bson.BsonType.Long);
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x00036CA7 File Offset: 0x00034EA7
		public override void WriteValue(float value)
		{
			base.WriteValue(value);
			this.AddValue(value, global::Newtonsoft.Json.Bson.BsonType.Number);
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x00036CBD File Offset: 0x00034EBD
		public override void WriteValue(double value)
		{
			base.WriteValue(value);
			this.AddValue(value, global::Newtonsoft.Json.Bson.BsonType.Number);
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x00036CD3 File Offset: 0x00034ED3
		public override void WriteValue(bool value)
		{
			base.WriteValue(value);
			this.AddToken(value ? global::Newtonsoft.Json.Bson.BsonBoolean.True : global::Newtonsoft.Json.Bson.BsonBoolean.False);
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x00036CF1 File Offset: 0x00034EF1
		public override void WriteValue(short value)
		{
			base.WriteValue(value);
			this.AddValue(value, global::Newtonsoft.Json.Bson.BsonType.Integer);
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x00036D08 File Offset: 0x00034F08
		[global::System.CLSCompliant(false)]
		public override void WriteValue(ushort value)
		{
			base.WriteValue(value);
			this.AddValue(value, global::Newtonsoft.Json.Bson.BsonType.Integer);
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x00036D20 File Offset: 0x00034F20
		public override void WriteValue(char value)
		{
			base.WriteValue(value);
			string value2 = value.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
			this.AddToken(new global::Newtonsoft.Json.Bson.BsonString(value2, true));
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x00036D50 File Offset: 0x00034F50
		public override void WriteValue(byte value)
		{
			base.WriteValue(value);
			this.AddValue(value, global::Newtonsoft.Json.Bson.BsonType.Integer);
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x00036D67 File Offset: 0x00034F67
		[global::System.CLSCompliant(false)]
		public override void WriteValue(sbyte value)
		{
			base.WriteValue(value);
			this.AddValue(value, global::Newtonsoft.Json.Bson.BsonType.Integer);
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x00036D7E File Offset: 0x00034F7E
		public override void WriteValue(decimal value)
		{
			base.WriteValue(value);
			this.AddValue(value, global::Newtonsoft.Json.Bson.BsonType.Number);
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x00036D94 File Offset: 0x00034F94
		public override void WriteValue(global::System.DateTime value)
		{
			base.WriteValue(value);
			value = global::Newtonsoft.Json.Utilities.DateTimeUtils.EnsureDateTime(value, base.DateTimeZoneHandling);
			this.AddValue(value, global::Newtonsoft.Json.Bson.BsonType.Date);
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x00036DB9 File Offset: 0x00034FB9
		public override void WriteValue(global::System.DateTimeOffset value)
		{
			base.WriteValue(value);
			this.AddValue(value, global::Newtonsoft.Json.Bson.BsonType.Date);
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00036DD0 File Offset: 0x00034FD0
		public override void WriteValue(byte[] value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			base.WriteValue(value);
			this.AddToken(new global::Newtonsoft.Json.Bson.BsonBinary(value, global::Newtonsoft.Json.Bson.BsonBinaryType.Binary));
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x00036DF0 File Offset: 0x00034FF0
		public override void WriteValue(global::System.Guid value)
		{
			base.WriteValue(value);
			this.AddToken(new global::Newtonsoft.Json.Bson.BsonBinary(value.ToByteArray(), global::Newtonsoft.Json.Bson.BsonBinaryType.Uuid));
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00036E0C File Offset: 0x0003500C
		public override void WriteValue(global::System.TimeSpan value)
		{
			base.WriteValue(value);
			this.AddToken(new global::Newtonsoft.Json.Bson.BsonString(value.ToString(), true));
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x00036E2E File Offset: 0x0003502E
		public override void WriteValue(global::System.Uri value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			base.WriteValue(value);
			this.AddToken(new global::Newtonsoft.Json.Bson.BsonString(value.ToString(), true));
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x00036E59 File Offset: 0x00035059
		public void WriteObjectId(byte[] value)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(value, "value");
			if (value.Length != 12)
			{
				throw global::Newtonsoft.Json.JsonWriterException.Create(this, "An object id must be 12 bytes", null);
			}
			base.SetWriteState(global::Newtonsoft.Json.JsonToken.Undefined, null);
			this.AddValue(value, global::Newtonsoft.Json.Bson.BsonType.Oid);
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x00036E8B File Offset: 0x0003508B
		public void WriteRegex(string pattern, string options)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(pattern, "pattern");
			base.SetWriteState(global::Newtonsoft.Json.JsonToken.Undefined, null);
			this.AddToken(new global::Newtonsoft.Json.Bson.BsonRegex(pattern, options));
		}

		// Token: 0x04000443 RID: 1091
		private readonly global::Newtonsoft.Json.Bson.BsonBinaryWriter _writer;

		// Token: 0x04000444 RID: 1092
		private global::Newtonsoft.Json.Bson.BsonToken _root;

		// Token: 0x04000445 RID: 1093
		private global::Newtonsoft.Json.Bson.BsonToken _parent;

		// Token: 0x04000446 RID: 1094
		private string _propertyName;
	}
}
