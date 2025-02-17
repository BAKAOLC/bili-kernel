﻿// Copyright (c) Richasy. All rights reserved.
// Licensed under the MIT License.

using Richasy.BiliKernel.Models.Appearance;

namespace Richasy.BiliKernel.Adapters;

/// <summary>
/// 图片适配器，将视频封面、用户头像等转换为 <see cref="BiliImage"/>.
/// </summary>
public static class ImageAdapter
{
    /// <summary>
    /// 将图片地址转换为 <see cref="BiliImage"/>.
    /// </summary>
    public static BiliImage ToImage(this string uri)
        => new(new(uri));

    /// <summary>
    /// 根据图片地址及大小信息生成缩略图地址（宽高相等）.
    /// </summary>
    public static BiliImage ToImage(this string uri, double size)
        => ToImage(uri, size, size);

    /// <summary>
    /// 根据图片地址及宽高信息生成缩略图地址.
    /// </summary>
    public static BiliImage ToImage(this string uri, double width, double height)
    {
        return string.IsNullOrEmpty(uri) ? default : new(new(uri), width, height, (w, h) => $"@{w}w_{h}h_1c.jpg");
    }

    /// <summary>
    /// 根据图片地址生成适用于视频卡片尺寸的缩略图地址.
    /// </summary>
    public static BiliImage ToVideoCover(this string uri)
        => ToImage(uri, 672, 378);

    /// <summary>
    /// 根据图片尺寸生成适用于专业内容的缩略图.
    /// </summary>
    public static BiliImage ToPgcCover(this string uri)
        => ToImage(uri, 320, 426);

    /// <summary>
    /// 根据图片地址生成适用于文章卡片尺寸的缩略图地址.
    /// </summary>
    public static BiliImage ToArticleCover(this string uri)
        => ToImage(uri, 400, 220);
}
