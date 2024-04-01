namespace ScrollCrashRepro;

public partial class TableEditPage : ContentPage {
    public class CustomEntry(string label, View view) {
        public string Label { get; } = label;
        public View View { get; } = view;
    }

    public TableEditPage() {
        InitializeComponent();


        ContentCollection.ItemTemplate = new DataTemplate(() => {
            var frame = new Frame {
                BorderColor = Colors.ForestGreen,
                Margin = new Thickness(5),
                CornerRadius = 3,
                HasShadow = true,
                Shadow = new Shadow() {
                    Radius = 5,
                    Brush = Brush.DeepPink
                }
            };

            var stackLayout = new StackLayout();

            var label = new Label();
            label.SetBinding(Label.TextProperty, "Label");
            label.FontAttributes = FontAttributes.Bold;
            stackLayout.Children.Add(label);

            var contentView = new ContentView();
            contentView.SetBinding(ContentView.ContentProperty, "View");
            stackLayout.Children.Add(contentView);

            frame.Content = stackLayout; //frame with border
            return frame;
        });


        var itemList = new List<CustomEntry>();
        for (int i = 0; i < 40; i++) {
            itemList.Add(new CustomEntry($"Label :{i}", new Entry { Placeholder = $"Entry {i}" }));
        }

        ContentCollection.ItemsSource = itemList;

    }

}
