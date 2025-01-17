﻿using System.Text.Json.Serialization;

namespace OkayegTeaTimeCSharp.JsonData.JsonClasses.HttpRequests;

public class SevenTvEmote
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("status")]
    public int Status { get; set; }

    [JsonPropertyName("visibility")]
    public int Visibility { get; set; }

    [JsonPropertyName("width")]
    public List<int> Width { get; set; }

    [JsonPropertyName("height")]
    public List<int> Height { get; set; }

    public override bool Equals(object obj)
    {
        return obj is SevenTvEmote emote && emote.Id == Id;
    }

    public override string ToString()
    {
        return Name;
    }
}
