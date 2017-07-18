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
    /// <para>Renamed a group.</para>
    /// </summary>
    public class GroupRenameDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GroupRenameDetails> Encoder = new GroupRenameDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GroupRenameDetails> Decoder = new GroupRenameDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupRenameDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="groupInfo">Group details.</param>
        /// <param name="previousValue">Previous display name.</param>
        public GroupRenameDetails(GroupLogInfo groupInfo,
                                  string previousValue)
        {
            if (groupInfo == null)
            {
                throw new sys.ArgumentNullException("groupInfo");
            }

            if (previousValue == null)
            {
                throw new sys.ArgumentNullException("previousValue");
            }

            this.GroupInfo = groupInfo;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupRenameDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public GroupRenameDetails()
        {
        }

        /// <summary>
        /// <para>Group details.</para>
        /// </summary>
        public GroupLogInfo GroupInfo { get; protected set; }

        /// <summary>
        /// <para>Previous display name.</para>
        /// </summary>
        public string PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GroupRenameDetails" />.</para>
        /// </summary>
        private class GroupRenameDetailsEncoder : enc.StructEncoder<GroupRenameDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GroupRenameDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("group_info", value.GroupInfo, writer, global::Dropbox.Api.TeamLog.GroupLogInfo.Encoder);
                WriteProperty("previous_value", value.PreviousValue, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GroupRenameDetails" />.</para>
        /// </summary>
        private class GroupRenameDetailsDecoder : enc.StructDecoder<GroupRenameDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GroupRenameDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GroupRenameDetails Create()
            {
                return new GroupRenameDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(GroupRenameDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "group_info":
                        value.GroupInfo = global::Dropbox.Api.TeamLog.GroupLogInfo.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = enc.StringDecoder.Instance.Decode(reader);
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
