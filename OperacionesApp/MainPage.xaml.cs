using Microsoft.Maui.Controls;

namespace OperacionesApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage() => InitializeComponent();

        // Cálculo del área del cuadrado
        private void OnCalculateSquareArea(object sender, EventArgs e)
        {
            Entry sideEntry1 = sideEntry;
            if (double.TryParse(sideEntry1.Text, out double side) && side > 0)
            {
                double area = side * side;
                squareResultLabel.Text = $"Área: {area}";
            }
            else
            {
                squareResultLabel.Text = "Por favor ingrese un valor válido.";
            }
        }

        // Limpieza de los campos del cuadrado
        private void OnClearSquareFields(object sender, EventArgs e)
        {
            sideEntry.Text = string.Empty;
            squareResultLabel.Text = "Resultado:";
        }

        // Cálculo del área del círculo
        private void OnCalculateCircleArea(object sender, EventArgs e)
        {
            if (double.TryParse(radiusEntry.Text, out double radius) && radius > 0)
            {
                double area = Math.PI * radius * radius;
                circleResultLabel.Text = $"Área: {area}";
            }
            else
            {
                circleResultLabel.Text = "Por favor ingrese un valor válido.";
            }
        }

        // Limpieza de los campos del círculo
        private void OnClearCircleFields(object sender, EventArgs e)
        {
            radiusEntry.Text = string.Empty;
            circleResultLabel.Text = "Resultado:";
        }

        // Cálculo del área del rectángulo
        private void OnCalculateRectangleArea(object sender, EventArgs e)
        {
            if (double.TryParse(baseEntry.Text, out double baseLength) &&
                double.TryParse(heightEntry.Text, out double height) &&
                baseLength > 0 && height > 0)
            {
                double area = baseLength * height;
                rectangleResultLabel.Text = $"Área: {area}";
            }
            else
            {
                rectangleResultLabel.Text = "Por favor ingrese valores válidos.";
            }
        }

        // Limpieza de los campos del rectángulo
        private void OnClearRectangleFields(object sender, EventArgs e)
        {
            baseEntry.Text = string.Empty;
            heightEntry.Text = string.Empty;
            rectangleResultLabel.Text = "Resultado:";
        }
    }
}
