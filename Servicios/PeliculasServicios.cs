using PeliculasFede2023.Models;

namespace PeliculasFede2023.Servicios
{
	public static class PeliculasServicios
	{
		public static List<Pelicula> Peliculas { get; set; } = new List<Pelicula>();
		static PeliculasServicios()
		{
			Peliculas.Add(new Pelicula
			{
				Codigo = "IND",
				Nombre = "Indiana Jones y el templo de la perdición",
				Duracion = 118,
				Categoria = "Aventura/Acción",
				Resenia = "Indiana Jones, tras un conflicto nocturno, escapa junto a una cantante y su joven acompañante. Los tres acaban en la India, donde intentarán ayudar a los habitantes de un pequeño poblado, cuyos niños han sido raptados."
			});

			Peliculas.Add(new Pelicula
			{
				Codigo = "AVT",
				Nombre = "Avatar 1",
				Duracion = 162,
				Categoria = "Ciencia ficción/Acción",
				Resenia = "En un exuberante planeta llamado Pandora viven los Na'vi, seres que aparentan ser primitivos pero que en realidad son muy evolucionados. Debido a que el ambiente de Pandora es venenoso, los híbridos humanos/Na'vi, llamados Avatares, están relacionados con las mentes humanas, lo que les permite mover..."
			});

			Peliculas.Add(new Pelicula
			{
				Codigo = "PES",
				Nombre = "Pesadilla en la calle Elm",
				Duracion = 91,
				Categoria = "Terror/Misterio",
				Resenia = "Un grupo de adolescentes sufre unas pesadillas horrendas en las que un ser deforme que porta garras de acero los persigue. Lo más inquietante es que los hechos empiezan a sugerir que lo que ocurre mientras sueñan repercute en la vida real."
			});

			Peliculas.Add(new Pelicula
			{
				Codigo = "NVR",
				Nombre = "Nueve Reinas",
				Duracion = 115,
				Categoria = "Crimen/Suspenso",
				Resenia = "Juan y Marcos son dos estafadores que casualmente se ven involucrados en un asunto que los puede convertir en millonarios: tienen menos de un día para llevar a cabo un engaño que no puede fallar."
			});

			Peliculas.Add(new Pelicula
			{
				Codigo = "MSY",
				Nombre = "Misery",
				Duracion = 107,
				Categoria = "Terror/Suspenso",
				Resenia = "Un autor se recupera de un accidente en la casa de una admiradora psicótica, quien le exige que escriba un libro solo para ella."
			});

			Peliculas.Add(new Pelicula
			{
				Codigo = "ZOL",
				Nombre = "Zoolander",
				Duracion = 105,
				Categoria = "Comedia",
				Resenia = "Un desafortunado modelo se vuelve el objetivo de un complot para asesinar a un importante líder internacional."
			});

		}
		public static List<Pelicula> GetPeliculas()
		{
			return Peliculas;
		}

		public static Pelicula GetPelicula(string id)
		{
			return Peliculas.FirstOrDefault(x => x.Codigo == id);
		}

		public static void Agregar(Pelicula pelicula)
		{
			Peliculas.Add(pelicula);
		}

		public static void Eliminar(string id)
		{
			var pelicula = GetPelicula(id);
			Peliculas.Remove(pelicula);
		}
	}
}
