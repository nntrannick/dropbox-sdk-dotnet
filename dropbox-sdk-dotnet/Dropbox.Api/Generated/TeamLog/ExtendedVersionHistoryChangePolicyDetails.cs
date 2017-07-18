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
    /// <para>Accepted or opted out of extended version history.</para>
    /// </summary>
    public class ExtendedVersionHistoryChangePolicyDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ExtendedVersionHistoryChangePolicyDetails> Encoder = new ExtendedVersionHistoryChangePolicyDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ExtendedVersionHistoryChangePolicyDetails> Decoder = new ExtendedVersionHistoryChangePolicyDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="ExtendedVersionHistoryChangePolicyDetails" /> class.</para>
        /// </summary>
        /// <param name="newValue">New extended version history policy.</param>
        /// <param name="previousValue">Previous extended version history policy. Might be
        /// missing due to historical data gap.</param>
        public ExtendedVersionHistoryChangePolicyDetails(ExtendedVersionHistoryPolicy newValue,
                                                         ExtendedVersionHistoryPolicy previousValue = null)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="ExtendedVersionHistoryChangePolicyDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public ExtendedVersionHistoryChangePolicyDetails()
        {
        }

        /// <summary>
        /// <para>New extended version history policy.</para>
        /// </summary>
        public ExtendedVersionHistoryPolicy NewValue { get; protected set; }

        /// <summary>
        /// <para>Previous extended version history policy. Might be missing due to historical
        /// data gap.</para>
        /// </summary>
        public ExtendedVersionHistoryPolicy PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ExtendedVersionHistoryChangePolicyDetails" />.</para>
        /// </summary>
        private class ExtendedVersionHistoryChangePolicyDetailsEncoder : enc.StructEncoder<ExtendedVersionHistoryChangePolicyDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ExtendedVersionHistoryChangePolicyDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamLog.ExtendedVersionHistoryPolicy.Encoder);
                if (value.PreviousValue != null)
                {
                    WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamLog.ExtendedVersionHistoryPolicy.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ExtendedVersionHistoryChangePolicyDetails" />.</para>
        /// </summary>
        private class ExtendedVersionHistoryChangePolicyDetailsDecoder : enc.StructDecoder<ExtendedVersionHistoryChangePolicyDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="ExtendedVersionHistoryChangePolicyDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ExtendedVersionHistoryChangePolicyDetails Create()
            {
                return new ExtendedVersionHistoryChangePolicyDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(ExtendedVersionHistoryChangePolicyDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamLog.ExtendedVersionHistoryPolicy.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamLog.ExtendedVersionHistoryPolicy.Decoder.Decode(reader);
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
