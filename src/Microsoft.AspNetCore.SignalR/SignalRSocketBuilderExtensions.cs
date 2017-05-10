// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Sockets;
using Microsoft.AspNetCore.Sockets.Abstractions;

namespace Microsoft.AspNetCore.Builder
{
    public static class SignalRSocketBuilderExtensions
    {
        public static ISocketBuilder UseHub<THub>(this ISocketBuilder socketBuilder) where THub : Hub
        {
            return socketBuilder.UseEndPoint<HubEndPoint<THub>>();
        }
    }
}