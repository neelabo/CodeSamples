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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ComboBoxTest
{
    public enum Animal
    {
        Cat,
        Dog,
        Tiger,
        Elephant,
    }

    public partial class MainWindow : Window
    {
        public Animal[] AnimalEnums { get; } = (Animal[])Enum.GetValues(typeof(Animal));

        public Dictionary<Animal, string> AnimalNames { get; } = new Dictionary<Animal, string>()
        {
            [Animal.Cat] = "猫",
            [Animal.Dog] = "犬",
            [Animal.Tiger] = "虎",
            [Animal.Elephant] = "ゾウ",
        };

        public Animal MyPet { get; set; } = Animal.Cat;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
