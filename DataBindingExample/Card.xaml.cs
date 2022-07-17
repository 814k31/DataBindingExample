namespace DataBindingExample;

public partial class Card : VerticalStackLayout
{
    public static readonly BindableProperty CardIncrementProperty = BindableProperty.Create(nameof(CardIncrement), typeof(int), typeof(Card), 0);

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
