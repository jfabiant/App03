using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App03.views;

namespace App03
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async private void BtnStackLayoutDemo(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new StackLayoutDemo());
        }
        async private void BtnStackLayoutCode(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new StackLayoutCode());
        }
        async private void BtnAbsoluteLayoutDemo(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AbsoluteLayoutDemo());
        }

        async private void BtnAbsoluteLayoutCode(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AbsoluteLayoutCode());
        }

        async private void BtnRelativeLayoutDemo(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new RelativeLayoutDemo());
        }

        async private void BtnRelativeLayoutCode(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new RelativeLayoutCode());
        }
        async private void BtnGridDemo(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new GridDemo());
        }
        async private void BtnGridCode(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new GridCode());
        }
        async private void BtnScrollViewDemo(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ScrollViewDemo());
        }
        async private void BtnScrollViewCode(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ScrollViewCode());
        }
    }
}
