﻿// Copyright (c) Richasy. All rights reserved.
// <auto-generated />

using System.Collections.Generic;

namespace Richasy.BiliKernel.Services.User.Core.Models;

internal sealed class UgcSeasonDetailResponse
{
    public IList<UgcSeasonArchive> archives { get; set; }
    public UgcSeasonPage page { get; set; }
}

internal sealed class UgcSeasonPage
{
    public int page_num { get; set; }
    public int page_size { get; set; }
    public int total { get; set; }
}

internal sealed class UgcSeasonArchive
{
    public long aid { get; set; }
    public string bvid { get; set; }
    public long ctime { get; set; }
    public int duration { get; set; }
    public bool interactive_video { get; set; }
    public string pic { get; set; }
    public int playback_position { get; set; }
    public int pubdate { get; set; }
    public UgcSeasonStat stat { get; set; }
    public int state { get; set; }
    public string title { get; set; }
    public int ugc_pay { get; set; }
}

internal sealed class UgcSeasonStat
{
    public int view { get; set; }
    public int vt { get; set; }
}

