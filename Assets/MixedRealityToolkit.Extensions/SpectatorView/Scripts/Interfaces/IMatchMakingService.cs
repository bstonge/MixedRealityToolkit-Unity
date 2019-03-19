﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace Microsoft.MixedReality.Toolkit.Extensions.SpectatorView.Interfaces
{
    public interface IMatchMakingService
    {
        void Connect();
        bool Disconnect();
        bool IsConnected();
    }
}