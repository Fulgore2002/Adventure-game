using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Adventure_game;

namespace Adventure_game;

enum GameState
{
    Setup,
    Explore
}

public partial class MainWindow : Window
{
    public World TheWorld = new World();
    public Person Player = new Person();
    public MainWindow()
    {
        InitializeComponent();
    }

    public void MainGrid_Loaded(object sender, RoutedEventArgs e)
    {
        Output.Text = "Hello!";
        Output.Text = "\nPlease enter in the name for you character below...";
    }

    public void SubmitButton_Click(object sender, RoutedEventArgs e)
    {
        if (Player.Name == "")
        {
            SetPlayerName();
        }
        else
        {
            ExploreWorld();
        }



    }

    private void SetPlayerName()
    {
        Player.Name = Input.Text;

        if (Input.Text == "")
        {
            Player.Name = "Annoymous Player";
        }
        Player.Name = Input.Text;
        Input.Text = "";
    }

    private void ExploreWorld()
    {
        Output.Text += $"{Player.Name}, enter the number of the location you would like to visit.";
        Output.Text += TheWorld.GetLocationList();

        string input = Input.Text;

        if (int.TryParse(input, out int number))
        {
            if (number >= 0 && number < TheWorld.Locations.Count)
            {
                Output.Text = TheWorld.Locations[number].PlayerVisit();
            }
            else
            {
                Output.Text = "Invalid location number. Please enter a valid number.";
            }
        }
        else
        {
            Output.Text = "Invalid input. Please enter a number.";
        }
    }
}
