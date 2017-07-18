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
    /// <para>Group's logged information.</para>
    /// </summary>
    /// <seealso cref="GroupAddExternalIdDetails" />
    /// <seealso cref="GroupAddMemberDetails" />
    /// <seealso cref="GroupChangeExternalIdDetails" />
    /// <seealso cref="GroupChangeManagementTypeDetails" />
    /// <seealso cref="GroupChangeMemberRoleDetails" />
    /// <seealso cref="GroupCreateDetails" />
    /// <seealso cref="GroupDeleteDetails" />
    /// <seealso cref="GroupDescriptionUpdatedDetails" />
    /// <seealso cref="GroupJoinPolicyUpdatedDetails" />
    /// <seealso cref="GroupMovedDetails" />
    /// <seealso cref="GroupRemoveExternalIdDetails" />
    /// <seealso cref="GroupRemoveMemberDetails" />
    /// <seealso cref="GroupRenameDetails" />
    public class GroupLogInfo
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GroupLogInfo> Encoder = new GroupLogInfoEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GroupLogInfo> Decoder = new GroupLogInfoDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupLogInfo" /> class.</para>
        /// </summary>
        /// <param name="displayName">The name of this group.</param>
        /// <param name="groupId">The unique id of this group. Might be missing due to
        /// historical data gap.</param>
        /// <param name="externalId">External group ID. Might be missing due to historical data
        /// gap.</param>
        public GroupLogInfo(string displayName,
                            string groupId = null,
                            string externalId = null)
        {
            if (displayName == null)
            {
                throw new sys.ArgumentNullException("displayName");
            }

            this.DisplayName = displayName;
            this.GroupId = groupId;
            this.ExternalId = externalId;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupLogInfo" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public GroupLogInfo()
        {
        }

        /// <summary>
        /// <para>The name of this group.</para>
        /// </summary>
        public string DisplayName { get; protected set; }

        /// <summary>
        /// <para>The unique id of this group. Might be missing due to historical data
        /// gap.</para>
        /// </summary>
        public string GroupId { get; protected set; }

        /// <summary>
        /// <para>External group ID. Might be missing due to historical data gap.</para>
        /// </summary>
        public string ExternalId { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GroupLogInfo" />.</para>
        /// </summary>
        private class GroupLogInfoEncoder : enc.StructEncoder<GroupLogInfo>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GroupLogInfo value, enc.IJsonWriter writer)
            {
                WriteProperty("display_name", value.DisplayName, writer, enc.StringEncoder.Instance);
                if (value.GroupId != null)
                {
                    WriteProperty("group_id", value.GroupId, writer, enc.StringEncoder.Instance);
                }
                if (value.ExternalId != null)
                {
                    WriteProperty("external_id", value.ExternalId, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GroupLogInfo" />.</para>
        /// </summary>
        private class GroupLogInfoDecoder : enc.StructDecoder<GroupLogInfo>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GroupLogInfo" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GroupLogInfo Create()
            {
                return new GroupLogInfo();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(GroupLogInfo value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "display_name":
                        value.DisplayName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "group_id":
                        value.GroupId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "external_id":
                        value.ExternalId = enc.StringDecoder.Instance.Decode(reader);
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
