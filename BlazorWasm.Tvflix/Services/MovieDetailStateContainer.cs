namespace BlazorWasm.Tvflix.Services
{
    public class MovieDetailStateContainer
    {
        private string? Id;

        public string Property
        {
            get => Id ?? string.Empty;
            set
            {
                Id = value;
                NotifyStateChanged();
            }
        }

        public event Action? OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
