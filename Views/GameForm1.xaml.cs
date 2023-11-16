using Scrambled_Word_WPF_Project.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Scrambled_Word_WPF_Project.Views
{
    /// <summary>
    /// Interaction logic for GameForm1.xaml
    /// </summary>
    public partial class GameForm1 : Window
    {
        public GameForm1()
        {
            InitializeComponent();
            TxtBlkScore.Text = CoreObjects.Scoring();
            TxtBlkWord.Text = CoreObjects.wordInfo();
        }
        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TxtBlkWord.Text = CoreObjects.CheckAnswer(TxtBxAnswer.Text);
                TxtBlkScore.Text = CoreObjects.Scoring();
                ClearFields();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnHint_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TxtBlkHint.Text = CoreObjects.Hints();
                TxtBlkScore.Text = CoreObjects.Scoring();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        void ClearFields()
        {
            TxtBlkHint.Text = "";
            TxtBxAnswer.Text = "";
        }
    }
}
