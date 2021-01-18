using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace WeigthLoss.Models
{
    public static class GetPlayers
    {
        public static ListView GetAll()
        {
            ListView listBox = new ListView();
            listBox.ScrollIntoView(listBox);
            File.AppendAllText("Info.txt",null);
            try
            {
                IEnumerable<string> lines = File.ReadLines("Info.txt");
                if (lines.ToString() != null)
                {                 
                    foreach (var item in lines)
                    {
                        listBox.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Список пуст!!!", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (ArgumentException)
            {
                throw new ArgumentException();
            }
            return listBox;
        }
    }
}
