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
    /// <para>The group management type object</para>
    /// </summary>
    public class GroupManagementType
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GroupManagementType> Encoder = new GroupManagementTypeEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GroupManagementType> Decoder = new GroupManagementTypeDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupManagementType" />
        /// class.</para>
        /// </summary>
        public GroupManagementType()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is AdminManagementGroup</para>
        /// </summary>
        public bool IsAdminManagementGroup
        {
            get
            {
                return this is AdminManagementGroup;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a AdminManagementGroup, or <c>null</c>.</para>
        /// </summary>
        public AdminManagementGroup AsAdminManagementGroup
        {
            get
            {
                return this as AdminManagementGroup;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is MemberManagementGroup</para>
        /// </summary>
        public bool IsMemberManagementGroup
        {
            get
            {
                return this is MemberManagementGroup;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a MemberManagementGroup, or <c>null</c>.</para>
        /// </summary>
        public MemberManagementGroup AsMemberManagementGroup
        {
            get
            {
                return this as MemberManagementGroup;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GroupManagementType" />.</para>
        /// </summary>
        private class GroupManagementTypeEncoder : enc.StructEncoder<GroupManagementType>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GroupManagementType value, enc.IJsonWriter writer)
            {
                if (value is AdminManagementGroup)
                {
                    WriteProperty(".tag", "admin_management_group", writer, enc.StringEncoder.Instance);
                    AdminManagementGroup.Encoder.EncodeFields((AdminManagementGroup)value, writer);
                    return;
                }
                if (value is MemberManagementGroup)
                {
                    WriteProperty(".tag", "member_management_group", writer, enc.StringEncoder.Instance);
                    MemberManagementGroup.Encoder.EncodeFields((MemberManagementGroup)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GroupManagementType" />.</para>
        /// </summary>
        private class GroupManagementTypeDecoder : enc.UnionDecoder<GroupManagementType>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GroupManagementType" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GroupManagementType Create()
            {
                return new GroupManagementType();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override GroupManagementType Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "admin_management_group":
                        return AdminManagementGroup.Decoder.DecodeFields(reader);
                    case "member_management_group":
                        return MemberManagementGroup.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The admin management group object</para>
        /// </summary>
        public sealed class AdminManagementGroup : GroupManagementType
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<AdminManagementGroup> Encoder = new AdminManagementGroupEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<AdminManagementGroup> Decoder = new AdminManagementGroupDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="AdminManagementGroup" />
            /// class.</para>
            /// </summary>
            private AdminManagementGroup()
            {
            }

            /// <summary>
            /// <para>A singleton instance of AdminManagementGroup</para>
            /// </summary>
            public static readonly AdminManagementGroup Instance = new AdminManagementGroup();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="AdminManagementGroup" />.</para>
            /// </summary>
            private class AdminManagementGroupEncoder : enc.StructEncoder<AdminManagementGroup>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(AdminManagementGroup value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="AdminManagementGroup" />.</para>
            /// </summary>
            private class AdminManagementGroupDecoder : enc.StructDecoder<AdminManagementGroup>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="AdminManagementGroup"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override AdminManagementGroup Create()
                {
                    return AdminManagementGroup.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The member management group object</para>
        /// </summary>
        public sealed class MemberManagementGroup : GroupManagementType
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<MemberManagementGroup> Encoder = new MemberManagementGroupEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<MemberManagementGroup> Decoder = new MemberManagementGroupDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="MemberManagementGroup" />
            /// class.</para>
            /// </summary>
            private MemberManagementGroup()
            {
            }

            /// <summary>
            /// <para>A singleton instance of MemberManagementGroup</para>
            /// </summary>
            public static readonly MemberManagementGroup Instance = new MemberManagementGroup();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="MemberManagementGroup" />.</para>
            /// </summary>
            private class MemberManagementGroupEncoder : enc.StructEncoder<MemberManagementGroup>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(MemberManagementGroup value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="MemberManagementGroup" />.</para>
            /// </summary>
            private class MemberManagementGroupDecoder : enc.StructDecoder<MemberManagementGroup>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="MemberManagementGroup"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override MemberManagementGroup Create()
                {
                    return MemberManagementGroup.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : GroupManagementType
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}
