﻿using SQLite;
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
            selectedPost.Experience = experienceEntry.Text;

            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Post>();
                int rows = conn.Update(selectedPost);

                if (rows > 0)
                    DisplayAlert("Success", "Experience succesfully updated", "Ok");
                else
                    DisplayAlert("Faliure", "Experience failed to be updated", "Ok");
            }
        }

        private void DeleteButton_Clicked(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Post>();
                int rows = conn.Delete(selectedPost);

                if (rows > 0)
                    DisplayAlert("Success", "Experience succesfully deleted", "Ok");
                else
                    DisplayAlert("Faliure", "Experience failed to be deleted", "Ok");
            }
        }
    }
}