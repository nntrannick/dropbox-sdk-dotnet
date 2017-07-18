// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Information returned by <see
    /// cref="Dropbox.Api.Team.Routes.TeamTeamRoutes.LinkedAppsListTeamLinkedAppsAsync"
    /// />.</para>
    /// </summary>
    public class ListTeamAppsResult
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ListTeamAppsResult> Encoder = new ListTeamAppsResultEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ListTeamAppsResult> Decoder = new ListTeamAppsResultDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListTeamAppsResult" />
        /// class.</para>
        /// </summary>
        /// <param name="apps">The linked applications of each member of the team</param>
        /// <param name="hasMore">If true, then there are more apps available. Pass the cursor
        /// to <see
        /// cref="Dropbox.Api.Team.Routes.TeamTeamRoutes.LinkedAppsListTeamLinkedAppsAsync" />
        /// to retrieve the rest.</param>
        /// <param name="cursor">Pass the cursor into <see
        /// cref="Dropbox.Api.Team.Routes.TeamTeamRoutes.LinkedAppsListTeamLinkedAppsAsync" />
        /// to receive the next sub list of team's applications.</param>
        public ListTeamAppsResult(col.IEnumerable<MemberLinkedApps> apps,
                                  bool hasMore,
                                  string cursor = null)
        {
            var appsList = enc.Util.ToList(apps);

            if (apps == null)
            {
                throw new sys.ArgumentNullException("apps");
            }

            this.Apps = appsList;
            this.HasMore = hasMore;
            this.Cursor = cursor;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListTeamAppsResult" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public ListTeamAppsResult()
        {
        }

        /// <summary>
        /// <para>The linked applications of each member of the team</para>
        /// </summary>
        public col.IList<MemberLinkedApps> Apps { get; protected set; }

        /// <summary>
        /// <para>If true, then there are more apps available. Pass the cursor to <see
        /// cref="Dropbox.Api.Team.Routes.TeamTeamRoutes.LinkedAppsListTeamLinkedAppsAsync" />
        /// to retrieve the rest.</para>
        /// </summary>
        public bool HasMore { get; protected set; }

        /// <summary>
        /// <para>Pass the cursor into <see
        /// cref="Dropbox.Api.Team.Routes.TeamTeamRoutes.LinkedAppsListTeamLinkedAppsAsync" />
        /// to receive the next sub list of team's applications.</para>
        /// </summary>
        public string Cursor { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ListTeamAppsResult" />.</para>
        /// </summary>
        private class ListTeamAppsResultEncoder : enc.StructEncoder<ListTeamAppsResult>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ListTeamAppsResult value, enc.IJsonWriter writer)
            {
                WriteListProperty("apps", value.Apps, writer, global::Dropbox.Api.Team.MemberLinkedApps.Encoder);
                WriteProperty("has_more", value.HasMore, writer, enc.BooleanEncoder.Instance);
                if (value.Cursor != null)
                {
                    WriteProperty("cursor", value.Cursor, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ListTeamAppsResult" />.</para>
        /// </summary>
        private class ListTeamAppsResultDecoder : enc.StructDecoder<ListTeamAppsResult>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ListTeamAppsResult" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ListTeamAppsResult Create()
            {
                return new ListTeamAppsResult();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(ListTeamAppsResult value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "apps":
                        value.Apps = ReadList<MemberLinkedApps>(reader, global::Dropbox.Api.Team.MemberLinkedApps.Decoder);
                        break;
                    case "has_more":
                        value.HasMore = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "cursor":
                        value.Cursor = enc.StringDecoder.Instance.Decode(reader);
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
