namespace BlazorWasm.Tvflix.Services;

public class Recommendations
{
    public int page { get; set; }
    public int total_pages { get; set; }
    public int total_results { get; set; }
    public MovieResult[] results { get; set; }
}