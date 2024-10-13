// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: service_accountprivateapps.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.WebUI.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountPrivateAppList : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<int> appids { get; } = new global::System.Collections.Generic.List<int>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountPrivateApps_GetPrivateAppList_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountPrivateApps_GetPrivateAppList_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public CAccountPrivateAppList private_apps { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountPrivateApps_ToggleAppPrivacy_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<int> appids { get; } = new global::System.Collections.Generic.List<int>();

        [global::ProtoBuf.ProtoMember(2)]
        public bool @private
        {
            get => __pbn__private.GetValueOrDefault();
            set => __pbn__private = value;
        }
        public bool ShouldSerializeprivate() => __pbn__private != null;
        public void Resetprivate() => __pbn__private = null;
        private bool? __pbn__private;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountPrivateApps_ToggleAppPrivacy_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountPrivateApsClient_NotifyPrivateAppListChanged_Notification : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public CAccountPrivateAppList private_apps { get; set; }

    }

    public interface IAccountPrivateApps
    {
        CAccountPrivateApps_GetPrivateAppList_Response GetPrivateAppList(CAccountPrivateApps_GetPrivateAppList_Request request);
        CAccountPrivateApps_ToggleAppPrivacy_Response ToggleAppPrivacy(CAccountPrivateApps_ToggleAppPrivacy_Request request);
    }

    public interface IAccountPrivateAppsClient
    {
        NoResponse NotifyPrivateAppListChanged(CAccountPrivateApsClient_NotifyPrivateAppListChanged_Notification request);
    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion