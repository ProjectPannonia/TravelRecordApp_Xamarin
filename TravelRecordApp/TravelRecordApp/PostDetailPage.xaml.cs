using System;
using TravelRecordApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelRecordApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PostDetailPage : ContentPage
	{
        Post selectedPost;

		public PostDetailPage (Post selectedPost)
		{
			InitializeComponent ();
            this.selectedPost = selectedPost;
            experienceEntry.Text = selectedPost.Experience;
		}

        private void UpdateButton_Clicked(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}