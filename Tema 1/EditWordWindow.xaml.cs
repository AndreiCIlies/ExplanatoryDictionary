﻿using System;
using System.IO;
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

namespace Tema_1
{
    /// <summary>
    /// Interaction logic for EditWordWindow.xaml
    /// </summary>
    public partial class EditWordWindow : Window
    {
        public EditWordWindow()
        {
            InitializeComponent();
        }

        private void editWordInDictionaryBtn(object sender, RoutedEventArgs e)
        {
            string inputWord = word.Text;
            string inputDescription = description.Text;
            string inputImage = image.Text;
            string inputCategory = category.Text;

            if (string.IsNullOrEmpty(inputWord))
            {
                MessageBox.Show($"Empty Word TextBox", "No Word", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            if (!string.IsNullOrEmpty(inputImage) && !inputImage.EndsWith(".jpg") == false)
            {
                MessageBox.Show($"The image of the word '{inputWord}' is not a .jpg file.", "Not .jpg Image", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            Classes.Word wordToEdit = new Classes.Word(inputWord, inputDescription, inputImage, inputCategory);
            Classes.Admin admin = new Classes.Admin();
            admin.EditWordInDictionary(wordToEdit);
        }
    }
}
