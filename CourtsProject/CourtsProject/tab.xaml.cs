using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CourtsProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class tab : TabbedPage
    {

        private bool isCreatedOnce1 = false;
        private bool isCreatedOnce2 = false;
        private bool isCreatedOnce3 = false;
        private bool isCreatedOnce4 = false;
        private bool isCreatedOnce5 = false;
        private int cntPressed1 = 0;
        private int cntPressed2 = 0;
        private int cntPressed3 = 0;
        private int cntPressed4 = 0;
        private int cntPressed5 = 0;

        private List<int> costList1 = new List<int> { 1700, 1700, 1700, 2100, 2100, 2100, 1800, 1800, 2400, 2400, 3200, 3200, 3200, 3200, 2600, 1800, 1600 };
        private List<int> costList2 = new List<int> { 1700, 1700, 1700, 2100, 2100, 2100, 1800, 1800, 2400, 2400, 3200, 3200, 3200, 3200, 2600, 1700, 1400 };
        private List<int> costList3 = new List<int> { 1700, 1700, 1700, 2000, 2000, 2000, 1800, 1800, 2200, 2200, 2900, 2900, 2900, 2900, 2500, 1700, 1400 };


        public tab()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        private void Btn1(object sender, EventArgs e)
        {

            if (isCreatedOnce1 == false)
            {
                ContentPage schedulePage = new ContentPage();

                Grid grid = new Grid();
                grid.RowSpacing = 0;
                grid.ColumnSpacing = 0;
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1.5, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

                Label labelT = new Label
                {
                    Text = "Время",
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center
                };
                Label label1 = new Label
                {
                    Text = "Корт1",
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center
                };
                Label label2 = new Label
                {
                    Text = "Корт2",
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center
                };
                Label label3 = new Label
                {
                    Text = "Корт3",
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center
                };
                grid.Children.Add(labelT, 0, 0);
                grid.Children.Add(label1, 1, 0);
                grid.Children.Add(label2, 2, 0);
                grid.Children.Add(label3, 3, 0);


                for (int i = 1; i < 18; i++)
                {
                    // Создаем строку
                    grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

                    // Добавляем ячейки в строку
                    for (int j = 0; j < 4; j++)
                    {
                        Button btn = new Button
                        {                            
                            Text = costList1[i-1].ToString(),
                            TextColor = Color.Black,
                            CornerRadius = 0,
                            BackgroundColor = Color.FromRgba(0, 0, 0, 0),
                            HeightRequest = 30,
                            FontSize = 16,
                            Padding = new Thickness(0, 0)
                        };
                        Frame frame = new Frame
                        {
                            HeightRequest = 30,
                            Padding = new Thickness(1, 1, 1, 1),
                            Margin = new Thickness(0, 0, 0, 0),
                            BorderColor = Color.Black,
                            CornerRadius = 0,
                            HasShadow = false
                        };
                        btn.Clicked += (s, ea) =>
                        {
                            Button clickedButton = (Button)s;

                            if (clickedButton.BackgroundColor == Color.LightBlue) { clickedButton.BackgroundColor = Color.FromRgba(0, 0, 0, 0); cntPressed1--; }
                            else { clickedButton.BackgroundColor = Color.LightBlue; cntPressed1++; }

                            if (cntPressed1 > 0) orderBtn.IsVisible = true;
                            else if (cntPressed1 == 0) orderBtn.IsVisible = false;
                        };
                        orderBtn.Clicked += (s, ea) =>
                        {
                            orderBtn.IsVisible = false;
                            Button clickedButton = (Button)s;

                            ScheduleContainer1.IsVisible = false;
                            StackInfo.IsVisible = false;

                            L1.IsVisible = false;
                            L2.IsVisible = false;

                            orderList.IsVisible = true;
                            L3.IsVisible = true;
                        };

                        frame.Content = btn;

                        Label labelTime = new Label
                        {
                            Text = $"{i + 6}:00-{i + 7}:00",
                            HorizontalTextAlignment = TextAlignment.Center,
                            VerticalTextAlignment = TextAlignment.Center,
                            TextColor = Color.Black,
                            FontSize = 16
                        };
                        if (j == 0) { frame.Content = labelTime; grid.Children.Add(frame, 0, i); }
                        else grid.Children.Add(frame, j, i);
                    }
                }
                schedulePage.Content = grid;
                ScheduleContainer1.Children.Add(schedulePage.Content);
                isCreatedOnce1 = true;
            }

            if (cntPressed1 > 0) orderBtn.IsVisible = true;
            ScheduleContainer1.IsVisible = true;
            StackInfo.IsVisible = false;
            L1.IsVisible = false;
            L2.IsVisible = false;
            L3.IsVisible = false;
        }

        private void Btn2(object sender, EventArgs e)
        {

            if (isCreatedOnce2 == false)
            {
                ContentPage schedulePage = new ContentPage();

                Grid grid = new Grid();
                grid.RowSpacing = 0;
                grid.ColumnSpacing = 0;
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1.5, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

                Label labelT = new Label
                {
                    Text = "Время",
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center
                };
                Label label4 = new Label
                {
                    Text = "Корт4",
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center
                };
                Label label5 = new Label
                {
                    Text = "Корт5",
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center
                };
                Label label6 = new Label
                {
                    Text = "Корт6",
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center
                };
                grid.Children.Add(labelT, 0, 0);
                grid.Children.Add(label4, 1, 0);
                grid.Children.Add(label5, 2, 0);
                grid.Children.Add(label6, 3, 0);


                for (int i = 1; i < 18; i++)
                {
                    // Создаем строку
                    grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

                    // Добавляем ячейки в строку
                    for (int j = 0; j < 4; j++)
                    {
                        Button btn = new Button
                        {
                            Text = costList2[i-1].ToString(),
                            TextColor = Color.Black,
                            CornerRadius = 0,
                            BackgroundColor = Color.FromRgba(0, 0, 0, 0),
                            HeightRequest = 30,
                            FontSize = 16,
                            Padding = new Thickness(0, 0)
                        };
                        Frame frame = new Frame
                        {
                            HeightRequest = 30,
                            Padding = new Thickness(1, 1, 1, 1),
                            Margin = new Thickness(0, 0, 0, 0),
                            BorderColor = Color.Black,
                            CornerRadius = 0,
                            HasShadow = false
                        };
                        btn.Clicked += (s, ea) =>
                        {
                            Button clickedButton = (Button)s;

                            if (clickedButton.BackgroundColor == Color.LightBlue) { clickedButton.BackgroundColor = Color.FromRgba(0, 0, 0, 0); cntPressed2--; }
                            else { clickedButton.BackgroundColor = Color.LightBlue; cntPressed2++; }

                            if (cntPressed2 > 0) orderBtn.IsVisible = true;
                            else if (cntPressed2 == 0) orderBtn.IsVisible = false;
                        };
                        orderBtn.Clicked += (s, ea) =>
                        {
                            orderBtn.IsVisible = false;
                            Button clickedButton = (Button)s;

                            ScheduleContainer2.IsVisible = false;
                            StackInfo.IsVisible = false;

                            L1.IsVisible = false;
                            L2.IsVisible = false;

                            orderList.IsVisible = true;
                            L3.IsVisible = true;
                        };

                        frame.Content = btn;

                        Label labelTime = new Label
                        {
                            Text = $"{i + 6}:00-{i + 7}:00",
                            HorizontalTextAlignment = TextAlignment.Center,
                            VerticalTextAlignment = TextAlignment.Center,
                            TextColor = Color.Black,
                            FontSize = 16
                        };
                        if (j == 0) { frame.Content = labelTime; grid.Children.Add(frame, 0, i); }
                        else grid.Children.Add(frame, j, i);
                    }
                }
                schedulePage.Content = grid;
                ScheduleContainer2.Children.Add(schedulePage.Content);
                isCreatedOnce2 = true;
            }

            if (cntPressed2 > 0) orderBtn.IsVisible = true;
            ScheduleContainer2.IsVisible = true;
            StackInfo.IsVisible = false;
            L1.IsVisible = false;
            L2.IsVisible = false;
            L3.IsVisible = false;
        }

        private void Btn3(object sender, EventArgs e)
        {

            if (isCreatedOnce3 == false)
            {
                ContentPage schedulePage = new ContentPage();

                Grid grid = new Grid();
                grid.RowSpacing = 0;
                grid.ColumnSpacing = 0;
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1.5, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

                Label labelT = new Label
                {
                    Text = "Время",
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center
                };
                Label label7 = new Label
                {
                    Text = "Корт7",
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center
                };
                Label label8 = new Label
                {
                    Text = "Корт8",
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center
                };
                Label label9 = new Label
                {
                    Text = "Корт9",
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center
                };
                grid.Children.Add(labelT, 0, 0);
                grid.Children.Add(label7, 1, 0);
                grid.Children.Add(label8, 2, 0);
                grid.Children.Add(label9, 3, 0);


                for (int i = 1; i < 18; i++)
                {
                    // Создаем строку
                    grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

                    // Добавляем ячейки в строку
                    for (int j = 0; j < 4; j++)
                    {
                        Button btn = new Button
                        {
                            Text = costList2[i - 1].ToString(),
                            TextColor = Color.Black,
                            CornerRadius = 0,
                            BackgroundColor = Color.FromRgba(0, 0, 0, 0),
                            HeightRequest = 30,
                            FontSize = 16,
                            Padding = new Thickness(0, 0)
                        };
                        Frame frame = new Frame
                        {
                            HeightRequest = 30,
                            Padding = new Thickness(1, 1, 1, 1),
                            Margin = new Thickness(0, 0, 0, 0),
                            BorderColor = Color.Black,
                            CornerRadius = 0,
                            HasShadow = false
                        };
                        btn.Clicked += (s, ea) =>
                        {
                            Button clickedButton = (Button)s;

                            if (clickedButton.BackgroundColor == Color.LightBlue) { clickedButton.BackgroundColor = Color.FromRgba(0, 0, 0, 0); cntPressed3--; }
                            else { clickedButton.BackgroundColor = Color.LightBlue; cntPressed3++; }

                            if (cntPressed3 > 0) orderBtn.IsVisible = true;
                            else if (cntPressed3 == 0) orderBtn.IsVisible = false;
                        };
                        orderBtn.Clicked += (s, ea) =>
                        {
                            orderBtn.IsVisible = false;
                            Button clickedButton = (Button)s;

                            ScheduleContainer3.IsVisible = false;
                            StackInfo.IsVisible = false;

                            L1.IsVisible = false;
                            L2.IsVisible = false;

                            orderList.IsVisible = true;
                            L3.IsVisible = true;
                        };

                        frame.Content = btn;

                        Label labelTime = new Label
                        {
                            Text = $"{i + 6}:00-{i + 7}:00",
                            HorizontalTextAlignment = TextAlignment.Center,
                            VerticalTextAlignment = TextAlignment.Center,
                            TextColor = Color.Black,
                            FontSize = 16
                        };
                        if (j == 0) { frame.Content = labelTime; grid.Children.Add(frame, 0, i); }
                        else grid.Children.Add(frame, j, i);
                    }
                }
                schedulePage.Content = grid;
                ScheduleContainer3.Children.Add(schedulePage.Content);
                isCreatedOnce3 = true;
            }

            if (cntPressed3 > 0) orderBtn.IsVisible = true;
            ScheduleContainer3.IsVisible = true;
            StackInfo.IsVisible = false;
            L1.IsVisible = false;
            L2.IsVisible = false;
            L3.IsVisible = false;
        }

        private void Btn4(object sender, EventArgs e)
        {

            if (isCreatedOnce4 == false)
            {
                ContentPage schedulePage = new ContentPage();

                Grid grid = new Grid();
                grid.RowSpacing = 0;
                grid.ColumnSpacing = 0;
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1.5, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

                Label labelT = new Label
                {
                    Text = "Время",
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center
                };
                Label label10 = new Label
                {
                    Text = "Корт10",
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center
                };
                Label label11 = new Label
                {
                    Text = "Корт11",
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center
                };
                Label label12 = new Label
                {
                    Text = "Корт12",
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center
                };
                Label label13 = new Label
                {
                    Text = "Корт13",
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center
                };
                grid.Children.Add(labelT, 0, 0);
                grid.Children.Add(label10, 1, 0);
                grid.Children.Add(label11, 2, 0);
                grid.Children.Add(label12, 3, 0);
                grid.Children.Add(label13, 4, 0);


                for (int i = 1; i < 18; i++)
                {
                    // Создаем строку
                    grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

                    // Добавляем ячейки в строку
                    for (int j = 0; j < 5; j++)
                    {
                        Button btn = new Button
                        {
                            Text = costList3[i - 1].ToString(),
                            TextColor = Color.Black,
                            CornerRadius = 0,
                            BackgroundColor = Color.FromRgba(0, 0, 0, 0),
                            HeightRequest = 30,
                            FontSize = 16,
                            Padding = new Thickness(0, 0)
                        };
                        Frame frame = new Frame
                        {
                            HeightRequest = 30,
                            Padding = new Thickness(1, 1, 1, 1),
                            Margin = new Thickness(0, 0, 0, 0),
                            BorderColor = Color.Black,
                            CornerRadius = 0,
                            HasShadow = false
                        };
                        btn.Clicked += (s, ea) =>
                        {
                            Button clickedButton = (Button)s;

                            if (clickedButton.BackgroundColor == Color.LightBlue) { clickedButton.BackgroundColor = Color.FromRgba(0, 0, 0, 0); cntPressed4--; }
                            else { clickedButton.BackgroundColor = Color.LightBlue; cntPressed4++; }

                            if (cntPressed4 > 0) orderBtn.IsVisible = true;
                            else if (cntPressed4 == 0) orderBtn.IsVisible = false;
                        };
                        orderBtn.Clicked += (s, ea) =>
                        {
                            orderBtn.IsVisible = false;
                            Button clickedButton = (Button)s;

                            ScheduleContainer4.IsVisible = false;
                            StackInfo.IsVisible = false;

                            L1.IsVisible = false;
                            L2.IsVisible = false;

                            orderList.IsVisible = true;
                            L3.IsVisible = true;
                        };

                        frame.Content = btn;

                        Label labelTime = new Label
                        {
                            Text = $"{i + 6}:00-{i + 7}:00",
                            HorizontalTextAlignment = TextAlignment.Center,
                            VerticalTextAlignment = TextAlignment.Center,
                            TextColor = Color.Black,
                            FontSize = 16
                        };
                        if (j == 0) { frame.Content = labelTime; grid.Children.Add(frame, 0, i); }
                        else grid.Children.Add(frame, j, i);
                    }
                }
                schedulePage.Content = grid;
                ScheduleContainer4.Children.Add(schedulePage.Content);
                isCreatedOnce4 = true;
            }

            if (cntPressed4 > 0) orderBtn.IsVisible = true;
            ScheduleContainer4.IsVisible = true;
            StackInfo.IsVisible = false;
            L1.IsVisible = false;
            L2.IsVisible = false;
            L3.IsVisible = false;
        }
                
        private void Btn5(object sender, EventArgs e)
        {

            if (isCreatedOnce5 == false)
            {
                ContentPage schedulePage = new ContentPage();

                Grid grid = new Grid();
                grid.RowSpacing = 0;
                grid.ColumnSpacing = 0;
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1.5, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

                Label labelT = new Label
                {
                    Text = "Время",
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center
                };
                Label label10 = new Label
                {
                    Text = "Корт10",
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center
                };
                Label label11 = new Label
                {
                    Text = "Корт11",
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center
                };
                Label label12 = new Label
                {
                    Text = "Корт12",
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center
                };
                Label label13 = new Label
                {
                    Text = "Корт13",
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center
                };
                grid.Children.Add(labelT, 0, 0);
                grid.Children.Add(label10, 1, 0);
                grid.Children.Add(label11, 2, 0);
                grid.Children.Add(label12, 3, 0);
                grid.Children.Add(label13, 3, 0);


                for (int i = 1; i < 18; i++)
                {
                    // Создаем строку
                    grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

                    // Добавляем ячейки в строку
                    for (int j = 0; j < 5; j++)
                    {
                        Button btn = new Button
                        {
                            Text = "1700",  //to be modificated
                            TextColor = Color.Black,
                            CornerRadius = 0,
                            BackgroundColor = Color.FromRgba(0, 0, 0, 0),
                            HeightRequest = 30,
                            FontSize = 16,
                            Padding = new Thickness(0, 0)
                        };
                        Frame frame = new Frame
                        {
                            HeightRequest = 30,
                            Padding = new Thickness(1, 1, 1, 1),
                            Margin = new Thickness(0, 0, 0, 0),
                            BorderColor = Color.Black,
                            CornerRadius = 0,
                            HasShadow = false
                        };
                        btn.Clicked += (s, ea) =>
                        {
                            Button clickedButton = (Button)s;

                            if (clickedButton.BackgroundColor == Color.LightBlue) { clickedButton.BackgroundColor = Color.FromRgba(0, 0, 0, 0); cntPressed4--; }
                            else { clickedButton.BackgroundColor = Color.LightBlue; cntPressed4++; }

                            if (cntPressed4 > 0) orderBtn.IsVisible = true;
                            else if (cntPressed4 == 0) orderBtn.IsVisible = false;
                        };
                        orderBtn.Clicked += (s, ea) =>
                        {
                            orderBtn.IsVisible = false;
                            Button clickedButton = (Button)s;

                            ScheduleContainer4.IsVisible = false;
                            StackInfo.IsVisible = false;

                            L1.IsVisible = false;
                            L2.IsVisible = false;

                            orderList.IsVisible = true;
                            L3.IsVisible = true;
                        };

                        frame.Content = btn;

                        Label labelTime = new Label
                        {
                            Text = $"{i + 6}:00-{i + 7}:00",
                            HorizontalTextAlignment = TextAlignment.Center,
                            VerticalTextAlignment = TextAlignment.Center,
                            TextColor = Color.Black,
                            FontSize = 16
                        };
                        if (j == 0) { frame.Content = labelTime; grid.Children.Add(frame, 0, i); }
                        else grid.Children.Add(frame, j, i);
                    }
                }
                schedulePage.Content = grid;
                ScheduleContainer4.Children.Add(schedulePage.Content);
                isCreatedOnce4 = true;
            }

            if (cntPressed4 > 0) orderBtn.IsVisible = true;
            ScheduleContainer4.IsVisible = true;
            StackInfo.IsVisible = false;
            L1.IsVisible = false;
            L2.IsVisible = false;
            L3.IsVisible = false;
        }

        protected override bool OnBackButtonPressed()
        {
            orderBtn.IsVisible = false;
            ScheduleContainer1.IsVisible = false;
            ScheduleContainer2.IsVisible = false;
            ScheduleContainer3.IsVisible = false;
            ScheduleContainer4.IsVisible = false;
            orderList.IsVisible = false;
            StackInfo.IsVisible = true;
            L1.IsVisible = true;
            L2.IsVisible = true;
            L3.IsVisible = false;

            return true;
        }
    }
}