﻿// Copyright (c) Richasy. All rights reserved.
// <auto-generated />

using System.Collections.Generic;

namespace Richasy.BiliKernel.Services.Article.Core.Models;

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
internal sealed class ArticleContentResponse
{
    public Readinfo readInfo { get; set; }
    public string dynamicId { get; set; }
    public bool isManualFollow { get; set; }
    public string userAgent { get; set; }
    public string lang { get; set; }
}

internal sealed class Readinfo
{
    public int id { get; set; }
    public Category category { get; set; }
    public IList<Category> categories { get; set; }
    public string title { get; set; }
    public string summary { get; set; }
    public string banner_url { get; set; }
    public int state { get; set; }
    public Author author { get; set; }
    public IList<string> image_urls { get; set; }
    public long publish_time { get; set; }
    public int ctime { get; set; }
    public int mtime { get; set; }
    public Stats stats { get; set; }
    public IList<ArticleTag> tags { get; set; }
    public int words { get; set; }
    public IList<string> origin_image_urls { get; set; }
    public bool is_like { get; set; }
    public string content { get; set; }
    public string keywords { get; set; }
    public Topic_Info topic_info { get; set; }
    public Opus opus { get; set; }
    public int total_art_num { get; set; }
}

internal sealed class Category
{
    public int id { get; set; }
    public int parent_id { get; set; }
    public string name { get; set; }
}

internal sealed class Author
{
    public long mid { get; set; }
    public string name { get; set; }
    public string face { get; set; }
    public Official_Verify official_verify { get; set; }
    public Vip vip { get; set; }
    public int fans { get; set; }
    public int level { get; set; }
}

internal sealed class Official_Verify
{
    public int type { get; set; }
    public string desc { get; set; }
}

internal sealed class Vip
{
    public int type { get; set; }
    public int status { get; set; }
    public int due_date { get; set; }
    public int vip_pay_type { get; set; }
    public int theme_type { get; set; }
    public int avatar_subscript { get; set; }
    public string nickname_color { get; set; }
}

internal sealed class Media
{
    public int score { get; set; }
    public int media_id { get; set; }
    public string title { get; set; }
    public string cover { get; set; }
    public string area { get; set; }
    public int type_id { get; set; }
    public string type_name { get; set; }
    public int spoiler { get; set; }
    public int season_id { get; set; }
}

internal sealed class Topic_Info
{
    public int topic_id { get; set; }
    public string topic_name { get; set; }
}

internal sealed class Opus
{
    public long opus_id { get; set; }
    public int opus_source { get; set; }
    public string title { get; set; }
    public OpusContent content { get; set; }
    public ArticleTag[] tags { get; set; }
    public OpusPubInfo pub_info { get; set; }
}

internal sealed class OpusContent
{
    public IList<OpusParagraph> paragraphs { get; set; }
}

internal sealed class OpusParagraph
{
    public int para_type { get; set; }
    public OpusParagraphFormat format { get; set; }
    public OpusText text { get; set; }
    public OpusPic pic { get; set; }
    public OpusLine line { get; set; }
}

internal sealed class OpusParagraphFormat
{
    public int align { get; set; }
}

internal sealed class OpusLine
{
    public OpusLinePic pic { get; set; }
}

internal sealed class OpusLinePic
{
    public string url { get; set; }
    public int height { get; set; }
}

internal sealed class OpusText
{
    public IList<OpusNode> nodes { get; set; }
}

internal sealed class OpusNode
{
    public int node_type { get; set; }
    public OpusWord word { get; set; }
}

internal sealed class OpusWord
{
    public string words { get; set; }
    public int font_size { get; set; }
    public OpusTextStyle style { get; set; }
    public string font_level { get; set; }
}

internal sealed class OpusTextStyle
{
    public bool bold { get; set; }
}

internal sealed class OpusPic
{
    public IList<OpusPicture> pics { get; set; }
    public int style { get; set; }
}

internal sealed class OpusPicture
{
    public string url { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public float size { get; set; }
}

internal sealed class OpusPubInfo
{
    public long uid { get; set; }
    public long pub_time { get; set; }
}

internal sealed class ArticleTag
{
    public int tid { get; set; }
    public string name { get; set; }
}
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
