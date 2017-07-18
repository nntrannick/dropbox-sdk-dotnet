// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Transferred contents of a removed team member account to another member.</para>
    /// </summary>
    public class MemberTransferAccountContentsDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MemberTransferAccountContentsDetails> Encoder = new MemberTransferAccountContentsDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MemberTransferAccountContentsDetails> Decoder = new MemberTransferAccountContentsDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="MemberTransferAccountContentsDetails" /> class.</para>
        /// </summary>
        /// <param name="srcIndex">Source asset index.</param>
        /// <param name="destIndex">Destination asset index.</param>
        public MemberTransferAccountContentsDetails(long srcIndex,
                                                    long destIndex)
        {
            this.SrcIndex = srcIndex;
            this.DestIndex = destIndex;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="MemberTransferAccountContentsDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public MemberTransferAccountContentsDetails()
        {
        }

        /// <summary>
        /// <para>Source asset index.</para>
        /// </summary>
        public long SrcIndex { get; protected set; }

        /// <summary>
        /// <para>Destination asset index.</para>
        /// </summary>
        public long DestIndex { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MemberTransferAccountContentsDetails" />.</para>
        /// </summary>
        private class MemberTransferAccountContentsDetailsEncoder : enc.StructEncoder<MemberTransferAccountContentsDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MemberTransferAccountContentsDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("src_index", value.SrcIndex, writer, enc.Int64Encoder.Instance);
                WriteProperty("dest_index", value.DestIndex, writer, enc.Int64Encoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MemberTransferAccountContentsDetails" />.</para>
        /// </summary>
        private class MemberTransferAccountContentsDetailsDecoder : enc.StructDecoder<MemberTransferAccountContentsDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="MemberTransferAccountContentsDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MemberTransferAccountContentsDetails Create()
            {
                return new MemberTransferAccountContentsDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(MemberTransferAccountContentsDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "src_index":
                        value.SrcIndex = enc.Int64Decoder.Instance.Decode(reader);
                        break;
                    case "dest_index":
                        value.DestIndex = enc.Int64Decoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
