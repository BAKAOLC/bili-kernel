﻿// Copyright (c) Richasy. All rights reserved.
// Licensed under the MIT License.

using Microsoft.Extensions.DependencyInjection;
using Richasy.BiliKernel.Bili.Authorization;
using Richasy.BiliKernel.Resolvers.WinUIToken;
using RichasyKernel;

namespace Richasy.BiliKernel;

/// <summary>
/// 内核构建器扩展.
/// </summary>
public static class KernelBuilderExtensions
{
    /// <summary>
    /// 添加 WinUI 令牌解析器.
    /// </summary>
    public static IKernelBuilder AddWinUITokenResolver(this IKernelBuilder builder)
    {
        builder.Services.AddSingleton<IBiliTokenResolver, WinUIBiliTokenResolver>();
        return builder;
    }
}
