﻿using System.Runtime.Serialization;

namespace BossaAPI_Core.Fixml
{
    /// <summary>
    /// Błąd wynikający z otrzymania komunikatu FIXML o błędzie (m.in. BizMsgReject)
    /// </summary>
    public class FixmlErrorMsgException : FixmlException
	{
		protected FixmlMsg msg;
		public FixmlMsg Msg { get { return msg; } }

		public FixmlErrorMsgException(string str, FixmlMsg msg) : base(str) { this.msg = msg; }
		public FixmlErrorMsgException(FixmlMsg msg) : this(msg.ToString(), msg) { }

		protected FixmlErrorMsgException(SerializationInfo info, StreamingContext context) : base(info, context) { }
	}
}
