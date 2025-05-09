﻿using Content.Shared.FixedPoint;
using Content.Shared.Radio;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization;

namespace Content.Shared._RMC14.Communications;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
[Access(typeof(CommunicationsTowerSystem))]
public sealed partial class CommunicationsTowerComponent : Component
{
    [DataField, AutoNetworkedField]
    public CommunicationsTowerState State = CommunicationsTowerState.Off;

    [DataField, AutoNetworkedField]
    public HashSet<ProtoId<RadioChannelPrototype>> Channels = new() {new ProtoId<RadioChannelPrototype>("Colony")};

    [DataField, AutoNetworkedField]
    public FixedPoint2 TechPoints = FixedPoint2.New(0.7);
}

[Serializable, NetSerializable]
public enum CommunicationsTowerState
{
    Broken,
    Off,
    On,
}

[Serializable, NetSerializable]
public enum CommunicationsTowerLayers
{
    Layer,
}

