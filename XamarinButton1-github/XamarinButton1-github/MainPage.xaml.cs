using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinButton1_github
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async private void Button1Tapp_Tapped(object sender, EventArgs e)
        {
            // -- button1 rotation
            await Button1.RotateXTo(360, 300);  //  rotate X 360* in 300ms
        }

        async private void Button2Tapp_Tapped(object sender, EventArgs e)
        {
            // -- button2 fadeto and changing color
            if (Button2.BackgroundColor != Color.Lime)
            {
                await Button2.FadeTo(0, 300);      // fadeto 0% in 300ms
                Button2.BackgroundColor = Color.Lime;  // changing border color to 'lime'
                await Button2.FadeTo(1, 300);      // fadeto 100% in 300ms
            }
            else
            {
                await Button2.FadeTo(0, 300);      // fadeto 0% in 300ms
                Button2.BackgroundColor = Color.Black;  // changing border color to 'lime'
                await Button2.FadeTo(1, 300);      // fadeto 100% in 300ms
            }
        }

        async private void Button3Tapp_Tapped(object sender, EventArgs e)
        {
            Button3first.FadeTo(0, 400); // fadeto 0% in 400ms
            await Button3first.RotateXTo(360, 300); // rotate X 360* in 300ms
            lblBtn3.Text = "OK";
            await Button3first.FadeTo(1, 300); // fadeto 100% in 300ms
        }

        async private void Button4Tapp_Tapped(object sender, EventArgs e)
        {
            await Button4.FadeTo(0, 300); // fadeto 0% in 300ms
            Button4.BackgroundColor = Color.Lime; // change background color button4 to lime
            await Button4.FadeTo(1, 300); // fadeto 100% in 300ms
            Button4.FadeTo(0, 400); // fadeto 0% in 400ms
            await Button4.ScaleTo(2, 300); // scale X2 in 300ms

        }
    }
}








//"Any sufficiently advanced technology is indistinguishable from magic."//