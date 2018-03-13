using System;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestBug
{
    public partial class TestBugPage : ContentPage
    {
        Random rand = new Random();

        public TestBugPage()
        {
            InitializeComponent();
        }

        void startButton_Clicked(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i ++)
            {
                StartAnimation();
            }
        }

        async void StartAnimation()
        {
            var box = new BoxView() { BackgroundColor = Color.Red, InputTransparent = true };

            absLayout.Children.Add(box, new Rectangle(rand.Next(0, 200), rand.Next(0, 200), 50, 50));

            await box.TranslateTo(100, 100, 500);

			absLayout.Children.Remove(box);
        }
    }
}
