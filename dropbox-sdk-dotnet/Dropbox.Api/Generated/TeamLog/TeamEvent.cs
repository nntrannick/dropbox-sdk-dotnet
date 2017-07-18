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
    /// <para>An audit log event.</para>
    /// </summary>
    public class TeamEvent
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<TeamEvent> Encoder = new TeamEventEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<TeamEvent> Decoder = new TeamEventDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TeamEvent" /> class.</para>
        /// </summary>
        /// <param name="timestamp">The Dropbox timestamp representing when the action was
        /// taken.</param>
        /// <param name="eventCategories">One or more categories that this type of action
        /// belongs to.</param>
        /// <param name="actor">The entity who actually performed the action.</param>
        /// <param name="involveNonTeamMember">True if the action involved a non team member
        /// either as the actor or as one of the affected users.</param>
        /// <param name="context">The user or team on whose behalf the actor performed the
        /// action.</param>
        /// <param name="eventType">The particular type of action taken.</param>
        /// <param name="details">The variable event schema applicable to this type of action,
        /// instantiated with respect to this particular action.</param>
        /// <param name="origin">The origin from which the actor performed the action including
        /// information about host, ip address, location, session, etc. If the action was
        /// performed programmatically via the API the origin represents the API
        /// client.</param>
        /// <param name="participants">Zero or more users and/or groups that are affected by
        /// the action. Note that this list doesn't include any actors or users in
        /// context.</param>
        /// <param name="assets">Zero or more content assets involved in the action. Currently
        /// these include Dropbox files and folders but in the future we might add other asset
        /// types such as Paper documents, folders, projects, etc.</param>
        public TeamEvent(sys.DateTime timestamp,
                         col.IEnumerable<EventCategory> eventCategories,
                         ActorLogInfo actor,
                         bool involveNonTeamMember,
                         ContextLogInfo context,
                         EventType eventType,
                         EventDetails details,
                         OriginLogInfo origin = null,
                         col.IEnumerable<ParticipantLogInfo> participants = null,
                         col.IEnumerable<AssetLogInfo> assets = null)
        {
            var eventCategoriesList = enc.Util.ToList(eventCategories);

            if (eventCategories == null)
            {
                throw new sys.ArgumentNullException("eventCategories");
            }
            if (eventCategoriesList.Count < 1)
            {
                throw new sys.ArgumentOutOfRangeException("eventCategories", "List should at at least 1 items");
            }

            if (actor == null)
            {
                throw new sys.ArgumentNullException("actor");
            }

            if (context == null)
            {
                throw new sys.ArgumentNullException("context");
            }

            if (eventType == null)
            {
                throw new sys.ArgumentNullException("eventType");
            }

            if (details == null)
            {
                throw new sys.ArgumentNullException("details");
            }

            var participantsList = enc.Util.ToList(participants);

            var assetsList = enc.Util.ToList(assets);

            this.Timestamp = timestamp;
            this.EventCategories = eventCategoriesList;
            this.Actor = actor;
            this.InvolveNonTeamMember = involveNonTeamMember;
            this.Context = context;
            this.EventType = eventType;
            this.Details = details;
            this.Origin = origin;
            this.Participants = participantsList;
            this.Assets = assetsList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TeamEvent" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public TeamEvent()
        {
        }

        /// <summary>
        /// <para>The Dropbox timestamp representing when the action was taken.</para>
        /// </summary>
        public sys.DateTime Timestamp { get; protected set; }

        /// <summary>
        /// <para>One or more categories that this type of action belongs to.</para>
        /// </summary>
        public col.IList<EventCategory> EventCategories { get; protected set; }

        /// <summary>
        /// <para>The entity who actually performed the action.</para>
        /// </summary>
        public ActorLogInfo Actor { get; protected set; }

        /// <summary>
        /// <para>True if the action involved a non team member either as the actor or as one
        /// of the affected users.</para>
        /// </summary>
        public bool InvolveNonTeamMember { get; protected set; }

        /// <summary>
        /// <para>The user or team on whose behalf the actor performed the action.</para>
        /// </summary>
        public ContextLogInfo Context { get; protected set; }

        /// <summary>
        /// <para>The particular type of action taken.</para>
        /// </summary>
        public EventType EventType { get; protected set; }

        /// <summary>
        /// <para>The variable event schema applicable to this type of action, instantiated
        /// with respect to this particular action.</para>
        /// </summary>
        public EventDetails Details { get; protected set; }

        /// <summary>
        /// <para>The origin from which the actor performed the action including information
        /// about host, ip address, location, session, etc. If the action was performed
        /// programmatically via the API the origin represents the API client.</para>
        /// </summary>
        public OriginLogInfo Origin { get; protected set; }

        /// <summary>
        /// <para>Zero or more users and/or groups that are affected by the action. Note that
        /// this list doesn't include any actors or users in context.</para>
        /// </summary>
        public col.IList<ParticipantLogInfo> Participants { get; protected set; }

        /// <summary>
        /// <para>Zero or more content assets involved in the action. Currently these include
        /// Dropbox files and folders but in the future we might add other asset types such as
        /// Paper documents, folders, projects, etc.</para>
        /// </summary>
        public col.IList<AssetLogInfo> Assets { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="TeamEvent" />.</para>
        /// </summary>
        private class TeamEventEncoder : enc.StructEncoder<TeamEvent>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(TeamEvent value, enc.IJsonWriter writer)
            {
                WriteProperty("timestamp", value.Timestamp, writer, enc.DateTimeEncoder.Instance);
                WriteListProperty("event_categories", value.EventCategories, writer, global::Dropbox.Api.TeamLog.EventCategory.Encoder);
                WriteProperty("actor", value.Actor, writer, global::Dropbox.Api.TeamLog.ActorLogInfo.Encoder);
                WriteProperty("involve_non_team_member", value.InvolveNonTeamMember, writer, enc.BooleanEncoder.Instance);
                WriteProperty("context", value.Context, writer, global::Dropbox.Api.TeamLog.ContextLogInfo.Encoder);
                WriteProperty("event_type", value.EventType, writer, global::Dropbox.Api.TeamLog.EventType.Encoder);
                WriteProperty("details", value.Details, writer, global::Dropbox.Api.TeamLog.EventDetails.Encoder);
                if (value.Origin != null)
                {
                    WriteProperty("origin", value.Origin, writer, global::Dropbox.Api.TeamLog.OriginLogInfo.Encoder);
                }
                if (value.Participants.Count > 0)
                {
                    WriteListProperty("participants", value.Participants, writer, global::Dropbox.Api.TeamLog.ParticipantLogInfo.Encoder);
                }
                if (value.Assets.Count > 0)
                {
                    WriteListProperty("assets", value.Assets, writer, global::Dropbox.Api.TeamLog.AssetLogInfo.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="TeamEvent" />.</para>
        /// </summary>
        private class TeamEventDecoder : enc.StructDecoder<TeamEvent>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="TeamEvent" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override TeamEvent Create()
            {
                return new TeamEvent();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(TeamEvent value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "timestamp":
                        value.Timestamp = enc.DateTimeDecoder.Instance.Decode(reader);
                        break;
                    case "event_categories":
                        value.EventCategories = ReadList<EventCategory>(reader, global::Dropbox.Api.TeamLog.EventCategory.Decoder);
                        break;
                    case "actor":
                        value.Actor = global::Dropbox.Api.TeamLog.ActorLogInfo.Decoder.Decode(reader);
                        break;
                    case "involve_non_team_member":
                        value.InvolveNonTeamMember = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "context":
                        value.Context = global::Dropbox.Api.TeamLog.ContextLogInfo.Decoder.Decode(reader);
                        break;
                    case "event_type":
                        value.EventType = global::Dropbox.Api.TeamLog.EventType.Decoder.Decode(reader);
                        break;
                    case "details":
                        value.Details = global::Dropbox.Api.TeamLog.EventDetails.Decoder.Decode(reader);
                        break;
                    case "origin":
                        value.Origin = global::Dropbox.Api.TeamLog.OriginLogInfo.Decoder.Decode(reader);
                        break;
                    case "participants":
                        value.Participants = ReadList<ParticipantLogInfo>(reader, global::Dropbox.Api.TeamLog.ParticipantLogInfo.Decoder);
                        break;
                    case "assets":
                        value.Assets = ReadList<AssetLogInfo>(reader, global::Dropbox.Api.TeamLog.AssetLogInfo.Decoder);
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
