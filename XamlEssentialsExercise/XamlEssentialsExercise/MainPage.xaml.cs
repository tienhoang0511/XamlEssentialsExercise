using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamlEssentialsExercise
{
    public partial class MainPage : ContentPage
    {
        static List<String> dsTen = new List<string>();
        int position = 0;
        public MainPage()
        {
            InitializeComponent();
            DsPhanTu();
            btn_next_Clicked(null, null);

        }

        private void btn_next_Clicked(object sender, EventArgs e)
        {

            if (position < dsTen.Count)
            {

                label_2.Text = dsTen[position].ToString();
                position++;
            }
            else
            {
                position = 0;
                label_2.Text = dsTen[position].ToString();
                position++;
            }
        }
        public void DsPhanTu()
        {
            dsTen = new List<string>();
            dsTen.Add("Nguyen Van Teo");
            dsTen.Add("Tran Thi Ty");
            dsTen.Add("Le Quang Tinh");

        }
    }
}
