﻿// Copyright (c) Richasy. All rights reserved.
// Licensed under the MIT License.

using Microsoft.Extensions.DependencyInjection;
using Richasy.BiliKernel.Bili.Article;
using Richasy.BiliKernel.Services.Article;
using RichasyKernel;

namespace Richasy.BiliKernel;

/// <summary>
/// 内核构建器扩展.
/// </summary>
public static class KernelBuilderExtensions
{
    /// <summary>
    /// 添加专栏文章服务.
    /// </summary>
    public static IKernelBuilder AddArticleDiscoveryService(this IKernelBuilder builder)
    {
        builder.Services.AddSingleton<IArticleDiscoveryService, ArticleDiscoveryService>();
        return builder;
    }

    /// <summary>
    /// 添加文章操作服务.
    /// </summary>
    public static IKernelBuilder AddArticleOperationService(this IKernelBuilder builder)
    {
        builder.Services.AddSingleton<IArticleOperationService, ArticleOperationService>();
        return builder;
    }
}
