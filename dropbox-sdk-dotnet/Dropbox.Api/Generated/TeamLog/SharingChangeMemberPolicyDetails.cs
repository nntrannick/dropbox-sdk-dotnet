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
    /// <para>Changed whether team members can share files and folders externally (i.e. outside
    /// the team).</para>
    /// </summary>
    public class SharingChangeMemberPolicyDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharingChangeMemberPolicyDetails> Encoder = new SharingChangeMemberPolicyDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharingChangeMemberPolicyDetails> Decoder = new SharingChangeMemberPolicyDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="SharingChangeMemberPolicyDetails" /> class.</para>
        /// </summary>
        /// <param name="newValue">New external invite policy.</param>
        /// <param name="previousValue">Previous external invite policy. Might be missing due
        /// to historical data gap.</param>
        public SharingChangeMemberPolicyDetails(ExternalSharingPolicy newValue,
                                                ExternalSharingPolicy previousValue = null)
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
        /// cref="SharingChangeMemberPolicyDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SharingChangeMemberPolicyDetails()
        {
        }

        /// <summary>
        /// <para>New external invite policy.</para>
        /// </summary>
        public ExternalSharingPolicy NewValue { get; protected set; }

        /// <summary>
        /// <para>Previous external invite policy. Might be missing due to historical data
        /// gap.</para>
        /// </summary>
        public ExternalSharingPolicy PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharingChangeMemberPolicyDetails" />.</para>
        /// </summary>
        private class SharingChangeMemberPolicyDetailsEncoder : enc.StructEncoder<SharingChangeMemberPolicyDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharingChangeMemberPolicyDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamLog.ExternalSharingPolicy.Encoder);
                if (value.PreviousValue != null)
                {
                    WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamLog.ExternalSharingPolicy.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharingChangeMemberPolicyDetails" />.</para>
        /// </summary>
        private class SharingChangeMemberPolicyDetailsDecoder : enc.StructDecoder<SharingChangeMemberPolicyDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="SharingChangeMemberPolicyDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharingChangeMemberPolicyDetails Create()
            {
                return new SharingChangeMemberPolicyDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SharingChangeMemberPolicyDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamLog.ExternalSharingPolicy.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamLog.ExternalSharingPolicy.Decoder.Decode(reader);
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
