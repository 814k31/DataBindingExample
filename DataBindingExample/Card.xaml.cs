namespace DataBindingExample;

public partial class Card : VerticalStackLayout
{
    public static readonly BindableProperty CardTitleProperty = BindableProperty.Create(nameof(CardTitle), typeof(string), typeof(Card), string.Empty);
    public static readonly BindableProperty CardIncrementProperty = BindableProperty.Create(nameof(CardIncrement), typeof(int), typeof(Card), 0);

    public string CardTitle
    {
        get => (string)GetValue(CardTitleProperty);
        set => SetValue(CardTitleProperty, value);
    }

    public int CardIncrement
    {
        get => (int)GetValue(CardIncrementProperty);
        set => SetValue(CardIncrementProperty, value);
    }

    public Card()
    {
        InitializeComponent();

        BindingContext = this;
    }
}
