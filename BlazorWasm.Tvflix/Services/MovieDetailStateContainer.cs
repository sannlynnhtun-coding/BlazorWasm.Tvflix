namespace BlazorWasm.Tvflix.Services
{
    public class MovieDetailStateContainer
    {
        private int? Id;

        public int Property
        {
            get => Id ?? 0;
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
