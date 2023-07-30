namespace BlazorWasm.Tvflix.Services
{
    public class MovieDetailStateContainer
    {
        private int _id;

        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                NotifyStateChanged();
            }
        }

        public event Action? OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
