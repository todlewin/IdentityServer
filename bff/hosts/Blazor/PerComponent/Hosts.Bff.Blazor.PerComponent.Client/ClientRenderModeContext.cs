﻿namespace Hosts.Bff.Blazor.PerComponent.Client;

public class ClientRenderModeContext : IRenderModeContext
{
    public RenderMode GetMode() => RenderMode.Client;
}