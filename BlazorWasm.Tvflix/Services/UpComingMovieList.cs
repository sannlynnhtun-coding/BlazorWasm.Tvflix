﻿namespace BlazorWasm.Tvflix.Services;

public class UpComingMovieList
{
    public Dates dates { get; set; }
    public int page { get; set; }
    public MovieResult[] results { get; set; }
    public int total_pages { get; set; }
    public int total_results { get; set; }
}

public class Dates
{
    public string maximum { get; set; }
    public string minimum { get; set; }
}

// public class UpcomingResults
// {
//     public bool adult { get; set; }
//     public string backdrop_path { get; set; }
//     public int[] genre_ids { get; set; }
//     public int id { get; set; }
//     public string original_language { get; set; }
//     public string original_title { get; set; }
//     public string overview { get; set; }
//     public double popularity { get; set; }
//     public string poster_path { get; set; }
//     public string release_date { get; set; }
//     public string title { get; set; }
//     public bool video { get; set; }
//     public double vote_average { get; set; }
//     public int vote_count { get; set; }
// }