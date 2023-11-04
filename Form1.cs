using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MovieLibrary
{
    public partial class Sistema : Form
        
    {
        private SistemaReservas sistemaReservas;
        private int cantidadTotalAsientos = 100;
        private int numeroAsientosSeleccionados = 0;
        private int asientosDisponibles;
        public Sistema()
        {
            InitializeComponent();
        }



        private void txbasientos_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnconfirmar_Click(object sender, EventArgs e) { 
        
        }

        private void lbldescripcion_Click(object sender, EventArgs e)
        {

        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una película válida en el ComboBox
            if (comboBox1.SelectedItem != null)
            {
                // Obtener la película seleccionada
                SistemaReservas.Pelicula peliculaSeleccionada = (SistemaReservas.Pelicula)comboBox1.SelectedItem;

                // Mostrar la descripción de la película seleccionada
                lbldescripcion.Text = peliculaSeleccionada.Descripcion;
            }

        }
        private void CargarPeliculasEnComboBox()
        {
            comboBox1.DataSource = sistemaReservas.ObtenerPeliculas();
        }
        private void lsbhorario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CargarHorariosEnListBox()
        {
            // Limpiar los elementos anteriores del ListBox
            lsbhorario.Items.Clear();

            // Días de la semana
            string[] diasSemana = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

            // Horarios desde las 2pm hasta las 8pm
            for (int hora = 14; hora <= 20; hora += 2)
            {
                // Iterar sobre los días de la semana
                
                foreach (string dia in diasSemana)
                {
                    // Crear un horario en formato "H:mm d"
                    
                        string horario = $"{hora:D2}:00 {dia}";
                        lsbhorario.Items.Add(horario);
                               


                    // Agregar el horario al ListBox

                }
            }

            // Agregar un elemento inicial al ListBox
            lsbhorario.Items.Insert(0, "Selecciona un horario");
            lsbhorario.SelectedIndex = 0; // Establecer el elemento inicial seleccionado
        }
        private void MostrarAsientosDisponibles()
        {
            // Mostrar la cantidad de asientos disponibles en el control lblasientosdisponibles
            lblasientosdisponibles.Text = $"Asientos disponibles: {asientosDisponibles}";
        }
        private void Sistema_Load(object sender, EventArgs e)
        {
            // Inicializar la instancia de SistemaReservas
            sistemaReservas = new SistemaReservas();

            // Agregar algunas películas de ejemplo
            sistemaReservas.AgregarPelicula(new SistemaReservas.Pelicula
            {
                Titulo = "Batman",
                Descripcion = "Batman, también conocido como \"El Caballero Oscuro\", es un icónico superhéroe de los cómics de DC Comics. Creado en 1939, este personaje es el alter ego de Bruce Wayne, un adinerado filántropo. Sin superpoderes, Batman confía en su inteligencia, habilidades físicas y tecnología avanzada para luchar contra el crimen en Gotham City. Su historia ha cautivado a generaciones, convirtiéndolo en uno de los héroes más emblemáticos del mundo del cómic.",
                Horarios = new List<string> { "Horario 1", "Horario 2", "Horario 3" }
            });
            sistemaReservas.AgregarPelicula(new SistemaReservas.Pelicula
            {
                Titulo = "Scary Movie",
                Descripcion = "Scary Movie es una película de comedia que parodia películas de terror populares. Prepárate para reír con las situaciones cómicas y las parodias hilarantes.",
                Horarios = new List<string> { "Horario X", "Horario Y", "Horario Z" }
            });
            sistemaReservas.AgregarPelicula(new SistemaReservas.Pelicula
            {
                Titulo = "Mario",
                Descripcion = "Mario, por otro lado, es el icónico personaje de videojuegos creado por Nintendo. Debutó en 1985 en \"Super Mario Bros.\" Mario es un fontanero italiano que se embarca en aventuras para rescatar a la Princesa Peach del villano Bowser. Con su bigote y peto, Mario se ha convertido en el rostro de los videojuegos, protagonizando numerosos títulos y siendo querido por jugadores de todas las edades.",
                Horarios = new List<string> { "Horario A", "Horario B", "Horario C" }
            });
            sistemaReservas.AgregarPelicula(new SistemaReservas.Pelicula
            {
                Titulo = "La abuela",
                Descripcion = "Una comedia de terror que sigue a una abuela aparentemente dulce, pero que esconde oscuros secretos. Cuando su nieto descubre sus verdaderas intenciones, se embarcan en una alocada aventura para desentrañar el misterio de la abuela antes de que sea demasiado tarde.",
                Horarios = new List<string> { "Horario A", "Horario B", "Horario C" }
            });
            sistemaReservas.AgregarPelicula(new SistemaReservas.Pelicula
            {
                Titulo = "El paseo 6",
                Descripcion = "Una película de comedia y acción que sigue las desventuras de un grupo de amigos en un parque temático. Con atracciones extravagantes y enredos cómicos, los personajes se enfrentan a situaciones hilarantes mientras intentan disfrutar de un día en el parque.",
                Horarios = new List<string> { "Horario A", "Horario B", "Horario C" }
            });
            sistemaReservas.AgregarPelicula(new SistemaReservas.Pelicula
            {
                Titulo = "Maremoto",
                Descripcion = " Un thriller de desastres naturales que sigue a un grupo de personas atrapadas en medio de un maremoto devastador. Con efectos especiales impactantes, la película narra la lucha por la supervivencia mientras enfrentan olas gigantes y luchan contra el tiempo para encontrar un lugar seguro.",
                Horarios = new List<string> { "Horario A", "Horario B", "Horario C" }
            });

            // ... Agregar más películas de ejemplo ...

            // Cargar las películas en el ComboBox
            CargarPeliculasEnComboBox();
            CargarHorariosEnListBox();
            // Inicializar los asientos disponibles para cada horario
            asientosDisponibles = cantidadTotalAsientos;
            MostrarAsientosDisponibles();

        }

        private void lblhorarios_Click(object sender, EventArgs e)
        {

        }

        private int numeroAsientos = 0;
        private void txbasientos_TextChanged_1(object sender, EventArgs e)
        {
            // Verificar si el texto ingresado es un número válido
            if (int.TryParse(txbasientos.Text, out int asientos))
            {
                // Almacenar el número de asientos
                numeroAsientos = asientos;
            }
            else
            {
                // Limpiar la variable si el texto no es un número válido
                numeroAsientos = 0;
            }
        }
        

       

        
        private void lblasientosdisponibles_Click(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una película válida en el ComboBox
            if (comboBox1.SelectedItem != null)
            {
                // Obtener la película seleccionada
                SistemaReservas.Pelicula peliculaSeleccionada = (SistemaReservas.Pelicula)comboBox1.SelectedItem;

                // Verificar si se ha seleccionado un horario válido en el ListBox
                if (lsbhorario.SelectedIndex > 0)
                {
                    // Obtener el horario seleccionado
                    string horarioSeleccionado = lsbhorario.SelectedItem.ToString();

                    // Verificar si la cantidad de asientos es válida
                    if (numeroAsientos > 0)
                    {
                        // Actualizar los asientos disponibles antes de mostrar el mensaje
                        asientosDisponibles = asientosDisponibles - numeroAsientos;

                        // Mostrar la nueva cantidad de asientos disponibles
                        // Actualizar los asientos disponibles antes de mostrar el mensaje
                    }
                    


                    // Mostrar la información en un mensaje
                    MessageBox.Show($"Pelicula: {peliculaSeleccionada.Titulo}\nHorario: {horarioSeleccionado}\nCantidad de Asientos: {numeroAsientos}",
                                        "Información de Boleto",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese un número válido de asientos antes de confirmar.",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un horario antes de confirmar.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
           
        

        private void lbldescripcion_Click_1(object sender, EventArgs e)
        {

        }
    }
}